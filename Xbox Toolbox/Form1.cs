using System;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;

using XDevkit;

namespace Xbox_Toolbox {
    public partial class Form1 : Form {
        public IXboxManager xbManager = null;
        public IXboxConsole xbCon = null;

        public bool activeConnection = false;
        public uint xboxConnection = 0;

        private string debuggerName = null;
        private string userName = null;

        public uint outBytes = 0;

        public Form1() {
            InitializeComponent();

            ModulePathTextBox.Text = Properties.Settings.Default.ModulePath;
            InstructionsTextBox.Text = Properties.Settings.Default.PPC;
            BinaryTextBox.Text = Properties.Settings.Default.OpCodes;
            InjectionAddressTextBox.Text = Properties.Settings.Default.InjectAddress;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.ModulePath = ModulePathTextBox.Text;
            Properties.Settings.Default.PPC = InstructionsTextBox.Text;
            Properties.Settings.Default.OpCodes = BinaryTextBox.Text;
            Properties.Settings.Default.InjectAddress = InjectionAddressTextBox.Text;
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
    }
}
