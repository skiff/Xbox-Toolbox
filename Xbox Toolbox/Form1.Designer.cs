namespace Xbox_Toolbox {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ConnectButton = new System.Windows.Forms.Button();
            this.RebootButton = new System.Windows.Forms.Button();
            this.SourceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ModuleTab = new System.Windows.Forms.TabPage();
            this.RefreshModulesButton = new System.Windows.Forms.Button();
            this.LoadModuleButton = new System.Windows.Forms.Button();
            this.ModulePathTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ModuleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnloadColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FunctionsTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CallAddressReturnTextBox = new System.Windows.Forms.TextBox();
            this.CallFunctionButton = new System.Windows.Forms.Button();
            this.CallByAddressReturnType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CallAddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ByOridinalReturnValueTextBox = new System.Windows.Forms.TextBox();
            this.CallByOrdinalButton = new System.Windows.Forms.Button();
            this.CallByOrdinalReturnTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ByOrdinalReturnLabel = new System.Windows.Forms.Label();
            this.OrdinalLabel = new System.Windows.Forms.Label();
            this.ModuleNameLabel = new System.Windows.Forms.Label();
            this.OrdinalTextBox = new System.Windows.Forms.TextBox();
            this.ModuleNameTextBox = new System.Windows.Forms.TextBox();
            this.Param8CheckBox = new System.Windows.Forms.CheckBox();
            this.Param7CheckBox = new System.Windows.Forms.CheckBox();
            this.Param6CheckBox = new System.Windows.Forms.CheckBox();
            this.Param5CheckBox = new System.Windows.Forms.CheckBox();
            this.Param4CheckBox = new System.Windows.Forms.CheckBox();
            this.Param3CheckBox = new System.Windows.Forms.CheckBox();
            this.Param2CheckBox = new System.Windows.Forms.CheckBox();
            this.Param1CheckBox = new System.Windows.Forms.CheckBox();
            this.Param8ComboBox = new System.Windows.Forms.ComboBox();
            this.Param7ComboBox = new System.Windows.Forms.ComboBox();
            this.Param6ComboBox = new System.Windows.Forms.ComboBox();
            this.Param5ComboBox = new System.Windows.Forms.ComboBox();
            this.Param4ComboBox = new System.Windows.Forms.ComboBox();
            this.Param3ComboBox = new System.Windows.Forms.ComboBox();
            this.Param2ComboBox = new System.Windows.Forms.ComboBox();
            this.Param1ComboBox = new System.Windows.Forms.ComboBox();
            this.Param8TextBox = new System.Windows.Forms.TextBox();
            this.Param7TextBox = new System.Windows.Forms.TextBox();
            this.Param6TextBox = new System.Windows.Forms.TextBox();
            this.Param5TextBox = new System.Windows.Forms.TextBox();
            this.Param4TextBox = new System.Windows.Forms.TextBox();
            this.Param3TextBox = new System.Windows.Forms.TextBox();
            this.Param2TextBox = new System.Windows.Forms.TextBox();
            this.Param1TextBox = new System.Windows.Forms.TextBox();
            this.PPCTab = new System.Windows.Forms.TabPage();
            this.InjectionAddressTextBox = new System.Windows.Forms.TextBox();
            this.InjectCodeButton = new System.Windows.Forms.Button();
            this.CompileInstructionsButton = new System.Windows.Forms.Button();
            this.BinaryTextBox = new System.Windows.Forms.RichTextBox();
            this.InstructionsTextBox = new System.Windows.Forms.RichTextBox();
            this.MemoryTab = new System.Windows.Forms.TabPage();
            this.CPUKeyLabel = new System.Windows.Forms.Label();
            this.TitleIDLabel = new System.Windows.Forms.Label();
            this.CPUKeyHeaderLabel = new System.Windows.Forms.Label();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.ConsoleDebugIPLabel = new System.Windows.Forms.Label();
            this.MemoryViewHexBox = new Be.Windows.Forms.HexBox();
            this.MemoryAddressTextBox = new System.Windows.Forms.TextBox();
            this.MemoryAddressLabel = new System.Windows.Forms.Label();
            this.MemorySizeLabel = new System.Windows.Forms.Label();
            this.MemorySizeTextBox = new System.Windows.Forms.TextBox();
            this.PeekMemoryButton = new System.Windows.Forms.Button();
            this.PokeMemoryButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.ModuleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.FunctionsTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PPCTab.SuspendLayout();
            this.MemoryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(21, 12);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(346, 58);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // RebootButton
            // 
            this.RebootButton.Location = new System.Drawing.Point(374, 12);
            this.RebootButton.Name = "RebootButton";
            this.RebootButton.Size = new System.Drawing.Size(339, 58);
            this.RebootButton.TabIndex = 1;
            this.RebootButton.Text = "Reboot";
            this.RebootButton.UseVisualStyleBackColor = true;
            this.RebootButton.Click += new System.EventHandler(this.RebootButton_Click);
            // 
            // SourceLinkLabel
            // 
            this.SourceLinkLabel.AutoSize = true;
            this.SourceLinkLabel.Location = new System.Drawing.Point(765, 31);
            this.SourceLinkLabel.Name = "SourceLinkLabel";
            this.SourceLinkLabel.Size = new System.Drawing.Size(60, 20);
            this.SourceLinkLabel.TabIndex = 3;
            this.SourceLinkLabel.TabStop = true;
            this.SourceLinkLabel.Text = "Source";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ModuleTab);
            this.MainTabControl.Controls.Add(this.FunctionsTab);
            this.MainTabControl.Controls.Add(this.PPCTab);
            this.MainTabControl.Controls.Add(this.MemoryTab);
            this.MainTabControl.Location = new System.Drawing.Point(14, 132);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(868, 628);
            this.MainTabControl.TabIndex = 4;
            this.MainTabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainTabControl_KeyDown);
            // 
            // ModuleTab
            // 
            this.ModuleTab.Controls.Add(this.RefreshModulesButton);
            this.ModuleTab.Controls.Add(this.LoadModuleButton);
            this.ModuleTab.Controls.Add(this.ModulePathTextBox);
            this.ModuleTab.Controls.Add(this.dataGridView1);
            this.ModuleTab.Location = new System.Drawing.Point(4, 29);
            this.ModuleTab.Name = "ModuleTab";
            this.ModuleTab.Padding = new System.Windows.Forms.Padding(3);
            this.ModuleTab.Size = new System.Drawing.Size(860, 595);
            this.ModuleTab.TabIndex = 0;
            this.ModuleTab.Text = "Modules";
            this.ModuleTab.UseVisualStyleBackColor = true;
            // 
            // RefreshModulesButton
            // 
            this.RefreshModulesButton.Location = new System.Drawing.Point(594, 552);
            this.RefreshModulesButton.Name = "RefreshModulesButton";
            this.RefreshModulesButton.Size = new System.Drawing.Size(260, 34);
            this.RefreshModulesButton.TabIndex = 3;
            this.RefreshModulesButton.Text = "Refresh Module List";
            this.RefreshModulesButton.UseVisualStyleBackColor = true;
            this.RefreshModulesButton.Click += new System.EventHandler(this.RefreshModulesButton_Click);
            // 
            // LoadModuleButton
            // 
            this.LoadModuleButton.Location = new System.Drawing.Point(328, 552);
            this.LoadModuleButton.Name = "LoadModuleButton";
            this.LoadModuleButton.Size = new System.Drawing.Size(260, 34);
            this.LoadModuleButton.TabIndex = 2;
            this.LoadModuleButton.Text = "Load Module";
            this.LoadModuleButton.UseVisualStyleBackColor = true;
            this.LoadModuleButton.Click += new System.EventHandler(this.LoadModuleButton_Click);
            // 
            // ModulePathTextBox
            // 
            this.ModulePathTextBox.Location = new System.Drawing.Point(8, 554);
            this.ModulePathTextBox.Name = "ModulePathTextBox";
            this.ModulePathTextBox.Size = new System.Drawing.Size(314, 26);
            this.ModulePathTextBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModuleColumn,
            this.BaseAddressColumn,
            this.SizeColumn,
            this.UnloadColumn});
            this.dataGridView1.Location = new System.Drawing.Point(8, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(848, 535);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ModuleColumn
            // 
            this.ModuleColumn.HeaderText = "Module Name";
            this.ModuleColumn.Name = "ModuleColumn";
            this.ModuleColumn.ReadOnly = true;
            this.ModuleColumn.Width = 205;
            // 
            // BaseAddressColumn
            // 
            this.BaseAddressColumn.HeaderText = "Base Address";
            this.BaseAddressColumn.Name = "BaseAddressColumn";
            this.BaseAddressColumn.ReadOnly = true;
            this.BaseAddressColumn.Width = 150;
            // 
            // SizeColumn
            // 
            this.SizeColumn.HeaderText = "Size";
            this.SizeColumn.Name = "SizeColumn";
            this.SizeColumn.ReadOnly = true;
            // 
            // UnloadColumn
            // 
            this.UnloadColumn.HeaderText = "Unload";
            this.UnloadColumn.Name = "UnloadColumn";
            this.UnloadColumn.ReadOnly = true;
            // 
            // FunctionsTab
            // 
            this.FunctionsTab.Controls.Add(this.groupBox2);
            this.FunctionsTab.Controls.Add(this.groupBox1);
            this.FunctionsTab.Controls.Add(this.Param8CheckBox);
            this.FunctionsTab.Controls.Add(this.Param7CheckBox);
            this.FunctionsTab.Controls.Add(this.Param6CheckBox);
            this.FunctionsTab.Controls.Add(this.Param5CheckBox);
            this.FunctionsTab.Controls.Add(this.Param4CheckBox);
            this.FunctionsTab.Controls.Add(this.Param3CheckBox);
            this.FunctionsTab.Controls.Add(this.Param2CheckBox);
            this.FunctionsTab.Controls.Add(this.Param1CheckBox);
            this.FunctionsTab.Controls.Add(this.Param8ComboBox);
            this.FunctionsTab.Controls.Add(this.Param7ComboBox);
            this.FunctionsTab.Controls.Add(this.Param6ComboBox);
            this.FunctionsTab.Controls.Add(this.Param5ComboBox);
            this.FunctionsTab.Controls.Add(this.Param4ComboBox);
            this.FunctionsTab.Controls.Add(this.Param3ComboBox);
            this.FunctionsTab.Controls.Add(this.Param2ComboBox);
            this.FunctionsTab.Controls.Add(this.Param1ComboBox);
            this.FunctionsTab.Controls.Add(this.Param8TextBox);
            this.FunctionsTab.Controls.Add(this.Param7TextBox);
            this.FunctionsTab.Controls.Add(this.Param6TextBox);
            this.FunctionsTab.Controls.Add(this.Param5TextBox);
            this.FunctionsTab.Controls.Add(this.Param4TextBox);
            this.FunctionsTab.Controls.Add(this.Param3TextBox);
            this.FunctionsTab.Controls.Add(this.Param2TextBox);
            this.FunctionsTab.Controls.Add(this.Param1TextBox);
            this.FunctionsTab.Location = new System.Drawing.Point(4, 29);
            this.FunctionsTab.Name = "FunctionsTab";
            this.FunctionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.FunctionsTab.Size = new System.Drawing.Size(860, 595);
            this.FunctionsTab.TabIndex = 1;
            this.FunctionsTab.Text = "Functions";
            this.FunctionsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CallAddressReturnTextBox);
            this.groupBox2.Controls.Add(this.CallFunctionButton);
            this.groupBox2.Controls.Add(this.CallByAddressReturnType);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CallAddressTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(446, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 206);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Call By Address";
            // 
            // CallAddressReturnTextBox
            // 
            this.CallAddressReturnTextBox.Location = new System.Drawing.Point(8, 160);
            this.CallAddressReturnTextBox.Name = "CallAddressReturnTextBox";
            this.CallAddressReturnTextBox.Size = new System.Drawing.Size(392, 26);
            this.CallAddressReturnTextBox.TabIndex = 11;
            // 
            // CallFunctionButton
            // 
            this.CallFunctionButton.Location = new System.Drawing.Point(6, 109);
            this.CallFunctionButton.Name = "CallFunctionButton";
            this.CallFunctionButton.Size = new System.Drawing.Size(396, 32);
            this.CallFunctionButton.TabIndex = 10;
            this.CallFunctionButton.Text = "Call Function";
            this.CallFunctionButton.UseVisualStyleBackColor = true;
            this.CallFunctionButton.Click += new System.EventHandler(this.CallFunctionButton_Click);
            // 
            // CallByAddressReturnType
            // 
            this.CallByAddressReturnType.FormattingEnabled = true;
            this.CallByAddressReturnType.Items.AddRange(new object[] {
            "void",
            "long",
            "string",
            "float"});
            this.CallByAddressReturnType.Location = new System.Drawing.Point(130, 67);
            this.CallByAddressReturnType.Name = "CallByAddressReturnType";
            this.CallByAddressReturnType.Size = new System.Drawing.Size(270, 28);
            this.CallByAddressReturnType.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Return Type";
            // 
            // CallAddressTextBox
            // 
            this.CallAddressTextBox.Location = new System.Drawing.Point(130, 25);
            this.CallAddressTextBox.Name = "CallAddressTextBox";
            this.CallAddressTextBox.Size = new System.Drawing.Size(270, 26);
            this.CallAddressTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ByOridinalReturnValueTextBox);
            this.groupBox1.Controls.Add(this.CallByOrdinalButton);
            this.groupBox1.Controls.Add(this.CallByOrdinalReturnTypeComboBox);
            this.groupBox1.Controls.Add(this.ByOrdinalReturnLabel);
            this.groupBox1.Controls.Add(this.OrdinalLabel);
            this.groupBox1.Controls.Add(this.ModuleNameLabel);
            this.groupBox1.Controls.Add(this.OrdinalTextBox);
            this.groupBox1.Controls.Add(this.ModuleNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 248);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Call By Ordinal";
            // 
            // ByOridinalReturnValueTextBox
            // 
            this.ByOridinalReturnValueTextBox.Location = new System.Drawing.Point(8, 202);
            this.ByOridinalReturnValueTextBox.Name = "ByOridinalReturnValueTextBox";
            this.ByOridinalReturnValueTextBox.Size = new System.Drawing.Size(392, 26);
            this.ByOridinalReturnValueTextBox.TabIndex = 7;
            // 
            // CallByOrdinalButton
            // 
            this.CallByOrdinalButton.Location = new System.Drawing.Point(6, 151);
            this.CallByOrdinalButton.Name = "CallByOrdinalButton";
            this.CallByOrdinalButton.Size = new System.Drawing.Size(396, 32);
            this.CallByOrdinalButton.TabIndex = 6;
            this.CallByOrdinalButton.Text = "Call Function";
            this.CallByOrdinalButton.UseVisualStyleBackColor = true;
            this.CallByOrdinalButton.Click += new System.EventHandler(this.CallByOrdinalButton_Click);
            // 
            // CallByOrdinalReturnTypeComboBox
            // 
            this.CallByOrdinalReturnTypeComboBox.FormattingEnabled = true;
            this.CallByOrdinalReturnTypeComboBox.Items.AddRange(new object[] {
            "void",
            "long",
            "string",
            "float"});
            this.CallByOrdinalReturnTypeComboBox.Location = new System.Drawing.Point(136, 109);
            this.CallByOrdinalReturnTypeComboBox.Name = "CallByOrdinalReturnTypeComboBox";
            this.CallByOrdinalReturnTypeComboBox.Size = new System.Drawing.Size(264, 28);
            this.CallByOrdinalReturnTypeComboBox.TabIndex = 5;
            // 
            // ByOrdinalReturnLabel
            // 
            this.ByOrdinalReturnLabel.AutoSize = true;
            this.ByOrdinalReturnLabel.Location = new System.Drawing.Point(10, 112);
            this.ByOrdinalReturnLabel.Name = "ByOrdinalReturnLabel";
            this.ByOrdinalReturnLabel.Size = new System.Drawing.Size(96, 20);
            this.ByOrdinalReturnLabel.TabIndex = 4;
            this.ByOrdinalReturnLabel.Text = "Return Type";
            // 
            // OrdinalLabel
            // 
            this.OrdinalLabel.AutoSize = true;
            this.OrdinalLabel.Location = new System.Drawing.Point(8, 69);
            this.OrdinalLabel.Name = "OrdinalLabel";
            this.OrdinalLabel.Size = new System.Drawing.Size(59, 20);
            this.OrdinalLabel.TabIndex = 3;
            this.OrdinalLabel.Text = "Ordinal";
            // 
            // ModuleNameLabel
            // 
            this.ModuleNameLabel.AutoSize = true;
            this.ModuleNameLabel.Location = new System.Drawing.Point(8, 31);
            this.ModuleNameLabel.Name = "ModuleNameLabel";
            this.ModuleNameLabel.Size = new System.Drawing.Size(107, 20);
            this.ModuleNameLabel.TabIndex = 2;
            this.ModuleNameLabel.Text = "Module Name";
            // 
            // OrdinalTextBox
            // 
            this.OrdinalTextBox.Location = new System.Drawing.Point(136, 66);
            this.OrdinalTextBox.Name = "OrdinalTextBox";
            this.OrdinalTextBox.Size = new System.Drawing.Size(264, 26);
            this.OrdinalTextBox.TabIndex = 1;
            // 
            // ModuleNameTextBox
            // 
            this.ModuleNameTextBox.Location = new System.Drawing.Point(136, 26);
            this.ModuleNameTextBox.Name = "ModuleNameTextBox";
            this.ModuleNameTextBox.Size = new System.Drawing.Size(264, 26);
            this.ModuleNameTextBox.TabIndex = 0;
            // 
            // Param8CheckBox
            // 
            this.Param8CheckBox.AutoSize = true;
            this.Param8CheckBox.Location = new System.Drawing.Point(704, 292);
            this.Param8CheckBox.Name = "Param8CheckBox";
            this.Param8CheckBox.Size = new System.Drawing.Size(151, 24);
            this.Param8CheckBox.TabIndex = 23;
            this.Param8CheckBox.Text = "Send Parameter";
            this.Param8CheckBox.UseVisualStyleBackColor = true;
            // 
            // Param7CheckBox
            // 
            this.Param7CheckBox.AutoSize = true;
            this.Param7CheckBox.Location = new System.Drawing.Point(704, 252);
            this.Param7CheckBox.Name = "Param7CheckBox";
            this.Param7CheckBox.Size = new System.Drawing.Size(151, 24);
            this.Param7CheckBox.TabIndex = 22;
            this.Param7CheckBox.Text = "Send Parameter";
            this.Param7CheckBox.UseVisualStyleBackColor = true;
            // 
            // Param6CheckBox
            // 
            this.Param6CheckBox.AutoSize = true;
            this.Param6CheckBox.Location = new System.Drawing.Point(704, 212);
            this.Param6CheckBox.Name = "Param6CheckBox";
            this.Param6CheckBox.Size = new System.Drawing.Size(151, 24);
            this.Param6CheckBox.TabIndex = 21;
            this.Param6CheckBox.Text = "Send Parameter";
            this.Param6CheckBox.UseVisualStyleBackColor = true;
            // 
            // Param5CheckBox
            // 
            this.Param5CheckBox.AutoSize = true;
            this.Param5CheckBox.Location = new System.Drawing.Point(704, 172);
            this.Param5CheckBox.Name = "Param5CheckBox";
            this.Param5CheckBox.Size = new System.Drawing.Size(151, 24);
            this.Param5CheckBox.TabIndex = 20;
            this.Param5CheckBox.Text = "Send Parameter";
            this.Param5CheckBox.UseVisualStyleBackColor = true;
            // 
            // Param4CheckBox
            // 
            this.Param4CheckBox.AutoSize = true;
            this.Param4CheckBox.Location = new System.Drawing.Point(704, 132);
            this.Param4CheckBox.Name = "Param4CheckBox";
            this.Param4CheckBox.Size = new System.Drawing.Size(151, 24);
            this.Param4CheckBox.TabIndex = 19;
            this.Param4CheckBox.Text = "Send Parameter";
            this.Param4CheckBox.UseVisualStyleBackColor = true;
            // 
            // Param3CheckBox
            // 
            this.Param3CheckBox.AutoSize = true;
            this.Param3CheckBox.Location = new System.Drawing.Point(704, 92);
            this.Param3CheckBox.Name = "Param3CheckBox";
            this.Param3CheckBox.Size = new System.Drawing.Size(151, 24);
            this.Param3CheckBox.TabIndex = 18;
            this.Param3CheckBox.Text = "Send Parameter";
            this.Param3CheckBox.UseVisualStyleBackColor = true;
            // 
            // Param2CheckBox
            // 
            this.Param2CheckBox.AutoSize = true;
            this.Param2CheckBox.Location = new System.Drawing.Point(704, 52);
            this.Param2CheckBox.Name = "Param2CheckBox";
            this.Param2CheckBox.Size = new System.Drawing.Size(151, 24);
            this.Param2CheckBox.TabIndex = 17;
            this.Param2CheckBox.Text = "Send Parameter";
            this.Param2CheckBox.UseVisualStyleBackColor = true;
            // 
            // Param1CheckBox
            // 
            this.Param1CheckBox.AutoSize = true;
            this.Param1CheckBox.Location = new System.Drawing.Point(704, 12);
            this.Param1CheckBox.Name = "Param1CheckBox";
            this.Param1CheckBox.Size = new System.Drawing.Size(151, 24);
            this.Param1CheckBox.TabIndex = 16;
            this.Param1CheckBox.Text = "Send Parameter";
            this.Param1CheckBox.UseVisualStyleBackColor = true;
            // 
            // Param8ComboBox
            // 
            this.Param8ComboBox.FormattingEnabled = true;
            this.Param8ComboBox.Items.AddRange(new object[] {
            "long",
            "string",
            "float"});
            this.Param8ComboBox.Location = new System.Drawing.Point(489, 289);
            this.Param8ComboBox.Name = "Param8ComboBox";
            this.Param8ComboBox.Size = new System.Drawing.Size(206, 28);
            this.Param8ComboBox.TabIndex = 15;
            // 
            // Param7ComboBox
            // 
            this.Param7ComboBox.FormattingEnabled = true;
            this.Param7ComboBox.Items.AddRange(new object[] {
            "long",
            "string",
            "float"});
            this.Param7ComboBox.Location = new System.Drawing.Point(489, 249);
            this.Param7ComboBox.Name = "Param7ComboBox";
            this.Param7ComboBox.Size = new System.Drawing.Size(206, 28);
            this.Param7ComboBox.TabIndex = 14;
            // 
            // Param6ComboBox
            // 
            this.Param6ComboBox.FormattingEnabled = true;
            this.Param6ComboBox.Items.AddRange(new object[] {
            "long",
            "string",
            "float"});
            this.Param6ComboBox.Location = new System.Drawing.Point(489, 209);
            this.Param6ComboBox.Name = "Param6ComboBox";
            this.Param6ComboBox.Size = new System.Drawing.Size(206, 28);
            this.Param6ComboBox.TabIndex = 13;
            // 
            // Param5ComboBox
            // 
            this.Param5ComboBox.FormattingEnabled = true;
            this.Param5ComboBox.Items.AddRange(new object[] {
            "long",
            "string",
            "float"});
            this.Param5ComboBox.Location = new System.Drawing.Point(489, 169);
            this.Param5ComboBox.Name = "Param5ComboBox";
            this.Param5ComboBox.Size = new System.Drawing.Size(206, 28);
            this.Param5ComboBox.TabIndex = 12;
            // 
            // Param4ComboBox
            // 
            this.Param4ComboBox.FormattingEnabled = true;
            this.Param4ComboBox.Items.AddRange(new object[] {
            "long",
            "string",
            "float"});
            this.Param4ComboBox.Location = new System.Drawing.Point(489, 129);
            this.Param4ComboBox.Name = "Param4ComboBox";
            this.Param4ComboBox.Size = new System.Drawing.Size(206, 28);
            this.Param4ComboBox.TabIndex = 11;
            // 
            // Param3ComboBox
            // 
            this.Param3ComboBox.FormattingEnabled = true;
            this.Param3ComboBox.Items.AddRange(new object[] {
            "long",
            "string",
            "float"});
            this.Param3ComboBox.Location = new System.Drawing.Point(489, 89);
            this.Param3ComboBox.Name = "Param3ComboBox";
            this.Param3ComboBox.Size = new System.Drawing.Size(206, 28);
            this.Param3ComboBox.TabIndex = 10;
            // 
            // Param2ComboBox
            // 
            this.Param2ComboBox.FormattingEnabled = true;
            this.Param2ComboBox.Items.AddRange(new object[] {
            "long",
            "string",
            "float"});
            this.Param2ComboBox.Location = new System.Drawing.Point(489, 49);
            this.Param2ComboBox.Name = "Param2ComboBox";
            this.Param2ComboBox.Size = new System.Drawing.Size(206, 28);
            this.Param2ComboBox.TabIndex = 9;
            // 
            // Param1ComboBox
            // 
            this.Param1ComboBox.FormattingEnabled = true;
            this.Param1ComboBox.Items.AddRange(new object[] {
            "long",
            "string",
            "float"});
            this.Param1ComboBox.Location = new System.Drawing.Point(489, 9);
            this.Param1ComboBox.Name = "Param1ComboBox";
            this.Param1ComboBox.Size = new System.Drawing.Size(206, 28);
            this.Param1ComboBox.TabIndex = 8;
            // 
            // Param8TextBox
            // 
            this.Param8TextBox.Location = new System.Drawing.Point(6, 289);
            this.Param8TextBox.Name = "Param8TextBox";
            this.Param8TextBox.Size = new System.Drawing.Size(476, 26);
            this.Param8TextBox.TabIndex = 7;
            // 
            // Param7TextBox
            // 
            this.Param7TextBox.Location = new System.Drawing.Point(6, 249);
            this.Param7TextBox.Name = "Param7TextBox";
            this.Param7TextBox.Size = new System.Drawing.Size(476, 26);
            this.Param7TextBox.TabIndex = 6;
            // 
            // Param6TextBox
            // 
            this.Param6TextBox.Location = new System.Drawing.Point(6, 209);
            this.Param6TextBox.Name = "Param6TextBox";
            this.Param6TextBox.Size = new System.Drawing.Size(476, 26);
            this.Param6TextBox.TabIndex = 5;
            // 
            // Param5TextBox
            // 
            this.Param5TextBox.Location = new System.Drawing.Point(6, 169);
            this.Param5TextBox.Name = "Param5TextBox";
            this.Param5TextBox.Size = new System.Drawing.Size(476, 26);
            this.Param5TextBox.TabIndex = 4;
            // 
            // Param4TextBox
            // 
            this.Param4TextBox.Location = new System.Drawing.Point(6, 129);
            this.Param4TextBox.Name = "Param4TextBox";
            this.Param4TextBox.Size = new System.Drawing.Size(476, 26);
            this.Param4TextBox.TabIndex = 3;
            // 
            // Param3TextBox
            // 
            this.Param3TextBox.Location = new System.Drawing.Point(6, 89);
            this.Param3TextBox.Name = "Param3TextBox";
            this.Param3TextBox.Size = new System.Drawing.Size(476, 26);
            this.Param3TextBox.TabIndex = 2;
            // 
            // Param2TextBox
            // 
            this.Param2TextBox.Location = new System.Drawing.Point(6, 49);
            this.Param2TextBox.Name = "Param2TextBox";
            this.Param2TextBox.Size = new System.Drawing.Size(476, 26);
            this.Param2TextBox.TabIndex = 1;
            // 
            // Param1TextBox
            // 
            this.Param1TextBox.Location = new System.Drawing.Point(6, 9);
            this.Param1TextBox.Name = "Param1TextBox";
            this.Param1TextBox.Size = new System.Drawing.Size(476, 26);
            this.Param1TextBox.TabIndex = 0;
            // 
            // PPCTab
            // 
            this.PPCTab.Controls.Add(this.InjectionAddressTextBox);
            this.PPCTab.Controls.Add(this.InjectCodeButton);
            this.PPCTab.Controls.Add(this.CompileInstructionsButton);
            this.PPCTab.Controls.Add(this.BinaryTextBox);
            this.PPCTab.Controls.Add(this.InstructionsTextBox);
            this.PPCTab.Location = new System.Drawing.Point(4, 29);
            this.PPCTab.Name = "PPCTab";
            this.PPCTab.Padding = new System.Windows.Forms.Padding(3);
            this.PPCTab.Size = new System.Drawing.Size(860, 595);
            this.PPCTab.TabIndex = 2;
            this.PPCTab.Text = "PowerPC";
            this.PPCTab.UseVisualStyleBackColor = true;
            // 
            // InjectionAddressTextBox
            // 
            this.InjectionAddressTextBox.Location = new System.Drawing.Point(394, 511);
            this.InjectionAddressTextBox.Name = "InjectionAddressTextBox";
            this.InjectionAddressTextBox.Size = new System.Drawing.Size(450, 26);
            this.InjectionAddressTextBox.TabIndex = 4;
            this.InjectionAddressTextBox.Text = "0x0";
            // 
            // InjectCodeButton
            // 
            this.InjectCodeButton.Location = new System.Drawing.Point(394, 552);
            this.InjectCodeButton.Name = "InjectCodeButton";
            this.InjectCodeButton.Size = new System.Drawing.Size(450, 35);
            this.InjectCodeButton.TabIndex = 3;
            this.InjectCodeButton.Text = "Inject PPC";
            this.InjectCodeButton.UseVisualStyleBackColor = true;
            this.InjectCodeButton.Click += new System.EventHandler(this.InjectCodeButton_Click);
            // 
            // CompileInstructionsButton
            // 
            this.CompileInstructionsButton.Location = new System.Drawing.Point(15, 552);
            this.CompileInstructionsButton.Name = "CompileInstructionsButton";
            this.CompileInstructionsButton.Size = new System.Drawing.Size(364, 35);
            this.CompileInstructionsButton.TabIndex = 2;
            this.CompileInstructionsButton.Text = "Compile";
            this.CompileInstructionsButton.UseVisualStyleBackColor = true;
            this.CompileInstructionsButton.Click += new System.EventHandler(this.CompileInstructionsButton_Click);
            // 
            // BinaryTextBox
            // 
            this.BinaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinaryTextBox.Location = new System.Drawing.Point(394, 15);
            this.BinaryTextBox.Name = "BinaryTextBox";
            this.BinaryTextBox.Size = new System.Drawing.Size(450, 478);
            this.BinaryTextBox.TabIndex = 1;
            this.BinaryTextBox.Text = "";
            // 
            // InstructionsTextBox
            // 
            this.InstructionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsTextBox.Location = new System.Drawing.Point(15, 15);
            this.InstructionsTextBox.Name = "InstructionsTextBox";
            this.InstructionsTextBox.Size = new System.Drawing.Size(364, 532);
            this.InstructionsTextBox.TabIndex = 0;
            this.InstructionsTextBox.Text = "";
            // 
            // MemoryTab
            // 
            this.MemoryTab.Controls.Add(this.PokeMemoryButton);
            this.MemoryTab.Controls.Add(this.PeekMemoryButton);
            this.MemoryTab.Controls.Add(this.MemorySizeLabel);
            this.MemoryTab.Controls.Add(this.MemorySizeTextBox);
            this.MemoryTab.Controls.Add(this.MemoryAddressLabel);
            this.MemoryTab.Controls.Add(this.MemoryAddressTextBox);
            this.MemoryTab.Controls.Add(this.MemoryViewHexBox);
            this.MemoryTab.Location = new System.Drawing.Point(4, 29);
            this.MemoryTab.Name = "MemoryTab";
            this.MemoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.MemoryTab.Size = new System.Drawing.Size(860, 595);
            this.MemoryTab.TabIndex = 3;
            this.MemoryTab.Text = "Memory";
            this.MemoryTab.UseVisualStyleBackColor = true;
            // 
            // CPUKeyLabel
            // 
            this.CPUKeyLabel.AutoSize = true;
            this.CPUKeyLabel.Location = new System.Drawing.Point(99, 109);
            this.CPUKeyLabel.Name = "CPUKeyLabel";
            this.CPUKeyLabel.Size = new System.Drawing.Size(297, 20);
            this.CPUKeyLabel.TabIndex = 5;
            this.CPUKeyLabel.Text = "00000000000000000000000000000000";
            this.CPUKeyLabel.Click += new System.EventHandler(this.CPUKeyLabel_Click);
            // 
            // TitleIDLabel
            // 
            this.TitleIDLabel.Location = new System.Drawing.Point(537, 78);
            this.TitleIDLabel.Name = "TitleIDLabel";
            this.TitleIDLabel.Size = new System.Drawing.Size(340, 20);
            this.TitleIDLabel.TabIndex = 6;
            this.TitleIDLabel.Text = "Current Title ID: 0x00000000";
            this.TitleIDLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CPUKeyHeaderLabel
            // 
            this.CPUKeyHeaderLabel.AutoSize = true;
            this.CPUKeyHeaderLabel.Location = new System.Drawing.Point(16, 108);
            this.CPUKeyHeaderLabel.Name = "CPUKeyHeaderLabel";
            this.CPUKeyHeaderLabel.Size = new System.Drawing.Size(76, 20);
            this.CPUKeyHeaderLabel.TabIndex = 7;
            this.CPUKeyHeaderLabel.Text = "CPU Key:";
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.AutoSize = true;
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(16, 78);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(116, 20);
            this.ConnectionStatusLabel.TabIndex = 8;
            this.ConnectionStatusLabel.Text = "Not Connected";
            // 
            // ConsoleDebugIPLabel
            // 
            this.ConsoleDebugIPLabel.Location = new System.Drawing.Point(498, 108);
            this.ConsoleDebugIPLabel.Name = "ConsoleDebugIPLabel";
            this.ConsoleDebugIPLabel.Size = new System.Drawing.Size(380, 22);
            this.ConsoleDebugIPLabel.TabIndex = 9;
            this.ConsoleDebugIPLabel.Text = "Console Debug IP: 192.168.1.1";
            this.ConsoleDebugIPLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MemoryViewHexBox
            // 
            this.MemoryViewHexBox.ColumnInfoVisible = true;
            this.MemoryViewHexBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryViewHexBox.LineInfoVisible = true;
            this.MemoryViewHexBox.Location = new System.Drawing.Point(10, 10);
            this.MemoryViewHexBox.Name = "MemoryViewHexBox";
            this.MemoryViewHexBox.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.MemoryViewHexBox.Size = new System.Drawing.Size(837, 540);
            this.MemoryViewHexBox.StringViewVisible = true;
            this.MemoryViewHexBox.TabIndex = 0;
            this.MemoryViewHexBox.UseFixedBytesPerLine = true;
            this.MemoryViewHexBox.VScrollBarVisible = true;
            // 
            // MemoryAddressTextBox
            // 
            this.MemoryAddressTextBox.Location = new System.Drawing.Point(125, 554);
            this.MemoryAddressTextBox.Name = "MemoryAddressTextBox";
            this.MemoryAddressTextBox.Size = new System.Drawing.Size(205, 26);
            this.MemoryAddressTextBox.TabIndex = 1;
            // 
            // MemoryAddressLabel
            // 
            this.MemoryAddressLabel.AutoSize = true;
            this.MemoryAddressLabel.Location = new System.Drawing.Point(32, 558);
            this.MemoryAddressLabel.Name = "MemoryAddressLabel";
            this.MemoryAddressLabel.Size = new System.Drawing.Size(68, 20);
            this.MemoryAddressLabel.TabIndex = 2;
            this.MemoryAddressLabel.Text = "Address";
            // 
            // MemorySizeLabel
            // 
            this.MemorySizeLabel.AutoSize = true;
            this.MemorySizeLabel.Location = new System.Drawing.Point(355, 558);
            this.MemorySizeLabel.Name = "MemorySizeLabel";
            this.MemorySizeLabel.Size = new System.Drawing.Size(40, 20);
            this.MemorySizeLabel.TabIndex = 4;
            this.MemorySizeLabel.Text = "Size";
            // 
            // MemorySizeTextBox
            // 
            this.MemorySizeTextBox.Location = new System.Drawing.Point(403, 554);
            this.MemorySizeTextBox.Name = "MemorySizeTextBox";
            this.MemorySizeTextBox.Size = new System.Drawing.Size(130, 26);
            this.MemorySizeTextBox.TabIndex = 3;
            // 
            // PeekMemoryButton
            // 
            this.PeekMemoryButton.Location = new System.Drawing.Point(563, 553);
            this.PeekMemoryButton.Name = "PeekMemoryButton";
            this.PeekMemoryButton.Size = new System.Drawing.Size(129, 34);
            this.PeekMemoryButton.TabIndex = 5;
            this.PeekMemoryButton.Text = "Peek";
            this.PeekMemoryButton.UseVisualStyleBackColor = true;
            this.PeekMemoryButton.Click += new System.EventHandler(this.PeekMemoryButton_Click);
            // 
            // PokeMemoryButton
            // 
            this.PokeMemoryButton.Location = new System.Drawing.Point(713, 553);
            this.PokeMemoryButton.Name = "PokeMemoryButton";
            this.PokeMemoryButton.Size = new System.Drawing.Size(129, 34);
            this.PokeMemoryButton.TabIndex = 6;
            this.PokeMemoryButton.Text = "Poke";
            this.PokeMemoryButton.UseVisualStyleBackColor = true;
            this.PokeMemoryButton.Click += new System.EventHandler(this.PokeMemoryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 772);
            this.Controls.Add(this.ConsoleDebugIPLabel);
            this.Controls.Add(this.ConnectionStatusLabel);
            this.Controls.Add(this.CPUKeyHeaderLabel);
            this.Controls.Add(this.TitleIDLabel);
            this.Controls.Add(this.CPUKeyLabel);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.SourceLinkLabel);
            this.Controls.Add(this.RebootButton);
            this.Controls.Add(this.ConnectButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Xbox 360 Toolbox by Matrix";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MainTabControl.ResumeLayout(false);
            this.ModuleTab.ResumeLayout(false);
            this.ModuleTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.FunctionsTab.ResumeLayout(false);
            this.FunctionsTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PPCTab.ResumeLayout(false);
            this.PPCTab.PerformLayout();
            this.MemoryTab.ResumeLayout(false);
            this.MemoryTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button RebootButton;
        private System.Windows.Forms.LinkLabel SourceLinkLabel;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage ModuleTab;
        private System.Windows.Forms.TabPage FunctionsTab;
        private System.Windows.Forms.Label CPUKeyLabel;
        private System.Windows.Forms.Label TitleIDLabel;
        private System.Windows.Forms.TabPage PPCTab;
        private System.Windows.Forms.TabPage MemoryTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LoadModuleButton;
        private System.Windows.Forms.TextBox ModulePathTextBox;
        private System.Windows.Forms.Button RefreshModulesButton;
        private System.Windows.Forms.Label CPUKeyHeaderLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
        private System.Windows.Forms.DataGridViewButtonColumn UnloadColumn;
        private System.Windows.Forms.Label ConnectionStatusLabel;
        private System.Windows.Forms.Label ConsoleDebugIPLabel;
        private System.Windows.Forms.RichTextBox BinaryTextBox;
        private System.Windows.Forms.RichTextBox InstructionsTextBox;
        private System.Windows.Forms.TextBox InjectionAddressTextBox;
        private System.Windows.Forms.Button InjectCodeButton;
        private System.Windows.Forms.Button CompileInstructionsButton;
        private System.Windows.Forms.ComboBox Param8ComboBox;
        private System.Windows.Forms.ComboBox Param7ComboBox;
        private System.Windows.Forms.ComboBox Param6ComboBox;
        private System.Windows.Forms.ComboBox Param5ComboBox;
        private System.Windows.Forms.ComboBox Param4ComboBox;
        private System.Windows.Forms.ComboBox Param3ComboBox;
        private System.Windows.Forms.ComboBox Param2ComboBox;
        private System.Windows.Forms.ComboBox Param1ComboBox;
        private System.Windows.Forms.TextBox Param8TextBox;
        private System.Windows.Forms.TextBox Param7TextBox;
        private System.Windows.Forms.TextBox Param6TextBox;
        private System.Windows.Forms.TextBox Param5TextBox;
        private System.Windows.Forms.TextBox Param4TextBox;
        private System.Windows.Forms.TextBox Param3TextBox;
        private System.Windows.Forms.TextBox Param2TextBox;
        private System.Windows.Forms.TextBox Param1TextBox;
        private System.Windows.Forms.CheckBox Param8CheckBox;
        private System.Windows.Forms.CheckBox Param7CheckBox;
        private System.Windows.Forms.CheckBox Param6CheckBox;
        private System.Windows.Forms.CheckBox Param5CheckBox;
        private System.Windows.Forms.CheckBox Param4CheckBox;
        private System.Windows.Forms.CheckBox Param3CheckBox;
        private System.Windows.Forms.CheckBox Param2CheckBox;
        private System.Windows.Forms.CheckBox Param1CheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ModuleNameTextBox;
        private System.Windows.Forms.Label ModuleNameLabel;
        private System.Windows.Forms.TextBox OrdinalTextBox;
        private System.Windows.Forms.Label OrdinalLabel;
        private System.Windows.Forms.TextBox ByOridinalReturnValueTextBox;
        private System.Windows.Forms.Button CallByOrdinalButton;
        private System.Windows.Forms.ComboBox CallByOrdinalReturnTypeComboBox;
        private System.Windows.Forms.Label ByOrdinalReturnLabel;
        private System.Windows.Forms.TextBox CallAddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CallAddressReturnTextBox;
        private System.Windows.Forms.Button CallFunctionButton;
        private System.Windows.Forms.ComboBox CallByAddressReturnType;
        private System.Windows.Forms.Label label2;
        private Be.Windows.Forms.HexBox MemoryViewHexBox;
        private System.Windows.Forms.Label MemorySizeLabel;
        private System.Windows.Forms.TextBox MemorySizeTextBox;
        private System.Windows.Forms.Label MemoryAddressLabel;
        private System.Windows.Forms.TextBox MemoryAddressTextBox;
        private System.Windows.Forms.Button PokeMemoryButton;
        private System.Windows.Forms.Button PeekMemoryButton;
    }
}

