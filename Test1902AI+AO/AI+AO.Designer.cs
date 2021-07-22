
namespace Test1902AI_AO
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
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries4 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries5 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries6 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.easyChartX_AISingle = new SeeSharpTools.JY.GUI.EasyChartX();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.groupBox_SetAIParaments = new System.Windows.Forms.GroupBox();
            this.comboBox_Range = new System.Windows.Forms.ComboBox();
            this.label_Mode = new System.Windows.Forms.Label();
            this.comboBox_Mode = new System.Windows.Forms.ComboBox();
            this.label_Range = new System.Windows.Forms.Label();
            this.label_SampleAcquire = new System.Windows.Forms.Label();
            this.label_SampleRate = new System.Windows.Forms.Label();
            this.label_Terminal = new System.Windows.Forms.Label();
            this.label_ChannelID = new System.Windows.Forms.Label();
            this.label_BoardNumber = new System.Windows.Forms.Label();
            this.numericUpDown_SampleAcquire = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SampleRate = new System.Windows.Forms.NumericUpDown();
            this.comboBox_ChannelId = new System.Windows.Forms.ComboBox();
            this.comboBox_Terminal = new System.Windows.Forms.ComboBox();
            this.comboBox_BoardNumber = new System.Windows.Forms.ComboBox();
            this.easyChartX_AI = new SeeSharpTools.JY.GUI.EasyChartX();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox_SetWave = new System.Windows.Forms.GroupBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.label_Amplitude = new System.Windows.Forms.Label();
            this.label_Frequency = new System.Windows.Forms.Label();
            this.label_WaveType = new System.Windows.Forms.Label();
            this.numericUpDown_Amplitude = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Frequency = new System.Windows.Forms.NumericUpDown();
            this.comboBox_WaveType = new System.Windows.Forms.ComboBox();
            this.button_AOStop = new System.Windows.Forms.Button();
            this.button_AOStart = new System.Windows.Forms.Button();
            this.groupBox_SetAOParaments = new System.Windows.Forms.GroupBox();
            this.label_SampleUpdate = new System.Windows.Forms.Label();
            this.label_UpdateRate = new System.Windows.Forms.Label();
            this.label_AOChannelId = new System.Windows.Forms.Label();
            this.label_OutputMode = new System.Windows.Forms.Label();
            this.numericUpDown_SampleUpdate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_UpdateRate = new System.Windows.Forms.NumericUpDown();
            this.comboBox_AOChannelId = new System.Windows.Forms.ComboBox();
            this.comboBox_OutputMode = new System.Windows.Forms.ComboBox();
            this.easyChartX_AO = new SeeSharpTools.JY.GUI.EasyChartX();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox_countResult = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_countValue = new System.Windows.Forms.TextBox();
            this.groupBox_genPara = new System.Windows.Forms.GroupBox();
            this.label_MeasureType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_countDIR = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_CountingDIR = new System.Windows.Forms.Label();
            this.comboBox_CIBoardNumber = new System.Windows.Forms.ComboBox();
            this.comboBox_gateSource = new System.Windows.Forms.ComboBox();
            this.comboBox_counterNumber = new System.Windows.Forms.ComboBox();
            this.label_GateSource = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_CIMode = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.groupBox_MeasureResult = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_measureValue = new System.Windows.Forms.TextBox();
            this.comboBox_MeasureType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_ClockSource = new System.Windows.Forms.ComboBox();
            this.label1_CIMode = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_SetAIParaments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SampleAcquire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SampleRate)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox_SetWave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Frequency)).BeginInit();
            this.groupBox_SetAOParaments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SampleUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UpdateRate)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_countResult.SuspendLayout();
            this.groupBox_genPara.SuspendLayout();
            this.groupBox_MeasureResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 86);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1183, 588);
            this.tabControl1.TabIndex = 80;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.easyChartX_AISingle);
            this.tabPage1.Controls.Add(this.button_Stop);
            this.tabPage1.Controls.Add(this.button_Start);
            this.tabPage1.Controls.Add(this.groupBox_SetAIParaments);
            this.tabPage1.Controls.Add(this.easyChartX_AI);
            this.tabPage1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1175, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AI";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // easyChartX_AISingle
            // 
            this.easyChartX_AISingle.AutoClear = true;
            this.easyChartX_AISingle.AxisX.AutoScale = true;
            this.easyChartX_AISingle.AxisX.AutoZoomReset = false;
            this.easyChartX_AISingle.AxisX.Color = System.Drawing.Color.Black;
            this.easyChartX_AISingle.AxisX.InitWithScaleView = false;
            this.easyChartX_AISingle.AxisX.IsLogarithmic = false;
            this.easyChartX_AISingle.AxisX.LabelAngle = 0;
            this.easyChartX_AISingle.AxisX.LabelEnabled = true;
            this.easyChartX_AISingle.AxisX.LabelFormat = null;
            this.easyChartX_AISingle.AxisX.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AISingle.AxisX.MajorGridCount = -1;
            this.easyChartX_AISingle.AxisX.MajorGridEnabled = true;
            this.easyChartX_AISingle.AxisX.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_AISingle.AxisX.Maximum = 1000D;
            this.easyChartX_AISingle.AxisX.Minimum = 0D;
            this.easyChartX_AISingle.AxisX.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AISingle.AxisX.MinorGridEnabled = false;
            this.easyChartX_AISingle.AxisX.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_AISingle.AxisX.TickWidth = 1F;
            this.easyChartX_AISingle.AxisX.Title = "";
            this.easyChartX_AISingle.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_AISingle.AxisX.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_AISingle.AxisX.ViewMaximum = 1000D;
            this.easyChartX_AISingle.AxisX.ViewMinimum = 0D;
            this.easyChartX_AISingle.AxisX2.AutoScale = true;
            this.easyChartX_AISingle.AxisX2.AutoZoomReset = false;
            this.easyChartX_AISingle.AxisX2.Color = System.Drawing.Color.Black;
            this.easyChartX_AISingle.AxisX2.InitWithScaleView = false;
            this.easyChartX_AISingle.AxisX2.IsLogarithmic = false;
            this.easyChartX_AISingle.AxisX2.LabelAngle = 0;
            this.easyChartX_AISingle.AxisX2.LabelEnabled = true;
            this.easyChartX_AISingle.AxisX2.LabelFormat = null;
            this.easyChartX_AISingle.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AISingle.AxisX2.MajorGridCount = -1;
            this.easyChartX_AISingle.AxisX2.MajorGridEnabled = true;
            this.easyChartX_AISingle.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_AISingle.AxisX2.Maximum = 1000D;
            this.easyChartX_AISingle.AxisX2.Minimum = 0D;
            this.easyChartX_AISingle.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AISingle.AxisX2.MinorGridEnabled = false;
            this.easyChartX_AISingle.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_AISingle.AxisX2.TickWidth = 1F;
            this.easyChartX_AISingle.AxisX2.Title = "";
            this.easyChartX_AISingle.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_AISingle.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_AISingle.AxisX2.ViewMaximum = 1000D;
            this.easyChartX_AISingle.AxisX2.ViewMinimum = 0D;
            this.easyChartX_AISingle.AxisY.AutoScale = true;
            this.easyChartX_AISingle.AxisY.AutoZoomReset = false;
            this.easyChartX_AISingle.AxisY.Color = System.Drawing.Color.Black;
            this.easyChartX_AISingle.AxisY.InitWithScaleView = false;
            this.easyChartX_AISingle.AxisY.IsLogarithmic = false;
            this.easyChartX_AISingle.AxisY.LabelAngle = 0;
            this.easyChartX_AISingle.AxisY.LabelEnabled = true;
            this.easyChartX_AISingle.AxisY.LabelFormat = null;
            this.easyChartX_AISingle.AxisY.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AISingle.AxisY.MajorGridCount = 6;
            this.easyChartX_AISingle.AxisY.MajorGridEnabled = true;
            this.easyChartX_AISingle.AxisY.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_AISingle.AxisY.Maximum = 3.5D;
            this.easyChartX_AISingle.AxisY.Minimum = 0.5D;
            this.easyChartX_AISingle.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AISingle.AxisY.MinorGridEnabled = false;
            this.easyChartX_AISingle.AxisY.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_AISingle.AxisY.TickWidth = 1F;
            this.easyChartX_AISingle.AxisY.Title = "";
            this.easyChartX_AISingle.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_AISingle.AxisY.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_AISingle.AxisY.ViewMaximum = 3.5D;
            this.easyChartX_AISingle.AxisY.ViewMinimum = 0.5D;
            this.easyChartX_AISingle.AxisY2.AutoScale = true;
            this.easyChartX_AISingle.AxisY2.AutoZoomReset = false;
            this.easyChartX_AISingle.AxisY2.Color = System.Drawing.Color.Black;
            this.easyChartX_AISingle.AxisY2.InitWithScaleView = false;
            this.easyChartX_AISingle.AxisY2.IsLogarithmic = false;
            this.easyChartX_AISingle.AxisY2.LabelAngle = 0;
            this.easyChartX_AISingle.AxisY2.LabelEnabled = true;
            this.easyChartX_AISingle.AxisY2.LabelFormat = null;
            this.easyChartX_AISingle.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AISingle.AxisY2.MajorGridCount = 6;
            this.easyChartX_AISingle.AxisY2.MajorGridEnabled = true;
            this.easyChartX_AISingle.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_AISingle.AxisY2.Maximum = 3.5D;
            this.easyChartX_AISingle.AxisY2.Minimum = 0.5D;
            this.easyChartX_AISingle.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AISingle.AxisY2.MinorGridEnabled = false;
            this.easyChartX_AISingle.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_AISingle.AxisY2.TickWidth = 1F;
            this.easyChartX_AISingle.AxisY2.Title = "";
            this.easyChartX_AISingle.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_AISingle.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_AISingle.AxisY2.ViewMaximum = 3.5D;
            this.easyChartX_AISingle.AxisY2.ViewMinimum = 0.5D;
            this.easyChartX_AISingle.BackColor = System.Drawing.Color.White;
            this.easyChartX_AISingle.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChartX_AISingle.Cumulitive = false;
            this.easyChartX_AISingle.GradientStyle = SeeSharpTools.JY.GUI.EasyChartX.ChartGradientStyle.None;
            this.easyChartX_AISingle.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartX_AISingle.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.easyChartX_AISingle.LegendForeColor = System.Drawing.Color.Black;
            this.easyChartX_AISingle.LegendVisible = true;
            easyChartXSeries4.Color = System.Drawing.Color.Red;
            easyChartXSeries4.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries4.Name = "Series1";
            easyChartXSeries4.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries4.Visible = true;
            easyChartXSeries4.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries4.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries4.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            this.easyChartX_AISingle.LineSeries.Add(easyChartXSeries4);
            this.easyChartX_AISingle.Location = new System.Drawing.Point(0, 11);
            this.easyChartX_AISingle.Margin = new System.Windows.Forms.Padding(5);
            this.easyChartX_AISingle.Miscellaneous.CheckInfinity = false;
            this.easyChartX_AISingle.Miscellaneous.CheckNaN = false;
            this.easyChartX_AISingle.Miscellaneous.CheckNegtiveOrZero = false;
            this.easyChartX_AISingle.Miscellaneous.DirectionChartCount = 3;
            this.easyChartX_AISingle.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.EasyChartX.FitType.Range;
            this.easyChartX_AISingle.Miscellaneous.MarkerSize = 7;
            this.easyChartX_AISingle.Miscellaneous.MaxSeriesCount = 32;
            this.easyChartX_AISingle.Miscellaneous.MaxSeriesPointCount = 4000;
            this.easyChartX_AISingle.Miscellaneous.ShowFunctionMenu = true;
            this.easyChartX_AISingle.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.easyChartX_AISingle.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.EasyChartXUtility.LayoutDirection.LeftToRight;
            this.easyChartX_AISingle.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.easyChartX_AISingle.Miscellaneous.SplitViewAutoLayout = true;
            this.easyChartX_AISingle.Name = "easyChartX_AISingle";
            this.easyChartX_AISingle.SeriesCount = 1;
            this.easyChartX_AISingle.Size = new System.Drawing.Size(685, 526);
            this.easyChartX_AISingle.SplitView = false;
            this.easyChartX_AISingle.TabIndex = 4;
            this.easyChartX_AISingle.XCursor.AutoInterval = true;
            this.easyChartX_AISingle.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChartX_AISingle.XCursor.Interval = 0.001D;
            this.easyChartX_AISingle.XCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Zoom;
            this.easyChartX_AISingle.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX_AISingle.XCursor.Value = double.NaN;
            this.easyChartX_AISingle.YCursor.AutoInterval = true;
            this.easyChartX_AISingle.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChartX_AISingle.YCursor.Interval = 0.001D;
            this.easyChartX_AISingle.YCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Disabled;
            this.easyChartX_AISingle.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX_AISingle.YCursor.Value = double.NaN;
            // 
            // button_Stop
            // 
            this.button_Stop.Enabled = false;
            this.button_Stop.Location = new System.Drawing.Point(1031, 462);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(112, 52);
            this.button_Stop.TabIndex = 3;
            this.button_Stop.Text = "停止";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(745, 462);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(112, 52);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "启动";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // groupBox_SetAIParaments
            // 
            this.groupBox_SetAIParaments.Controls.Add(this.comboBox_Range);
            this.groupBox_SetAIParaments.Controls.Add(this.label_Mode);
            this.groupBox_SetAIParaments.Controls.Add(this.comboBox_Mode);
            this.groupBox_SetAIParaments.Controls.Add(this.label_Range);
            this.groupBox_SetAIParaments.Controls.Add(this.label_SampleAcquire);
            this.groupBox_SetAIParaments.Controls.Add(this.label_SampleRate);
            this.groupBox_SetAIParaments.Controls.Add(this.label_Terminal);
            this.groupBox_SetAIParaments.Controls.Add(this.label_ChannelID);
            this.groupBox_SetAIParaments.Controls.Add(this.label_BoardNumber);
            this.groupBox_SetAIParaments.Controls.Add(this.numericUpDown_SampleAcquire);
            this.groupBox_SetAIParaments.Controls.Add(this.numericUpDown_SampleRate);
            this.groupBox_SetAIParaments.Controls.Add(this.comboBox_ChannelId);
            this.groupBox_SetAIParaments.Controls.Add(this.comboBox_Terminal);
            this.groupBox_SetAIParaments.Controls.Add(this.comboBox_BoardNumber);
            this.groupBox_SetAIParaments.Location = new System.Drawing.Point(692, 11);
            this.groupBox_SetAIParaments.Name = "groupBox_SetAIParaments";
            this.groupBox_SetAIParaments.Size = new System.Drawing.Size(494, 396);
            this.groupBox_SetAIParaments.TabIndex = 1;
            this.groupBox_SetAIParaments.TabStop = false;
            this.groupBox_SetAIParaments.Text = "基本参数配置";
            // 
            // comboBox_Range
            // 
            this.comboBox_Range.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Range.FormattingEnabled = true;
            this.comboBox_Range.Items.AddRange(new object[] {
            "±10",
            "±2",
            "±1",
            "±0.2"});
            this.comboBox_Range.Location = new System.Drawing.Point(293, 345);
            this.comboBox_Range.Name = "comboBox_Range";
            this.comboBox_Range.Size = new System.Drawing.Size(159, 28);
            this.comboBox_Range.TabIndex = 38;
            // 
            // label_Mode
            // 
            this.label_Mode.AutoSize = true;
            this.label_Mode.Enabled = false;
            this.label_Mode.Location = new System.Drawing.Point(49, 93);
            this.label_Mode.Name = "label_Mode";
            this.label_Mode.Size = new System.Drawing.Size(109, 20);
            this.label_Mode.TabIndex = 37;
            this.label_Mode.Text = "采样模式：";
            // 
            // comboBox_Mode
            // 
            this.comboBox_Mode.DisplayMember = "0";
            this.comboBox_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Mode.FormattingEnabled = true;
            this.comboBox_Mode.Location = new System.Drawing.Point(293, 85);
            this.comboBox_Mode.Name = "comboBox_Mode";
            this.comboBox_Mode.Size = new System.Drawing.Size(159, 28);
            this.comboBox_Mode.TabIndex = 36;
            this.comboBox_Mode.SelectedIndexChanged += new System.EventHandler(this.comboBox_Mode_SelectedIndexChanged);
            // 
            // label_Range
            // 
            this.label_Range.AutoSize = true;
            this.label_Range.Enabled = false;
            this.label_Range.Location = new System.Drawing.Point(49, 353);
            this.label_Range.Name = "label_Range";
            this.label_Range.Size = new System.Drawing.Size(149, 20);
            this.label_Range.TabIndex = 35;
            this.label_Range.Text = "量程限制范围：";
            // 
            // label_SampleAcquire
            // 
            this.label_SampleAcquire.AutoSize = true;
            this.label_SampleAcquire.Enabled = false;
            this.label_SampleAcquire.Location = new System.Drawing.Point(49, 302);
            this.label_SampleAcquire.Name = "label_SampleAcquire";
            this.label_SampleAcquire.Size = new System.Drawing.Size(89, 20);
            this.label_SampleAcquire.TabIndex = 34;
            this.label_SampleAcquire.Text = "采集数：";
            // 
            // label_SampleRate
            // 
            this.label_SampleRate.AutoSize = true;
            this.label_SampleRate.Enabled = false;
            this.label_SampleRate.Location = new System.Drawing.Point(49, 248);
            this.label_SampleRate.Name = "label_SampleRate";
            this.label_SampleRate.Size = new System.Drawing.Size(89, 20);
            this.label_SampleRate.TabIndex = 33;
            this.label_SampleRate.Text = "采样率：";
            // 
            // label_Terminal
            // 
            this.label_Terminal.AutoSize = true;
            this.label_Terminal.Enabled = false;
            this.label_Terminal.Location = new System.Drawing.Point(49, 193);
            this.label_Terminal.Name = "label_Terminal";
            this.label_Terminal.Size = new System.Drawing.Size(109, 20);
            this.label_Terminal.TabIndex = 32;
            this.label_Terminal.Text = "连接方式：";
            // 
            // label_ChannelID
            // 
            this.label_ChannelID.AutoSize = true;
            this.label_ChannelID.Enabled = false;
            this.label_ChannelID.Location = new System.Drawing.Point(49, 143);
            this.label_ChannelID.Name = "label_ChannelID";
            this.label_ChannelID.Size = new System.Drawing.Size(89, 20);
            this.label_ChannelID.TabIndex = 31;
            this.label_ChannelID.Text = "通道号：";
            // 
            // label_BoardNumber
            // 
            this.label_BoardNumber.AutoSize = true;
            this.label_BoardNumber.Enabled = false;
            this.label_BoardNumber.Location = new System.Drawing.Point(49, 45);
            this.label_BoardNumber.Name = "label_BoardNumber";
            this.label_BoardNumber.Size = new System.Drawing.Size(89, 20);
            this.label_BoardNumber.TabIndex = 30;
            this.label_BoardNumber.Text = "板卡号：";
            // 
            // numericUpDown_SampleAcquire
            // 
            this.numericUpDown_SampleAcquire.Location = new System.Drawing.Point(293, 292);
            this.numericUpDown_SampleAcquire.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.numericUpDown_SampleAcquire.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_SampleAcquire.Name = "numericUpDown_SampleAcquire";
            this.numericUpDown_SampleAcquire.Size = new System.Drawing.Size(158, 30);
            this.numericUpDown_SampleAcquire.TabIndex = 29;
            this.numericUpDown_SampleAcquire.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDown_SampleRate
            // 
            this.numericUpDown_SampleRate.Location = new System.Drawing.Point(293, 238);
            this.numericUpDown_SampleRate.Maximum = new decimal(new int[] {
            2500000,
            0,
            0,
            0});
            this.numericUpDown_SampleRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_SampleRate.Name = "numericUpDown_SampleRate";
            this.numericUpDown_SampleRate.Size = new System.Drawing.Size(158, 30);
            this.numericUpDown_SampleRate.TabIndex = 27;
            this.numericUpDown_SampleRate.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // comboBox_ChannelId
            // 
            this.comboBox_ChannelId.DisplayMember = "0";
            this.comboBox_ChannelId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ChannelId.FormattingEnabled = true;
            this.comboBox_ChannelId.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox_ChannelId.Location = new System.Drawing.Point(293, 135);
            this.comboBox_ChannelId.Name = "comboBox_ChannelId";
            this.comboBox_ChannelId.Size = new System.Drawing.Size(159, 28);
            this.comboBox_ChannelId.TabIndex = 26;
            // 
            // comboBox_Terminal
            // 
            this.comboBox_Terminal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Terminal.FormattingEnabled = true;
            this.comboBox_Terminal.Location = new System.Drawing.Point(293, 185);
            this.comboBox_Terminal.Name = "comboBox_Terminal";
            this.comboBox_Terminal.Size = new System.Drawing.Size(159, 28);
            this.comboBox_Terminal.TabIndex = 25;
            // 
            // comboBox_BoardNumber
            // 
            this.comboBox_BoardNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BoardNumber.FormattingEnabled = true;
            this.comboBox_BoardNumber.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox_BoardNumber.Location = new System.Drawing.Point(293, 37);
            this.comboBox_BoardNumber.Name = "comboBox_BoardNumber";
            this.comboBox_BoardNumber.Size = new System.Drawing.Size(159, 28);
            this.comboBox_BoardNumber.TabIndex = 24;
            // 
            // easyChartX_AI
            // 
            this.easyChartX_AI.AutoClear = true;
            this.easyChartX_AI.AxisX.AutoScale = true;
            this.easyChartX_AI.AxisX.AutoZoomReset = false;
            this.easyChartX_AI.AxisX.Color = System.Drawing.Color.Black;
            this.easyChartX_AI.AxisX.InitWithScaleView = false;
            this.easyChartX_AI.AxisX.IsLogarithmic = false;
            this.easyChartX_AI.AxisX.LabelAngle = 0;
            this.easyChartX_AI.AxisX.LabelEnabled = true;
            this.easyChartX_AI.AxisX.LabelFormat = null;
            this.easyChartX_AI.AxisX.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AI.AxisX.MajorGridCount = -1;
            this.easyChartX_AI.AxisX.MajorGridEnabled = true;
            this.easyChartX_AI.AxisX.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_AI.AxisX.Maximum = 1000D;
            this.easyChartX_AI.AxisX.Minimum = 0D;
            this.easyChartX_AI.AxisX.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AI.AxisX.MinorGridEnabled = false;
            this.easyChartX_AI.AxisX.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_AI.AxisX.TickWidth = 1F;
            this.easyChartX_AI.AxisX.Title = "";
            this.easyChartX_AI.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_AI.AxisX.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_AI.AxisX.ViewMaximum = 1000D;
            this.easyChartX_AI.AxisX.ViewMinimum = 0D;
            this.easyChartX_AI.AxisX2.AutoScale = true;
            this.easyChartX_AI.AxisX2.AutoZoomReset = false;
            this.easyChartX_AI.AxisX2.Color = System.Drawing.Color.Black;
            this.easyChartX_AI.AxisX2.InitWithScaleView = false;
            this.easyChartX_AI.AxisX2.IsLogarithmic = false;
            this.easyChartX_AI.AxisX2.LabelAngle = 0;
            this.easyChartX_AI.AxisX2.LabelEnabled = true;
            this.easyChartX_AI.AxisX2.LabelFormat = null;
            this.easyChartX_AI.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AI.AxisX2.MajorGridCount = -1;
            this.easyChartX_AI.AxisX2.MajorGridEnabled = true;
            this.easyChartX_AI.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_AI.AxisX2.Maximum = 1000D;
            this.easyChartX_AI.AxisX2.Minimum = 0D;
            this.easyChartX_AI.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AI.AxisX2.MinorGridEnabled = false;
            this.easyChartX_AI.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_AI.AxisX2.TickWidth = 1F;
            this.easyChartX_AI.AxisX2.Title = "";
            this.easyChartX_AI.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_AI.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_AI.AxisX2.ViewMaximum = 1000D;
            this.easyChartX_AI.AxisX2.ViewMinimum = 0D;
            this.easyChartX_AI.AxisY.AutoScale = true;
            this.easyChartX_AI.AxisY.AutoZoomReset = false;
            this.easyChartX_AI.AxisY.Color = System.Drawing.Color.Black;
            this.easyChartX_AI.AxisY.InitWithScaleView = false;
            this.easyChartX_AI.AxisY.IsLogarithmic = false;
            this.easyChartX_AI.AxisY.LabelAngle = 0;
            this.easyChartX_AI.AxisY.LabelEnabled = true;
            this.easyChartX_AI.AxisY.LabelFormat = null;
            this.easyChartX_AI.AxisY.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AI.AxisY.MajorGridCount = 6;
            this.easyChartX_AI.AxisY.MajorGridEnabled = true;
            this.easyChartX_AI.AxisY.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_AI.AxisY.Maximum = 3.5D;
            this.easyChartX_AI.AxisY.Minimum = 0.5D;
            this.easyChartX_AI.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AI.AxisY.MinorGridEnabled = false;
            this.easyChartX_AI.AxisY.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_AI.AxisY.TickWidth = 1F;
            this.easyChartX_AI.AxisY.Title = "";
            this.easyChartX_AI.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_AI.AxisY.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_AI.AxisY.ViewMaximum = 3.5D;
            this.easyChartX_AI.AxisY.ViewMinimum = 0.5D;
            this.easyChartX_AI.AxisY2.AutoScale = true;
            this.easyChartX_AI.AxisY2.AutoZoomReset = false;
            this.easyChartX_AI.AxisY2.Color = System.Drawing.Color.Black;
            this.easyChartX_AI.AxisY2.InitWithScaleView = false;
            this.easyChartX_AI.AxisY2.IsLogarithmic = false;
            this.easyChartX_AI.AxisY2.LabelAngle = 0;
            this.easyChartX_AI.AxisY2.LabelEnabled = true;
            this.easyChartX_AI.AxisY2.LabelFormat = null;
            this.easyChartX_AI.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AI.AxisY2.MajorGridCount = 6;
            this.easyChartX_AI.AxisY2.MajorGridEnabled = true;
            this.easyChartX_AI.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_AI.AxisY2.Maximum = 3.5D;
            this.easyChartX_AI.AxisY2.Minimum = 0.5D;
            this.easyChartX_AI.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AI.AxisY2.MinorGridEnabled = false;
            this.easyChartX_AI.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_AI.AxisY2.TickWidth = 1F;
            this.easyChartX_AI.AxisY2.Title = "";
            this.easyChartX_AI.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_AI.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_AI.AxisY2.ViewMaximum = 3.5D;
            this.easyChartX_AI.AxisY2.ViewMinimum = 0.5D;
            this.easyChartX_AI.BackColor = System.Drawing.Color.White;
            this.easyChartX_AI.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChartX_AI.Cumulitive = false;
            this.easyChartX_AI.GradientStyle = SeeSharpTools.JY.GUI.EasyChartX.ChartGradientStyle.None;
            this.easyChartX_AI.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartX_AI.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.easyChartX_AI.LegendForeColor = System.Drawing.Color.Black;
            this.easyChartX_AI.LegendVisible = true;
            easyChartXSeries5.Color = System.Drawing.Color.Red;
            easyChartXSeries5.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries5.Name = "Series1";
            easyChartXSeries5.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries5.Visible = true;
            easyChartXSeries5.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries5.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries5.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            this.easyChartX_AI.LineSeries.Add(easyChartXSeries5);
            this.easyChartX_AI.Location = new System.Drawing.Point(0, 11);
            this.easyChartX_AI.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.easyChartX_AI.Miscellaneous.CheckInfinity = false;
            this.easyChartX_AI.Miscellaneous.CheckNaN = false;
            this.easyChartX_AI.Miscellaneous.CheckNegtiveOrZero = false;
            this.easyChartX_AI.Miscellaneous.DirectionChartCount = 3;
            this.easyChartX_AI.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.EasyChartX.FitType.Range;
            this.easyChartX_AI.Miscellaneous.MarkerSize = 7;
            this.easyChartX_AI.Miscellaneous.MaxSeriesCount = 32;
            this.easyChartX_AI.Miscellaneous.MaxSeriesPointCount = 4000;
            this.easyChartX_AI.Miscellaneous.ShowFunctionMenu = true;
            this.easyChartX_AI.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.easyChartX_AI.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.EasyChartXUtility.LayoutDirection.LeftToRight;
            this.easyChartX_AI.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.easyChartX_AI.Miscellaneous.SplitViewAutoLayout = true;
            this.easyChartX_AI.Name = "easyChartX_AI";
            this.easyChartX_AI.SeriesCount = 1;
            this.easyChartX_AI.Size = new System.Drawing.Size(685, 494);
            this.easyChartX_AI.SplitView = false;
            this.easyChartX_AI.TabIndex = 0;
            this.easyChartX_AI.XCursor.AutoInterval = true;
            this.easyChartX_AI.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChartX_AI.XCursor.Interval = 0.001D;
            this.easyChartX_AI.XCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Zoom;
            this.easyChartX_AI.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX_AI.XCursor.Value = double.NaN;
            this.easyChartX_AI.YCursor.AutoInterval = true;
            this.easyChartX_AI.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChartX_AI.YCursor.Interval = 0.001D;
            this.easyChartX_AI.YCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Disabled;
            this.easyChartX_AI.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX_AI.YCursor.Value = double.NaN;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.groupBox_SetWave);
            this.tabPage2.Controls.Add(this.button_AOStop);
            this.tabPage2.Controls.Add(this.button_AOStart);
            this.tabPage2.Controls.Add(this.groupBox_SetAOParaments);
            this.tabPage2.Controls.Add(this.easyChartX_AO);
            this.tabPage2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1175, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox_SetWave
            // 
            this.groupBox_SetWave.Controls.Add(this.button_Update);
            this.groupBox_SetWave.Controls.Add(this.label_Amplitude);
            this.groupBox_SetWave.Controls.Add(this.label_Frequency);
            this.groupBox_SetWave.Controls.Add(this.label_WaveType);
            this.groupBox_SetWave.Controls.Add(this.numericUpDown_Amplitude);
            this.groupBox_SetWave.Controls.Add(this.numericUpDown_Frequency);
            this.groupBox_SetWave.Controls.Add(this.comboBox_WaveType);
            this.groupBox_SetWave.Location = new System.Drawing.Point(690, 229);
            this.groupBox_SetWave.Name = "groupBox_SetWave";
            this.groupBox_SetWave.Size = new System.Drawing.Size(494, 213);
            this.groupBox_SetWave.TabIndex = 35;
            this.groupBox_SetWave.TabStop = false;
            this.groupBox_SetWave.Text = "波形设置";
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(350, 170);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(85, 37);
            this.button_Update.TabIndex = 36;
            this.button_Update.Text = "更新";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label_Amplitude
            // 
            this.label_Amplitude.AutoSize = true;
            this.label_Amplitude.Enabled = false;
            this.label_Amplitude.Location = new System.Drawing.Point(47, 124);
            this.label_Amplitude.Name = "label_Amplitude";
            this.label_Amplitude.Size = new System.Drawing.Size(69, 20);
            this.label_Amplitude.TabIndex = 34;
            this.label_Amplitude.Text = "振幅：";
            // 
            // label_Frequency
            // 
            this.label_Frequency.AutoSize = true;
            this.label_Frequency.Enabled = false;
            this.label_Frequency.Location = new System.Drawing.Point(47, 77);
            this.label_Frequency.Name = "label_Frequency";
            this.label_Frequency.Size = new System.Drawing.Size(69, 20);
            this.label_Frequency.TabIndex = 33;
            this.label_Frequency.Text = "频率：";
            // 
            // label_WaveType
            // 
            this.label_WaveType.AutoSize = true;
            this.label_WaveType.Enabled = false;
            this.label_WaveType.Location = new System.Drawing.Point(48, 32);
            this.label_WaveType.Name = "label_WaveType";
            this.label_WaveType.Size = new System.Drawing.Size(109, 20);
            this.label_WaveType.TabIndex = 31;
            this.label_WaveType.Text = "波形类型：";
            // 
            // numericUpDown_Amplitude
            // 
            this.numericUpDown_Amplitude.Location = new System.Drawing.Point(294, 122);
            this.numericUpDown_Amplitude.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_Amplitude.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Amplitude.Name = "numericUpDown_Amplitude";
            this.numericUpDown_Amplitude.Size = new System.Drawing.Size(156, 30);
            this.numericUpDown_Amplitude.TabIndex = 29;
            this.numericUpDown_Amplitude.Value = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            // 
            // numericUpDown_Frequency
            // 
            this.numericUpDown_Frequency.Location = new System.Drawing.Point(294, 75);
            this.numericUpDown_Frequency.Maximum = new decimal(new int[] {
            2500000,
            0,
            0,
            0});
            this.numericUpDown_Frequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Frequency.Name = "numericUpDown_Frequency";
            this.numericUpDown_Frequency.Size = new System.Drawing.Size(155, 30);
            this.numericUpDown_Frequency.TabIndex = 27;
            this.numericUpDown_Frequency.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // comboBox_WaveType
            // 
            this.comboBox_WaveType.DisplayMember = "0";
            this.comboBox_WaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_WaveType.FormattingEnabled = true;
            this.comboBox_WaveType.Items.AddRange(new object[] {
            "Sine",
            "Square",
            "UniformWhiteNoise"});
            this.comboBox_WaveType.Location = new System.Drawing.Point(294, 29);
            this.comboBox_WaveType.Name = "comboBox_WaveType";
            this.comboBox_WaveType.Size = new System.Drawing.Size(156, 28);
            this.comboBox_WaveType.TabIndex = 26;
            // 
            // button_AOStop
            // 
            this.button_AOStop.Enabled = false;
            this.button_AOStop.Location = new System.Drawing.Point(1028, 482);
            this.button_AOStop.Name = "button_AOStop";
            this.button_AOStop.Size = new System.Drawing.Size(112, 52);
            this.button_AOStop.TabIndex = 7;
            this.button_AOStop.Text = "停止";
            this.button_AOStop.UseVisualStyleBackColor = true;
            this.button_AOStop.Click += new System.EventHandler(this.button_AOStop_Click);
            // 
            // button_AOStart
            // 
            this.button_AOStart.Location = new System.Drawing.Point(741, 482);
            this.button_AOStart.Name = "button_AOStart";
            this.button_AOStart.Size = new System.Drawing.Size(112, 52);
            this.button_AOStart.TabIndex = 6;
            this.button_AOStart.Text = "启动";
            this.button_AOStart.UseVisualStyleBackColor = true;
            this.button_AOStart.Click += new System.EventHandler(this.button_AOStart_Click);
            // 
            // groupBox_SetAOParaments
            // 
            this.groupBox_SetAOParaments.Controls.Add(this.label_SampleUpdate);
            this.groupBox_SetAOParaments.Controls.Add(this.label_UpdateRate);
            this.groupBox_SetAOParaments.Controls.Add(this.label_AOChannelId);
            this.groupBox_SetAOParaments.Controls.Add(this.label_OutputMode);
            this.groupBox_SetAOParaments.Controls.Add(this.numericUpDown_SampleUpdate);
            this.groupBox_SetAOParaments.Controls.Add(this.numericUpDown_UpdateRate);
            this.groupBox_SetAOParaments.Controls.Add(this.comboBox_AOChannelId);
            this.groupBox_SetAOParaments.Controls.Add(this.comboBox_OutputMode);
            this.groupBox_SetAOParaments.Location = new System.Drawing.Point(690, 6);
            this.groupBox_SetAOParaments.Name = "groupBox_SetAOParaments";
            this.groupBox_SetAOParaments.Size = new System.Drawing.Size(494, 217);
            this.groupBox_SetAOParaments.TabIndex = 5;
            this.groupBox_SetAOParaments.TabStop = false;
            this.groupBox_SetAOParaments.Text = "基本参数配置";
            // 
            // label_SampleUpdate
            // 
            this.label_SampleUpdate.AutoSize = true;
            this.label_SampleUpdate.Enabled = false;
            this.label_SampleUpdate.Location = new System.Drawing.Point(47, 174);
            this.label_SampleUpdate.Name = "label_SampleUpdate";
            this.label_SampleUpdate.Size = new System.Drawing.Size(109, 20);
            this.label_SampleUpdate.TabIndex = 34;
            this.label_SampleUpdate.Text = "更新点数：";
            // 
            // label_UpdateRate
            // 
            this.label_UpdateRate.AutoSize = true;
            this.label_UpdateRate.Enabled = false;
            this.label_UpdateRate.Location = new System.Drawing.Point(47, 127);
            this.label_UpdateRate.Name = "label_UpdateRate";
            this.label_UpdateRate.Size = new System.Drawing.Size(89, 20);
            this.label_UpdateRate.TabIndex = 33;
            this.label_UpdateRate.Text = "更新率：";
            // 
            // label_AOChannelId
            // 
            this.label_AOChannelId.AutoSize = true;
            this.label_AOChannelId.Enabled = false;
            this.label_AOChannelId.Location = new System.Drawing.Point(48, 82);
            this.label_AOChannelId.Name = "label_AOChannelId";
            this.label_AOChannelId.Size = new System.Drawing.Size(89, 20);
            this.label_AOChannelId.TabIndex = 31;
            this.label_AOChannelId.Text = "通道号：";
            // 
            // label_OutputMode
            // 
            this.label_OutputMode.AutoSize = true;
            this.label_OutputMode.Enabled = false;
            this.label_OutputMode.Location = new System.Drawing.Point(47, 37);
            this.label_OutputMode.Name = "label_OutputMode";
            this.label_OutputMode.Size = new System.Drawing.Size(109, 20);
            this.label_OutputMode.TabIndex = 30;
            this.label_OutputMode.Text = "输出模式：";
            // 
            // numericUpDown_SampleUpdate
            // 
            this.numericUpDown_SampleUpdate.Location = new System.Drawing.Point(294, 172);
            this.numericUpDown_SampleUpdate.Maximum = new decimal(new int[] {
            2500000,
            0,
            0,
            0});
            this.numericUpDown_SampleUpdate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_SampleUpdate.Name = "numericUpDown_SampleUpdate";
            this.numericUpDown_SampleUpdate.Size = new System.Drawing.Size(155, 30);
            this.numericUpDown_SampleUpdate.TabIndex = 29;
            this.numericUpDown_SampleUpdate.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // numericUpDown_UpdateRate
            // 
            this.numericUpDown_UpdateRate.Location = new System.Drawing.Point(294, 125);
            this.numericUpDown_UpdateRate.Maximum = new decimal(new int[] {
            25000000,
            0,
            0,
            0});
            this.numericUpDown_UpdateRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_UpdateRate.Name = "numericUpDown_UpdateRate";
            this.numericUpDown_UpdateRate.Size = new System.Drawing.Size(155, 30);
            this.numericUpDown_UpdateRate.TabIndex = 27;
            this.numericUpDown_UpdateRate.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // comboBox_AOChannelId
            // 
            this.comboBox_AOChannelId.DisplayMember = "0";
            this.comboBox_AOChannelId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AOChannelId.FormattingEnabled = true;
            this.comboBox_AOChannelId.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBox_AOChannelId.Location = new System.Drawing.Point(294, 79);
            this.comboBox_AOChannelId.Name = "comboBox_AOChannelId";
            this.comboBox_AOChannelId.Size = new System.Drawing.Size(156, 28);
            this.comboBox_AOChannelId.TabIndex = 26;
            // 
            // comboBox_OutputMode
            // 
            this.comboBox_OutputMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_OutputMode.FormattingEnabled = true;
            this.comboBox_OutputMode.Location = new System.Drawing.Point(294, 34);
            this.comboBox_OutputMode.Name = "comboBox_OutputMode";
            this.comboBox_OutputMode.Size = new System.Drawing.Size(157, 28);
            this.comboBox_OutputMode.TabIndex = 24;
            this.comboBox_OutputMode.SelectedIndexChanged += new System.EventHandler(this.comboBox_OutputMode_SelectedIndexChanged);
            // 
            // easyChartX_AO
            // 
            this.easyChartX_AO.AutoClear = true;
            this.easyChartX_AO.AxisX.AutoScale = true;
            this.easyChartX_AO.AxisX.AutoZoomReset = false;
            this.easyChartX_AO.AxisX.Color = System.Drawing.Color.Black;
            this.easyChartX_AO.AxisX.InitWithScaleView = false;
            this.easyChartX_AO.AxisX.IsLogarithmic = false;
            this.easyChartX_AO.AxisX.LabelAngle = 0;
            this.easyChartX_AO.AxisX.LabelEnabled = true;
            this.easyChartX_AO.AxisX.LabelFormat = null;
            this.easyChartX_AO.AxisX.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AO.AxisX.MajorGridCount = -1;
            this.easyChartX_AO.AxisX.MajorGridEnabled = true;
            this.easyChartX_AO.AxisX.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_AO.AxisX.Maximum = 1000D;
            this.easyChartX_AO.AxisX.Minimum = 0D;
            this.easyChartX_AO.AxisX.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AO.AxisX.MinorGridEnabled = false;
            this.easyChartX_AO.AxisX.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_AO.AxisX.TickWidth = 1F;
            this.easyChartX_AO.AxisX.Title = "";
            this.easyChartX_AO.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_AO.AxisX.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_AO.AxisX.ViewMaximum = 1000D;
            this.easyChartX_AO.AxisX.ViewMinimum = 0D;
            this.easyChartX_AO.AxisX2.AutoScale = true;
            this.easyChartX_AO.AxisX2.AutoZoomReset = false;
            this.easyChartX_AO.AxisX2.Color = System.Drawing.Color.Black;
            this.easyChartX_AO.AxisX2.InitWithScaleView = false;
            this.easyChartX_AO.AxisX2.IsLogarithmic = false;
            this.easyChartX_AO.AxisX2.LabelAngle = 0;
            this.easyChartX_AO.AxisX2.LabelEnabled = true;
            this.easyChartX_AO.AxisX2.LabelFormat = null;
            this.easyChartX_AO.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AO.AxisX2.MajorGridCount = -1;
            this.easyChartX_AO.AxisX2.MajorGridEnabled = true;
            this.easyChartX_AO.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_AO.AxisX2.Maximum = 1000D;
            this.easyChartX_AO.AxisX2.Minimum = 0D;
            this.easyChartX_AO.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AO.AxisX2.MinorGridEnabled = false;
            this.easyChartX_AO.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_AO.AxisX2.TickWidth = 1F;
            this.easyChartX_AO.AxisX2.Title = "";
            this.easyChartX_AO.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_AO.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_AO.AxisX2.ViewMaximum = 1000D;
            this.easyChartX_AO.AxisX2.ViewMinimum = 0D;
            this.easyChartX_AO.AxisY.AutoScale = true;
            this.easyChartX_AO.AxisY.AutoZoomReset = false;
            this.easyChartX_AO.AxisY.Color = System.Drawing.Color.Black;
            this.easyChartX_AO.AxisY.InitWithScaleView = false;
            this.easyChartX_AO.AxisY.IsLogarithmic = false;
            this.easyChartX_AO.AxisY.LabelAngle = 0;
            this.easyChartX_AO.AxisY.LabelEnabled = true;
            this.easyChartX_AO.AxisY.LabelFormat = null;
            this.easyChartX_AO.AxisY.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AO.AxisY.MajorGridCount = 6;
            this.easyChartX_AO.AxisY.MajorGridEnabled = true;
            this.easyChartX_AO.AxisY.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_AO.AxisY.Maximum = 3.5D;
            this.easyChartX_AO.AxisY.Minimum = 0.5D;
            this.easyChartX_AO.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AO.AxisY.MinorGridEnabled = false;
            this.easyChartX_AO.AxisY.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_AO.AxisY.TickWidth = 1F;
            this.easyChartX_AO.AxisY.Title = "";
            this.easyChartX_AO.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_AO.AxisY.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_AO.AxisY.ViewMaximum = 3.5D;
            this.easyChartX_AO.AxisY.ViewMinimum = 0.5D;
            this.easyChartX_AO.AxisY2.AutoScale = true;
            this.easyChartX_AO.AxisY2.AutoZoomReset = false;
            this.easyChartX_AO.AxisY2.Color = System.Drawing.Color.Black;
            this.easyChartX_AO.AxisY2.InitWithScaleView = false;
            this.easyChartX_AO.AxisY2.IsLogarithmic = false;
            this.easyChartX_AO.AxisY2.LabelAngle = 0;
            this.easyChartX_AO.AxisY2.LabelEnabled = true;
            this.easyChartX_AO.AxisY2.LabelFormat = null;
            this.easyChartX_AO.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AO.AxisY2.MajorGridCount = 6;
            this.easyChartX_AO.AxisY2.MajorGridEnabled = true;
            this.easyChartX_AO.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX_AO.AxisY2.Maximum = 3.5D;
            this.easyChartX_AO.AxisY2.Minimum = 0.5D;
            this.easyChartX_AO.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX_AO.AxisY2.MinorGridEnabled = false;
            this.easyChartX_AO.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX_AO.AxisY2.TickWidth = 1F;
            this.easyChartX_AO.AxisY2.Title = "";
            this.easyChartX_AO.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX_AO.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX_AO.AxisY2.ViewMaximum = 3.5D;
            this.easyChartX_AO.AxisY2.ViewMinimum = 0.5D;
            this.easyChartX_AO.BackColor = System.Drawing.Color.White;
            this.easyChartX_AO.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChartX_AO.Cumulitive = false;
            this.easyChartX_AO.GradientStyle = SeeSharpTools.JY.GUI.EasyChartX.ChartGradientStyle.None;
            this.easyChartX_AO.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartX_AO.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.easyChartX_AO.LegendForeColor = System.Drawing.Color.Black;
            this.easyChartX_AO.LegendVisible = true;
            easyChartXSeries6.Color = System.Drawing.Color.Red;
            easyChartXSeries6.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries6.Name = "Series1";
            easyChartXSeries6.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries6.Visible = true;
            easyChartXSeries6.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries6.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries6.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            this.easyChartX_AO.LineSeries.Add(easyChartXSeries6);
            this.easyChartX_AO.Location = new System.Drawing.Point(-2, 6);
            this.easyChartX_AO.Margin = new System.Windows.Forms.Padding(12, 15, 12, 15);
            this.easyChartX_AO.Miscellaneous.CheckInfinity = false;
            this.easyChartX_AO.Miscellaneous.CheckNaN = false;
            this.easyChartX_AO.Miscellaneous.CheckNegtiveOrZero = false;
            this.easyChartX_AO.Miscellaneous.DirectionChartCount = 3;
            this.easyChartX_AO.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.EasyChartX.FitType.Range;
            this.easyChartX_AO.Miscellaneous.MarkerSize = 7;
            this.easyChartX_AO.Miscellaneous.MaxSeriesCount = 32;
            this.easyChartX_AO.Miscellaneous.MaxSeriesPointCount = 4000;
            this.easyChartX_AO.Miscellaneous.ShowFunctionMenu = true;
            this.easyChartX_AO.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.easyChartX_AO.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.EasyChartXUtility.LayoutDirection.LeftToRight;
            this.easyChartX_AO.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.easyChartX_AO.Miscellaneous.SplitViewAutoLayout = true;
            this.easyChartX_AO.Name = "easyChartX_AO";
            this.easyChartX_AO.SeriesCount = 1;
            this.easyChartX_AO.Size = new System.Drawing.Size(677, 528);
            this.easyChartX_AO.SplitView = false;
            this.easyChartX_AO.TabIndex = 4;
            this.easyChartX_AO.XCursor.AutoInterval = true;
            this.easyChartX_AO.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChartX_AO.XCursor.Interval = 0.001D;
            this.easyChartX_AO.XCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Zoom;
            this.easyChartX_AO.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX_AO.XCursor.Value = double.NaN;
            this.easyChartX_AO.YCursor.AutoInterval = true;
            this.easyChartX_AO.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChartX_AO.YCursor.Interval = 0.001D;
            this.easyChartX_AO.YCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Disabled;
            this.easyChartX_AO.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX_AO.YCursor.Value = double.NaN;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox_MeasureResult);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.groupBox_countResult);
            this.tabPage3.Controls.Add(this.groupBox_genPara);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1175, 551);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CI";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(995, 423);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 51);
            this.button1.TabIndex = 90;
            this.button1.Text = "停止";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(700, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(817, 423);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 51);
            this.button2.TabIndex = 89;
            this.button2.Tag = "ParaConfig";
            this.button2.Text = "开始";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox_countResult
            // 
            this.groupBox_countResult.Controls.Add(this.label6);
            this.groupBox_countResult.Controls.Add(this.textBox_countValue);
            this.groupBox_countResult.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_countResult.Location = new System.Drawing.Point(245, 342);
            this.groupBox_countResult.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_countResult.Name = "groupBox_countResult";
            this.groupBox_countResult.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_countResult.Size = new System.Drawing.Size(255, 131);
            this.groupBox_countResult.TabIndex = 86;
            this.groupBox_countResult.TabStop = false;
            this.groupBox_countResult.Text = "计数结果显示";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(53, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 79;
            this.label6.Text = "计数值";
            // 
            // textBox_countValue
            // 
            this.textBox_countValue.Location = new System.Drawing.Point(56, 60);
            this.textBox_countValue.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_countValue.Name = "textBox_countValue";
            this.textBox_countValue.Size = new System.Drawing.Size(142, 27);
            this.textBox_countValue.TabIndex = 78;
            this.textBox_countValue.Text = "0";
            // 
            // groupBox_genPara
            // 
            this.groupBox_genPara.Controls.Add(this.label1_CIMode);
            this.groupBox_genPara.Controls.Add(this.label10);
            this.groupBox_genPara.Controls.Add(this.comboBox_ClockSource);
            this.groupBox_genPara.Controls.Add(this.comboBox_MeasureType);
            this.groupBox_genPara.Controls.Add(this.label_MeasureType);
            this.groupBox_genPara.Controls.Add(this.label2);
            this.groupBox_genPara.Controls.Add(this.comboBox_countDIR);
            this.groupBox_genPara.Controls.Add(this.label7);
            this.groupBox_genPara.Controls.Add(this.label_CountingDIR);
            this.groupBox_genPara.Controls.Add(this.comboBox_CIBoardNumber);
            this.groupBox_genPara.Controls.Add(this.comboBox_gateSource);
            this.groupBox_genPara.Controls.Add(this.comboBox_counterNumber);
            this.groupBox_genPara.Controls.Add(this.label_GateSource);
            this.groupBox_genPara.Controls.Add(this.label3);
            this.groupBox_genPara.Controls.Add(this.comboBox_CIMode);
            this.groupBox_genPara.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_genPara.Location = new System.Drawing.Point(45, 31);
            this.groupBox_genPara.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_genPara.Name = "groupBox_genPara";
            this.groupBox_genPara.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_genPara.Size = new System.Drawing.Size(647, 264);
            this.groupBox_genPara.TabIndex = 83;
            this.groupBox_genPara.TabStop = false;
            this.groupBox_genPara.Text = "基本参数配置";
            // 
            // label_MeasureType
            // 
            this.label_MeasureType.AutoSize = true;
            this.label_MeasureType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_MeasureType.Location = new System.Drawing.Point(331, 123);
            this.label_MeasureType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MeasureType.Name = "label_MeasureType";
            this.label_MeasureType.Size = new System.Drawing.Size(80, 18);
            this.label_MeasureType.TabIndex = 75;
            this.label_MeasureType.Text = "测量类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(339, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "计数器";
            // 
            // comboBox_countDIR
            // 
            this.comboBox_countDIR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_countDIR.FormattingEnabled = true;
            this.comboBox_countDIR.Location = new System.Drawing.Point(180, 148);
            this.comboBox_countDIR.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_countDIR.Name = "comboBox_countDIR";
            this.comboBox_countDIR.Size = new System.Drawing.Size(109, 28);
            this.comboBox_countDIR.TabIndex = 73;
            this.comboBox_countDIR.Tag = "ParaConfig";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(24, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 66;
            this.label7.Text = "板卡号 ";
            // 
            // label_CountingDIR
            // 
            this.label_CountingDIR.AutoSize = true;
            this.label_CountingDIR.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_CountingDIR.Location = new System.Drawing.Point(179, 126);
            this.label_CountingDIR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CountingDIR.Name = "label_CountingDIR";
            this.label_CountingDIR.Size = new System.Drawing.Size(80, 18);
            this.label_CountingDIR.TabIndex = 74;
            this.label_CountingDIR.Text = "计数方向";
            // 
            // comboBox_CIBoardNumber
            // 
            this.comboBox_CIBoardNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CIBoardNumber.FormattingEnabled = true;
            this.comboBox_CIBoardNumber.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox_CIBoardNumber.Location = new System.Drawing.Point(24, 74);
            this.comboBox_CIBoardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_CIBoardNumber.Name = "comboBox_CIBoardNumber";
            this.comboBox_CIBoardNumber.Size = new System.Drawing.Size(113, 28);
            this.comboBox_CIBoardNumber.TabIndex = 65;
            this.comboBox_CIBoardNumber.Tag = "ParaConfig";
            // 
            // comboBox_gateSource
            // 
            this.comboBox_gateSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gateSource.FormattingEnabled = true;
            this.comboBox_gateSource.Location = new System.Drawing.Point(24, 148);
            this.comboBox_gateSource.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_gateSource.Name = "comboBox_gateSource";
            this.comboBox_gateSource.Size = new System.Drawing.Size(113, 28);
            this.comboBox_gateSource.TabIndex = 71;
            this.comboBox_gateSource.Tag = "ParaConfig";
            // 
            // comboBox_counterNumber
            // 
            this.comboBox_counterNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_counterNumber.FormattingEnabled = true;
            this.comboBox_counterNumber.Items.AddRange(new object[] {
            "0",
            "2"});
            this.comboBox_counterNumber.Location = new System.Drawing.Point(332, 74);
            this.comboBox_counterNumber.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_counterNumber.Name = "comboBox_counterNumber";
            this.comboBox_counterNumber.Size = new System.Drawing.Size(117, 28);
            this.comboBox_counterNumber.TabIndex = 67;
            this.comboBox_counterNumber.Tag = "ParaConfig";
            // 
            // label_GateSource
            // 
            this.label_GateSource.AutoSize = true;
            this.label_GateSource.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_GateSource.Location = new System.Drawing.Point(20, 126);
            this.label_GateSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GateSource.Name = "label_GateSource";
            this.label_GateSource.Size = new System.Drawing.Size(44, 18);
            this.label_GateSource.TabIndex = 72;
            this.label_GateSource.Text = "Gate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(186, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 70;
            // 
            // comboBox_CIMode
            // 
            this.comboBox_CIMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CIMode.FormattingEnabled = true;
            this.comboBox_CIMode.Location = new System.Drawing.Point(182, 74);
            this.comboBox_CIMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_CIMode.Name = "comboBox_CIMode";
            this.comboBox_CIMode.Size = new System.Drawing.Size(107, 28);
            this.comboBox_CIMode.TabIndex = 69;
            this.comboBox_CIMode.Tag = "ParaConfig";
            this.comboBox_CIMode.SelectedIndexChanged += new System.EventHandler(this.comboBox_CIMode_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1175, 551);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CO";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label4.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(376, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(416, 28);
            this.label4.TabIndex = 79;
            this.label4.Text = "USB-61902 Test Pannel";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1183, 79);
            this.splitter1.TabIndex = 78;
            this.splitter1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 10;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 10;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // groupBox_MeasureResult
            // 
            this.groupBox_MeasureResult.Controls.Add(this.label9);
            this.groupBox_MeasureResult.Controls.Add(this.textBox_measureValue);
            this.groupBox_MeasureResult.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_MeasureResult.Location = new System.Drawing.Point(245, 342);
            this.groupBox_MeasureResult.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_MeasureResult.Name = "groupBox_MeasureResult";
            this.groupBox_MeasureResult.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_MeasureResult.Size = new System.Drawing.Size(255, 131);
            this.groupBox_MeasureResult.TabIndex = 91;
            this.groupBox_MeasureResult.TabStop = false;
            this.groupBox_MeasureResult.Text = "测量结果显示";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(50, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 18);
            this.label9.TabIndex = 79;
            this.label9.Text = "周期/脉宽(s)";
            // 
            // textBox_measureValue
            // 
            this.textBox_measureValue.Location = new System.Drawing.Point(53, 60);
            this.textBox_measureValue.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_measureValue.Name = "textBox_measureValue";
            this.textBox_measureValue.Size = new System.Drawing.Size(124, 27);
            this.textBox_measureValue.TabIndex = 78;
            this.textBox_measureValue.Text = "0";
            // 
            // comboBox_MeasureType
            // 
            this.comboBox_MeasureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MeasureType.FormattingEnabled = true;
            this.comboBox_MeasureType.Location = new System.Drawing.Point(334, 148);
            this.comboBox_MeasureType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_MeasureType.Name = "comboBox_MeasureType";
            this.comboBox_MeasureType.Size = new System.Drawing.Size(223, 28);
            this.comboBox_MeasureType.TabIndex = 76;
            this.comboBox_MeasureType.Tag = "ParaConfig";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(490, 51);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 18);
            this.label10.TabIndex = 78;
            this.label10.Text = "时钟";
            // 
            // comboBox_ClockSource
            // 
            this.comboBox_ClockSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ClockSource.FormattingEnabled = true;
            this.comboBox_ClockSource.Location = new System.Drawing.Point(486, 74);
            this.comboBox_ClockSource.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_ClockSource.Name = "comboBox_ClockSource";
            this.comboBox_ClockSource.Size = new System.Drawing.Size(121, 28);
            this.comboBox_ClockSource.TabIndex = 77;
            this.comboBox_ClockSource.Tag = "ParaConfig";
            // 
            // label1_CIMode
            // 
            this.label1_CIMode.AutoSize = true;
            this.label1_CIMode.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_CIMode.Location = new System.Drawing.Point(186, 52);
            this.label1_CIMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_CIMode.Name = "label1_CIMode";
            this.label1_CIMode.Size = new System.Drawing.Size(62, 18);
            this.label1_CIMode.TabIndex = 79;
            this.label1_CIMode.Text = "CI模式";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 674);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.splitter1);
            this.Name = "MainForm";
            this.Text = "USB-61902 Test Pannel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox_SetAIParaments.ResumeLayout(false);
            this.groupBox_SetAIParaments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SampleAcquire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SampleRate)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox_SetWave.ResumeLayout(false);
            this.groupBox_SetWave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Frequency)).EndInit();
            this.groupBox_SetAOParaments.ResumeLayout(false);
            this.groupBox_SetAOParaments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SampleUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UpdateRate)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_countResult.ResumeLayout(false);
            this.groupBox_countResult.PerformLayout();
            this.groupBox_genPara.ResumeLayout(false);
            this.groupBox_genPara.PerformLayout();
            this.groupBox_MeasureResult.ResumeLayout(false);
            this.groupBox_MeasureResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox_SetAIParaments;
        private SeeSharpTools.JY.GUI.EasyChartX easyChartX_AI;
        private System.Windows.Forms.Label label_Range;
        private System.Windows.Forms.Label label_SampleAcquire;
        private System.Windows.Forms.Label label_SampleRate;
        private System.Windows.Forms.Label label_Terminal;
        private System.Windows.Forms.Label label_ChannelID;
        private System.Windows.Forms.Label label_BoardNumber;
        private System.Windows.Forms.NumericUpDown numericUpDown_SampleAcquire;
        private System.Windows.Forms.NumericUpDown numericUpDown_SampleRate;
        private System.Windows.Forms.ComboBox comboBox_ChannelId;
        private System.Windows.Forms.ComboBox comboBox_Terminal;
        private System.Windows.Forms.ComboBox comboBox_BoardNumber;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_Mode;
        private System.Windows.Forms.ComboBox comboBox_Mode;
        private System.Windows.Forms.ComboBox comboBox_Range;
        private System.Windows.Forms.Button button_AOStop;
        private System.Windows.Forms.Button button_AOStart;
        private System.Windows.Forms.GroupBox groupBox_SetAOParaments;
        private System.Windows.Forms.Label label_SampleUpdate;
        private System.Windows.Forms.Label label_UpdateRate;
        private System.Windows.Forms.Label label_AOChannelId;
        private System.Windows.Forms.Label label_OutputMode;
        private System.Windows.Forms.NumericUpDown numericUpDown_SampleUpdate;
        private System.Windows.Forms.NumericUpDown numericUpDown_UpdateRate;
        private System.Windows.Forms.ComboBox comboBox_AOChannelId;
        private System.Windows.Forms.ComboBox comboBox_OutputMode;
        private SeeSharpTools.JY.GUI.EasyChartX easyChartX_AO;
        private System.Windows.Forms.GroupBox groupBox_SetWave;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label_Amplitude;
        private System.Windows.Forms.Label label_Frequency;
        private System.Windows.Forms.Label label_WaveType;
        private System.Windows.Forms.NumericUpDown numericUpDown_Amplitude;
        private System.Windows.Forms.NumericUpDown numericUpDown_Frequency;
        private System.Windows.Forms.ComboBox comboBox_WaveType;
        private System.Windows.Forms.Timer timer1;
        private SeeSharpTools.JY.GUI.EasyChartX easyChartX_AISingle;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox_countResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_countValue;
        private System.Windows.Forms.GroupBox groupBox_genPara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_countDIR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_CountingDIR;
        private System.Windows.Forms.ComboBox comboBox_CIBoardNumber;
        private System.Windows.Forms.ComboBox comboBox_gateSource;
        private System.Windows.Forms.ComboBox comboBox_counterNumber;
        private System.Windows.Forms.Label label_GateSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_CIMode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_MeasureType;
        private System.Windows.Forms.GroupBox groupBox_MeasureResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_measureValue;
        private System.Windows.Forms.ComboBox comboBox_MeasureType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_ClockSource;
        private System.Windows.Forms.Label label1_CIMode;
    }
}

