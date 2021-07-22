namespace Winform_AI_Finite_Digital_Trigger
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
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries1 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.timer_FetchData = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_TrigParam = new System.Windows.Forms.GroupBox();
            this.numericUpDown_PreSamples = new System.Windows.Forms.NumericUpDown();
            this.label_PreSamples = new System.Windows.Forms.Label();
            this.comboBox_triggermode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_triggerSource = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_retriggerCount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_triggerEdge = new System.Windows.Forms.ComboBox();
            this.groupBox_genParam = new System.Windows.Forms.GroupBox();
            this.comboBox_inputRange = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_cardID = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_terminalType = new System.Windows.Forms.ComboBox();
            this.comboBox_channelNumber = new System.Windows.Forms.ComboBox();
            this.comboBox_SoltNumber = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_samples = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label_SampleRate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Channel = new System.Windows.Forms.Label();
            this.numericUpDown_sampleRate = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.easyChartX_readData = new SeeSharpTools.JY.GUI.EasyChartX();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox_TrigParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PreSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_retriggerCount)).BeginInit();
            this.groupBox_genParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_samples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 592);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1176, 22);
            this.statusStrip1.TabIndex = 83;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("宋体", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 31);
            this.label1.TabIndex = 85;
            this.label1.Text = "PCIe/PXIe 5500 Series Single Channel Finite ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1176, 80);
            this.splitter1.TabIndex = 84;
            this.splitter1.TabStop = false;
            // 
            // timer_FetchData
            // 
            this.timer_FetchData.Interval = 10;
            this.timer_FetchData.Tick += new System.EventHandler(this.timer_FetchData_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox_TrigParam);
            this.panel1.Controls.Add(this.groupBox_genParam);
            this.panel1.Location = new System.Drawing.Point(888, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 458);
            this.panel1.TabIndex = 89;
            // 
            // groupBox_TrigParam
            // 
            this.groupBox_TrigParam.Controls.Add(this.numericUpDown_PreSamples);
            this.groupBox_TrigParam.Controls.Add(this.label_PreSamples);
            this.groupBox_TrigParam.Controls.Add(this.comboBox_triggermode);
            this.groupBox_TrigParam.Controls.Add(this.label3);
            this.groupBox_TrigParam.Controls.Add(this.comboBox_triggerSource);
            this.groupBox_TrigParam.Controls.Add(this.label2);
            this.groupBox_TrigParam.Controls.Add(this.numericUpDown_retriggerCount);
            this.groupBox_TrigParam.Controls.Add(this.label10);
            this.groupBox_TrigParam.Controls.Add(this.label4);
            this.groupBox_TrigParam.Controls.Add(this.comboBox_triggerEdge);
            this.groupBox_TrigParam.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_TrigParam.Location = new System.Drawing.Point(4, 286);
            this.groupBox_TrigParam.Name = "groupBox_TrigParam";
            this.groupBox_TrigParam.Size = new System.Drawing.Size(279, 170);
            this.groupBox_TrigParam.TabIndex = 84;
            this.groupBox_TrigParam.TabStop = false;
            this.groupBox_TrigParam.Text = "Trigger Param Configuration";
            // 
            // numericUpDown_PreSamples
            // 
            this.numericUpDown_PreSamples.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_PreSamples.Location = new System.Drawing.Point(152, 129);
            this.numericUpDown_PreSamples.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_PreSamples.Name = "numericUpDown_PreSamples";
            this.numericUpDown_PreSamples.Size = new System.Drawing.Size(125, 23);
            this.numericUpDown_PreSamples.TabIndex = 86;
            this.numericUpDown_PreSamples.Tag = "ParaConfig";
            // 
            // label_PreSamples
            // 
            this.label_PreSamples.AutoSize = true;
            this.label_PreSamples.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_PreSamples.Location = new System.Drawing.Point(3, 130);
            this.label_PreSamples.Name = "label_PreSamples";
            this.label_PreSamples.Size = new System.Drawing.Size(133, 14);
            this.label_PreSamples.TabIndex = 87;
            this.label_PreSamples.Text = "Pretrigger Samples";
            // 
            // comboBox_triggermode
            // 
            this.comboBox_triggermode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_triggermode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_triggermode.FormattingEnabled = true;
            this.comboBox_triggermode.Location = new System.Drawing.Point(153, 22);
            this.comboBox_triggermode.Name = "comboBox_triggermode";
            this.comboBox_triggermode.Size = new System.Drawing.Size(125, 20);
            this.comboBox_triggermode.TabIndex = 69;
            this.comboBox_triggermode.Tag = "ParaConfig";
            this.comboBox_triggermode.SelectedIndexChanged += new System.EventHandler(this.comboBox_triggermode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 68;
            this.label3.Text = "Trigger Mode";
            // 
            // comboBox_triggerSource
            // 
            this.comboBox_triggerSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_triggerSource.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_triggerSource.FormattingEnabled = true;
            this.comboBox_triggerSource.Location = new System.Drawing.Point(153, 48);
            this.comboBox_triggerSource.Name = "comboBox_triggerSource";
            this.comboBox_triggerSource.Size = new System.Drawing.Size(125, 20);
            this.comboBox_triggerSource.TabIndex = 67;
            this.comboBox_triggerSource.Tag = "ParaConfig";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 66;
            this.label2.Text = "Trigger Source";
            // 
            // numericUpDown_retriggerCount
            // 
            this.numericUpDown_retriggerCount.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_retriggerCount.Location = new System.Drawing.Point(153, 100);
            this.numericUpDown_retriggerCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_retriggerCount.Name = "numericUpDown_retriggerCount";
            this.numericUpDown_retriggerCount.Size = new System.Drawing.Size(125, 23);
            this.numericUpDown_retriggerCount.TabIndex = 9;
            this.numericUpDown_retriggerCount.Tag = "ParaConfig";
            this.numericUpDown_retriggerCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label10.Location = new System.Drawing.Point(3, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 14);
            this.label10.TabIndex = 65;
            this.label10.Text = "Retrigger Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label4.Location = new System.Drawing.Point(3, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 55;
            this.label4.Text = "Trigger Edge";
            // 
            // comboBox_triggerEdge
            // 
            this.comboBox_triggerEdge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_triggerEdge.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_triggerEdge.FormattingEnabled = true;
            this.comboBox_triggerEdge.Location = new System.Drawing.Point(153, 74);
            this.comboBox_triggerEdge.Name = "comboBox_triggerEdge";
            this.comboBox_triggerEdge.Size = new System.Drawing.Size(125, 20);
            this.comboBox_triggerEdge.TabIndex = 8;
            this.comboBox_triggerEdge.Tag = "ParaConfig";
            // 
            // groupBox_genParam
            // 
            this.groupBox_genParam.Controls.Add(this.comboBox_inputRange);
            this.groupBox_genParam.Controls.Add(this.label14);
            this.groupBox_genParam.Controls.Add(this.comboBox_cardID);
            this.groupBox_genParam.Controls.Add(this.label11);
            this.groupBox_genParam.Controls.Add(this.comboBox_terminalType);
            this.groupBox_genParam.Controls.Add(this.comboBox_channelNumber);
            this.groupBox_genParam.Controls.Add(this.comboBox_SoltNumber);
            this.groupBox_genParam.Controls.Add(this.label7);
            this.groupBox_genParam.Controls.Add(this.numericUpDown_samples);
            this.groupBox_genParam.Controls.Add(this.label5);
            this.groupBox_genParam.Controls.Add(this.label_SampleRate);
            this.groupBox_genParam.Controls.Add(this.label8);
            this.groupBox_genParam.Controls.Add(this.label_Channel);
            this.groupBox_genParam.Controls.Add(this.numericUpDown_sampleRate);
            this.groupBox_genParam.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_genParam.Location = new System.Drawing.Point(4, 3);
            this.groupBox_genParam.Name = "groupBox_genParam";
            this.groupBox_genParam.Size = new System.Drawing.Size(280, 279);
            this.groupBox_genParam.TabIndex = 90;
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
            this.comboBox_inputRange.Location = new System.Drawing.Point(153, 222);
            this.comboBox_inputRange.Name = "comboBox_inputRange";
            this.comboBox_inputRange.Size = new System.Drawing.Size(125, 22);
            this.comboBox_inputRange.TabIndex = 112;
            this.comboBox_inputRange.SelectedIndexChanged += new System.EventHandler(this.comboBox_inputRange_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(3, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 14);
            this.label14.TabIndex = 111;
            this.label14.Text = "Input Range";
            // 
            // comboBox_cardID
            // 
            this.comboBox_cardID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cardID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_cardID.FormattingEnabled = true;
            this.comboBox_cardID.Items.AddRange(new object[] {
            "5510",
            "5511",
            "5515",
            "5516"});
            this.comboBox_cardID.Location = new System.Drawing.Point(154, 30);
            this.comboBox_cardID.Name = "comboBox_cardID";
            this.comboBox_cardID.Size = new System.Drawing.Size(125, 20);
            this.comboBox_cardID.TabIndex = 90;
            this.comboBox_cardID.Tag = "ParaConfig";
            this.comboBox_cardID.SelectedIndexChanged += new System.EventHandler(this.comboBox_cardID_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label11.Location = new System.Drawing.Point(3, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 14);
            this.label11.TabIndex = 91;
            this.label11.Text = "Card ID";
            // 
            // comboBox_terminalType
            // 
            this.comboBox_terminalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_terminalType.Font = new System.Drawing.Font("宋体", 9F);
            this.comboBox_terminalType.FormattingEnabled = true;
            this.comboBox_terminalType.Location = new System.Drawing.Point(154, 123);
            this.comboBox_terminalType.Name = "comboBox_terminalType";
            this.comboBox_terminalType.Size = new System.Drawing.Size(125, 20);
            this.comboBox_terminalType.TabIndex = 3;
            this.comboBox_terminalType.Tag = "ParaConfig";
            // 
            // comboBox_channelNumber
            // 
            this.comboBox_channelNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_channelNumber.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_channelNumber.FormattingEnabled = true;
            this.comboBox_channelNumber.Location = new System.Drawing.Point(154, 92);
            this.comboBox_channelNumber.Name = "comboBox_channelNumber";
            this.comboBox_channelNumber.Size = new System.Drawing.Size(125, 20);
            this.comboBox_channelNumber.TabIndex = 2;
            this.comboBox_channelNumber.Tag = "ParaConfig";
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
            this.comboBox_SoltNumber.Location = new System.Drawing.Point(154, 61);
            this.comboBox_SoltNumber.Name = "comboBox_SoltNumber";
            this.comboBox_SoltNumber.Size = new System.Drawing.Size(125, 20);
            this.comboBox_SoltNumber.TabIndex = 1;
            this.comboBox_SoltNumber.Tag = "ParaConfig";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label7.Location = new System.Drawing.Point(3, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 14);
            this.label7.TabIndex = 64;
            this.label7.Text = "Slot Number ";
            // 
            // numericUpDown_samples
            // 
            this.numericUpDown_samples.Location = new System.Drawing.Point(154, 188);
            this.numericUpDown_samples.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numericUpDown_samples.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_samples.Name = "numericUpDown_samples";
            this.numericUpDown_samples.Size = new System.Drawing.Size(125, 23);
            this.numericUpDown_samples.TabIndex = 4;
            this.numericUpDown_samples.Tag = "ParaConfig";
            this.numericUpDown_samples.ThousandsSeparator = true;
            this.numericUpDown_samples.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label5.Location = new System.Drawing.Point(3, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Samples to Acquire";
            // 
            // label_SampleRate
            // 
            this.label_SampleRate.AutoSize = true;
            this.label_SampleRate.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label_SampleRate.Location = new System.Drawing.Point(3, 158);
            this.label_SampleRate.Name = "label_SampleRate";
            this.label_SampleRate.Size = new System.Drawing.Size(133, 14);
            this.label_SampleRate.TabIndex = 1;
            this.label_SampleRate.Text = "Sample Rate(Sa/s) ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label8.Location = new System.Drawing.Point(3, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 14);
            this.label8.TabIndex = 2;
            this.label8.Text = "AI Terminal";
            // 
            // label_Channel
            // 
            this.label_Channel.AutoSize = true;
            this.label_Channel.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label_Channel.Location = new System.Drawing.Point(3, 94);
            this.label_Channel.Name = "label_Channel";
            this.label_Channel.Size = new System.Drawing.Size(77, 14);
            this.label_Channel.TabIndex = 2;
            this.label_Channel.Text = "Channel ID";
            // 
            // numericUpDown_sampleRate
            // 
            this.numericUpDown_sampleRate.Location = new System.Drawing.Point(154, 154);
            this.numericUpDown_sampleRate.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.Name = "numericUpDown_sampleRate";
            this.numericUpDown_sampleRate.Size = new System.Drawing.Size(125, 23);
            this.numericUpDown_sampleRate.TabIndex = 5;
            this.numericUpDown_sampleRate.Tag = "ParaConfig";
            this.numericUpDown_sampleRate.ThousandsSeparator = true;
            this.numericUpDown_sampleRate.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.easyChartX_readData);
            this.panel2.Location = new System.Drawing.Point(12, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 504);
            this.panel2.TabIndex = 90;
            // 
            // easyChartX_readData
            // 
            this.easyChartX_readData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.easyChartX_readData.AutoClear = true;
            this.easyChartX_readData.AxisX.AutoScale = true;
            this.easyChartX_readData.AxisX.AutoZoomReset = false;
            this.easyChartX_readData.AxisX.Color = System.Drawing.Color.Black;
            this.easyChartX_readData.AxisX.InitWithScaleView = false;
            this.easyChartX_readData.AxisX.IsLogarithmic = false;
            this.easyChartX_readData.AxisX.LabelAngle = 0;
            this.easyChartX_readData.AxisX.LabelEnabled = true;
            this.easyChartX_readData.AxisX.LabelFormat = null;
            this.easyChartX_readData.AxisX.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_readData.AxisX.MajorGridCount = -1;
            this.easyChartX_readData.AxisX.MajorGridEnabled = true;
            this.easyChartX_readData.AxisX.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_readData.AxisX.Maximum = 1000D;
            this.easyChartX_readData.AxisX.Minimum = 0D;
            this.easyChartX_readData.AxisX.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_readData.AxisX.MinorGridEnabled = false;
            this.easyChartX_readData.AxisX.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_readData.AxisX.TickWidth = 1F;
            this.easyChartX_readData.AxisX.Title = "";
            this.easyChartX_readData.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_readData.AxisX.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_readData.AxisX.ViewMaximum = 1000D;
            this.easyChartX_readData.AxisX.ViewMinimum = 0D;
            this.easyChartX_readData.AxisX2.AutoScale = true;
            this.easyChartX_readData.AxisX2.AutoZoomReset = false;
            this.easyChartX_readData.AxisX2.Color = System.Drawing.Color.Black;
            this.easyChartX_readData.AxisX2.InitWithScaleView = false;
            this.easyChartX_readData.AxisX2.IsLogarithmic = false;
            this.easyChartX_readData.AxisX2.LabelAngle = 0;
            this.easyChartX_readData.AxisX2.LabelEnabled = true;
            this.easyChartX_readData.AxisX2.LabelFormat = null;
            this.easyChartX_readData.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_readData.AxisX2.MajorGridCount = -1;
            this.easyChartX_readData.AxisX2.MajorGridEnabled = true;
            this.easyChartX_readData.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_readData.AxisX2.Maximum = 1000D;
            this.easyChartX_readData.AxisX2.Minimum = 0D;
            this.easyChartX_readData.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_readData.AxisX2.MinorGridEnabled = false;
            this.easyChartX_readData.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_readData.AxisX2.TickWidth = 1F;
            this.easyChartX_readData.AxisX2.Title = "";
            this.easyChartX_readData.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_readData.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_readData.AxisX2.ViewMaximum = 1000D;
            this.easyChartX_readData.AxisX2.ViewMinimum = 0D;
            this.easyChartX_readData.AxisY.AutoScale = true;
            this.easyChartX_readData.AxisY.AutoZoomReset = false;
            this.easyChartX_readData.AxisY.Color = System.Drawing.Color.Black;
            this.easyChartX_readData.AxisY.InitWithScaleView = false;
            this.easyChartX_readData.AxisY.IsLogarithmic = false;
            this.easyChartX_readData.AxisY.LabelAngle = 0;
            this.easyChartX_readData.AxisY.LabelEnabled = true;
            this.easyChartX_readData.AxisY.LabelFormat = null;
            this.easyChartX_readData.AxisY.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_readData.AxisY.MajorGridCount = 6;
            this.easyChartX_readData.AxisY.MajorGridEnabled = true;
            this.easyChartX_readData.AxisY.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_readData.AxisY.Maximum = 3.5D;
            this.easyChartX_readData.AxisY.Minimum = 0.5D;
            this.easyChartX_readData.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_readData.AxisY.MinorGridEnabled = false;
            this.easyChartX_readData.AxisY.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_readData.AxisY.TickWidth = 1F;
            this.easyChartX_readData.AxisY.Title = "";
            this.easyChartX_readData.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_readData.AxisY.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_readData.AxisY.ViewMaximum = 3.5D;
            this.easyChartX_readData.AxisY.ViewMinimum = 0.5D;
            this.easyChartX_readData.AxisY2.AutoScale = true;
            this.easyChartX_readData.AxisY2.AutoZoomReset = false;
            this.easyChartX_readData.AxisY2.Color = System.Drawing.Color.Black;
            this.easyChartX_readData.AxisY2.InitWithScaleView = false;
            this.easyChartX_readData.AxisY2.IsLogarithmic = false;
            this.easyChartX_readData.AxisY2.LabelAngle = 0;
            this.easyChartX_readData.AxisY2.LabelEnabled = true;
            this.easyChartX_readData.AxisY2.LabelFormat = null;
            this.easyChartX_readData.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_readData.AxisY2.MajorGridCount = 6;
            this.easyChartX_readData.AxisY2.MajorGridEnabled = true;
            this.easyChartX_readData.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_readData.AxisY2.Maximum = 3.5D;
            this.easyChartX_readData.AxisY2.Minimum = 0.5D;
            this.easyChartX_readData.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_readData.AxisY2.MinorGridEnabled = false;
            this.easyChartX_readData.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_readData.AxisY2.TickWidth = 1F;
            this.easyChartX_readData.AxisY2.Title = "";
            this.easyChartX_readData.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_readData.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_readData.AxisY2.ViewMaximum = 3.5D;
            this.easyChartX_readData.AxisY2.ViewMinimum = 0.5D;
            this.easyChartX_readData.BackColor = System.Drawing.Color.White;
            this.easyChartX_readData.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChartX_readData.Cumulitive = false;
            this.easyChartX_readData.GradientStyle = SeeSharpTools.JY.GUI.EasyChartX.ChartGradientStyle.None;
            this.easyChartX_readData.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartX_readData.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.easyChartX_readData.LegendForeColor = System.Drawing.Color.Black;
            this.easyChartX_readData.LegendVisible = true;
            easyChartXSeries1.Color = System.Drawing.Color.Red;
            easyChartXSeries1.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries1.Name = "Series1";
            easyChartXSeries1.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries1.Visible = true;
            easyChartXSeries1.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries1.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries1.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            this.easyChartX_readData.LineSeries.Add(easyChartXSeries1);
            this.easyChartX_readData.Location = new System.Drawing.Point(0, 0);
            this.easyChartX_readData.Margin = new System.Windows.Forms.Padding(4);
            this.easyChartX_readData.Miscellaneous.CheckInfinity = false;
            this.easyChartX_readData.Miscellaneous.CheckNaN = false;
            this.easyChartX_readData.Miscellaneous.CheckNegtiveOrZero = false;
            this.easyChartX_readData.Miscellaneous.DirectionChartCount = 3;
            this.easyChartX_readData.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.EasyChartX.FitType.Range;
            this.easyChartX_readData.Miscellaneous.MarkerSize = 5;
            this.easyChartX_readData.Miscellaneous.MaxSeriesCount = 32;
            this.easyChartX_readData.Miscellaneous.MaxSeriesPointCount = 4000;
            this.easyChartX_readData.Miscellaneous.ShowFunctionMenu = true;
            this.easyChartX_readData.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.easyChartX_readData.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.EasyChartXUtility.LayoutDirection.LeftToRight;
            this.easyChartX_readData.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.easyChartX_readData.Miscellaneous.SplitViewAutoLayout = true;
            this.easyChartX_readData.Name = "easyChartX_readData";
            this.easyChartX_readData.SeriesCount = 1;
            this.easyChartX_readData.Size = new System.Drawing.Size(870, 500);
            this.easyChartX_readData.SplitView = false;
            this.easyChartX_readData.TabIndex = 0;
            this.easyChartX_readData.XCursor.AutoInterval = true;
            this.easyChartX_readData.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChartX_readData.XCursor.Interval = 0.001D;
            this.easyChartX_readData.XCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Zoom;
            this.easyChartX_readData.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX_readData.XCursor.Value = double.NaN;
            this.easyChartX_readData.YCursor.AutoInterval = true;
            this.easyChartX_readData.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChartX_readData.YCursor.Interval = 0.001D;
            this.easyChartX_readData.YCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Disabled;
            this.easyChartX_readData.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX_readData.YCursor.Value = double.NaN;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoEllipsis = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label9.Font = new System.Drawing.Font("宋体", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(270, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(624, 31);
            this.label9.TabIndex = 93;
            this.label9.Text = " Data Acquisition (Digital Trigger）";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.button_start);
            this.panel4.Controls.Add(this.button_stop);
            this.panel4.Location = new System.Drawing.Point(888, 545);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 47);
            this.panel4.TabIndex = 94;
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_start.Location = new System.Drawing.Point(46, 11);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(66, 30);
            this.button_start.TabIndex = 79;
            this.button_start.Tag = "ParaConfig";
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click_1);
            // 
            // button_stop
            // 
            this.button_stop.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_stop.Location = new System.Drawing.Point(157, 11);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(66, 30);
            this.button_stop.TabIndex = 87;
            this.button_stop.Tag = "ParaConfig";
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 614);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCIe/PXIe 5500 Series Single Channel Finite Mode Data Acquisition （Digital Trigge" +
    "r）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox_TrigParam.ResumeLayout(false);
            this.groupBox_TrigParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PreSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_retriggerCount)).EndInit();
            this.groupBox_genParam.ResumeLayout(false);
            this.groupBox_genParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_samples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Timer timer_FetchData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private SeeSharpTools.JY.GUI.EasyChartX easyChartX_readData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox_genParam;
        private System.Windows.Forms.ComboBox comboBox_cardID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_terminalType;
        private System.Windows.Forms.ComboBox comboBox_channelNumber;
        private System.Windows.Forms.ComboBox comboBox_SoltNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_samples;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_SampleRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Channel;
        private System.Windows.Forms.NumericUpDown numericUpDown_sampleRate;
        private System.Windows.Forms.GroupBox groupBox_TrigParam;
        private System.Windows.Forms.NumericUpDown numericUpDown_PreSamples;
        private System.Windows.Forms.Label label_PreSamples;
        private System.Windows.Forms.ComboBox comboBox_triggermode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_triggerSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_retriggerCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_triggerEdge;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.ComboBox comboBox_inputRange;
        private System.Windows.Forms.Label label14;
    }
}

