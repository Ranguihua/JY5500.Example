namespace Winform_AI_Continuous_MulitiChannel_Soft_Trigger
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox_genParam = new System.Windows.Forms.GroupBox();
            this.comboBox_inputRange = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_cardID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_samples = new System.Windows.Forms.NumericUpDown();
            this.comboBox_terminalType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_channelNumber = new System.Windows.Forms.ComboBox();
            this.comboBox_SoltNumber = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_SampleRate = new System.Windows.Forms.Label();
            this.label_Channel = new System.Windows.Forms.Label();
            this.numericUpDown_sampleRate = new System.Windows.Forms.NumericUpDown();
            this.button_sendSoftTrigger = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.easyChartX_readData = new SeeSharpTools.JY.GUI.EasyChartX();
            this.timer_FetchData = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox_genParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_samples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox_genParam);
            this.panel2.Location = new System.Drawing.Point(821, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 313);
            this.panel2.TabIndex = 91;
            // 
            // groupBox_genParam
            // 
            this.groupBox_genParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_genParam.Controls.Add(this.comboBox_inputRange);
            this.groupBox_genParam.Controls.Add(this.label12);
            this.groupBox_genParam.Controls.Add(this.comboBox_cardID);
            this.groupBox_genParam.Controls.Add(this.label4);
            this.groupBox_genParam.Controls.Add(this.label2);
            this.groupBox_genParam.Controls.Add(this.numericUpDown_samples);
            this.groupBox_genParam.Controls.Add(this.comboBox_terminalType);
            this.groupBox_genParam.Controls.Add(this.label5);
            this.groupBox_genParam.Controls.Add(this.comboBox_channelNumber);
            this.groupBox_genParam.Controls.Add(this.comboBox_SoltNumber);
            this.groupBox_genParam.Controls.Add(this.label7);
            this.groupBox_genParam.Controls.Add(this.label_SampleRate);
            this.groupBox_genParam.Controls.Add(this.label_Channel);
            this.groupBox_genParam.Controls.Add(this.numericUpDown_sampleRate);
            this.groupBox_genParam.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_genParam.Location = new System.Drawing.Point(3, 2);
            this.groupBox_genParam.Name = "groupBox_genParam";
            this.groupBox_genParam.Size = new System.Drawing.Size(286, 308);
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
            this.comboBox_inputRange.Location = new System.Drawing.Point(154, 228);
            this.comboBox_inputRange.Name = "comboBox_inputRange";
            this.comboBox_inputRange.Size = new System.Drawing.Size(115, 22);
            this.comboBox_inputRange.TabIndex = 104;
            this.comboBox_inputRange.SelectedIndexChanged += new System.EventHandler(this.comboBox_inputRange_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(8, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 14);
            this.label12.TabIndex = 103;
            this.label12.Text = "Input Range";
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
            this.comboBox_cardID.Location = new System.Drawing.Point(154, 42);
            this.comboBox_cardID.Name = "comboBox_cardID";
            this.comboBox_cardID.Size = new System.Drawing.Size(115, 20);
            this.comboBox_cardID.TabIndex = 74;
            this.comboBox_cardID.Tag = "ParaConfig";
            this.comboBox_cardID.SelectedIndexChanged += new System.EventHandler(this.comboBox_cardID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(8, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 75;
            this.label4.Text = "Card ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 14);
            this.label2.TabIndex = 70;
            this.label2.Text = "Samples to Acquire";
            // 
            // numericUpDown_samples
            // 
            this.numericUpDown_samples.Location = new System.Drawing.Point(154, 195);
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
            this.numericUpDown_samples.Size = new System.Drawing.Size(115, 23);
            this.numericUpDown_samples.TabIndex = 71;
            this.numericUpDown_samples.Tag = "ParaConfig";
            this.numericUpDown_samples.ThousandsSeparator = true;
            this.numericUpDown_samples.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // comboBox_terminalType
            // 
            this.comboBox_terminalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_terminalType.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_terminalType.FormattingEnabled = true;
            this.comboBox_terminalType.Location = new System.Drawing.Point(154, 132);
            this.comboBox_terminalType.Name = "comboBox_terminalType";
            this.comboBox_terminalType.Size = new System.Drawing.Size(115, 20);
            this.comboBox_terminalType.TabIndex = 69;
            this.comboBox_terminalType.Tag = "ParaConfig";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(8, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 68;
            this.label5.Text = "AI Terminal";
            // 
            // comboBox_channelNumber
            // 
            this.comboBox_channelNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_channelNumber.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_channelNumber.FormattingEnabled = true;
            this.comboBox_channelNumber.Location = new System.Drawing.Point(154, 102);
            this.comboBox_channelNumber.Name = "comboBox_channelNumber";
            this.comboBox_channelNumber.Size = new System.Drawing.Size(115, 20);
            this.comboBox_channelNumber.TabIndex = 67;
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
            this.comboBox_SoltNumber.Location = new System.Drawing.Point(154, 72);
            this.comboBox_SoltNumber.Name = "comboBox_SoltNumber";
            this.comboBox_SoltNumber.Size = new System.Drawing.Size(115, 20);
            this.comboBox_SoltNumber.TabIndex = 63;
            this.comboBox_SoltNumber.Tag = "ParaConfig";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(8, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 14);
            this.label7.TabIndex = 64;
            this.label7.Text = "Slot Number";
            // 
            // label_SampleRate
            // 
            this.label_SampleRate.AutoSize = true;
            this.label_SampleRate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SampleRate.Location = new System.Drawing.Point(8, 168);
            this.label_SampleRate.Name = "label_SampleRate";
            this.label_SampleRate.Size = new System.Drawing.Size(133, 14);
            this.label_SampleRate.TabIndex = 1;
            this.label_SampleRate.Text = "Sample Rate(Sa/s) ";
            // 
            // label_Channel
            // 
            this.label_Channel.AutoSize = true;
            this.label_Channel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Channel.Location = new System.Drawing.Point(8, 104);
            this.label_Channel.Name = "label_Channel";
            this.label_Channel.Size = new System.Drawing.Size(98, 14);
            this.label_Channel.TabIndex = 2;
            this.label_Channel.Text = "Channel Count";
            // 
            // numericUpDown_sampleRate
            // 
            this.numericUpDown_sampleRate.Location = new System.Drawing.Point(154, 162);
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
            this.numericUpDown_sampleRate.Size = new System.Drawing.Size(115, 23);
            this.numericUpDown_sampleRate.TabIndex = 5;
            this.numericUpDown_sampleRate.Tag = "ParaConfig";
            this.numericUpDown_sampleRate.ThousandsSeparator = true;
            this.numericUpDown_sampleRate.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // button_sendSoftTrigger
            // 
            this.button_sendSoftTrigger.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_sendSoftTrigger.Location = new System.Drawing.Point(81, 15);
            this.button_sendSoftTrigger.Name = "button_sendSoftTrigger";
            this.button_sendSoftTrigger.Size = new System.Drawing.Size(134, 30);
            this.button_sendSoftTrigger.TabIndex = 98;
            this.button_sendSoftTrigger.Text = "Send Soft Trigger";
            this.button_sendSoftTrigger.UseVisualStyleBackColor = true;
            this.button_sendSoftTrigger.Click += new System.EventHandler(this.button_sendSoftTrigger_Click);
            // 
            // button_stop
            // 
            this.button_stop.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_stop.Location = new System.Drawing.Point(221, 15);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(66, 30);
            this.button_stop.TabIndex = 78;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_start.Location = new System.Drawing.Point(9, 15);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(66, 30);
            this.button_start.TabIndex = 77;
            this.button_start.Tag = "ParaConfig";
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.easyChartX_readData);
            this.panel1.Location = new System.Drawing.Point(12, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 373);
            this.panel1.TabIndex = 90;
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
            this.easyChartX_readData.Miscellaneous.MarkerSize = 7;
            this.easyChartX_readData.Miscellaneous.MaxSeriesCount = 32;
            this.easyChartX_readData.Miscellaneous.MaxSeriesPointCount = 4000;
            this.easyChartX_readData.Miscellaneous.ShowFunctionMenu = true;
            this.easyChartX_readData.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.easyChartX_readData.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.EasyChartXUtility.LayoutDirection.LeftToRight;
            this.easyChartX_readData.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.easyChartX_readData.Miscellaneous.SplitViewAutoLayout = true;
            this.easyChartX_readData.Name = "easyChartX_readData";
            this.easyChartX_readData.SeriesCount = 1;
            this.easyChartX_readData.Size = new System.Drawing.Size(803, 369);
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
            // timer_FetchData
            // 
            this.timer_FetchData.Interval = 10;
            this.timer_FetchData.Tick += new System.EventHandler(this.timer_FetchData_Tick);
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
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 29);
            this.label1.TabIndex = 88;
            this.label1.Text = "PCIe/PXIe 5500 Series Multichannel Continuous";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1118, 80);
            this.splitter1.TabIndex = 87;
            this.splitter1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1118, 22);
            this.statusStrip1.TabIndex = 89;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.button_stop);
            this.panel3.Controls.Add(this.button_sendSoftTrigger);
            this.panel3.Controls.Add(this.button_start);
            this.panel3.Location = new System.Drawing.Point(821, 403);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 60);
            this.panel3.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoEllipsis = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label6.Font = new System.Drawing.Font("宋体", 23F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(242, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(556, 31);
            this.label6.TabIndex = 94;
            this.label6.Text = " Data Acquisition（Soft Trigger)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 488);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCIe/PXIe 5500 Series Multichannel Continuous Mode Data Acquisition（Soft Trigger)" +
    "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox_genParam.ResumeLayout(false);
            this.groupBox_genParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_samples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox_genParam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_samples;
        private System.Windows.Forms.ComboBox comboBox_terminalType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_channelNumber;
        private System.Windows.Forms.ComboBox comboBox_SoltNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_SampleRate;
        private System.Windows.Forms.Label label_Channel;
        private System.Windows.Forms.NumericUpDown numericUpDown_sampleRate;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Panel panel1;
        private SeeSharpTools.JY.GUI.EasyChartX easyChartX_readData;
        private System.Windows.Forms.Timer timer_FetchData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button button_sendSoftTrigger;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_cardID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_inputRange;
        private System.Windows.Forms.Label label12;
    }
}

