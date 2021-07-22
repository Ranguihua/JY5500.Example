namespace AI_AO_Sync
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
            this.easyChartX1 = new SeeSharpTools.JY.GUI.EasyChartX();
            this.easyButton_Start = new SeeSharpTools.JY.GUI.EasyButton();
            this.easyButton_Stop = new SeeSharpTools.JY.GUI.EasyButton();
            this.groupBox_SignalRouting = new System.Windows.Forms.GroupBox();
            this.comboBox_aodes = new System.Windows.Forms.ComboBox();
            this.comboBox_aides = new System.Windows.Forms.ComboBox();
            this.comboBox_aosignal = new System.Windows.Forms.ComboBox();
            this.comboBox_aisignal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Trigger_Clock = new System.Windows.Forms.GroupBox();
            this.comboBox_AOTrig = new System.Windows.Forms.ComboBox();
            this.comboBox_AOClock = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_AIParam = new System.Windows.Forms.GroupBox();
            this.comboBox_channelNumber = new System.Windows.Forms.ComboBox();
            this.numericUpDown_aisamplerate = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox_AOParam = new System.Windows.Forms.GroupBox();
            this.comboBox_aochannel = new System.Windows.Forms.ComboBox();
            this.numericUpDown_aosignalRate = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timer_FetchData = new System.Windows.Forms.Timer(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_SoltNumber = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox_cardID = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox_SignalRouting.SuspendLayout();
            this.groupBox_Trigger_Clock.SuspendLayout();
            this.groupBox_AIParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_aisamplerate)).BeginInit();
            this.groupBox_AOParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_aosignalRate)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // easyChartX1
            // 
            this.easyChartX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.easyChartX1.AutoClear = true;
            this.easyChartX1.AxisX.AutoScale = true;
            this.easyChartX1.AxisX.AutoZoomReset = false;
            this.easyChartX1.AxisX.Color = System.Drawing.Color.Black;
            this.easyChartX1.AxisX.InitWithScaleView = false;
            this.easyChartX1.AxisX.IsLogarithmic = false;
            this.easyChartX1.AxisX.LabelAngle = 0;
            this.easyChartX1.AxisX.LabelEnabled = true;
            this.easyChartX1.AxisX.LabelFormat = null;
            this.easyChartX1.AxisX.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisX.MajorGridCount = -1;
            this.easyChartX1.AxisX.MajorGridEnabled = true;
            this.easyChartX1.AxisX.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX1.AxisX.Maximum = 1000D;
            this.easyChartX1.AxisX.Minimum = 0D;
            this.easyChartX1.AxisX.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisX.MinorGridEnabled = false;
            this.easyChartX1.AxisX.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX1.AxisX.TickWidth = 1F;
            this.easyChartX1.AxisX.Title = "";
            this.easyChartX1.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX1.AxisX.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX1.AxisX.ViewMaximum = 1000D;
            this.easyChartX1.AxisX.ViewMinimum = 0D;
            this.easyChartX1.AxisX2.AutoScale = true;
            this.easyChartX1.AxisX2.AutoZoomReset = false;
            this.easyChartX1.AxisX2.Color = System.Drawing.Color.Black;
            this.easyChartX1.AxisX2.InitWithScaleView = false;
            this.easyChartX1.AxisX2.IsLogarithmic = false;
            this.easyChartX1.AxisX2.LabelAngle = 0;
            this.easyChartX1.AxisX2.LabelEnabled = true;
            this.easyChartX1.AxisX2.LabelFormat = null;
            this.easyChartX1.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisX2.MajorGridCount = -1;
            this.easyChartX1.AxisX2.MajorGridEnabled = true;
            this.easyChartX1.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX1.AxisX2.Maximum = 1000D;
            this.easyChartX1.AxisX2.Minimum = 0D;
            this.easyChartX1.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisX2.MinorGridEnabled = false;
            this.easyChartX1.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX1.AxisX2.TickWidth = 1F;
            this.easyChartX1.AxisX2.Title = "";
            this.easyChartX1.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX1.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX1.AxisX2.ViewMaximum = 1000D;
            this.easyChartX1.AxisX2.ViewMinimum = 0D;
            this.easyChartX1.AxisY.AutoScale = true;
            this.easyChartX1.AxisY.AutoZoomReset = false;
            this.easyChartX1.AxisY.Color = System.Drawing.Color.Black;
            this.easyChartX1.AxisY.InitWithScaleView = false;
            this.easyChartX1.AxisY.IsLogarithmic = false;
            this.easyChartX1.AxisY.LabelAngle = 0;
            this.easyChartX1.AxisY.LabelEnabled = true;
            this.easyChartX1.AxisY.LabelFormat = null;
            this.easyChartX1.AxisY.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisY.MajorGridCount = 6;
            this.easyChartX1.AxisY.MajorGridEnabled = true;
            this.easyChartX1.AxisY.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX1.AxisY.Maximum = 3.5D;
            this.easyChartX1.AxisY.Minimum = 0.5D;
            this.easyChartX1.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisY.MinorGridEnabled = false;
            this.easyChartX1.AxisY.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX1.AxisY.TickWidth = 1F;
            this.easyChartX1.AxisY.Title = "";
            this.easyChartX1.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX1.AxisY.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX1.AxisY.ViewMaximum = 3.5D;
            this.easyChartX1.AxisY.ViewMinimum = 0.5D;
            this.easyChartX1.AxisY2.AutoScale = true;
            this.easyChartX1.AxisY2.AutoZoomReset = false;
            this.easyChartX1.AxisY2.Color = System.Drawing.Color.Black;
            this.easyChartX1.AxisY2.InitWithScaleView = false;
            this.easyChartX1.AxisY2.IsLogarithmic = false;
            this.easyChartX1.AxisY2.LabelAngle = 0;
            this.easyChartX1.AxisY2.LabelEnabled = true;
            this.easyChartX1.AxisY2.LabelFormat = null;
            this.easyChartX1.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisY2.MajorGridCount = 6;
            this.easyChartX1.AxisY2.MajorGridEnabled = true;
            this.easyChartX1.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX1.AxisY2.Maximum = 3.5D;
            this.easyChartX1.AxisY2.Minimum = 0.5D;
            this.easyChartX1.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisY2.MinorGridEnabled = false;
            this.easyChartX1.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX1.AxisY2.TickWidth = 1F;
            this.easyChartX1.AxisY2.Title = "";
            this.easyChartX1.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX1.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX1.AxisY2.ViewMaximum = 3.5D;
            this.easyChartX1.AxisY2.ViewMinimum = 0.5D;
            this.easyChartX1.BackColor = System.Drawing.Color.White;
            this.easyChartX1.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChartX1.Cumulitive = false;
            this.easyChartX1.GradientStyle = SeeSharpTools.JY.GUI.EasyChartX.ChartGradientStyle.None;
            this.easyChartX1.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartX1.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.easyChartX1.LegendForeColor = System.Drawing.Color.Black;
            this.easyChartX1.LegendVisible = true;
            easyChartXSeries1.Color = System.Drawing.Color.Red;
            easyChartXSeries1.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries1.Name = "Series1";
            easyChartXSeries1.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries1.Visible = true;
            easyChartXSeries1.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries1.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries1.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            this.easyChartX1.LineSeries.Add(easyChartXSeries1);
            this.easyChartX1.Location = new System.Drawing.Point(7, 1);
            this.easyChartX1.Margin = new System.Windows.Forms.Padding(4);
            this.easyChartX1.Miscellaneous.CheckInfinity = false;
            this.easyChartX1.Miscellaneous.CheckNaN = false;
            this.easyChartX1.Miscellaneous.CheckNegtiveOrZero = false;
            this.easyChartX1.Miscellaneous.DirectionChartCount = 3;
            this.easyChartX1.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.EasyChartX.FitType.Range;
            this.easyChartX1.Miscellaneous.MarkerSize = 7;
            this.easyChartX1.Miscellaneous.MaxSeriesCount = 32;
            this.easyChartX1.Miscellaneous.MaxSeriesPointCount = 4000;
            this.easyChartX1.Miscellaneous.ShowFunctionMenu = true;
            this.easyChartX1.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.easyChartX1.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.EasyChartXUtility.LayoutDirection.LeftToRight;
            this.easyChartX1.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.easyChartX1.Miscellaneous.SplitViewAutoLayout = true;
            this.easyChartX1.Name = "easyChartX1";
            this.easyChartX1.SeriesCount = 1;
            this.easyChartX1.Size = new System.Drawing.Size(782, 265);
            this.easyChartX1.SplitView = false;
            this.easyChartX1.TabIndex = 0;
            this.easyChartX1.XCursor.AutoInterval = true;
            this.easyChartX1.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChartX1.XCursor.Interval = 0.001D;
            this.easyChartX1.XCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Zoom;
            this.easyChartX1.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX1.XCursor.Value = double.NaN;
            this.easyChartX1.YCursor.AutoInterval = true;
            this.easyChartX1.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChartX1.YCursor.Interval = 0.001D;
            this.easyChartX1.YCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Disabled;
            this.easyChartX1.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX1.YCursor.Value = double.NaN;
            // 
            // easyButton_Start
            // 
            this.easyButton_Start.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.easyButton_Start.Location = new System.Drawing.Point(59, 397);
            this.easyButton_Start.Name = "easyButton_Start";
            this.easyButton_Start.PreSetImage = SeeSharpTools.JY.GUI.EasyButton.ButtonPresetImage.None;
            this.easyButton_Start.Size = new System.Drawing.Size(95, 46);
            this.easyButton_Start.TabIndex = 1;
            this.easyButton_Start.Text = "Start";
            this.easyButton_Start.Click += new System.EventHandler(this.easyButton_Start_Click);
            // 
            // easyButton_Stop
            // 
            this.easyButton_Stop.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.easyButton_Stop.Location = new System.Drawing.Point(214, 394);
            this.easyButton_Stop.Name = "easyButton_Stop";
            this.easyButton_Stop.PreSetImage = SeeSharpTools.JY.GUI.EasyButton.ButtonPresetImage.None;
            this.easyButton_Stop.Size = new System.Drawing.Size(94, 46);
            this.easyButton_Stop.TabIndex = 1;
            this.easyButton_Stop.Text = "Stop";
            this.easyButton_Stop.Click += new System.EventHandler(this.easyButton_Stop_Click);
            // 
            // groupBox_SignalRouting
            // 
            this.groupBox_SignalRouting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_SignalRouting.Controls.Add(this.comboBox_aodes);
            this.groupBox_SignalRouting.Controls.Add(this.comboBox_aides);
            this.groupBox_SignalRouting.Controls.Add(this.comboBox_aosignal);
            this.groupBox_SignalRouting.Controls.Add(this.comboBox_aisignal);
            this.groupBox_SignalRouting.Controls.Add(this.label5);
            this.groupBox_SignalRouting.Controls.Add(this.label2);
            this.groupBox_SignalRouting.Controls.Add(this.label3);
            this.groupBox_SignalRouting.Controls.Add(this.label1);
            this.groupBox_SignalRouting.Font = new System.Drawing.Font("宋体", 10.5F);
            this.groupBox_SignalRouting.Location = new System.Drawing.Point(3, 3);
            this.groupBox_SignalRouting.Name = "groupBox_SignalRouting";
            this.groupBox_SignalRouting.Size = new System.Drawing.Size(361, 223);
            this.groupBox_SignalRouting.TabIndex = 2;
            this.groupBox_SignalRouting.TabStop = false;
            this.groupBox_SignalRouting.Text = "Signal Routing";
            // 
            // comboBox_aodes
            // 
            this.comboBox_aodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_aodes.FormattingEnabled = true;
            this.comboBox_aodes.Location = new System.Drawing.Point(183, 164);
            this.comboBox_aodes.Name = "comboBox_aodes";
            this.comboBox_aodes.Size = new System.Drawing.Size(169, 22);
            this.comboBox_aodes.TabIndex = 1;
            // 
            // comboBox_aides
            // 
            this.comboBox_aides.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_aides.FormattingEnabled = true;
            this.comboBox_aides.Location = new System.Drawing.Point(183, 72);
            this.comboBox_aides.Name = "comboBox_aides";
            this.comboBox_aides.Size = new System.Drawing.Size(169, 22);
            this.comboBox_aides.TabIndex = 1;
            // 
            // comboBox_aosignal
            // 
            this.comboBox_aosignal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_aosignal.FormattingEnabled = true;
            this.comboBox_aosignal.Location = new System.Drawing.Point(183, 118);
            this.comboBox_aosignal.Name = "comboBox_aosignal";
            this.comboBox_aosignal.Size = new System.Drawing.Size(169, 22);
            this.comboBox_aosignal.TabIndex = 1;
            // 
            // comboBox_aisignal
            // 
            this.comboBox_aisignal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_aisignal.FormattingEnabled = true;
            this.comboBox_aisignal.Location = new System.Drawing.Point(183, 26);
            this.comboBox_aisignal.Name = "comboBox_aisignal";
            this.comboBox_aisignal.Size = new System.Drawing.Size(169, 22);
            this.comboBox_aisignal.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "AO Destination Terminal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "AI Destination Terminal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "AO Source Signal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "AI Source Signal";
            // 
            // groupBox_Trigger_Clock
            // 
            this.groupBox_Trigger_Clock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Trigger_Clock.Controls.Add(this.comboBox_AOTrig);
            this.groupBox_Trigger_Clock.Controls.Add(this.comboBox_AOClock);
            this.groupBox_Trigger_Clock.Controls.Add(this.label6);
            this.groupBox_Trigger_Clock.Controls.Add(this.label8);
            this.groupBox_Trigger_Clock.Font = new System.Drawing.Font("宋体", 10.5F);
            this.groupBox_Trigger_Clock.Location = new System.Drawing.Point(3, 232);
            this.groupBox_Trigger_Clock.Name = "groupBox_Trigger_Clock";
            this.groupBox_Trigger_Clock.Size = new System.Drawing.Size(361, 156);
            this.groupBox_Trigger_Clock.TabIndex = 3;
            this.groupBox_Trigger_Clock.TabStop = false;
            this.groupBox_Trigger_Clock.Text = "Trigger and Clock";
            // 
            // comboBox_AOTrig
            // 
            this.comboBox_AOTrig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AOTrig.FormattingEnabled = true;
            this.comboBox_AOTrig.Location = new System.Drawing.Point(183, 88);
            this.comboBox_AOTrig.Name = "comboBox_AOTrig";
            this.comboBox_AOTrig.Size = new System.Drawing.Size(169, 22);
            this.comboBox_AOTrig.TabIndex = 1;
            // 
            // comboBox_AOClock
            // 
            this.comboBox_AOClock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AOClock.FormattingEnabled = true;
            this.comboBox_AOClock.Location = new System.Drawing.Point(183, 46);
            this.comboBox_AOClock.Name = "comboBox_AOClock";
            this.comboBox_AOClock.Size = new System.Drawing.Size(169, 22);
            this.comboBox_AOClock.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "AO Clock Source";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "AO Digital TrigSource";
            // 
            // groupBox_AIParam
            // 
            this.groupBox_AIParam.Controls.Add(this.comboBox_channelNumber);
            this.groupBox_AIParam.Controls.Add(this.numericUpDown_aisamplerate);
            this.groupBox_AIParam.Controls.Add(this.label10);
            this.groupBox_AIParam.Controls.Add(this.label11);
            this.groupBox_AIParam.Controls.Add(this.label9);
            this.groupBox_AIParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_AIParam.Font = new System.Drawing.Font("宋体", 10.5F);
            this.groupBox_AIParam.Location = new System.Drawing.Point(0, 0);
            this.groupBox_AIParam.Name = "groupBox_AIParam";
            this.groupBox_AIParam.Size = new System.Drawing.Size(524, 90);
            this.groupBox_AIParam.TabIndex = 4;
            this.groupBox_AIParam.TabStop = false;
            this.groupBox_AIParam.Text = "AI Configuration";
            // 
            // comboBox_channelNumber
            // 
            this.comboBox_channelNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_channelNumber.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_channelNumber.FormattingEnabled = true;
            this.comboBox_channelNumber.Location = new System.Drawing.Point(64, 52);
            this.comboBox_channelNumber.Name = "comboBox_channelNumber";
            this.comboBox_channelNumber.Size = new System.Drawing.Size(118, 20);
            this.comboBox_channelNumber.TabIndex = 6;
            this.comboBox_channelNumber.Tag = "ParaConfig";
            // 
            // numericUpDown_aisamplerate
            // 
            this.numericUpDown_aisamplerate.Location = new System.Drawing.Point(292, 49);
            this.numericUpDown_aisamplerate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_aisamplerate.Name = "numericUpDown_aisamplerate";
            this.numericUpDown_aisamplerate.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_aisamplerate.TabIndex = 5;
            this.numericUpDown_aisamplerate.ThousandsSeparator = true;
            this.numericUpDown_aisamplerate.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-513, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "AIClockSource";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "AI Sample Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "AI Channel Count";
            // 
            // groupBox_AOParam
            // 
            this.groupBox_AOParam.Controls.Add(this.comboBox_aochannel);
            this.groupBox_AOParam.Controls.Add(this.numericUpDown_aosignalRate);
            this.groupBox_AOParam.Controls.Add(this.label12);
            this.groupBox_AOParam.Controls.Add(this.label13);
            this.groupBox_AOParam.Controls.Add(this.label14);
            this.groupBox_AOParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_AOParam.Font = new System.Drawing.Font("宋体", 10.5F);
            this.groupBox_AOParam.Location = new System.Drawing.Point(0, 0);
            this.groupBox_AOParam.Name = "groupBox_AOParam";
            this.groupBox_AOParam.Size = new System.Drawing.Size(524, 95);
            this.groupBox_AOParam.TabIndex = 4;
            this.groupBox_AOParam.TabStop = false;
            this.groupBox_AOParam.Text = "AO Configuration";
            // 
            // comboBox_aochannel
            // 
            this.comboBox_aochannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_aochannel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_aochannel.FormattingEnabled = true;
            this.comboBox_aochannel.Location = new System.Drawing.Point(61, 55);
            this.comboBox_aochannel.Name = "comboBox_aochannel";
            this.comboBox_aochannel.Size = new System.Drawing.Size(118, 20);
            this.comboBox_aochannel.TabIndex = 6;
            this.comboBox_aochannel.Tag = "ParaConfig";
            // 
            // numericUpDown_aosignalRate
            // 
            this.numericUpDown_aosignalRate.Location = new System.Drawing.Point(292, 53);
            this.numericUpDown_aosignalRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_aosignalRate.Name = "numericUpDown_aosignalRate";
            this.numericUpDown_aosignalRate.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_aosignalRate.TabIndex = 5;
            this.numericUpDown_aosignalRate.ThousandsSeparator = true;
            this.numericUpDown_aosignalRate.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-513, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 14);
            this.label12.TabIndex = 0;
            this.label12.Text = "AIClockSource";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(61, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 14);
            this.label13.TabIndex = 0;
            this.label13.Text = "AO Channel Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(289, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 14);
            this.label14.TabIndex = 0;
            this.label14.Text = "AO Signal Rate";
            // 
            // timer_FetchData
            // 
            this.timer_FetchData.Tick += new System.EventHandler(this.timer_FetchData_Tick);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1159, 80);
            this.splitter1.TabIndex = 92;
            this.splitter1.TabStop = false;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoEllipsis = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label15.Font = new System.Drawing.Font("宋体", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(300, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(558, 31);
            this.label15.TabIndex = 93;
            this.label15.Text = "PCIe/PXIe 5500 Series AI_AO Sync";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.easyChartX1);
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 268);
            this.panel1.TabIndex = 94;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox_Trigger_Clock);
            this.panel2.Controls.Add(this.groupBox_SignalRouting);
            this.panel2.Controls.Add(this.easyButton_Stop);
            this.panel2.Controls.Add(this.easyButton_Start);
            this.panel2.Location = new System.Drawing.Point(792, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 461);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Location = new System.Drawing.Point(3, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 189);
            this.panel3.TabIndex = 95;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(791, 189);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_SoltNumber);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.comboBox_cardID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 189);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
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
            this.comboBox_SoltNumber.Location = new System.Drawing.Point(109, 120);
            this.comboBox_SoltNumber.Name = "comboBox_SoltNumber";
            this.comboBox_SoltNumber.Size = new System.Drawing.Size(141, 20);
            this.comboBox_SoltNumber.TabIndex = 65;
            this.comboBox_SoltNumber.Tag = "ParaConfig";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label16.Location = new System.Drawing.Point(6, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 14);
            this.label16.TabIndex = 98;
            this.label16.Text = "Card ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(6, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 14);
            this.label17.TabIndex = 66;
            this.label17.Text = "Slot Number ";
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
            this.comboBox_cardID.Location = new System.Drawing.Point(109, 49);
            this.comboBox_cardID.Name = "comboBox_cardID";
            this.comboBox_cardID.Size = new System.Drawing.Size(141, 20);
            this.comboBox_cardID.TabIndex = 99;
            this.comboBox_cardID.Tag = "ParaConfig";
            this.comboBox_cardID.SelectedIndexChanged += new System.EventHandler(this.comboBox_cardID_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox_AIParam);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox_AOParam);
            this.splitContainer2.Size = new System.Drawing.Size(524, 189);
            this.splitContainer2.SplitterDistance = 90;
            this.splitContainer2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCIe/PXIe 5500 Series AI_AO Sync";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_SignalRouting.ResumeLayout(false);
            this.groupBox_SignalRouting.PerformLayout();
            this.groupBox_Trigger_Clock.ResumeLayout(false);
            this.groupBox_Trigger_Clock.PerformLayout();
            this.groupBox_AIParam.ResumeLayout(false);
            this.groupBox_AIParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_aisamplerate)).EndInit();
            this.groupBox_AOParam.ResumeLayout(false);
            this.groupBox_AOParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_aosignalRate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SeeSharpTools.JY.GUI.EasyChartX easyChartX1;
        private SeeSharpTools.JY.GUI.EasyButton easyButton_Start;
        private SeeSharpTools.JY.GUI.EasyButton easyButton_Stop;
        private System.Windows.Forms.GroupBox groupBox_SignalRouting;
        private System.Windows.Forms.ComboBox comboBox_aodes;
        private System.Windows.Forms.ComboBox comboBox_aides;
        private System.Windows.Forms.ComboBox comboBox_aosignal;
        private System.Windows.Forms.ComboBox comboBox_aisignal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Trigger_Clock;
        private System.Windows.Forms.ComboBox comboBox_AOTrig;
        private System.Windows.Forms.ComboBox comboBox_AOClock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox_AIParam;
        private System.Windows.Forms.NumericUpDown numericUpDown_aisamplerate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox_AOParam;
        private System.Windows.Forms.NumericUpDown numericUpDown_aosignalRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer_FetchData;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox_cardID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox_channelNumber;
        private System.Windows.Forms.ComboBox comboBox_SoltNumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox_aochannel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

