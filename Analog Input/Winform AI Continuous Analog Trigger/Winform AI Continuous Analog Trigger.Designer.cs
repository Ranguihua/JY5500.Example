namespace Winform_AI_Continuous_Analog_Trigger
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
            this.button_start = new System.Windows.Forms.Button();
            this.timer_FetchData = new System.Windows.Forms.Timer(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_stop = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.easyChartX_readData = new SeeSharpTools.JY.GUI.EasyChartX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox_TrigParam = new System.Windows.Forms.GroupBox();
            this.label_windowTriggerCondition = new System.Windows.Forms.Label();
            this.label_triggerEdge = new System.Windows.Forms.Label();
            this.comboBox_windowTriggerCondition = new System.Windows.Forms.ComboBox();
            this.comboBox_analogTriggerEdge = new System.Windows.Forms.ComboBox();
            this.numericUpDown_LowThreshold = new System.Windows.Forms.NumericUpDown();
            this.label_LowThreshold = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_analogTriggerComparator = new System.Windows.Forms.ComboBox();
            this.label_HighThreshold = new System.Windows.Forms.Label();
            this.numericUpDown_highthreshold = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_TriggerSource = new System.Windows.Forms.ComboBox();
            this.groupBox_ParamConfig = new System.Windows.Forms.GroupBox();
            this.comboBox_inputRange = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_CardID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox_TrigParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LowThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_highthreshold)).BeginInit();
            this.groupBox_ParamConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_samples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_start.Location = new System.Drawing.Point(56, 18);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(66, 30);
            this.button_start.TabIndex = 78;
            this.button_start.Tag = "ParaConfig";
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer_FetchData
            // 
            this.timer_FetchData.Interval = 10;
            this.timer_FetchData.Tick += new System.EventHandler(this.timer_FetchData_Tick);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1138, 80);
            this.splitter1.TabIndex = 83;
            this.splitter1.TabStop = false;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 613);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1138, 22);
            this.statusStrip.TabIndex = 82;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("宋体", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(791, 31);
            this.label1.TabIndex = 84;
            this.label1.Text = "JYUSB61902Single Channel 有限点采集（模拟触发）";
            // 
            // button_stop
            // 
            this.button_stop.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_stop.Location = new System.Drawing.Point(149, 19);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(66, 30);
            this.button_stop.TabIndex = 79;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoEllipsis = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label11.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(132, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(825, 29);
            this.label11.TabIndex = 85;
            this.label11.Text = "PCIe/PXIe 5500 Series Single Channel Continuous";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.easyChartX_readData);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 520);
            this.panel1.TabIndex = 88;
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
            this.easyChartX_readData.Location = new System.Drawing.Point(4, 4);
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
            this.easyChartX_readData.Size = new System.Drawing.Size(819, 512);
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox_TrigParam);
            this.panel2.Controls.Add(this.groupBox_ParamConfig);
            this.panel2.Location = new System.Drawing.Point(842, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 475);
            this.panel2.TabIndex = 1;
            // 
            // groupBox_TrigParam
            // 
            this.groupBox_TrigParam.Controls.Add(this.label_windowTriggerCondition);
            this.groupBox_TrigParam.Controls.Add(this.label_triggerEdge);
            this.groupBox_TrigParam.Controls.Add(this.comboBox_windowTriggerCondition);
            this.groupBox_TrigParam.Controls.Add(this.comboBox_analogTriggerEdge);
            this.groupBox_TrigParam.Controls.Add(this.numericUpDown_LowThreshold);
            this.groupBox_TrigParam.Controls.Add(this.label_LowThreshold);
            this.groupBox_TrigParam.Controls.Add(this.label4);
            this.groupBox_TrigParam.Controls.Add(this.comboBox_analogTriggerComparator);
            this.groupBox_TrigParam.Controls.Add(this.label_HighThreshold);
            this.groupBox_TrigParam.Controls.Add(this.numericUpDown_highthreshold);
            this.groupBox_TrigParam.Controls.Add(this.label3);
            this.groupBox_TrigParam.Controls.Add(this.comboBox_TriggerSource);
            this.groupBox_TrigParam.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_TrigParam.Location = new System.Drawing.Point(4, 242);
            this.groupBox_TrigParam.Name = "groupBox_TrigParam";
            this.groupBox_TrigParam.Size = new System.Drawing.Size(287, 208);
            this.groupBox_TrigParam.TabIndex = 82;
            this.groupBox_TrigParam.TabStop = false;
            this.groupBox_TrigParam.Text = "Trigger Param Configuration";
            // 
            // label_windowTriggerCondition
            // 
            this.label_windowTriggerCondition.AutoSize = true;
            this.label_windowTriggerCondition.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_windowTriggerCondition.Location = new System.Drawing.Point(3, 116);
            this.label_windowTriggerCondition.Name = "label_windowTriggerCondition";
            this.label_windowTriggerCondition.Size = new System.Drawing.Size(126, 14);
            this.label_windowTriggerCondition.TabIndex = 105;
            this.label_windowTriggerCondition.Text = "Trigger Condition";
            // 
            // label_triggerEdge
            // 
            this.label_triggerEdge.AutoSize = true;
            this.label_triggerEdge.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_triggerEdge.Location = new System.Drawing.Point(3, 85);
            this.label_triggerEdge.Name = "label_triggerEdge";
            this.label_triggerEdge.Size = new System.Drawing.Size(91, 14);
            this.label_triggerEdge.TabIndex = 103;
            this.label_triggerEdge.Text = "Trigger Edge";
            // 
            // comboBox_windowTriggerCondition
            // 
            this.comboBox_windowTriggerCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_windowTriggerCondition.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_windowTriggerCondition.FormattingEnabled = true;
            this.comboBox_windowTriggerCondition.Location = new System.Drawing.Point(148, 109);
            this.comboBox_windowTriggerCondition.Name = "comboBox_windowTriggerCondition";
            this.comboBox_windowTriggerCondition.Size = new System.Drawing.Size(133, 20);
            this.comboBox_windowTriggerCondition.TabIndex = 104;
            this.comboBox_windowTriggerCondition.Tag = "ParaConfig";
            // 
            // comboBox_analogTriggerEdge
            // 
            this.comboBox_analogTriggerEdge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_analogTriggerEdge.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_analogTriggerEdge.FormattingEnabled = true;
            this.comboBox_analogTriggerEdge.Location = new System.Drawing.Point(148, 81);
            this.comboBox_analogTriggerEdge.Name = "comboBox_analogTriggerEdge";
            this.comboBox_analogTriggerEdge.Size = new System.Drawing.Size(133, 20);
            this.comboBox_analogTriggerEdge.TabIndex = 99;
            this.comboBox_analogTriggerEdge.Tag = "ParaConfig";
            // 
            // numericUpDown_LowThreshold
            // 
            this.numericUpDown_LowThreshold.DecimalPlaces = 1;
            this.numericUpDown_LowThreshold.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_LowThreshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_LowThreshold.Location = new System.Drawing.Point(148, 168);
            this.numericUpDown_LowThreshold.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_LowThreshold.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown_LowThreshold.Name = "numericUpDown_LowThreshold";
            this.numericUpDown_LowThreshold.Size = new System.Drawing.Size(133, 23);
            this.numericUpDown_LowThreshold.TabIndex = 102;
            this.numericUpDown_LowThreshold.Tag = "ParaConfig";
            // 
            // label_LowThreshold
            // 
            this.label_LowThreshold.AutoSize = true;
            this.label_LowThreshold.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_LowThreshold.Location = new System.Drawing.Point(3, 175);
            this.label_LowThreshold.Name = "label_LowThreshold";
            this.label_LowThreshold.Size = new System.Drawing.Size(133, 14);
            this.label_LowThreshold.TabIndex = 101;
            this.label_LowThreshold.Text = "Low Threshold（V）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 14);
            this.label4.TabIndex = 98;
            this.label4.Text = "Trigger Comparator";
            // 
            // comboBox_analogTriggerComparator
            // 
            this.comboBox_analogTriggerComparator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_analogTriggerComparator.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_analogTriggerComparator.FormattingEnabled = true;
            this.comboBox_analogTriggerComparator.Location = new System.Drawing.Point(148, 53);
            this.comboBox_analogTriggerComparator.Name = "comboBox_analogTriggerComparator";
            this.comboBox_analogTriggerComparator.Size = new System.Drawing.Size(133, 20);
            this.comboBox_analogTriggerComparator.TabIndex = 96;
            this.comboBox_analogTriggerComparator.Tag = "ParaConfig";
            this.comboBox_analogTriggerComparator.SelectedIndexChanged += new System.EventHandler(this.comboBox_analogTriggerComparator_SelectedIndexChanged);
            // 
            // label_HighThreshold
            // 
            this.label_HighThreshold.AutoSize = true;
            this.label_HighThreshold.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_HighThreshold.Location = new System.Drawing.Point(3, 147);
            this.label_HighThreshold.Name = "label_HighThreshold";
            this.label_HighThreshold.Size = new System.Drawing.Size(140, 14);
            this.label_HighThreshold.TabIndex = 100;
            this.label_HighThreshold.Text = "High Threshold（V）";
            // 
            // numericUpDown_highthreshold
            // 
            this.numericUpDown_highthreshold.DecimalPlaces = 1;
            this.numericUpDown_highthreshold.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_highthreshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_highthreshold.Location = new System.Drawing.Point(148, 137);
            this.numericUpDown_highthreshold.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_highthreshold.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown_highthreshold.Name = "numericUpDown_highthreshold";
            this.numericUpDown_highthreshold.Size = new System.Drawing.Size(133, 23);
            this.numericUpDown_highthreshold.TabIndex = 97;
            this.numericUpDown_highthreshold.Tag = "ParaConfig";
            this.numericUpDown_highthreshold.Value = new decimal(new int[] {
            30,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 55;
            this.label3.Text = "Trigger Source";
            // 
            // comboBox_TriggerSource
            // 
            this.comboBox_TriggerSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TriggerSource.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_TriggerSource.FormattingEnabled = true;
            this.comboBox_TriggerSource.Location = new System.Drawing.Point(148, 25);
            this.comboBox_TriggerSource.Name = "comboBox_TriggerSource";
            this.comboBox_TriggerSource.Size = new System.Drawing.Size(133, 20);
            this.comboBox_TriggerSource.TabIndex = 9;
            this.comboBox_TriggerSource.Tag = "ParaConfig";
            // 
            // groupBox_ParamConfig
            // 
            this.groupBox_ParamConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_ParamConfig.Controls.Add(this.comboBox_inputRange);
            this.groupBox_ParamConfig.Controls.Add(this.label12);
            this.groupBox_ParamConfig.Controls.Add(this.comboBox_CardID);
            this.groupBox_ParamConfig.Controls.Add(this.label6);
            this.groupBox_ParamConfig.Controls.Add(this.comboBox_terminalType);
            this.groupBox_ParamConfig.Controls.Add(this.comboBox_channelNumber);
            this.groupBox_ParamConfig.Controls.Add(this.comboBox_SoltNumber);
            this.groupBox_ParamConfig.Controls.Add(this.label7);
            this.groupBox_ParamConfig.Controls.Add(this.numericUpDown_samples);
            this.groupBox_ParamConfig.Controls.Add(this.label5);
            this.groupBox_ParamConfig.Controls.Add(this.label_SampleRate);
            this.groupBox_ParamConfig.Controls.Add(this.label8);
            this.groupBox_ParamConfig.Controls.Add(this.label_Channel);
            this.groupBox_ParamConfig.Controls.Add(this.numericUpDown_sampleRate);
            this.groupBox_ParamConfig.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_ParamConfig.Location = new System.Drawing.Point(9, 3);
            this.groupBox_ParamConfig.Name = "groupBox_ParamConfig";
            this.groupBox_ParamConfig.Size = new System.Drawing.Size(284, 233);
            this.groupBox_ParamConfig.TabIndex = 89;
            this.groupBox_ParamConfig.TabStop = false;
            this.groupBox_ParamConfig.Text = "Basic Param Configuration";
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
            this.comboBox_inputRange.Location = new System.Drawing.Point(140, 204);
            this.comboBox_inputRange.Name = "comboBox_inputRange";
            this.comboBox_inputRange.Size = new System.Drawing.Size(134, 22);
            this.comboBox_inputRange.TabIndex = 92;
            this.comboBox_inputRange.SelectedIndexChanged += new System.EventHandler(this.comboBox_inputRange_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(6, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 14);
            this.label12.TabIndex = 91;
            this.label12.Text = "Input Range";
            // 
            // comboBox_CardID
            // 
            this.comboBox_CardID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CardID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_CardID.FormattingEnabled = true;
            this.comboBox_CardID.Items.AddRange(new object[] {
            "5510",
            "5511",
            "5515",
            "5516"});
            this.comboBox_CardID.Location = new System.Drawing.Point(140, 36);
            this.comboBox_CardID.Name = "comboBox_CardID";
            this.comboBox_CardID.Size = new System.Drawing.Size(134, 20);
            this.comboBox_CardID.TabIndex = 89;
            this.comboBox_CardID.Tag = "ParaConfig";
            this.comboBox_CardID.SelectedIndexChanged += new System.EventHandler(this.comboBox_CardID_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(6, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 14);
            this.label6.TabIndex = 90;
            this.label6.Text = "Card ID";
            // 
            // comboBox_terminalType
            // 
            this.comboBox_terminalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_terminalType.Font = new System.Drawing.Font("宋体", 9F);
            this.comboBox_terminalType.FormattingEnabled = true;
            this.comboBox_terminalType.Location = new System.Drawing.Point(140, 117);
            this.comboBox_terminalType.Name = "comboBox_terminalType";
            this.comboBox_terminalType.Size = new System.Drawing.Size(134, 20);
            this.comboBox_terminalType.TabIndex = 3;
            this.comboBox_terminalType.Tag = "ParaConfig";
            // 
            // comboBox_channelNumber
            // 
            this.comboBox_channelNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_channelNumber.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_channelNumber.FormattingEnabled = true;
            this.comboBox_channelNumber.Location = new System.Drawing.Point(140, 90);
            this.comboBox_channelNumber.Name = "comboBox_channelNumber";
            this.comboBox_channelNumber.Size = new System.Drawing.Size(134, 20);
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
            this.comboBox_SoltNumber.Location = new System.Drawing.Point(140, 63);
            this.comboBox_SoltNumber.Name = "comboBox_SoltNumber";
            this.comboBox_SoltNumber.Size = new System.Drawing.Size(134, 20);
            this.comboBox_SoltNumber.TabIndex = 1;
            this.comboBox_SoltNumber.Tag = "ParaConfig";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(6, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 14);
            this.label7.TabIndex = 64;
            this.label7.Text = "Slot number";
            // 
            // numericUpDown_samples
            // 
            this.numericUpDown_samples.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_samples.Location = new System.Drawing.Point(141, 174);
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
            this.numericUpDown_samples.Size = new System.Drawing.Size(134, 23);
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
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(6, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Samples to Acquire";
            // 
            // label_SampleRate
            // 
            this.label_SampleRate.AutoSize = true;
            this.label_SampleRate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SampleRate.Location = new System.Drawing.Point(6, 152);
            this.label_SampleRate.Name = "label_SampleRate";
            this.label_SampleRate.Size = new System.Drawing.Size(126, 14);
            this.label_SampleRate.TabIndex = 1;
            this.label_SampleRate.Text = "Sample Rate(Sa/s)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(6, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 14);
            this.label8.TabIndex = 2;
            this.label8.Text = "AI Terminal";
            // 
            // label_Channel
            // 
            this.label_Channel.AutoSize = true;
            this.label_Channel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Channel.Location = new System.Drawing.Point(6, 94);
            this.label_Channel.Name = "label_Channel";
            this.label_Channel.Size = new System.Drawing.Size(77, 14);
            this.label_Channel.TabIndex = 2;
            this.label_Channel.Text = "Channel ID";
            // 
            // numericUpDown_sampleRate
            // 
            this.numericUpDown_sampleRate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_sampleRate.Location = new System.Drawing.Point(141, 144);
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
            this.numericUpDown_sampleRate.Size = new System.Drawing.Size(134, 23);
            this.numericUpDown_sampleRate.TabIndex = 5;
            this.numericUpDown_sampleRate.Tag = "ParaConfig";
            this.numericUpDown_sampleRate.ThousandsSeparator = true;
            this.numericUpDown_sampleRate.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.button_start);
            this.panel4.Controls.Add(this.button_stop);
            this.panel4.Location = new System.Drawing.Point(842, 542);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 65);
            this.panel4.TabIndex = 90;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoEllipsis = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label10.Font = new System.Drawing.Font("宋体", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(196, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(665, 31);
            this.label10.TabIndex = 91;
            this.label10.Text = " Data Acquisition（Analog Trigger）";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 635);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCIe/PXIe 5500 Series Single Channel Continuous Mode  Data Acquisition（Analog Tri" +
    "gger）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox_TrigParam.ResumeLayout(false);
            this.groupBox_TrigParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LowThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_highthreshold)).EndInit();
            this.groupBox_ParamConfig.ResumeLayout(false);
            this.groupBox_ParamConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_samples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer_FetchData;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private SeeSharpTools.JY.GUI.EasyChartX easyChartX_readData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox_ParamConfig;
        private System.Windows.Forms.ComboBox comboBox_CardID;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_TriggerSource;
        private System.Windows.Forms.ComboBox comboBox_inputRange;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_windowTriggerCondition;
        private System.Windows.Forms.Label label_triggerEdge;
        private System.Windows.Forms.ComboBox comboBox_windowTriggerCondition;
        private System.Windows.Forms.ComboBox comboBox_analogTriggerEdge;
        private System.Windows.Forms.NumericUpDown numericUpDown_LowThreshold;
        private System.Windows.Forms.Label label_LowThreshold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_analogTriggerComparator;
        private System.Windows.Forms.Label label_HighThreshold;
        private System.Windows.Forms.NumericUpDown numericUpDown_highthreshold;
    }
}

