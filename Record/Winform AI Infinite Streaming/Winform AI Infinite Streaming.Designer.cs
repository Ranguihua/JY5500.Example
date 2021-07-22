namespace Winform_AI_Infinite_Streaming
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
            this.timer_FetchData = new System.Windows.Forms.Timer(this.components);
            this.button_start = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button_stop = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox_param = new System.Windows.Forms.GroupBox();
            this.comboBox_inputRange = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_CardId = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_terminalType = new System.Windows.Forms.ComboBox();
            this.comboBox_channelcount = new System.Windows.Forms.ComboBox();
            this.numericUpDown_PreviewSamplesPerChannels = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button_savepath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_channelID = new System.Windows.Forms.Label();
            this.numericUpDown_samplerate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_boardID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.easyChartX_readrecordData = new SeeSharpTools.JY.GUI.EasyChartX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.groupBox_param.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PreviewSamplesPerChannels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_samplerate)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_FetchData
            // 
            this.timer_FetchData.Interval = 10;
            this.timer_FetchData.Tick += new System.EventHandler(this.timer_FetchData_Tick);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_start.Location = new System.Drawing.Point(46, 22);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(109, 42);
            this.button_start.TabIndex = 94;
            this.button_start.Text = "start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoEllipsis = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label11.Font = new System.Drawing.Font("宋体", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(233, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(694, 31);
            this.label11.TabIndex = 92;
            this.label11.Text = "PCIe/PXIe 5500 Series Infinite Streaming";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1158, 80);
            this.splitter1.TabIndex = 91;
            this.splitter1.TabStop = false;
            // 
            // button_stop
            // 
            this.button_stop.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_stop.Location = new System.Drawing.Point(182, 22);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(103, 42);
            this.button_stop.TabIndex = 95;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1158, 22);
            this.statusStrip1.TabIndex = 96;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox_param
            // 
            this.groupBox_param.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_param.Controls.Add(this.comboBox_inputRange);
            this.groupBox_param.Controls.Add(this.label7);
            this.groupBox_param.Controls.Add(this.comboBox_CardId);
            this.groupBox_param.Controls.Add(this.label8);
            this.groupBox_param.Controls.Add(this.textBox_path);
            this.groupBox_param.Controls.Add(this.label6);
            this.groupBox_param.Controls.Add(this.comboBox_terminalType);
            this.groupBox_param.Controls.Add(this.comboBox_channelcount);
            this.groupBox_param.Controls.Add(this.numericUpDown_PreviewSamplesPerChannels);
            this.groupBox_param.Controls.Add(this.label5);
            this.groupBox_param.Controls.Add(this.button_savepath);
            this.groupBox_param.Controls.Add(this.label3);
            this.groupBox_param.Controls.Add(this.label_channelID);
            this.groupBox_param.Controls.Add(this.numericUpDown_samplerate);
            this.groupBox_param.Controls.Add(this.label2);
            this.groupBox_param.Controls.Add(this.comboBox_boardID);
            this.groupBox_param.Controls.Add(this.label1);
            this.groupBox_param.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_param.Location = new System.Drawing.Point(13, 3);
            this.groupBox_param.Name = "groupBox_param";
            this.groupBox_param.Size = new System.Drawing.Size(307, 365);
            this.groupBox_param.TabIndex = 97;
            this.groupBox_param.TabStop = false;
            this.groupBox_param.Text = "Basic Param Configuration";
            // 
            // comboBox_inputRange
            // 
            this.comboBox_inputRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_inputRange.FormattingEnabled = true;
            this.comboBox_inputRange.Items.AddRange(new object[] {
            "±10V",
            "±5 V",
            "±2V",
            "±1V",
            "±0.5V",
            "±0.2V",
            "±0.1V"});
            this.comboBox_inputRange.Location = new System.Drawing.Point(153, 173);
            this.comboBox_inputRange.Name = "comboBox_inputRange";
            this.comboBox_inputRange.Size = new System.Drawing.Size(120, 22);
            this.comboBox_inputRange.TabIndex = 103;
            this.comboBox_inputRange.SelectedIndexChanged += new System.EventHandler(this.comboBox_inputRange_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(6, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 14);
            this.label7.TabIndex = 102;
            this.label7.Text = "Input Range";
            // 
            // comboBox_CardId
            // 
            this.comboBox_CardId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CardId.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_CardId.FormattingEnabled = true;
            this.comboBox_CardId.Items.AddRange(new object[] {
            "5510",
            "5511",
            "5515",
            "5516"});
            this.comboBox_CardId.Location = new System.Drawing.Point(153, 41);
            this.comboBox_CardId.Name = "comboBox_CardId";
            this.comboBox_CardId.Size = new System.Drawing.Size(120, 22);
            this.comboBox_CardId.TabIndex = 101;
            this.comboBox_CardId.SelectedIndexChanged += new System.EventHandler(this.comboBox_CardId_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(6, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 14);
            this.label8.TabIndex = 100;
            this.label8.Text = "Card ID";
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(153, 274);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(120, 23);
            this.textBox_path.TabIndex = 96;
            this.textBox_path.Text = "D:\\";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 14);
            this.label6.TabIndex = 90;
            this.label6.Text = "AI Terminal";
            // 
            // comboBox_terminalType
            // 
            this.comboBox_terminalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_terminalType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_terminalType.FormattingEnabled = true;
            this.comboBox_terminalType.Location = new System.Drawing.Point(153, 140);
            this.comboBox_terminalType.Name = "comboBox_terminalType";
            this.comboBox_terminalType.Size = new System.Drawing.Size(120, 22);
            this.comboBox_terminalType.TabIndex = 91;
            this.comboBox_terminalType.Tag = "ParaConfig";
            // 
            // comboBox_channelcount
            // 
            this.comboBox_channelcount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_channelcount.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_channelcount.FormattingEnabled = true;
            this.comboBox_channelcount.Location = new System.Drawing.Point(153, 107);
            this.comboBox_channelcount.Name = "comboBox_channelcount";
            this.comboBox_channelcount.Size = new System.Drawing.Size(120, 22);
            this.comboBox_channelcount.TabIndex = 68;
            this.comboBox_channelcount.Tag = "ParaConfig";
            // 
            // numericUpDown_PreviewSamplesPerChannels
            // 
            this.numericUpDown_PreviewSamplesPerChannels.Location = new System.Drawing.Point(153, 240);
            this.numericUpDown_PreviewSamplesPerChannels.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numericUpDown_PreviewSamplesPerChannels.Name = "numericUpDown_PreviewSamplesPerChannels";
            this.numericUpDown_PreviewSamplesPerChannels.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_PreviewSamplesPerChannels.TabIndex = 14;
            this.numericUpDown_PreviewSamplesPerChannels.ThousandsSeparator = true;
            this.numericUpDown_PreviewSamplesPerChannels.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Record Preview Data";
            // 
            // button_savepath
            // 
            this.button_savepath.Location = new System.Drawing.Point(229, 318);
            this.button_savepath.Name = "button_savepath";
            this.button_savepath.Size = new System.Drawing.Size(44, 23);
            this.button_savepath.TabIndex = 9;
            this.button_savepath.Text = "...";
            this.button_savepath.UseVisualStyleBackColor = true;
            this.button_savepath.Click += new System.EventHandler(this.button_savepath_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "File Path";
            // 
            // label_channelID
            // 
            this.label_channelID.AutoSize = true;
            this.label_channelID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_channelID.Location = new System.Drawing.Point(6, 110);
            this.label_channelID.Name = "label_channelID";
            this.label_channelID.Size = new System.Drawing.Size(98, 14);
            this.label_channelID.TabIndex = 5;
            this.label_channelID.Text = "Channel Count";
            // 
            // numericUpDown_samplerate
            // 
            this.numericUpDown_samplerate.Location = new System.Drawing.Point(153, 206);
            this.numericUpDown_samplerate.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numericUpDown_samplerate.Name = "numericUpDown_samplerate";
            this.numericUpDown_samplerate.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_samplerate.TabIndex = 4;
            this.numericUpDown_samplerate.ThousandsSeparator = true;
            this.numericUpDown_samplerate.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sample Rate";
            // 
            // comboBox_boardID
            // 
            this.comboBox_boardID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_boardID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_boardID.FormattingEnabled = true;
            this.comboBox_boardID.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox_boardID.Location = new System.Drawing.Point(153, 74);
            this.comboBox_boardID.Name = "comboBox_boardID";
            this.comboBox_boardID.Size = new System.Drawing.Size(120, 22);
            this.comboBox_boardID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Slot Number";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox_param);
            this.panel1.Location = new System.Drawing.Point(838, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 368);
            this.panel1.TabIndex = 98;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.easyChartX_readrecordData);
            this.panel2.Location = new System.Drawing.Point(12, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 454);
            this.panel2.TabIndex = 99;
            // 
            // easyChartX_readrecordData
            // 
            this.easyChartX_readrecordData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.easyChartX_readrecordData.AutoClear = true;
            this.easyChartX_readrecordData.AxisX.AutoScale = true;
            this.easyChartX_readrecordData.AxisX.AutoZoomReset = false;
            this.easyChartX_readrecordData.AxisX.Color = System.Drawing.Color.Black;
            this.easyChartX_readrecordData.AxisX.InitWithScaleView = false;
            this.easyChartX_readrecordData.AxisX.IsLogarithmic = false;
            this.easyChartX_readrecordData.AxisX.LabelAngle = 0;
            this.easyChartX_readrecordData.AxisX.LabelEnabled = true;
            this.easyChartX_readrecordData.AxisX.LabelFormat = null;
            this.easyChartX_readrecordData.AxisX.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_readrecordData.AxisX.MajorGridCount = -1;
            this.easyChartX_readrecordData.AxisX.MajorGridEnabled = true;
            this.easyChartX_readrecordData.AxisX.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_readrecordData.AxisX.Maximum = 1000D;
            this.easyChartX_readrecordData.AxisX.Minimum = 0D;
            this.easyChartX_readrecordData.AxisX.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_readrecordData.AxisX.MinorGridEnabled = false;
            this.easyChartX_readrecordData.AxisX.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_readrecordData.AxisX.TickWidth = 1F;
            this.easyChartX_readrecordData.AxisX.Title = "";
            this.easyChartX_readrecordData.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_readrecordData.AxisX.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_readrecordData.AxisX.ViewMaximum = 1000D;
            this.easyChartX_readrecordData.AxisX.ViewMinimum = 0D;
            this.easyChartX_readrecordData.AxisX2.AutoScale = true;
            this.easyChartX_readrecordData.AxisX2.AutoZoomReset = false;
            this.easyChartX_readrecordData.AxisX2.Color = System.Drawing.Color.Black;
            this.easyChartX_readrecordData.AxisX2.InitWithScaleView = false;
            this.easyChartX_readrecordData.AxisX2.IsLogarithmic = false;
            this.easyChartX_readrecordData.AxisX2.LabelAngle = 0;
            this.easyChartX_readrecordData.AxisX2.LabelEnabled = true;
            this.easyChartX_readrecordData.AxisX2.LabelFormat = null;
            this.easyChartX_readrecordData.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_readrecordData.AxisX2.MajorGridCount = -1;
            this.easyChartX_readrecordData.AxisX2.MajorGridEnabled = true;
            this.easyChartX_readrecordData.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_readrecordData.AxisX2.Maximum = 1000D;
            this.easyChartX_readrecordData.AxisX2.Minimum = 0D;
            this.easyChartX_readrecordData.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_readrecordData.AxisX2.MinorGridEnabled = false;
            this.easyChartX_readrecordData.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_readrecordData.AxisX2.TickWidth = 1F;
            this.easyChartX_readrecordData.AxisX2.Title = "";
            this.easyChartX_readrecordData.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_readrecordData.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_readrecordData.AxisX2.ViewMaximum = 1000D;
            this.easyChartX_readrecordData.AxisX2.ViewMinimum = 0D;
            this.easyChartX_readrecordData.AxisY.AutoScale = true;
            this.easyChartX_readrecordData.AxisY.AutoZoomReset = false;
            this.easyChartX_readrecordData.AxisY.Color = System.Drawing.Color.Black;
            this.easyChartX_readrecordData.AxisY.InitWithScaleView = false;
            this.easyChartX_readrecordData.AxisY.IsLogarithmic = false;
            this.easyChartX_readrecordData.AxisY.LabelAngle = 0;
            this.easyChartX_readrecordData.AxisY.LabelEnabled = true;
            this.easyChartX_readrecordData.AxisY.LabelFormat = null;
            this.easyChartX_readrecordData.AxisY.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_readrecordData.AxisY.MajorGridCount = 6;
            this.easyChartX_readrecordData.AxisY.MajorGridEnabled = true;
            this.easyChartX_readrecordData.AxisY.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_readrecordData.AxisY.Maximum = 3.5D;
            this.easyChartX_readrecordData.AxisY.Minimum = 0.5D;
            this.easyChartX_readrecordData.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_readrecordData.AxisY.MinorGridEnabled = false;
            this.easyChartX_readrecordData.AxisY.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_readrecordData.AxisY.TickWidth = 1F;
            this.easyChartX_readrecordData.AxisY.Title = "";
            this.easyChartX_readrecordData.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_readrecordData.AxisY.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_readrecordData.AxisY.ViewMaximum = 3.5D;
            this.easyChartX_readrecordData.AxisY.ViewMinimum = 0.5D;
            this.easyChartX_readrecordData.AxisY2.AutoScale = true;
            this.easyChartX_readrecordData.AxisY2.AutoZoomReset = false;
            this.easyChartX_readrecordData.AxisY2.Color = System.Drawing.Color.Black;
            this.easyChartX_readrecordData.AxisY2.InitWithScaleView = false;
            this.easyChartX_readrecordData.AxisY2.IsLogarithmic = false;
            this.easyChartX_readrecordData.AxisY2.LabelAngle = 0;
            this.easyChartX_readrecordData.AxisY2.LabelEnabled = true;
            this.easyChartX_readrecordData.AxisY2.LabelFormat = null;
            this.easyChartX_readrecordData.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_readrecordData.AxisY2.MajorGridCount = 6;
            this.easyChartX_readrecordData.AxisY2.MajorGridEnabled = true;
            this.easyChartX_readrecordData.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_readrecordData.AxisY2.Maximum = 3.5D;
            this.easyChartX_readrecordData.AxisY2.Minimum = 0.5D;
            this.easyChartX_readrecordData.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_readrecordData.AxisY2.MinorGridEnabled = false;
            this.easyChartX_readrecordData.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_readrecordData.AxisY2.TickWidth = 1F;
            this.easyChartX_readrecordData.AxisY2.Title = "";
            this.easyChartX_readrecordData.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_readrecordData.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_readrecordData.AxisY2.ViewMaximum = 3.5D;
            this.easyChartX_readrecordData.AxisY2.ViewMinimum = 0.5D;
            this.easyChartX_readrecordData.BackColor = System.Drawing.Color.White;
            this.easyChartX_readrecordData.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChartX_readrecordData.Cumulitive = false;
            this.easyChartX_readrecordData.GradientStyle = SeeSharpTools.JY.GUI.EasyChartX.ChartGradientStyle.None;
            this.easyChartX_readrecordData.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartX_readrecordData.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.easyChartX_readrecordData.LegendForeColor = System.Drawing.Color.Black;
            this.easyChartX_readrecordData.LegendVisible = true;
            easyChartXSeries1.Color = System.Drawing.Color.Red;
            easyChartXSeries1.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries1.Name = "Series1";
            easyChartXSeries1.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries1.Visible = true;
            easyChartXSeries1.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries1.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries1.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            this.easyChartX_readrecordData.LineSeries.Add(easyChartXSeries1);
            this.easyChartX_readrecordData.Location = new System.Drawing.Point(0, 0);
            this.easyChartX_readrecordData.Margin = new System.Windows.Forms.Padding(4);
            this.easyChartX_readrecordData.Miscellaneous.CheckInfinity = false;
            this.easyChartX_readrecordData.Miscellaneous.CheckNaN = false;
            this.easyChartX_readrecordData.Miscellaneous.CheckNegtiveOrZero = false;
            this.easyChartX_readrecordData.Miscellaneous.DirectionChartCount = 3;
            this.easyChartX_readrecordData.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.EasyChartX.FitType.Range;
            this.easyChartX_readrecordData.Miscellaneous.MarkerSize = 5;
            this.easyChartX_readrecordData.Miscellaneous.MaxSeriesCount = 32;
            this.easyChartX_readrecordData.Miscellaneous.MaxSeriesPointCount = 4000;
            this.easyChartX_readrecordData.Miscellaneous.ShowFunctionMenu = true;
            this.easyChartX_readrecordData.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.easyChartX_readrecordData.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.EasyChartXUtility.LayoutDirection.LeftToRight;
            this.easyChartX_readrecordData.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.easyChartX_readrecordData.Miscellaneous.SplitViewAutoLayout = true;
            this.easyChartX_readrecordData.Name = "easyChartX_readrecordData";
            this.easyChartX_readrecordData.SeriesCount = 1;
            this.easyChartX_readrecordData.Size = new System.Drawing.Size(820, 450);
            this.easyChartX_readrecordData.SplitView = false;
            this.easyChartX_readrecordData.TabIndex = 0;
            this.easyChartX_readrecordData.XCursor.AutoInterval = true;
            this.easyChartX_readrecordData.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChartX_readrecordData.XCursor.Interval = 0.001D;
            this.easyChartX_readrecordData.XCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Zoom;
            this.easyChartX_readrecordData.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX_readrecordData.XCursor.Value = double.NaN;
            this.easyChartX_readrecordData.YCursor.AutoInterval = true;
            this.easyChartX_readrecordData.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChartX_readrecordData.YCursor.Interval = 0.001D;
            this.easyChartX_readrecordData.YCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Disabled;
            this.easyChartX_readrecordData.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX_readrecordData.YCursor.Value = double.NaN;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.button_start);
            this.panel3.Controls.Add(this.button_stop);
            this.panel3.Location = new System.Drawing.Point(839, 460);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 80);
            this.panel3.TabIndex = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 566);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCIe/PXIe 5500 Infinite Mode Record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox_param.ResumeLayout(false);
            this.groupBox_param.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PreviewSamplesPerChannels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_samplerate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_FetchData;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox_param;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_terminalType;
        private System.Windows.Forms.ComboBox comboBox_channelcount;
        private System.Windows.Forms.NumericUpDown numericUpDown_PreviewSamplesPerChannels;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_savepath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_channelID;
        private System.Windows.Forms.NumericUpDown numericUpDown_samplerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_boardID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private SeeSharpTools.JY.GUI.EasyChartX easyChartX_readrecordData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox_CardId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_inputRange;
        private System.Windows.Forms.Label label7;
    }
}

