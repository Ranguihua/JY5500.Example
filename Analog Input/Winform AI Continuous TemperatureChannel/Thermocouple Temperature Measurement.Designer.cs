namespace Winform_AI_Continuous_MulitiChannel
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
            this.components = new System.ComponentModel.Container();
            SeeSharpTools.JY.GUI.StripChartXSeries stripChartXSeries1 = new SeeSharpTools.JY.GUI.StripChartXSeries();
            SeeSharpTools.JY.GUI.StripChartXSeries stripChartXSeries2 = new SeeSharpTools.JY.GUI.StripChartXSeries();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_FetchData = new System.Windows.Forms.Timer(this.components);
            this.groupBox_genParam = new System.Windows.Forms.GroupBox();
            this.comboBox_inputRange = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBox_channels = new System.Windows.Forms.CheckedListBox();
            this.label_Channel = new System.Windows.Forms.Label();
            this.comboBox_thermocoupleType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_cardID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_SoltNumber = new System.Windows.Forms.ComboBox();
            this.label_SampleRate = new System.Windows.Forms.Label();
            this.numericUpDown_sampleRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_samples = new System.Windows.Forms.NumericUpDown();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.textBox_coldJunction = new System.Windows.Forms.TextBox();
            this.textBox_std = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_avg = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.stripChartX_readData = new SeeSharpTools.JY.GUI.StripChartX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1.SuspendLayout();
            this.groupBox_genParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_samples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1114, 22);
            this.statusStrip1.TabIndex = 82;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(922, 24);
            this.label1.TabIndex = 81;
            this.label1.Text = "PCIe/PXIe 5500 Series Thermocopule Temperature Measurment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_FetchData
            // 
            this.timer_FetchData.Interval = 10;
            this.timer_FetchData.Tick += new System.EventHandler(this.timer_FetchData_Tick);
            // 
            // groupBox_genParam
            // 
            this.groupBox_genParam.Controls.Add(this.comboBox_inputRange);
            this.groupBox_genParam.Controls.Add(this.label5);
            this.groupBox_genParam.Controls.Add(this.checkedListBox_channels);
            this.groupBox_genParam.Controls.Add(this.label_Channel);
            this.groupBox_genParam.Controls.Add(this.comboBox_thermocoupleType);
            this.groupBox_genParam.Controls.Add(this.label4);
            this.groupBox_genParam.Controls.Add(this.label8);
            this.groupBox_genParam.Controls.Add(this.comboBox_cardID);
            this.groupBox_genParam.Controls.Add(this.label7);
            this.groupBox_genParam.Controls.Add(this.comboBox_SoltNumber);
            this.groupBox_genParam.Controls.Add(this.label_SampleRate);
            this.groupBox_genParam.Controls.Add(this.numericUpDown_sampleRate);
            this.groupBox_genParam.Controls.Add(this.label2);
            this.groupBox_genParam.Controls.Add(this.numericUpDown_samples);
            this.groupBox_genParam.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_genParam.Location = new System.Drawing.Point(214, 0);
            this.groupBox_genParam.Name = "groupBox_genParam";
            this.groupBox_genParam.Size = new System.Drawing.Size(417, 381);
            this.groupBox_genParam.TabIndex = 84;
            this.groupBox_genParam.TabStop = false;
            this.groupBox_genParam.Text = "Basic Param Configuration";
            // 
            // comboBox_inputRange
            // 
            this.comboBox_inputRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_inputRange.FormattingEnabled = true;
            this.comboBox_inputRange.Items.AddRange(new object[] {
            "±10V",
            "±5V",
            "±2V",
            "±1V",
            "±0.5V",
            "±0.2V",
            "±0.1V"});
            this.comboBox_inputRange.Location = new System.Drawing.Point(11, 263);
            this.comboBox_inputRange.Name = "comboBox_inputRange";
            this.comboBox_inputRange.Size = new System.Drawing.Size(120, 22);
            this.comboBox_inputRange.TabIndex = 105;
            this.comboBox_inputRange.SelectedIndexChanged += new System.EventHandler(this.comboBox_inputRange_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(8, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 104;
            this.label5.Text = "Input Range";
            // 
            // checkedListBox_channels
            // 
            this.checkedListBox_channels.CheckOnClick = true;
            this.checkedListBox_channels.FormattingEnabled = true;
            this.checkedListBox_channels.Location = new System.Drawing.Point(137, 39);
            this.checkedListBox_channels.Name = "checkedListBox_channels";
            this.checkedListBox_channels.Size = new System.Drawing.Size(268, 328);
            this.checkedListBox_channels.TabIndex = 90;
            // 
            // label_Channel
            // 
            this.label_Channel.AutoSize = true;
            this.label_Channel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Channel.Location = new System.Drawing.Point(136, 23);
            this.label_Channel.Name = "label_Channel";
            this.label_Channel.Size = new System.Drawing.Size(63, 14);
            this.label_Channel.TabIndex = 2;
            this.label_Channel.Text = "Channels";
            // 
            // comboBox_thermocoupleType
            // 
            this.comboBox_thermocoupleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_thermocoupleType.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_thermocoupleType.FormattingEnabled = true;
            this.comboBox_thermocoupleType.Location = new System.Drawing.Point(11, 327);
            this.comboBox_thermocoupleType.Name = "comboBox_thermocoupleType";
            this.comboBox_thermocoupleType.Size = new System.Drawing.Size(119, 20);
            this.comboBox_thermocoupleType.TabIndex = 92;
            this.comboBox_thermocoupleType.Tag = "ParaConfig";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 75;
            this.label4.Text = "Card ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(8, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 14);
            this.label8.TabIndex = 91;
            this.label8.Text = "Thermocouple Type";
            // 
            // comboBox_cardID
            // 
            this.comboBox_cardID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cardID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_cardID.FormattingEnabled = true;
            this.comboBox_cardID.Items.AddRange(new object[] {
            "5500",
            "5511",
            "5515",
            "5516"});
            this.comboBox_cardID.Location = new System.Drawing.Point(9, 39);
            this.comboBox_cardID.Name = "comboBox_cardID";
            this.comboBox_cardID.Size = new System.Drawing.Size(116, 20);
            this.comboBox_cardID.TabIndex = 74;
            this.comboBox_cardID.Tag = "ParaConfig";
            this.comboBox_cardID.SelectedIndexChanged += new System.EventHandler(this.comboBox_cardID_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 14);
            this.label7.TabIndex = 64;
            this.label7.Text = "Slot Number";
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
            this.comboBox_SoltNumber.Location = new System.Drawing.Point(9, 91);
            this.comboBox_SoltNumber.Name = "comboBox_SoltNumber";
            this.comboBox_SoltNumber.Size = new System.Drawing.Size(116, 20);
            this.comboBox_SoltNumber.TabIndex = 63;
            this.comboBox_SoltNumber.Tag = "ParaConfig";
            // 
            // label_SampleRate
            // 
            this.label_SampleRate.AutoSize = true;
            this.label_SampleRate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SampleRate.Location = new System.Drawing.Point(6, 126);
            this.label_SampleRate.Name = "label_SampleRate";
            this.label_SampleRate.Size = new System.Drawing.Size(133, 14);
            this.label_SampleRate.TabIndex = 1;
            this.label_SampleRate.Text = "Sample Rate(Sa/s) ";
            // 
            // numericUpDown_sampleRate
            // 
            this.numericUpDown_sampleRate.Location = new System.Drawing.Point(9, 143);
            this.numericUpDown_sampleRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.Name = "numericUpDown_sampleRate";
            this.numericUpDown_sampleRate.Size = new System.Drawing.Size(116, 23);
            this.numericUpDown_sampleRate.TabIndex = 5;
            this.numericUpDown_sampleRate.Tag = "ParaConfig";
            this.numericUpDown_sampleRate.ThousandsSeparator = true;
            this.numericUpDown_sampleRate.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 14);
            this.label2.TabIndex = 70;
            this.label2.Text = "Samples to Acquire";
            // 
            // numericUpDown_samples
            // 
            this.numericUpDown_samples.Location = new System.Drawing.Point(9, 198);
            this.numericUpDown_samples.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_samples.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_samples.Name = "numericUpDown_samples";
            this.numericUpDown_samples.Size = new System.Drawing.Size(116, 23);
            this.numericUpDown_samples.TabIndex = 71;
            this.numericUpDown_samples.Tag = "ParaConfig";
            this.numericUpDown_samples.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // button_stop
            // 
            this.button_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_stop.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_stop.Location = new System.Drawing.Point(430, 400);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(100, 36);
            this.button_stop.TabIndex = 78;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_start
            // 
            this.button_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_start.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_start.Location = new System.Drawing.Point(266, 400);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(114, 36);
            this.button_start.TabIndex = 77;
            this.button_start.Tag = "ParaConfig";
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // textBox_coldJunction
            // 
            this.textBox_coldJunction.BackColor = System.Drawing.Color.White;
            this.textBox_coldJunction.Location = new System.Drawing.Point(5, 21);
            this.textBox_coldJunction.Multiline = true;
            this.textBox_coldJunction.Name = "textBox_coldJunction";
            this.textBox_coldJunction.ReadOnly = true;
            this.textBox_coldJunction.Size = new System.Drawing.Size(200, 21);
            this.textBox_coldJunction.TabIndex = 88;
            // 
            // textBox_std
            // 
            this.textBox_std.BackColor = System.Drawing.Color.White;
            this.textBox_std.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_std.Location = new System.Drawing.Point(103, 0);
            this.textBox_std.Multiline = true;
            this.textBox_std.Name = "textBox_std";
            this.textBox_std.ReadOnly = true;
            this.textBox_std.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_std.Size = new System.Drawing.Size(105, 342);
            this.textBox_std.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 92;
            this.label9.Text = "Std(℃):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 12);
            this.label6.TabIndex = 90;
            this.label6.Text = "ColdJunction Temperature(℃):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 92;
            this.label3.Text = "Avg(℃)";
            // 
            // textBox_avg
            // 
            this.textBox_avg.BackColor = System.Drawing.Color.White;
            this.textBox_avg.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_avg.Location = new System.Drawing.Point(0, 0);
            this.textBox_avg.Multiline = true;
            this.textBox_avg.Name = "textBox_avg";
            this.textBox_avg.ReadOnly = true;
            this.textBox_avg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_avg.Size = new System.Drawing.Size(97, 342);
            this.textBox_avg.TabIndex = 93;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1114, 516);
            this.splitContainer1.SplitterDistance = 60;
            this.splitContainer1.TabIndex = 94;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.stripChartX_readData);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button_stop);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2.Controls.Add(this.button_start);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox_genParam);
            this.splitContainer2.Size = new System.Drawing.Size(1114, 452);
            this.splitContainer2.SplitterDistance = 488;
            this.splitContainer2.TabIndex = 0;
            // 
            // stripChartX_readData
            // 
            this.stripChartX_readData.AxisX.AutoScale = false;
            this.stripChartX_readData.AxisX.AutoZoomReset = false;
            this.stripChartX_readData.AxisX.Color = System.Drawing.Color.Black;
            this.stripChartX_readData.AxisX.InitWithScaleView = false;
            this.stripChartX_readData.AxisX.IsLogarithmic = false;
            this.stripChartX_readData.AxisX.LabelAngle = 0;
            this.stripChartX_readData.AxisX.LabelEnabled = true;
            this.stripChartX_readData.AxisX.LabelFormat = null;
            this.stripChartX_readData.AxisX.MajorGridColor = System.Drawing.Color.Black;
            this.stripChartX_readData.AxisX.MajorGridCount = 6;
            this.stripChartX_readData.AxisX.MajorGridEnabled = true;
            this.stripChartX_readData.AxisX.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.stripChartX_readData.AxisX.Maximum = 1000D;
            this.stripChartX_readData.AxisX.Minimum = 0D;
            this.stripChartX_readData.AxisX.MinorGridColor = System.Drawing.Color.Black;
            this.stripChartX_readData.AxisX.MinorGridEnabled = false;
            this.stripChartX_readData.AxisX.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.stripChartX_readData.AxisX.TickWidth = 1F;
            this.stripChartX_readData.AxisX.Title = "";
            this.stripChartX_readData.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.stripChartX_readData.AxisX.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.stripChartX_readData.AxisX.ViewMaximum = 1000D;
            this.stripChartX_readData.AxisX.ViewMinimum = 0D;
            this.stripChartX_readData.AxisX2.AutoScale = false;
            this.stripChartX_readData.AxisX2.AutoZoomReset = false;
            this.stripChartX_readData.AxisX2.Color = System.Drawing.Color.Black;
            this.stripChartX_readData.AxisX2.InitWithScaleView = false;
            this.stripChartX_readData.AxisX2.IsLogarithmic = false;
            this.stripChartX_readData.AxisX2.LabelAngle = 0;
            this.stripChartX_readData.AxisX2.LabelEnabled = true;
            this.stripChartX_readData.AxisX2.LabelFormat = null;
            this.stripChartX_readData.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.stripChartX_readData.AxisX2.MajorGridCount = 6;
            this.stripChartX_readData.AxisX2.MajorGridEnabled = true;
            this.stripChartX_readData.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.stripChartX_readData.AxisX2.Maximum = 1000D;
            this.stripChartX_readData.AxisX2.Minimum = 0D;
            this.stripChartX_readData.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.stripChartX_readData.AxisX2.MinorGridEnabled = false;
            this.stripChartX_readData.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.stripChartX_readData.AxisX2.TickWidth = 1F;
            this.stripChartX_readData.AxisX2.Title = "";
            this.stripChartX_readData.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.stripChartX_readData.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.stripChartX_readData.AxisX2.ViewMaximum = 1000D;
            this.stripChartX_readData.AxisX2.ViewMinimum = 0D;
            this.stripChartX_readData.AxisY.AutoScale = true;
            this.stripChartX_readData.AxisY.AutoZoomReset = false;
            this.stripChartX_readData.AxisY.Color = System.Drawing.Color.Black;
            this.stripChartX_readData.AxisY.InitWithScaleView = false;
            this.stripChartX_readData.AxisY.IsLogarithmic = false;
            this.stripChartX_readData.AxisY.LabelAngle = 0;
            this.stripChartX_readData.AxisY.LabelEnabled = true;
            this.stripChartX_readData.AxisY.LabelFormat = null;
            this.stripChartX_readData.AxisY.MajorGridColor = System.Drawing.Color.Black;
            this.stripChartX_readData.AxisY.MajorGridCount = 6;
            this.stripChartX_readData.AxisY.MajorGridEnabled = true;
            this.stripChartX_readData.AxisY.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.stripChartX_readData.AxisY.Maximum = 3.5D;
            this.stripChartX_readData.AxisY.Minimum = 0.5D;
            this.stripChartX_readData.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.stripChartX_readData.AxisY.MinorGridEnabled = false;
            this.stripChartX_readData.AxisY.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.stripChartX_readData.AxisY.TickWidth = 1F;
            this.stripChartX_readData.AxisY.Title = "";
            this.stripChartX_readData.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.stripChartX_readData.AxisY.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.stripChartX_readData.AxisY.ViewMaximum = 3.5D;
            this.stripChartX_readData.AxisY.ViewMinimum = 0.5D;
            this.stripChartX_readData.AxisY2.AutoScale = true;
            this.stripChartX_readData.AxisY2.AutoZoomReset = false;
            this.stripChartX_readData.AxisY2.Color = System.Drawing.Color.Black;
            this.stripChartX_readData.AxisY2.InitWithScaleView = false;
            this.stripChartX_readData.AxisY2.IsLogarithmic = false;
            this.stripChartX_readData.AxisY2.LabelAngle = 0;
            this.stripChartX_readData.AxisY2.LabelEnabled = true;
            this.stripChartX_readData.AxisY2.LabelFormat = null;
            this.stripChartX_readData.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.stripChartX_readData.AxisY2.MajorGridCount = 6;
            this.stripChartX_readData.AxisY2.MajorGridEnabled = true;
            this.stripChartX_readData.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.stripChartX_readData.AxisY2.Maximum = 3.5D;
            this.stripChartX_readData.AxisY2.Minimum = 0.5D;
            this.stripChartX_readData.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.stripChartX_readData.AxisY2.MinorGridEnabled = false;
            this.stripChartX_readData.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.stripChartX_readData.AxisY2.TickWidth = 1F;
            this.stripChartX_readData.AxisY2.Title = "";
            this.stripChartX_readData.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.stripChartX_readData.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.stripChartX_readData.AxisY2.ViewMaximum = 3.5D;
            this.stripChartX_readData.AxisY2.ViewMinimum = 0.5D;
            this.stripChartX_readData.BackColor = System.Drawing.Color.White;
            this.stripChartX_readData.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.stripChartX_readData.Direction = SeeSharpTools.JY.GUI.StripChartX.ScrollDirection.LeftToRight;
            this.stripChartX_readData.DisplayPoints = 200;
            this.stripChartX_readData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stripChartX_readData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stripChartX_readData.GradientStyle = SeeSharpTools.JY.GUI.StripChartX.ChartGradientStyle.None;
            this.stripChartX_readData.LegendBackColor = System.Drawing.Color.Transparent;
            this.stripChartX_readData.LegendFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stripChartX_readData.LegendForeColor = System.Drawing.Color.Black;
            this.stripChartX_readData.LegendVisible = false;
            stripChartXSeries1.Color = System.Drawing.Color.Red;
            stripChartXSeries1.Marker = SeeSharpTools.JY.GUI.StripChartXSeries.MarkerType.None;
            stripChartXSeries1.Name = "Series1";
            stripChartXSeries1.Type = SeeSharpTools.JY.GUI.StripChartXSeries.LineType.FastLine;
            stripChartXSeries1.Visible = true;
            stripChartXSeries1.Width = SeeSharpTools.JY.GUI.StripChartXSeries.LineWidth.Thin;
            stripChartXSeries1.XPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            stripChartXSeries1.YPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            stripChartXSeries2.Color = System.Drawing.Color.Blue;
            stripChartXSeries2.Marker = SeeSharpTools.JY.GUI.StripChartXSeries.MarkerType.None;
            stripChartXSeries2.Name = "Series2";
            stripChartXSeries2.Type = SeeSharpTools.JY.GUI.StripChartXSeries.LineType.FastLine;
            stripChartXSeries2.Visible = false;
            stripChartXSeries2.Width = SeeSharpTools.JY.GUI.StripChartXSeries.LineWidth.Thin;
            stripChartXSeries2.XPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            stripChartXSeries2.YPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            this.stripChartX_readData.LineSeries.Add(stripChartXSeries1);
            this.stripChartX_readData.LineSeries.Add(stripChartXSeries2);
            this.stripChartX_readData.Location = new System.Drawing.Point(0, 0);
            this.stripChartX_readData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stripChartX_readData.Miscellaneous.CheckInfinity = false;
            this.stripChartX_readData.Miscellaneous.CheckNaN = false;
            this.stripChartX_readData.Miscellaneous.CheckNegtiveOrZero = false;
            this.stripChartX_readData.Miscellaneous.DirectionChartCount = 3;
            this.stripChartX_readData.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.StripChartX.FitType.Range;
            this.stripChartX_readData.Miscellaneous.MaxSeriesCount = 32;
            this.stripChartX_readData.Miscellaneous.MaxSeriesPointCount = 4000;
            this.stripChartX_readData.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.stripChartX_readData.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.StripChartXUtility.LayoutDirection.LeftToRight;
            this.stripChartX_readData.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.stripChartX_readData.Miscellaneous.SplitViewAutoLayout = true;
            this.stripChartX_readData.Name = "stripChartX_readData";
            this.stripChartX_readData.NextTimeStamp = new System.DateTime(((long)(0)));
            this.stripChartX_readData.ScrollType = SeeSharpTools.JY.GUI.StripChartX.StripScrollType.Cumulation;
            this.stripChartX_readData.SeriesCount = 1;
            this.stripChartX_readData.Size = new System.Drawing.Size(488, 452);
            this.stripChartX_readData.SplitView = false;
            this.stripChartX_readData.StartIndex = 0;
            this.stripChartX_readData.TabIndex = 91;
            this.stripChartX_readData.TimeInterval = System.TimeSpan.Parse("00:00:00");
            this.stripChartX_readData.TimeStampFormat = null;
            this.stripChartX_readData.XCursor.AutoInterval = true;
            this.stripChartX_readData.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.stripChartX_readData.XCursor.Interval = 0.001D;
            this.stripChartX_readData.XCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Zoom;
            this.stripChartX_readData.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.stripChartX_readData.XCursor.Value = double.NaN;
            this.stripChartX_readData.XDataType = SeeSharpTools.JY.GUI.StripChartX.XAxisDataType.Index;
            this.stripChartX_readData.YCursor.AutoInterval = true;
            this.stripChartX_readData.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.stripChartX_readData.YCursor.Interval = 0.001D;
            this.stripChartX_readData.YCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Disabled;
            this.stripChartX_readData.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.stripChartX_readData.YCursor.Value = double.NaN;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.splitContainer3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 452);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature View";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(3, 17);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.textBox_coldJunction);
            this.splitContainer3.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(208, 432);
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label9);
            this.splitContainer4.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.textBox_std);
            this.splitContainer4.Panel2.Controls.Add(this.textBox_avg);
            this.splitContainer4.Size = new System.Drawing.Size(208, 378);
            this.splitContainer4.SplitterDistance = 32;
            this.splitContainer4.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 538);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCIe/PXIe 5500 Series Thermocopule Temperature Measurment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox_genParam.ResumeLayout(false);
            this.groupBox_genParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_samples)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_FetchData;
        private System.Windows.Forms.GroupBox groupBox_genParam;
        private System.Windows.Forms.TextBox textBox_coldJunction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_std;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_avg;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.CheckedListBox checkedListBox_channels;
        private System.Windows.Forms.Label label_Channel;
        private System.Windows.Forms.ComboBox comboBox_thermocoupleType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_cardID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_SoltNumber;
        private System.Windows.Forms.Label label_SampleRate;
        private System.Windows.Forms.NumericUpDown numericUpDown_sampleRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_samples;
        private System.Windows.Forms.ComboBox comboBox_inputRange;
        private System.Windows.Forms.Label label5;
        private SeeSharpTools.JY.GUI.StripChartX stripChartX_readData;
    }
}

