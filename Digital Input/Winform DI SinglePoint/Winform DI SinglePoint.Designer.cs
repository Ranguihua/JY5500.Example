namespace Winform_DI_SinglePoint
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
        /// 设计器支持所需的方法不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox_anaInParam = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_cardID = new System.Windows.Forms.ComboBox();
            this.comboBox_SoltNumber = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.checkedListBox_portChoose = new System.Windows.Forms.CheckedListBox();
            this.ledArrayPort3 = new SeeSharpTools.JY.GUI.LEDArray();
            this.ledArrayPort2 = new SeeSharpTools.JY.GUI.LEDArray();
            this.ledArrayPort1 = new SeeSharpTools.JY.GUI.LEDArray();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.ledArrayPort0 = new SeeSharpTools.JY.GUI.LEDArray();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox_anaInParam.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_anaInParam
            // 
            this.groupBox_anaInParam.Controls.Add(this.label3);
            this.groupBox_anaInParam.Controls.Add(this.comboBox_cardID);
            this.groupBox_anaInParam.Controls.Add(this.comboBox_SoltNumber);
            this.groupBox_anaInParam.Controls.Add(this.label7);
            this.groupBox_anaInParam.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_anaInParam.Location = new System.Drawing.Point(20, 16);
            this.groupBox_anaInParam.Name = "groupBox_anaInParam";
            this.groupBox_anaInParam.Size = new System.Drawing.Size(227, 110);
            this.groupBox_anaInParam.TabIndex = 71;
            this.groupBox_anaInParam.TabStop = false;
            this.groupBox_anaInParam.Text = "Basic Param Configuration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(11, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 89;
            this.label3.Text = "Card ID";
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
            this.comboBox_cardID.Location = new System.Drawing.Point(103, 33);
            this.comboBox_cardID.Name = "comboBox_cardID";
            this.comboBox_cardID.Size = new System.Drawing.Size(118, 22);
            this.comboBox_cardID.TabIndex = 88;
            this.comboBox_cardID.Tag = "ParaConfig";
            this.comboBox_cardID.SelectedIndexChanged += new System.EventHandler(this.comboBox_cardID_SelectedIndexChanged);
            // 
            // comboBox_SoltNumber
            // 
            this.comboBox_SoltNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SoltNumber.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.comboBox_SoltNumber.Location = new System.Drawing.Point(103, 72);
            this.comboBox_SoltNumber.Name = "comboBox_SoltNumber";
            this.comboBox_SoltNumber.Size = new System.Drawing.Size(118, 20);
            this.comboBox_SoltNumber.TabIndex = 1;
            this.comboBox_SoltNumber.Tag = "ParaConfig";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(11, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 14);
            this.label7.TabIndex = 64;
            this.label7.Text = "Slot Number ";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(755, 80);
            this.splitter1.TabIndex = 81;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label2.Font = new System.Drawing.Font("宋体", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(747, 27);
            this.label2.TabIndex = 86;
            this.label2.Text = "PCIe/PXIe 5500 Series Single Digital Signal Input";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_start.Location = new System.Drawing.Point(66, 247);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(129, 30);
            this.button_start.TabIndex = 95;
            this.button_start.Tag = "ParaConfig";
            this.button_start.Text = "Check DI Status";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
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
            this.checkedListBox_portChoose.Location = new System.Drawing.Point(20, 132);
            this.checkedListBox_portChoose.Name = "checkedListBox_portChoose";
            this.checkedListBox_portChoose.Size = new System.Drawing.Size(227, 100);
            this.checkedListBox_portChoose.TabIndex = 193;
            // 
            // ledArrayPort3
            // 
            this.ledArrayPort3.ControlHeight = 30;
            this.ledArrayPort3.ControlWidth = 30;
            this.ledArrayPort3.Dimension = ((uint)(8u));
            this.ledArrayPort3.Direction = false;
            this.ledArrayPort3.LEDOffColor = System.Drawing.Color.Gray;
            this.ledArrayPort3.LEDOnColor = System.Drawing.Color.Lime;
            this.ledArrayPort3.LEDStyle = SeeSharpTools.JY.GUI.LED.LedStyle.Circular;
            this.ledArrayPort3.Location = new System.Drawing.Point(336, 299);
            this.ledArrayPort3.Margin = new System.Windows.Forms.Padding(4);
            this.ledArrayPort3.Name = "ledArrayPort3";
            this.ledArrayPort3.Size = new System.Drawing.Size(310, 40);
            this.ledArrayPort3.TabIndex = 157;
            this.ledArrayPort3.Value = new bool[] {
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false};
            // 
            // ledArrayPort2
            // 
            this.ledArrayPort2.ControlHeight = 30;
            this.ledArrayPort2.ControlWidth = 30;
            this.ledArrayPort2.Dimension = ((uint)(8u));
            this.ledArrayPort2.Direction = false;
            this.ledArrayPort2.LEDOffColor = System.Drawing.Color.Gray;
            this.ledArrayPort2.LEDOnColor = System.Drawing.Color.Lime;
            this.ledArrayPort2.LEDStyle = SeeSharpTools.JY.GUI.LED.LedStyle.Circular;
            this.ledArrayPort2.Location = new System.Drawing.Point(337, 152);
            this.ledArrayPort2.Margin = new System.Windows.Forms.Padding(4);
            this.ledArrayPort2.Name = "ledArrayPort2";
            this.ledArrayPort2.Size = new System.Drawing.Size(310, 55);
            this.ledArrayPort2.TabIndex = 158;
            this.ledArrayPort2.Value = new bool[] {
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false};
            // 
            // ledArrayPort1
            // 
            this.ledArrayPort1.ControlHeight = 30;
            this.ledArrayPort1.ControlWidth = 30;
            this.ledArrayPort1.Dimension = ((uint)(8u));
            this.ledArrayPort1.Direction = false;
            this.ledArrayPort1.LEDOffColor = System.Drawing.Color.Gray;
            this.ledArrayPort1.LEDOnColor = System.Drawing.Color.Lime;
            this.ledArrayPort1.LEDStyle = SeeSharpTools.JY.GUI.LED.LedStyle.Circular;
            this.ledArrayPort1.Location = new System.Drawing.Point(336, 174);
            this.ledArrayPort1.Margin = new System.Windows.Forms.Padding(4);
            this.ledArrayPort1.Name = "ledArrayPort1";
            this.ledArrayPort1.Size = new System.Drawing.Size(310, 55);
            this.ledArrayPort1.TabIndex = 159;
            this.ledArrayPort1.Value = new bool[] {
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false};
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(344, 156);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(17, 12);
            this.label36.TabIndex = 160;
            this.label36.Text = "L0";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(384, 156);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(17, 12);
            this.label35.TabIndex = 162;
            this.label35.Text = "L1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 161;
            this.label1.Text = "L2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(453, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 163;
            this.label10.Text = "L3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(488, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 165;
            this.label9.Text = "L4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(528, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 164;
            this.label8.Text = "L5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(564, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 167;
            this.label12.Text = "L6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(598, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 166;
            this.label11.Text = "L7";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(347, 217);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 168;
            this.label18.Text = "L8";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(387, 217);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 170;
            this.label17.Text = "L9";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(422, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 12);
            this.label16.TabIndex = 169;
            this.label16.Text = "L10";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(456, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 12);
            this.label15.TabIndex = 171;
            this.label15.Text = "L11";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(491, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 12);
            this.label14.TabIndex = 173;
            this.label14.Text = "L12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(531, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 172;
            this.label13.Text = "L13";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 175;
            this.label6.Text = "L14";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 174;
            this.label5.Text = "L15";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(344, 281);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(23, 12);
            this.label34.TabIndex = 184;
            this.label34.Text = "L16";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(384, 281);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(23, 12);
            this.label33.TabIndex = 186;
            this.label33.Text = "L17";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(419, 281);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(23, 12);
            this.label32.TabIndex = 185;
            this.label32.Text = "L18";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(453, 281);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(23, 12);
            this.label31.TabIndex = 187;
            this.label31.Text = "L19";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(488, 281);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(23, 12);
            this.label30.TabIndex = 189;
            this.label30.Text = "L20";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(528, 281);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(23, 12);
            this.label29.TabIndex = 188;
            this.label29.Text = "L21";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(564, 281);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(23, 12);
            this.label28.TabIndex = 191;
            this.label28.Text = "L22";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(599, 195);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(23, 12);
            this.label27.TabIndex = 190;
            this.label27.Text = "L23";
            // 
            // ledArrayPort0
            // 
            this.ledArrayPort0.ControlHeight = 30;
            this.ledArrayPort0.ControlWidth = 30;
            this.ledArrayPort0.Dimension = ((uint)(8u));
            this.ledArrayPort0.Direction = false;
            this.ledArrayPort0.LEDOffColor = System.Drawing.Color.Gray;
            this.ledArrayPort0.LEDOnColor = System.Drawing.Color.Lime;
            this.ledArrayPort0.LEDStyle = SeeSharpTools.JY.GUI.LED.LedStyle.Circular;
            this.ledArrayPort0.Location = new System.Drawing.Point(336, 102);
            this.ledArrayPort0.Margin = new System.Windows.Forms.Padding(4);
            this.ledArrayPort0.Name = "ledArrayPort0";
            this.ledArrayPort0.Size = new System.Drawing.Size(297, 55);
            this.ledArrayPort0.TabIndex = 192;
            this.ledArrayPort0.Value = new bool[] {
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false};
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.groupBox_anaInParam);
            this.panel1.Controls.Add(this.checkedListBox_portChoose);
            this.panel1.Controls.Add(this.button_start);
            this.panel1.Controls.Add(this.ledArrayPort2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(4, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 301);
            this.panel1.TabIndex = 194;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(599, 256);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 12);
            this.label19.TabIndex = 182;
            this.label19.Text = "L31";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(559, 257);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 12);
            this.label20.TabIndex = 183;
            this.label20.Text = "L30";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(523, 257);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 12);
            this.label21.TabIndex = 180;
            this.label21.Text = "L29";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(483, 257);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(23, 12);
            this.label22.TabIndex = 181;
            this.label22.Text = "L28";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(448, 257);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 12);
            this.label23.TabIndex = 179;
            this.label23.Text = "L27";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(414, 257);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(23, 12);
            this.label24.TabIndex = 177;
            this.label24.Text = "L26";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(379, 257);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(23, 12);
            this.label25.TabIndex = 178;
            this.label25.Text = "L25";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(339, 257);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(23, 12);
            this.label26.TabIndex = 176;
            this.label26.Text = "L24";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(328, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 20);
            this.panel2.TabIndex = 194;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 388);
            this.Controls.Add(this.ledArrayPort0);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.ledArrayPort1);
            this.Controls.Add(this.ledArrayPort3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCIe/PXIe 5500 Series Single Mode Digital Signal Input";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox_anaInParam.ResumeLayout(false);
            this.groupBox_anaInParam.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_anaInParam;
        private System.Windows.Forms.ComboBox comboBox_SoltNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.CheckedListBox checkedListBox_portChoose;
        private SeeSharpTools.JY.GUI.LEDArray ledArrayPort3;
        private SeeSharpTools.JY.GUI.LEDArray ledArrayPort2;
        private SeeSharpTools.JY.GUI.LEDArray ledArrayPort1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private SeeSharpTools.JY.GUI.LEDArray ledArrayPort0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_cardID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel2;
    }
}

