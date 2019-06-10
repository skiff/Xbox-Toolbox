using System;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;

using XDevkit;
using Be.Windows.Forms;
using Microsoft.Test.Xbox.XDRPC;

namespace Xbox_Toolbox {
    public partial class Form1 : Form {
        public IXboxManager xbManager = null;
        public IXboxConsole xbCon = null;

        public bool activeConnection = false;
        public uint xboxConnection = 0;

        private string debuggerName = null;
        private string userName = null;

        public uint outBytes = 0;

        private static byte[] MemoryData = null;

        public Form1() {
            InitializeComponent();

            ModulePathTextBox.Text = Properties.Settings.Default.ModulePath;
            InstructionsTextBox.Text = Properties.Settings.Default.PPC;
            BinaryTextBox.Text = Properties.Settings.Default.OpCodes;
            InjectionAddressTextBox.Text = Properties.Settings.Default.InjectAddress;
            MemoryAddressTextBox.Text = Properties.Settings.Default.MemAddress;
            MemorySizeTextBox.Text = Properties.Settings.Default.MemSize;

            MemoryViewHexBox.ByteProvider = new DynamicByteProvider(new byte[0x1000]);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.ModulePath = ModulePathTextBox.Text;
            Properties.Settings.Default.PPC = InstructionsTextBox.Text;
            Properties.Settings.Default.OpCodes = BinaryTextBox.Text;
            Properties.Settings.Default.InjectAddress = InjectionAddressTextBox.Text;
            Properties.Settings.Default.MemAddress = MemoryAddressTextBox.Text;
            Properties.Settings.Default.MemSize = MemorySizeTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void CPUKeyLabel_Click(object sender, EventArgs e) {
            CPUKeyLabel.Focus();
        }

        private void MainTabControl_KeyDown(object sender, KeyEventArgs e) {
            if (CPUKeyLabel.ContainsFocus && e.Control && e.KeyCode == Keys.C)
                Clipboard.SetText(CPUKeyLabel.Text);
        }

        public bool ConnectToConsole() {
            if (!this.activeConnection) {
                this.xbManager = new XboxManager();
                this.xbCon = this.xbManager.OpenConsole(this.xbManager.DefaultConsole);

                try {
                    this.xboxConnection = this.xbCon.OpenConnection(null);
                }
                catch (Exception) {
                    ConnectionStatusLabel.Text = "Could not connect to console: " + this.xbManager.DefaultConsole;
                    return false;
                }
                if (this.xbCon.DebugTarget.IsDebuggerConnected(out this.debuggerName, out this.userName)) {
                    this.activeConnection = true;
                    ConnectionStatusLabel.Text = "Connection to " + xbCon.Name + " established!";
                    return true;
                }
                else {
                    this.xbCon.DebugTarget.ConnectAsDebugger("Xbox Toolbox", XboxDebugConnectFlags.Force);
                    if (!this.xbCon.DebugTarget.IsDebuggerConnected(out this.debuggerName, out this.userName)) {
                        ConnectionStatusLabel.Text = "Attempted to connect to console: " + xbCon.Name + " but failed";
                        return false;
                    }
                    else {
                        this.activeConnection = true;
                        ConnectionStatusLabel.Text = "Connection to " + xbCon.Name + " established!";
                        return true;
                    }
                }
            }
            else if (this.xbCon.DebugTarget.IsDebuggerConnected(out this.debuggerName, out this.userName)) {
                ConnectionStatusLabel.Text = "Connection to " + xbCon.Name + " already established!";
                return true;
            }
            else {
                this.activeConnection = false;
                return ConnectToConsole();
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e) {
            if(ConnectToConsole()) {
                CPUKeyLabel.Text = xbCon.GetCPUKey();
                TitleIDLabel.Text = String.Format("Current Title ID: 0x{0}", xbCon.GetCurrentTitleId().ToString("X"));
                ConsoleDebugIPLabel.Text = String.Format("Console Debug IP: {0}", xbCon.GetConsoleIP());

                //XBOX_AUTOMATION_GAMEPAD gPad = new XBOX_AUTOMATION_GAMEPAD(); 
                //gPad.Buttons = XboxAutomationButtonFlags.Xbox360_Button;
                //
                //xbCon.XboxAutomation.SetGamepadState(0, ref gPad);
                //
                //gPad.Buttons = 0;
                //xbCon.XboxAutomation.SetGamepadState(0, ref gPad);
            }
            else {
                CPUKeyLabel.Text = "00000000000000000000000000000000";
                TitleIDLabel.Text = "Current Title ID: 0x00000000";
                ConsoleDebugIPLabel.Text = "Console Debug IP: 192.168.1.1";
            }
        }

        private void RebootButton_Click(object sender, EventArgs e) {
            try {
                xbCon.Reboot();
            }
            catch {
                ConnectionStatusLabel.Text = "Unable to reach console";
            }
        }

        private void RefreshModulesButton_Click(object sender, EventArgs e) {
            dataGridView1.Rows.Clear();

            foreach(IXboxModule module in xbCon.DebugTarget.Modules) {
                string name = module.ModuleInfo.Name;
                string addr = "0x" + module.ModuleInfo.BaseAddress.ToString("X");
                string size = "0x" + module.ModuleInfo.Size.ToString("X");

                dataGridView1.Rows.Add(name, addr, size, null);
            }

            dataGridView1.Sort(dataGridView1.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void LoadModuleButton_Click(object sender, EventArgs e) {
            xbCon.LoadModule(ModulePathTextBox.Text);

            RefreshModulesButton_Click(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                string module = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                xbCon.UnloadModule(module);

                RefreshModulesButton_Click(sender, null);
            }
        }

        private string[] CleanInstructions(string[] lines) {
            for (int i = 0; i < lines.Length; i++) {
                string line = lines[i];
                if (line.EndsWith(";", StringComparison.CurrentCultureIgnoreCase))
                    line = line.Substring(0, line.IndexOf(";", StringComparison.CurrentCultureIgnoreCase));

                if (line.StartsWith("//"))
                    line = string.Empty;

                lines[i] = line;
            }

            return lines;
        }

        private void CompileInstructionsButton_Click(object sender, EventArgs e) {
            string[] instructions = CleanInstructions(InstructionsTextBox.Lines);

            File.WriteAllLines(@"PPC/assembly.s", instructions);

            Process process = Process.Start(new ProcessStartInfo(@"PPC\\\\buildppc.bat") {
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true
            });
            process.WaitForExit();

            File.WriteAllText(@"PPC/assembly.s", InstructionsTextBox.Text);
            File.Delete(@"PPC/assembly.bin");
            File.Move(@"a.out", @"PPC/assembly.bin");

            BinaryTextBox.Text = BitConverter.ToString(File.ReadAllBytes(@"PPC/assembly.bin")).Replace('-', ' ');
        }

        public static byte[] StringToByteArray(string hex) {
            return (from x in Enumerable.Range(0, hex.Length) where x % 2 == 0
                    select Convert.ToByte(hex.Substring(x, 2), 16)).ToArray();
        }

        private void InjectCodeButton_Click(object sender, EventArgs e) {
            uint offset = Convert.ToUInt32(InjectionAddressTextBox.Text.StartsWith("0x", StringComparison.CurrentCultureIgnoreCase) ? InjectionAddressTextBox.Text.Substring(2) : InjectionAddressTextBox.Text, 16);
            byte[] buffer = StringToByteArray(BinaryTextBox.Text.Replace(" ", ""));
            xbCon.WriteBytes(offset, buffer);
        }

        private object[] GetParameters() {
            object[] parameters = new object[8];
            for (int i = 0; i < parameters.Length; i++)
                parameters[i] = 0;

            if(Param1CheckBox.Checked)
                parameters[0] = Param1ComboBox.SelectedIndex == 0 ? Convert.ToUInt64(Param1ComboBox.Text) : Param1ComboBox.SelectedIndex == 1 ? Param1ComboBox.Text : (object)Convert.ToSingle(Param1ComboBox.Text);
            if (Param2CheckBox.Checked)
                parameters[1] = Param2ComboBox.SelectedIndex == 0 ? Convert.ToUInt64(Param2ComboBox.Text) : Param2ComboBox.SelectedIndex == 1 ? Param2ComboBox.Text : (object)Convert.ToSingle(Param2ComboBox.Text);
            if (Param3CheckBox.Checked)
                parameters[2] = Param3ComboBox.SelectedIndex == 0 ? Convert.ToUInt64(Param3ComboBox.Text) : Param3ComboBox.SelectedIndex == 1 ? Param3ComboBox.Text : (object)Convert.ToSingle(Param3ComboBox.Text);
            if (Param4CheckBox.Checked)
                parameters[3] = Param4ComboBox.SelectedIndex == 0 ? Convert.ToUInt64(Param4ComboBox.Text) : Param4ComboBox.SelectedIndex == 1 ? Param4ComboBox.Text : (object)Convert.ToSingle(Param4ComboBox.Text);
            if (Param5CheckBox.Checked)
                parameters[4] = Param5ComboBox.SelectedIndex == 0 ? Convert.ToUInt64(Param5ComboBox.Text) : Param5ComboBox.SelectedIndex == 1 ? Param5ComboBox.Text : (object)Convert.ToSingle(Param5ComboBox.Text);
            if (Param6CheckBox.Checked)
                parameters[5] = Param6ComboBox.SelectedIndex == 0 ? Convert.ToUInt64(Param6ComboBox.Text) : Param6ComboBox.SelectedIndex == 1 ? Param6ComboBox.Text : (object)Convert.ToSingle(Param6ComboBox.Text);
            if (Param7CheckBox.Checked)
                parameters[6] = Param7ComboBox.SelectedIndex == 0 ? Convert.ToUInt64(Param7ComboBox.Text) : Param7ComboBox.SelectedIndex == 1 ? Param7ComboBox.Text : (object)Convert.ToSingle(Param7ComboBox.Text);
            if (Param8CheckBox.Checked)
                parameters[7] = Param8ComboBox.SelectedIndex == 0 ? Convert.ToUInt64(Param8ComboBox.Text) : Param8ComboBox.SelectedIndex == 1 ? Param8ComboBox.Text : (object)Convert.ToSingle(Param8ComboBox.Text);

            return parameters;
        }

        private void CallByOrdinalButton_Click(object sender, EventArgs e) {
            if(ModuleNameTextBox.Text.Equals(string.Empty) || OrdinalTextBox.Text.Equals(string.Empty)) {
                MessageBox.Show("Error", "Please enter a module name and ordinal value!");
                return;
            }

            string moduleName = ModuleNameTextBox.Text;
            int ordinalNumber = OrdinalTextBox.Text.Contains("0x") ? Convert.ToInt32(OrdinalTextBox.Text, 16) : Convert.ToInt32(OrdinalTextBox.Text, 10);

            if(CallByOrdinalReturnTypeComboBox.Text.Equals(string.Empty)) {
                MessageBox.Show("Error", "Please select a return type before calling the function!");
                return;
            }

            try {
                if (CallByOrdinalReturnTypeComboBox.SelectedIndex == 0) {
                    xbCon.ExecuteRPC<Int64>(XDRPCMode.System, moduleName, ordinalNumber, GetParameters());
                    ByOridinalReturnValueTextBox.Text = "No Return";
                }
                else if (CallByOrdinalReturnTypeComboBox.SelectedIndex == 1) {
                    Int64 returnVal = xbCon.ExecuteRPC<Int64>(XDRPCMode.System, moduleName, ordinalNumber, GetParameters());
                    ByOridinalReturnValueTextBox.Text = "0x" + returnVal.ToString("X");
                }
                else if (CallByOrdinalReturnTypeComboBox.SelectedIndex == 2) {
                    string returnVal = xbCon.CallString(moduleName, ordinalNumber, GetParameters());
                    ByOridinalReturnValueTextBox.Text = returnVal;
                }
                else if (CallByOrdinalReturnTypeComboBox.SelectedIndex == 3) {
                    float returnVal = xbCon.ExecuteRPC<float>(XDRPCMode.System, moduleName, ordinalNumber, GetParameters());
                    ByOridinalReturnValueTextBox.Text = returnVal.ToString();
                }
            }
            catch {
                MessageBox.Show("Error", "Make sure you have set values and types for all parameters being used!");
            }
        }

        private void CallFunctionButton_Click(object sender, EventArgs e) {
            if (CallAddressTextBox.Text.Equals(string.Empty)) {
                MessageBox.Show("Error", "Please enter the address of the function to call!");
                return;
            }

            UInt32 CallAddress = Convert.ToUInt32(CallAddressTextBox.Text, 16);

            if (CallByAddressReturnType.Text.Equals(string.Empty)) {
                MessageBox.Show("Error", "Please select a return type before calling the function!");
                return;
            }

            try {
                if(CallByAddressReturnType.SelectedIndex == 0) {
                    xbCon.ExecuteRPC<Int64>(new XDRPCExecutionOptions(XDRPCMode.Title, CallAddress), GetParameters());
                    CallAddressReturnTextBox.Text = "No Return";
                }
                else if (CallByAddressReturnType.SelectedIndex == 1) {
                    Int64 returnVal = xbCon.ExecuteRPC<Int64>(new XDRPCExecutionOptions(XDRPCMode.Title, CallAddress), GetParameters());
                    CallAddressReturnTextBox.Text = "0x" + returnVal.ToString("X");
                }
                else if (CallByAddressReturnType.SelectedIndex == 2) {
                    string returnVal = xbCon.CallString(CallAddress, GetParameters());
                    CallAddressReturnTextBox.Text = returnVal;
                }
                else if (CallByAddressReturnType.SelectedIndex == 3) {
                    float returnVal = xbCon.ExecuteRPC<float>(new XDRPCExecutionOptions(XDRPCMode.Title, CallAddress), GetParameters());
                    CallAddressReturnTextBox.Text = returnVal.ToString();
                }
            }
            catch {
                MessageBox.Show("Error", "Make sure you have set values and types for all parameters being used!");
            }
        }

        private void PeekMemoryButton_Click(object sender, EventArgs e) {
            if(MemoryAddressTextBox.Text.Equals(string.Empty) || MemorySizeTextBox.Text.Equals(string.Empty)) {
                MessageBox.Show("Error", "Please enter an address and size of memory to peek!");
                return;
            }

            UInt32 Address = Convert.ToUInt32(MemoryAddressTextBox.Text, 16);
            UInt32 Size = MemorySizeTextBox.Text.Contains("0x") ? Convert.ToUInt32(MemorySizeTextBox.Text, 16) : Convert.ToUInt32(MemorySizeTextBox.Text, 10);

            MemoryData = xbCon.ReadBytes(Address, Size);
            MemoryStream stream = new MemoryStream(MemoryData);
            DynamicFileByteProvider byteProvider = new DynamicFileByteProvider(stream);
            MemoryViewHexBox.ByteProvider = byteProvider;
        }

        private void PokeMemoryButton_Click(object sender, EventArgs e) {
            if (MemoryAddressTextBox.Text.Equals(string.Empty)) {
                MessageBox.Show("Error", "Please enter an address of memory to poke!");
                return;
            }

            DynamicFileByteProvider dynamicFileByteProvider = MemoryViewHexBox.ByteProvider as DynamicFileByteProvider;
            dynamicFileByteProvider.ApplyChanges();

            UInt32 Address = Convert.ToUInt32(MemoryAddressTextBox.Text, 16);
            xbCon.WriteBytes(Address, MemoryData);
        }
    }
}
