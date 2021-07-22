namespace Winform_DO_SinglePoint
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_ParamConfig = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_cardID = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_SoltNumber = new System.Windows.Forms.ComboBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox_port0 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.switchArrayport0 = new SeeSharpTools.JY.GUI.SwitchArray();
            this.groupBox_port1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.switchArrayport1 = new SeeSharpTools.JY.GUI.SwitchArray();
            this.groupBox_port2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.switchArrayport2 = new SeeSharpTools.JY.GUI.SwitchArray();
            this.groupBox_port3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.switchArrayport3 = new SeeSharpTools.JY.GUI.SwitchArray();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.button_stop = new System.Windows.Forms.Button();
            this.checkedListBox_portChoose = new System.Windows.Forms.CheckedListBox();
            this.groupBox_ParamConfig.SuspendLayout();
            this.groupBox_port0.SuspendLayout();
            this.groupBox_port1.SuspendLayout();
            this.groupBox_port2.SuspendLayout();
            this.groupBox_port3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1084, 100);
            this.splitter1.TabIndex = 81;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label2.Font = new System.Drawing.Font("宋体", 23F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(993, 39);
            this.label2.TabIndex = 82;
            this.label2.Text = "PCIe/PXIe 5500 Series Single Digital Output";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_ParamConfig
            // 
            this.groupBox_ParamConfig.Controls.Add(this.label8);
            this.groupBox_ParamConfig.Controls.Add(this.comboBox_cardID);
            this.groupBox_ParamConfig.Controls.Add(this.label13);
            this.groupBox_ParamConfig.Controls.Add(this.comboBox_SoltNumber);
            this.groupBox_ParamConfig.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_ParamConfig.Location = new System.Drawing.Point(16, 136);
            this.groupBox_ParamConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_ParamConfig.Name = "groupBox_ParamConfig";
            this.groupBox_ParamConfig.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_ParamConfig.Size = new System.Drawing.Size(263, 115);
            this.groupBox_ParamConfig.TabIndex = 83;
            this.groupBox_ParamConfig.TabStop = false;
            this.groupBox_ParamConfig.Text = "Basic Param Configuration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(8, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 91;
            this.label8.Text = "Card ID";
            // 
            // comboBox_cardID
            // 
            this.comboBox_cardID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cardID.FormattingEnabled = true;
            this.comboBox_cardID.Items.AddRange(new object[] {
            "5510",
            "5511",
            "5515",
            "5516"});
            this.comboBox_cardID.Location = new System.Drawing.Point(143, 36);
            this.comboBox_cardID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_cardID.Name = "comboBox_cardID";
            this.comboBox_cardID.Size = new System.Drawing.Size(96, 25);
            this.comboBox_cardID.TabIndex = 90;
            this.comboBox_cardID.Tag = "ParaConfig";
            this.comboBox_cardID.SelectedIndexChanged += new System.EventHandler(this.comboBox_cardID_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(8, 81);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 18);
            this.label13.TabIndex = 66;
            this.label13.Text = "Slot Number ";
            // 
            // comboBox_SoltNumber
            // 
            this.comboBox_SoltNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SoltNumber.FormattingEnabled = true;
            this.comboBox_SoltNumber.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox_SoltNumber.Location = new System.Drawing.Point(143, 78);
            this.comboBox_SoltNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_SoltNumber.Name = "comboBox_SoltNumber";
            this.comboBox_SoltNumber.Size = new System.Drawing.Size(96, 25);
            this.comboBox_SoltNumber.TabIndex = 65;
            this.comboBox_SoltNumber.Tag = "ParaConfig";
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_start.Location = new System.Drawing.Point(36, 470);
            this.button_start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(88, 38);
            this.button_start.TabIndex = 85;
            this.button_start.Tag = "ParaConfig";
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 68);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(143, 18);
            this.label20.TabIndex = 2;
            this.label20.Text = "LowLevel(false)";
            // 
            // groupBox_port0
            // 
            this.groupBox_port0.Controls.Add(this.label34);
            this.groupBox_port0.Controls.Add(this.switchArrayport0);
            this.groupBox_port0.Controls.Add(this.label20);
            this.groupBox_port0.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_port0.Location = new System.Drawing.Point(369, 121);
            this.groupBox_port0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_port0.Name = "groupBox_port0";
            this.groupBox_port0.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_port0.Size = new System.Drawing.Size(700, 120);
            this.groupBox_port0.TabIndex = 93;
            this.groupBox_port0.TabStop = false;
            this.groupBox_port0.Text = "Line(0~7)";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(13, 36);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(143, 18);
            this.label34.TabIndex = 1;
            this.label34.Text = "HighLevel(true)";
            // 
            // switchArrayport0
            // 
            this.switchArrayport0.ControlHeight = 40;
            this.switchArrayport0.ControlWidth = 30;
            this.switchArrayport0.Dimension = ((uint)(8u));
            this.switchArrayport0.Direction = false;
            this.switchArrayport0.Location = new System.Drawing.Point(172, 15);
            this.switchArrayport0.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.switchArrayport0.Name = "switchArrayport0";
            this.switchArrayport0.Size = new System.Drawing.Size(501, 81);
            this.switchArrayport0.Style = SeeSharpTools.JY.GUI.IndustrySwitch.SwitchStyles.Vertical;
            this.switchArrayport0.TabIndex = 95;
            this.switchArrayport0.Value = new bool[] {
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false};
            this.switchArrayport0.ControlValueChanged += new SeeSharpTools.JY.GUI.SwitchArray.ValueChangedEventHandler(this.switchArrayport0_ControlValueChanged);
            // 
            // groupBox_port1
            // 
            this.groupBox_port1.Controls.Add(this.label10);
            this.groupBox_port1.Controls.Add(this.label1);
            this.groupBox_port1.Controls.Add(this.switchArrayport1);
            this.groupBox_port1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_port1.Location = new System.Drawing.Point(369, 249);
            this.groupBox_port1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_port1.Name = "groupBox_port1";
            this.groupBox_port1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_port1.Size = new System.Drawing.Size(700, 126);
            this.groupBox_port1.TabIndex = 102;
            this.groupBox_port1.TabStop = false;
            this.groupBox_port1.Text = "Line(0~7)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 18);
            this.label10.TabIndex = 96;
            this.label10.Text = "LowLevel(false)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 98;
            this.label1.Text = "HighLevel(true)";
            // 
            // switchArrayport1
            // 
            this.switchArrayport1.ControlHeight = 40;
            this.switchArrayport1.ControlWidth = 30;
            this.switchArrayport1.Dimension = ((uint)(8u));
            this.switchArrayport1.Direction = false;
            this.switchArrayport1.Location = new System.Drawing.Point(165, 22);
            this.switchArrayport1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.switchArrayport1.Name = "switchArrayport1";
            this.switchArrayport1.Size = new System.Drawing.Size(508, 89);
            this.switchArrayport1.Style = SeeSharpTools.JY.GUI.IndustrySwitch.SwitchStyles.Vertical;
            this.switchArrayport1.TabIndex = 96;
            this.switchArrayport1.Value = new bool[] {
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false};
            this.switchArrayport1.ControlValueChanged += new SeeSharpTools.JY.GUI.SwitchArray.ValueChangedEventHandler(this.switchArrayport1_ControlValueChanged);
            // 
            // groupBox_port2
            // 
            this.groupBox_port2.Controls.Add(this.label9);
            this.groupBox_port2.Controls.Add(this.label11);
            this.groupBox_port2.Controls.Add(this.switchArrayport2);
            this.groupBox_port2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_port2.Location = new System.Drawing.Point(369, 382);
            this.groupBox_port2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_port2.Name = "groupBox_port2";
            this.groupBox_port2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_port2.Size = new System.Drawing.Size(700, 111);
            this.groupBox_port2.TabIndex = 105;
            this.groupBox_port2.TabStop = false;
            this.groupBox_port2.Text = "Line(0~7)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 18);
            this.label9.TabIndex = 99;
            this.label9.Text = "HighLevel(true)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 18);
            this.label11.TabIndex = 97;
            this.label11.Text = "LowLevel(false)";
            // 
            // switchArrayport2
            // 
            this.switchArrayport2.ControlHeight = 40;
            this.switchArrayport2.ControlWidth = 30;
            this.switchArrayport2.Dimension = ((uint)(8u));
            this.switchArrayport2.Direction = false;
            this.switchArrayport2.Location = new System.Drawing.Point(165, 24);
            this.switchArrayport2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.switchArrayport2.Name = "switchArrayport2";
            this.switchArrayport2.Size = new System.Drawing.Size(508, 76);
            this.switchArrayport2.Style = SeeSharpTools.JY.GUI.IndustrySwitch.SwitchStyles.Vertical;
            this.switchArrayport2.TabIndex = 97;
            this.switchArrayport2.Value = new bool[] {
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false};
            this.switchArrayport2.ControlValueChanged += new SeeSharpTools.JY.GUI.SwitchArray.ValueChangedEventHandler(this.switchArrayport2_ControlValueChanged);
            // 
            // groupBox_port3
            // 
            this.groupBox_port3.Controls.Add(this.label7);
            this.groupBox_port3.Controls.Add(this.label6);
            this.groupBox_port3.Controls.Add(this.switchArrayport3);
            this.groupBox_port3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_port3.Location = new System.Drawing.Point(369, 501);
            this.groupBox_port3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_port3.Name = "groupBox_port3";
            this.groupBox_port3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_port3.Size = new System.Drawing.Size(700, 111);
            this.groupBox_port3.TabIndex = 106;
            this.groupBox_port3.TabStop = false;
            this.groupBox_port3.Text = "Line(0~7)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 18);
            this.label7.TabIndex = 101;
            this.label7.Text = "LowLevel(false)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 100;
            this.label6.Text = "HighLevel(true)";
            // 
            // switchArrayport3
            // 
            this.switchArrayport3.ControlHeight = 40;
            this.switchArrayport3.ControlWidth = 30;
            this.switchArrayport3.Dimension = ((uint)(8u));
            this.switchArrayport3.Direction = false;
            this.switchArrayport3.Location = new System.Drawing.Point(165, 15);
            this.switchArrayport3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.switchArrayport3.Name = "switchArrayport3";
            this.switchArrayport3.Size = new System.Drawing.Size(524, 89);
            this.switchArrayport3.Style = SeeSharpTools.JY.GUI.IndustrySwitch.SwitchStyles.Vertical;
            this.switchArrayport3.TabIndex = 98;
            this.switchArrayport3.Value = new bool[] {
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false};
            this.switchArrayport3.ControlValueChanged += new SeeSharpTools.JY.GUI.SwitchArray.ValueChangedEventHandler(this.switchArrayport3_ControlValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 502);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 99;
            this.label3.Text = "port3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 368);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 100;
            this.label4.Text = "port2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 101;
            this.label5.Text = "port1";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(315, 136);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(47, 15);
            this.label46.TabIndex = 98;
            this.label46.Text = "port0";
            // 
            // button_stop
            // 
            this.button_stop.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_stop.Location = new System.Drawing.Point(167, 470);
            this.button_stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(88, 38);
            this.button_stop.TabIndex = 107;
            this.button_stop.Tag = "ParaConfig";
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // checkedListBox_portChoose
            // 
            this.checkedListBox_portChoose.CheckOnClick = true;
            this.checkedListBox_portChoose.FormattingEnabled = true;
            this.checkedListBox_portChoose.Items.AddRange(new object[] {
            "port0",
            "port1",
            "port2",
            "port3"});
            this.checkedListBox_portChoose.Location = new System.Drawing.Point(16, 290);
            this.checkedListBox_portChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox_portChoose.Name = "checkedListBox_portChoose";
            this.checkedListBox_portChoose.Size = new System.Drawing.Size(263, 124);
            this.checkedListBox_portChoose.TabIndex = 194;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 622);
            this.Controls.Add(this.checkedListBox_portChoose);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.groupBox_port3);
            this.Controls.Add(this.groupBox_port2);
            this.Controls.Add(this.groupBox_port1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.groupBox_port0);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.groupBox_ParamConfig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCIe/PXIe 5500 Single Mode Digital Signal Output";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox_ParamConfig.ResumeLayout(false);
            this.groupBox_ParamConfig.PerformLayout();
            this.groupBox_port0.ResumeLayout(false);
            this.groupBox_port0.PerformLayout();
            this.groupBox_port1.ResumeLayout(false);
            this.groupBox_port1.PerformLayout();
            this.groupBox_port2.ResumeLayout(false);
            this.groupBox_port2.PerformLayout();
            this.groupBox_port3.ResumeLayout(false);
            this.groupBox_port3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_ParamConfig;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_SoltNumber;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox_port0;
        private System.Windows.Forms.Label label34;
        private SeeSharpTools.JY.GUI.SwitchArray switchArrayport0;
        private System.Windows.Forms.GroupBox groupBox_port1;
        private SeeSharpTools.JY.GUI.SwitchArray switchArrayport1;
        private System.Windows.Forms.GroupBox groupBox_port2;
        private System.Windows.Forms.GroupBox groupBox_port3;
        private SeeSharpTools.JY.GUI.SwitchArray switchArrayport2;
        private SeeSharpTools.JY.GUI.SwitchArray switchArrayport3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_cardID;
        private System.Windows.Forms.CheckedListBox checkedListBox_portChoose;
    }
}

