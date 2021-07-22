namespace Winform_JY5510Demo
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
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries2 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.easyChartX1 = new SeeSharpTools.JY.GUI.EasyChartX();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_boardNum = new System.Windows.Forms.ComboBox();
            this.comboBox_CardID = new System.Windows.Forms.ComboBox();
            this.button_stopAIO = new System.Windows.Forms.Button();
            this.button_startAIO = new System.Windows.Forms.Button();
            this.groupBox_WaveConfig = new System.Windows.Forms.GroupBox();
            this.radioButtonNoise = new System.Windows.Forms.RadioButton();
            this.radioButtonSquare = new System.Windows.Forms.RadioButton();
            this.numericUpDown_dutyCycle = new System.Windows.Forms.NumericUpDown();
            this.labelDutyCycle = new System.Windows.Forms.Label();
            this.radioButtonSine = new System.Windows.Forms.RadioButton();
            this.labelam = new System.Windows.Forms.Label();
            this.numericUpDown_WaveAmplitude = new System.Windows.Forms.NumericUpDown();
            this.labelFre = new System.Windows.Forms.Label();
            this.numericUpDown_WaveFre = new System.Windows.Forms.NumericUpDown();
            this.groupBox_GenParamAI = new System.Windows.Forms.GroupBox();
            this.comboBox_rangeLimitAI = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_ChanNoAI = new System.Windows.Forms.ComboBox();
            this.label_SampleRate = new System.Windows.Forms.Label();
            this.label_Channel = new System.Windows.Forms.Label();
            this.numericUpDown_SampleRate = new System.Windows.Forms.NumericUpDown();
            this.groupBox_GenParamAO = new System.Windows.Forms.GroupBox();
            this.comboBox_rangeLimitAO = new System.Windows.Forms.ComboBox();
            this.label_RangeHigh = new System.Windows.Forms.Label();
            this.comboBox_ChanNoAO = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_UpdateRate = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_stopDIO = new System.Windows.Forms.Button();
            this.button_startDIO = new System.Windows.Forms.Button();
            this.groupBoxDI = new System.Windows.Forms.GroupBox();
            this.ledArray1 = new SeeSharpTools.JY.GUI.LEDArray();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxDO = new System.Windows.Forms.GroupBox();
            this.switchArray1 = new SeeSharpTools.JY.GUI.SwitchArray();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.AllHigh = new System.Windows.Forms.Button();
            this.AllLow = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox_GenparamDO = new System.Windows.Forms.GroupBox();
            this.groupBox_GenparamDI = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.button_stopCIO = new System.Windows.Forms.Button();
            this.groupBox_genParaCO = new System.Windows.Forms.GroupBox();
            this.numericUpDown_frequency = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label_HighLevel = new System.Windows.Forms.Label();
            this.comboBox_counterNumberCO = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox_genParaCI = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_counterNumberCI = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_measureType = new System.Windows.Forms.ComboBox();
            this.button_startCIO = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_Values = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.JYJY5510_5511 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer_AIOFetchData = new System.Windows.Forms.Timer(this.components);
            this.timer_DIOFetchData = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox_WaveConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dutyCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_WaveAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_WaveFre)).BeginInit();
            this.groupBox_GenParamAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SampleRate)).BeginInit();
            this.groupBox_GenParamAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UpdateRate)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBoxDI.SuspendLayout();
            this.groupBoxDO.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox_genParaCO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox_genParaCI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.JYJY5510_5511.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1262, 755);
            this.splitContainer1.SplitterDistance = 88;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(467, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 27);
            this.label1.TabIndex = 94;
            this.label1.Text = "PCIe/PXIe 5500 Series Demo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1262, 662);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1254, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Analog Input/Output";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(4, 3);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.easyChartX1);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 23);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label12);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.comboBox_boardNum);
            this.splitContainer2.Panel2.Controls.Add(this.comboBox_CardID);
            this.splitContainer2.Panel2.Controls.Add(this.button_stopAIO);
            this.splitContainer2.Panel2.Controls.Add(this.button_startAIO);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox_WaveConfig);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox_GenParamAI);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox_GenParamAO);
            this.splitContainer2.Size = new System.Drawing.Size(1246, 628);
            this.splitContainer2.SplitterDistance = 852;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // easyChartX1
            // 
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
            this.easyChartX1.AxisY.Maximum = 3D;
            this.easyChartX1.AxisY.Minimum = 0D;
            this.easyChartX1.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisY.MinorGridEnabled = false;
            this.easyChartX1.AxisY.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX1.AxisY.TickWidth = 1F;
            this.easyChartX1.AxisY.Title = "Time Domain (V) ";
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
            this.easyChartX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.easyChartX1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyChartX1.GradientStyle = SeeSharpTools.JY.GUI.EasyChartX.ChartGradientStyle.None;
            this.easyChartX1.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartX1.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.easyChartX1.LegendForeColor = System.Drawing.Color.Black;
            this.easyChartX1.LegendVisible = false;
            easyChartXSeries2.Color = System.Drawing.Color.Red;
            easyChartXSeries2.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries2.Name = "Series1";
            easyChartXSeries2.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries2.Visible = true;
            easyChartXSeries2.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries2.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries2.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            this.easyChartX1.LineSeries.Add(easyChartXSeries2);
            this.easyChartX1.Location = new System.Drawing.Point(13, 12);
            this.easyChartX1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
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
            this.easyChartX1.Size = new System.Drawing.Size(826, 593);
            this.easyChartX1.SplitView = false;
            this.easyChartX1.TabIndex = 1;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(13, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 14);
            this.label12.TabIndex = 99;
            this.label12.Text = "Card ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(13, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 14);
            this.label4.TabIndex = 64;
            this.label4.Text = "Slot Number";
            // 
            // comboBox_boardNum
            // 
            this.comboBox_boardNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_boardNum.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_boardNum.FormattingEnabled = true;
            this.comboBox_boardNum.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox_boardNum.Location = new System.Drawing.Point(226, 60);
            this.comboBox_boardNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_boardNum.Name = "comboBox_boardNum";
            this.comboBox_boardNum.Size = new System.Drawing.Size(136, 22);
            this.comboBox_boardNum.TabIndex = 63;
            this.comboBox_boardNum.Tag = "ParaConfig";
            // 
            // comboBox_CardID
            // 
            this.comboBox_CardID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CardID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_CardID.FormattingEnabled = true;
            this.comboBox_CardID.Items.AddRange(new object[] {
            "5510",
            "5511",
            "5515",
            "5516"});
            this.comboBox_CardID.Location = new System.Drawing.Point(226, 18);
            this.comboBox_CardID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_CardID.Name = "comboBox_CardID";
            this.comboBox_CardID.Size = new System.Drawing.Size(136, 22);
            this.comboBox_CardID.TabIndex = 98;
            this.comboBox_CardID.Tag = "ParaConfig";
            this.comboBox_CardID.SelectedIndexChanged += new System.EventHandler(this.comboBox_CardID_SelectedIndexChanged);
            // 
            // button_stopAIO
            // 
            this.button_stopAIO.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stopAIO.Location = new System.Drawing.Point(210, 565);
            this.button_stopAIO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_stopAIO.Name = "button_stopAIO";
            this.button_stopAIO.Size = new System.Drawing.Size(105, 40);
            this.button_stopAIO.TabIndex = 78;
            this.button_stopAIO.Text = "Stop";
            this.button_stopAIO.UseVisualStyleBackColor = true;
            this.button_stopAIO.Click += new System.EventHandler(this.button_stopAIO_Click);
            // 
            // button_startAIO
            // 
            this.button_startAIO.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_startAIO.Location = new System.Drawing.Point(34, 565);
            this.button_startAIO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_startAIO.Name = "button_startAIO";
            this.button_startAIO.Size = new System.Drawing.Size(105, 40);
            this.button_startAIO.TabIndex = 77;
            this.button_startAIO.Text = "Start";
            this.button_startAIO.UseVisualStyleBackColor = true;
            this.button_startAIO.Click += new System.EventHandler(this.button_startAIO_Click);
            // 
            // groupBox_WaveConfig
            // 
            this.groupBox_WaveConfig.Controls.Add(this.radioButtonNoise);
            this.groupBox_WaveConfig.Controls.Add(this.radioButtonSquare);
            this.groupBox_WaveConfig.Controls.Add(this.numericUpDown_dutyCycle);
            this.groupBox_WaveConfig.Controls.Add(this.labelDutyCycle);
            this.groupBox_WaveConfig.Controls.Add(this.radioButtonSine);
            this.groupBox_WaveConfig.Controls.Add(this.labelam);
            this.groupBox_WaveConfig.Controls.Add(this.numericUpDown_WaveAmplitude);
            this.groupBox_WaveConfig.Controls.Add(this.labelFre);
            this.groupBox_WaveConfig.Controls.Add(this.numericUpDown_WaveFre);
            this.groupBox_WaveConfig.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_WaveConfig.Location = new System.Drawing.Point(4, 393);
            this.groupBox_WaveConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_WaveConfig.Name = "groupBox_WaveConfig";
            this.groupBox_WaveConfig.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_WaveConfig.Size = new System.Drawing.Size(378, 133);
            this.groupBox_WaveConfig.TabIndex = 76;
            this.groupBox_WaveConfig.TabStop = false;
            this.groupBox_WaveConfig.Text = "Waveform Configuration";
            // 
            // radioButtonNoise
            // 
            this.radioButtonNoise.AutoSize = true;
            this.radioButtonNoise.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNoise.Location = new System.Drawing.Point(7, 98);
            this.radioButtonNoise.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonNoise.Name = "radioButtonNoise";
            this.radioButtonNoise.Size = new System.Drawing.Size(144, 18);
            this.radioButtonNoise.TabIndex = 77;
            this.radioButtonNoise.Text = "UniformWhiteNoise";
            this.radioButtonNoise.UseVisualStyleBackColor = true;
            this.radioButtonNoise.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSquare
            // 
            this.radioButtonSquare.AutoSize = true;
            this.radioButtonSquare.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSquare.Location = new System.Drawing.Point(8, 62);
            this.radioButtonSquare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonSquare.Name = "radioButtonSquare";
            this.radioButtonSquare.Size = new System.Drawing.Size(95, 18);
            this.radioButtonSquare.TabIndex = 76;
            this.radioButtonSquare.Text = "SquareWave";
            this.radioButtonSquare.UseVisualStyleBackColor = true;
            this.radioButtonSquare.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // numericUpDown_dutyCycle
            // 
            this.numericUpDown_dutyCycle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_dutyCycle.Location = new System.Drawing.Point(245, 100);
            this.numericUpDown_dutyCycle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown_dutyCycle.Name = "numericUpDown_dutyCycle";
            this.numericUpDown_dutyCycle.Size = new System.Drawing.Size(112, 23);
            this.numericUpDown_dutyCycle.TabIndex = 79;
            this.numericUpDown_dutyCycle.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // labelDutyCycle
            // 
            this.labelDutyCycle.AutoSize = true;
            this.labelDutyCycle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDutyCycle.Location = new System.Drawing.Point(168, 101);
            this.labelDutyCycle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDutyCycle.Name = "labelDutyCycle";
            this.labelDutyCycle.Size = new System.Drawing.Size(35, 14);
            this.labelDutyCycle.TabIndex = 78;
            this.labelDutyCycle.Text = "Duty";
            this.labelDutyCycle.Visible = false;
            // 
            // radioButtonSine
            // 
            this.radioButtonSine.AutoSize = true;
            this.radioButtonSine.Checked = true;
            this.radioButtonSine.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSine.Location = new System.Drawing.Point(7, 31);
            this.radioButtonSine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonSine.Name = "radioButtonSine";
            this.radioButtonSine.Size = new System.Drawing.Size(81, 18);
            this.radioButtonSine.TabIndex = 75;
            this.radioButtonSine.TabStop = true;
            this.radioButtonSine.Text = "SineWave";
            this.radioButtonSine.UseVisualStyleBackColor = true;
            this.radioButtonSine.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // labelam
            // 
            this.labelam.AutoSize = true;
            this.labelam.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelam.Location = new System.Drawing.Point(168, 31);
            this.labelam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelam.Name = "labelam";
            this.labelam.Size = new System.Drawing.Size(35, 14);
            this.labelam.TabIndex = 77;
            this.labelam.Text = "Volt";
            // 
            // numericUpDown_WaveAmplitude
            // 
            this.numericUpDown_WaveAmplitude.DecimalPlaces = 1;
            this.numericUpDown_WaveAmplitude.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_WaveAmplitude.Location = new System.Drawing.Point(245, 26);
            this.numericUpDown_WaveAmplitude.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown_WaveAmplitude.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_WaveAmplitude.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown_WaveAmplitude.Name = "numericUpDown_WaveAmplitude";
            this.numericUpDown_WaveAmplitude.Size = new System.Drawing.Size(112, 23);
            this.numericUpDown_WaveAmplitude.TabIndex = 76;
            this.numericUpDown_WaveAmplitude.Tag = "ParaConfig";
            this.numericUpDown_WaveAmplitude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelFre
            // 
            this.labelFre.AutoSize = true;
            this.labelFre.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFre.Location = new System.Drawing.Point(168, 64);
            this.labelFre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFre.Name = "labelFre";
            this.labelFre.Size = new System.Drawing.Size(70, 14);
            this.labelFre.TabIndex = 75;
            this.labelFre.Text = "Frequency";
            // 
            // numericUpDown_WaveFre
            // 
            this.numericUpDown_WaveFre.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_WaveFre.Location = new System.Drawing.Point(245, 62);
            this.numericUpDown_WaveFre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown_WaveFre.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.numericUpDown_WaveFre.Name = "numericUpDown_WaveFre";
            this.numericUpDown_WaveFre.Size = new System.Drawing.Size(112, 23);
            this.numericUpDown_WaveFre.TabIndex = 72;
            this.numericUpDown_WaveFre.Tag = "ParaConfig";
            this.numericUpDown_WaveFre.ThousandsSeparator = true;
            this.numericUpDown_WaveFre.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // groupBox_GenParamAI
            // 
            this.groupBox_GenParamAI.Controls.Add(this.comboBox_rangeLimitAI);
            this.groupBox_GenParamAI.Controls.Add(this.label2);
            this.groupBox_GenParamAI.Controls.Add(this.comboBox_ChanNoAI);
            this.groupBox_GenParamAI.Controls.Add(this.label_SampleRate);
            this.groupBox_GenParamAI.Controls.Add(this.label_Channel);
            this.groupBox_GenParamAI.Controls.Add(this.numericUpDown_SampleRate);
            this.groupBox_GenParamAI.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_GenParamAI.Location = new System.Drawing.Point(4, 221);
            this.groupBox_GenParamAI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_GenParamAI.Name = "groupBox_GenParamAI";
            this.groupBox_GenParamAI.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_GenParamAI.Size = new System.Drawing.Size(379, 166);
            this.groupBox_GenParamAI.TabIndex = 72;
            this.groupBox_GenParamAI.TabStop = false;
            this.groupBox_GenParamAI.Text = "AI Configuration";
            // 
            // comboBox_rangeLimitAI
            // 
            this.comboBox_rangeLimitAI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rangeLimitAI.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_rangeLimitAI.FormattingEnabled = true;
            this.comboBox_rangeLimitAI.Items.AddRange(new object[] {
            "±10V",
            "±5V",
            "±2V",
            "±1V",
            "±0.5V",
            "±0.2V",
            "±0.1V"});
            this.comboBox_rangeLimitAI.Location = new System.Drawing.Point(222, 112);
            this.comboBox_rangeLimitAI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_rangeLimitAI.Name = "comboBox_rangeLimitAI";
            this.comboBox_rangeLimitAI.Size = new System.Drawing.Size(135, 22);
            this.comboBox_rangeLimitAI.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 106;
            this.label2.Text = "Channel Range";
            // 
            // comboBox_ChanNoAI
            // 
            this.comboBox_ChanNoAI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ChanNoAI.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ChanNoAI.FormattingEnabled = true;
            this.comboBox_ChanNoAI.Items.AddRange(new object[] {
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
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox_ChanNoAI.Location = new System.Drawing.Point(222, 42);
            this.comboBox_ChanNoAI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_ChanNoAI.Name = "comboBox_ChanNoAI";
            this.comboBox_ChanNoAI.Size = new System.Drawing.Size(135, 22);
            this.comboBox_ChanNoAI.TabIndex = 67;
            this.comboBox_ChanNoAI.Tag = "ParaConfig";
            // 
            // label_SampleRate
            // 
            this.label_SampleRate.AutoSize = true;
            this.label_SampleRate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SampleRate.Location = new System.Drawing.Point(12, 77);
            this.label_SampleRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SampleRate.Name = "label_SampleRate";
            this.label_SampleRate.Size = new System.Drawing.Size(84, 14);
            this.label_SampleRate.TabIndex = 1;
            this.label_SampleRate.Text = "Sample Rate";
            // 
            // label_Channel
            // 
            this.label_Channel.AutoSize = true;
            this.label_Channel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Channel.Location = new System.Drawing.Point(12, 42);
            this.label_Channel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Channel.Name = "label_Channel";
            this.label_Channel.Size = new System.Drawing.Size(105, 14);
            this.label_Channel.TabIndex = 2;
            this.label_Channel.Text = "Channel Number";
            // 
            // numericUpDown_SampleRate
            // 
            this.numericUpDown_SampleRate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_SampleRate.Location = new System.Drawing.Point(222, 77);
            this.numericUpDown_SampleRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown_SampleRate.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numericUpDown_SampleRate.Minimum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numericUpDown_SampleRate.Name = "numericUpDown_SampleRate";
            this.numericUpDown_SampleRate.Size = new System.Drawing.Size(136, 23);
            this.numericUpDown_SampleRate.TabIndex = 5;
            this.numericUpDown_SampleRate.Tag = "ParaConfig";
            this.numericUpDown_SampleRate.ThousandsSeparator = true;
            this.numericUpDown_SampleRate.Value = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            // 
            // groupBox_GenParamAO
            // 
            this.groupBox_GenParamAO.Controls.Add(this.comboBox_rangeLimitAO);
            this.groupBox_GenParamAO.Controls.Add(this.label_RangeHigh);
            this.groupBox_GenParamAO.Controls.Add(this.comboBox_ChanNoAO);
            this.groupBox_GenParamAO.Controls.Add(this.label8);
            this.groupBox_GenParamAO.Controls.Add(this.label9);
            this.groupBox_GenParamAO.Controls.Add(this.numericUpDown_UpdateRate);
            this.groupBox_GenParamAO.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_GenParamAO.Location = new System.Drawing.Point(4, 85);
            this.groupBox_GenParamAO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_GenParamAO.Name = "groupBox_GenParamAO";
            this.groupBox_GenParamAO.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_GenParamAO.Size = new System.Drawing.Size(378, 130);
            this.groupBox_GenParamAO.TabIndex = 71;
            this.groupBox_GenParamAO.TabStop = false;
            this.groupBox_GenParamAO.Text = "AO Configuration";
            // 
            // comboBox_rangeLimitAO
            // 
            this.comboBox_rangeLimitAO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rangeLimitAO.FormattingEnabled = true;
            this.comboBox_rangeLimitAO.Items.AddRange(new object[] {
            "±10V"});
            this.comboBox_rangeLimitAO.Location = new System.Drawing.Point(222, 87);
            this.comboBox_rangeLimitAO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_rangeLimitAO.Name = "comboBox_rangeLimitAO";
            this.comboBox_rangeLimitAO.Size = new System.Drawing.Size(133, 22);
            this.comboBox_rangeLimitAO.TabIndex = 105;
            // 
            // label_RangeHigh
            // 
            this.label_RangeHigh.AutoSize = true;
            this.label_RangeHigh.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RangeHigh.Location = new System.Drawing.Point(9, 93);
            this.label_RangeHigh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RangeHigh.Name = "label_RangeHigh";
            this.label_RangeHigh.Size = new System.Drawing.Size(98, 14);
            this.label_RangeHigh.TabIndex = 104;
            this.label_RangeHigh.Text = "Channel Range";
            // 
            // comboBox_ChanNoAO
            // 
            this.comboBox_ChanNoAO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ChanNoAO.FormattingEnabled = true;
            this.comboBox_ChanNoAO.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox_ChanNoAO.Location = new System.Drawing.Point(222, 22);
            this.comboBox_ChanNoAO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_ChanNoAO.Name = "comboBox_ChanNoAO";
            this.comboBox_ChanNoAO.Size = new System.Drawing.Size(133, 22);
            this.comboBox_ChanNoAO.TabIndex = 67;
            this.comboBox_ChanNoAO.Tag = "ParaConfig";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 14);
            this.label8.TabIndex = 1;
            this.label8.Text = "Update Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "Channel Number";
            // 
            // numericUpDown_UpdateRate
            // 
            this.numericUpDown_UpdateRate.Location = new System.Drawing.Point(222, 54);
            this.numericUpDown_UpdateRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown_UpdateRate.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numericUpDown_UpdateRate.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_UpdateRate.Name = "numericUpDown_UpdateRate";
            this.numericUpDown_UpdateRate.Size = new System.Drawing.Size(133, 23);
            this.numericUpDown_UpdateRate.TabIndex = 5;
            this.numericUpDown_UpdateRate.Tag = "ParaConfig";
            this.numericUpDown_UpdateRate.ThousandsSeparator = true;
            this.numericUpDown_UpdateRate.Value = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_stopDIO);
            this.tabPage2.Controls.Add(this.button_startDIO);
            this.tabPage2.Controls.Add(this.groupBoxDI);
            this.tabPage2.Controls.Add(this.groupBoxDO);
            this.tabPage2.Controls.Add(this.groupBox_GenparamDO);
            this.tabPage2.Controls.Add(this.groupBox_GenparamDI);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1254, 634);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Digital Input/OutPut";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_stopDIO
            // 
            this.button_stopDIO.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stopDIO.Location = new System.Drawing.Point(693, 507);
            this.button_stopDIO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_stopDIO.Name = "button_stopDIO";
            this.button_stopDIO.Size = new System.Drawing.Size(119, 48);
            this.button_stopDIO.TabIndex = 86;
            this.button_stopDIO.Text = "Stop";
            this.button_stopDIO.UseVisualStyleBackColor = true;
            this.button_stopDIO.Click += new System.EventHandler(this.button_stopDIO_Click);
            // 
            // button_startDIO
            // 
            this.button_startDIO.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_startDIO.Location = new System.Drawing.Point(468, 507);
            this.button_startDIO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_startDIO.Name = "button_startDIO";
            this.button_startDIO.Size = new System.Drawing.Size(119, 48);
            this.button_startDIO.TabIndex = 85;
            this.button_startDIO.Text = "Start";
            this.button_startDIO.UseVisualStyleBackColor = true;
            this.button_startDIO.Click += new System.EventHandler(this.button_startDIO_Click);
            // 
            // groupBoxDI
            // 
            this.groupBoxDI.Controls.Add(this.ledArray1);
            this.groupBoxDI.Controls.Add(this.label19);
            this.groupBoxDI.Controls.Add(this.label20);
            this.groupBoxDI.Controls.Add(this.label21);
            this.groupBoxDI.Controls.Add(this.label24);
            this.groupBoxDI.Controls.Add(this.label10);
            this.groupBoxDI.Controls.Add(this.label7);
            this.groupBoxDI.Controls.Add(this.label6);
            this.groupBoxDI.Controls.Add(this.label5);
            this.groupBoxDI.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDI.Location = new System.Drawing.Point(236, 104);
            this.groupBoxDI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxDI.Name = "groupBoxDI";
            this.groupBoxDI.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxDI.Size = new System.Drawing.Size(918, 135);
            this.groupBoxDI.TabIndex = 84;
            this.groupBoxDI.TabStop = false;
            this.groupBoxDI.Text = "Port 0";
            // 
            // ledArray1
            // 
            this.ledArray1.ControlHeight = 52;
            this.ledArray1.ControlWidth = 54;
            this.ledArray1.Dimension = ((uint)(8u));
            this.ledArray1.Direction = false;
            this.ledArray1.LEDOffColor = System.Drawing.Color.Gray;
            this.ledArray1.LEDOnColor = System.Drawing.Color.Lime;
            this.ledArray1.LEDStyle = SeeSharpTools.JY.GUI.LED.LedStyle.Circular;
            this.ledArray1.Location = new System.Drawing.Point(153, 51);
            this.ledArray1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ledArray1.Name = "ledArray1";
            this.ledArray1.Size = new System.Drawing.Size(518, 76);
            this.ledArray1.TabIndex = 34;
            this.ledArray1.Value = new bool[] {
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false};
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 12F);
            this.label19.Location = new System.Drawing.Point(612, 16);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 18);
            this.label19.TabIndex = 33;
            this.label19.Text = "L7";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 12F);
            this.label20.Location = new System.Drawing.Point(549, 16);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 18);
            this.label20.TabIndex = 31;
            this.label20.Text = "L6";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 12F);
            this.label21.Location = new System.Drawing.Point(486, 16);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 18);
            this.label21.TabIndex = 32;
            this.label21.Text = "L5";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Verdana", 12F);
            this.label24.Location = new System.Drawing.Point(424, 16);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(27, 18);
            this.label24.TabIndex = 30;
            this.label24.Text = "L4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F);
            this.label10.Location = new System.Drawing.Point(361, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "L3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F);
            this.label7.Location = new System.Drawing.Point(298, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "L2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F);
            this.label6.Location = new System.Drawing.Point(236, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "L1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F);
            this.label5.Location = new System.Drawing.Point(173, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "L0";
            // 
            // groupBoxDO
            // 
            this.groupBoxDO.Controls.Add(this.switchArray1);
            this.groupBoxDO.Controls.Add(this.label25);
            this.groupBoxDO.Controls.Add(this.label26);
            this.groupBoxDO.Controls.Add(this.label27);
            this.groupBoxDO.Controls.Add(this.label28);
            this.groupBoxDO.Controls.Add(this.label29);
            this.groupBoxDO.Controls.Add(this.label30);
            this.groupBoxDO.Controls.Add(this.label31);
            this.groupBoxDO.Controls.Add(this.label32);
            this.groupBoxDO.Controls.Add(this.label22);
            this.groupBoxDO.Controls.Add(this.AllHigh);
            this.groupBoxDO.Controls.Add(this.AllLow);
            this.groupBoxDO.Controls.Add(this.label23);
            this.groupBoxDO.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDO.Location = new System.Drawing.Point(236, 286);
            this.groupBoxDO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxDO.Name = "groupBoxDO";
            this.groupBoxDO.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxDO.Size = new System.Drawing.Size(918, 136);
            this.groupBoxDO.TabIndex = 87;
            this.groupBoxDO.TabStop = false;
            this.groupBoxDO.Text = "Port 1";
            // 
            // switchArray1
            // 
            this.switchArray1.ControlHeight = 50;
            this.switchArray1.ControlWidth = 54;
            this.switchArray1.Dimension = ((uint)(8u));
            this.switchArray1.Direction = false;
            this.switchArray1.Location = new System.Drawing.Point(154, 51);
            this.switchArray1.Margin = new System.Windows.Forms.Padding(4);
            this.switchArray1.Name = "switchArray1";
            this.switchArray1.Size = new System.Drawing.Size(533, 75);
            this.switchArray1.Style = SeeSharpTools.JY.GUI.IndustrySwitch.SwitchStyles.Vertical;
            this.switchArray1.TabIndex = 86;
            this.switchArray1.Value = new bool[] {
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false};
            this.switchArray1.ControlValueChanged += new SeeSharpTools.JY.GUI.SwitchArray.ValueChangedEventHandler(this.switchArray1_ControlValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Verdana", 12F);
            this.label25.Location = new System.Drawing.Point(612, 26);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(27, 18);
            this.label25.TabIndex = 85;
            this.label25.Text = "L7";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Verdana", 12F);
            this.label26.Location = new System.Drawing.Point(549, 26);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(27, 18);
            this.label26.TabIndex = 83;
            this.label26.Text = "L6";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Verdana", 12F);
            this.label27.Location = new System.Drawing.Point(486, 26);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(27, 18);
            this.label27.TabIndex = 84;
            this.label27.Text = "L5";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Verdana", 12F);
            this.label28.Location = new System.Drawing.Point(424, 26);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(27, 18);
            this.label28.TabIndex = 82;
            this.label28.Text = "L4";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Verdana", 12F);
            this.label29.Location = new System.Drawing.Point(361, 26);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(27, 18);
            this.label29.TabIndex = 81;
            this.label29.Text = "L3";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Verdana", 12F);
            this.label30.Location = new System.Drawing.Point(298, 26);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(27, 18);
            this.label30.TabIndex = 79;
            this.label30.Text = "L2";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Verdana", 12F);
            this.label31.Location = new System.Drawing.Point(236, 26);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(27, 18);
            this.label31.TabIndex = 80;
            this.label31.Text = "L1";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Verdana", 12F);
            this.label32.Location = new System.Drawing.Point(173, 26);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(27, 18);
            this.label32.TabIndex = 78;
            this.label32.Text = "L0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(8, 82);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 14);
            this.label22.TabIndex = 2;
            this.label22.Text = "Low(false)";
            // 
            // AllHigh
            // 
            this.AllHigh.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AllHigh.Location = new System.Drawing.Point(806, 32);
            this.AllHigh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AllHigh.Name = "AllHigh";
            this.AllHigh.Size = new System.Drawing.Size(104, 35);
            this.AllHigh.TabIndex = 73;
            this.AllHigh.Tag = "ParaConfig";
            this.AllHigh.Text = "All High";
            this.AllHigh.UseVisualStyleBackColor = true;
            this.AllHigh.Click += new System.EventHandler(this.AllHigh_Click);
            // 
            // AllLow
            // 
            this.AllLow.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllLow.Location = new System.Drawing.Point(806, 80);
            this.AllLow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AllLow.Name = "AllLow";
            this.AllLow.Size = new System.Drawing.Size(104, 35);
            this.AllLow.TabIndex = 74;
            this.AllLow.Tag = "ParaConfig";
            this.AllLow.Text = "All Low";
            this.AllLow.UseVisualStyleBackColor = true;
            this.AllLow.Click += new System.EventHandler(this.AllLow_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(8, 43);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 14);
            this.label23.TabIndex = 1;
            this.label23.Text = "High(true)";
            // 
            // groupBox_GenparamDO
            // 
            this.groupBox_GenparamDO.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_GenparamDO.Location = new System.Drawing.Point(9, 286);
            this.groupBox_GenparamDO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_GenparamDO.Name = "groupBox_GenparamDO";
            this.groupBox_GenparamDO.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_GenparamDO.Size = new System.Drawing.Size(220, 136);
            this.groupBox_GenparamDO.TabIndex = 83;
            this.groupBox_GenparamDO.TabStop = false;
            this.groupBox_GenparamDO.Text = "DO Configuration";
            // 
            // groupBox_GenparamDI
            // 
            this.groupBox_GenparamDI.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_GenparamDI.Location = new System.Drawing.Point(9, 111);
            this.groupBox_GenparamDI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_GenparamDI.Name = "groupBox_GenparamDI";
            this.groupBox_GenparamDI.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_GenparamDI.Size = new System.Drawing.Size(220, 128);
            this.groupBox_GenparamDI.TabIndex = 82;
            this.groupBox_GenparamDI.TabStop = false;
            this.groupBox_GenparamDI.Text = "DI Configuration";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Size = new System.Drawing.Size(1254, 634);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Counter Input/Output";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(4, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.button_stopCIO);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox_genParaCO);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox_genParaCI);
            this.splitContainer3.Panel1.Controls.Add(this.button_startCIO);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(1246, 628);
            this.splitContainer3.SplitterDistance = 721;
            this.splitContainer3.TabIndex = 111;
            // 
            // button_stopCIO
            // 
            this.button_stopCIO.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stopCIO.Location = new System.Drawing.Point(369, 414);
            this.button_stopCIO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_stopCIO.Name = "button_stopCIO";
            this.button_stopCIO.Size = new System.Drawing.Size(127, 55);
            this.button_stopCIO.TabIndex = 95;
            this.button_stopCIO.Tag = "ParaConfig";
            this.button_stopCIO.Text = "Stop";
            this.button_stopCIO.UseVisualStyleBackColor = true;
            this.button_stopCIO.Click += new System.EventHandler(this.button_stopCIO_Click);
            // 
            // groupBox_genParaCO
            // 
            this.groupBox_genParaCO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_genParaCO.Controls.Add(this.numericUpDown_frequency);
            this.groupBox_genParaCO.Controls.Add(this.numericUpDown1);
            this.groupBox_genParaCO.Controls.Add(this.label16);
            this.groupBox_genParaCO.Controls.Add(this.label_HighLevel);
            this.groupBox_genParaCO.Controls.Add(this.comboBox_counterNumberCO);
            this.groupBox_genParaCO.Controls.Add(this.label17);
            this.groupBox_genParaCO.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_genParaCO.Location = new System.Drawing.Point(27, 31);
            this.groupBox_genParaCO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_genParaCO.Name = "groupBox_genParaCO";
            this.groupBox_genParaCO.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_genParaCO.Size = new System.Drawing.Size(661, 141);
            this.groupBox_genParaCO.TabIndex = 91;
            this.groupBox_genParaCO.TabStop = false;
            this.groupBox_genParaCO.Text = "CO Configuration";
            // 
            // numericUpDown_frequency
            // 
            this.numericUpDown_frequency.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_frequency.Location = new System.Drawing.Point(238, 50);
            this.numericUpDown_frequency.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown_frequency.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_frequency.Name = "numericUpDown_frequency";
            this.numericUpDown_frequency.Size = new System.Drawing.Size(181, 23);
            this.numericUpDown_frequency.TabIndex = 91;
            this.numericUpDown_frequency.ThousandsSeparator = true;
            this.numericUpDown_frequency.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown1.Location = new System.Drawing.Point(468, 48);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(181, 23);
            this.numericUpDown1.TabIndex = 90;
            this.numericUpDown1.Tag = "ParaConfig";
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 22);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 14);
            this.label16.TabIndex = 68;
            this.label16.Text = "Counter";
            // 
            // label_HighLevel
            // 
            this.label_HighLevel.AutoSize = true;
            this.label_HighLevel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HighLevel.Location = new System.Drawing.Point(465, 22);
            this.label_HighLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_HighLevel.Name = "label_HighLevel";
            this.label_HighLevel.Size = new System.Drawing.Size(35, 14);
            this.label_HighLevel.TabIndex = 89;
            this.label_HighLevel.Text = "Duty";
            // 
            // comboBox_counterNumberCO
            // 
            this.comboBox_counterNumberCO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_counterNumberCO.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_counterNumberCO.FormattingEnabled = true;
            this.comboBox_counterNumberCO.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox_counterNumberCO.Location = new System.Drawing.Point(8, 51);
            this.comboBox_counterNumberCO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_counterNumberCO.Name = "comboBox_counterNumberCO";
            this.comboBox_counterNumberCO.Size = new System.Drawing.Size(181, 22);
            this.comboBox_counterNumberCO.TabIndex = 67;
            this.comboBox_counterNumberCO.Tag = "ParaConfig";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(235, 22);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 14);
            this.label17.TabIndex = 88;
            this.label17.Text = "Frequency";
            // 
            // groupBox_genParaCI
            // 
            this.groupBox_genParaCI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_genParaCI.Controls.Add(this.label14);
            this.groupBox_genParaCI.Controls.Add(this.comboBox_counterNumberCI);
            this.groupBox_genParaCI.Controls.Add(this.label15);
            this.groupBox_genParaCI.Controls.Add(this.comboBox_measureType);
            this.groupBox_genParaCI.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_genParaCI.Location = new System.Drawing.Point(27, 207);
            this.groupBox_genParaCI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_genParaCI.Name = "groupBox_genParaCI";
            this.groupBox_genParaCI.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_genParaCI.Size = new System.Drawing.Size(661, 102);
            this.groupBox_genParaCI.TabIndex = 93;
            this.groupBox_genParaCI.TabStop = false;
            this.groupBox_genParaCI.Text = "CI Configuration";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 26);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 14);
            this.label14.TabIndex = 68;
            this.label14.Text = "Counter";
            // 
            // comboBox_counterNumberCI
            // 
            this.comboBox_counterNumberCI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_counterNumberCI.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_counterNumberCI.FormattingEnabled = true;
            this.comboBox_counterNumberCI.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox_counterNumberCI.Location = new System.Drawing.Point(8, 55);
            this.comboBox_counterNumberCI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_counterNumberCI.Name = "comboBox_counterNumberCI";
            this.comboBox_counterNumberCI.Size = new System.Drawing.Size(181, 22);
            this.comboBox_counterNumberCI.TabIndex = 67;
            this.comboBox_counterNumberCI.Tag = "ParaConfig";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(235, 26);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 14);
            this.label15.TabIndex = 70;
            this.label15.Text = "Measured Mode";
            // 
            // comboBox_measureType
            // 
            this.comboBox_measureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_measureType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_measureType.FormattingEnabled = true;
            this.comboBox_measureType.Location = new System.Drawing.Point(238, 55);
            this.comboBox_measureType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_measureType.Name = "comboBox_measureType";
            this.comboBox_measureType.Size = new System.Drawing.Size(181, 22);
            this.comboBox_measureType.TabIndex = 69;
            this.comboBox_measureType.Tag = "ParaConfig";
            // 
            // button_startCIO
            // 
            this.button_startCIO.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_startCIO.Location = new System.Drawing.Point(166, 414);
            this.button_startCIO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_startCIO.Name = "button_startCIO";
            this.button_startCIO.Size = new System.Drawing.Size(127, 55);
            this.button_startCIO.TabIndex = 92;
            this.button_startCIO.Tag = "ParaConfig";
            this.button_startCIO.Text = "Start";
            this.button_startCIO.UseVisualStyleBackColor = true;
            this.button_startCIO.Click += new System.EventHandler(this.button_startCIO_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer4.Size = new System.Drawing.Size(521, 628);
            this.splitContainer4.SplitterDistance = 325;
            this.splitContainer4.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Values});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(521, 325);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column_Values
            // 
            this.Column_Values.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Values.HeaderText = "Meas";
            this.Column_Values.Name = "Column_Values";
            this.Column_Values.ReadOnly = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.JYJY5510_5511);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(521, 299);
            this.tabControl2.TabIndex = 19;
            // 
            // JYJY5510_5511
            // 
            this.JYJY5510_5511.Controls.Add(this.pictureBox1);
            this.JYJY5510_5511.Location = new System.Drawing.Point(4, 24);
            this.JYJY5510_5511.Name = "JYJY5510_5511";
            this.JYJY5510_5511.Padding = new System.Windows.Forms.Padding(3);
            this.JYJY5510_5511.Size = new System.Drawing.Size(513, 271);
            this.JYJY5510_5511.TabIndex = 0;
            this.JYJY5510_5511.Text = "5510_5511";
            this.JYJY5510_5511.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(513, 271);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "5515_5516";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(507, 265);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 109;
            this.pictureBox2.TabStop = false;
            // 
            // timer_AIOFetchData
            // 
            this.timer_AIOFetchData.Tick += new System.EventHandler(this.timer_AIOFetchData_Tick);
            // 
            // timer_DIOFetchData
            // 
            this.timer_DIOFetchData.Tick += new System.EventHandler(this.timer_DIOFetchData_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 755);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCIe/PXIe 5500 Series Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox_WaveConfig.ResumeLayout(false);
            this.groupBox_WaveConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dutyCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_WaveAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_WaveFre)).EndInit();
            this.groupBox_GenParamAI.ResumeLayout(false);
            this.groupBox_GenParamAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SampleRate)).EndInit();
            this.groupBox_GenParamAO.ResumeLayout(false);
            this.groupBox_GenParamAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UpdateRate)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBoxDI.ResumeLayout(false);
            this.groupBoxDI.PerformLayout();
            this.groupBoxDO.ResumeLayout(false);
            this.groupBoxDO.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox_genParaCO.ResumeLayout(false);
            this.groupBox_genParaCO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox_genParaCI.ResumeLayout(false);
            this.groupBox_genParaCI.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.JYJY5510_5511.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox_WaveConfig;
        private System.Windows.Forms.RadioButton radioButtonNoise;
        private System.Windows.Forms.RadioButton radioButtonSquare;
        private System.Windows.Forms.NumericUpDown numericUpDown_dutyCycle;
        private System.Windows.Forms.Label labelDutyCycle;
        private System.Windows.Forms.RadioButton radioButtonSine;
        private System.Windows.Forms.Label labelam;
        private System.Windows.Forms.NumericUpDown numericUpDown_WaveAmplitude;
        private System.Windows.Forms.Label labelFre;
        private System.Windows.Forms.NumericUpDown numericUpDown_WaveFre;
        private System.Windows.Forms.GroupBox groupBox_GenParamAI;
        private System.Windows.Forms.ComboBox comboBox_rangeLimitAI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_ChanNoAI;
        private System.Windows.Forms.Label label_SampleRate;
        private System.Windows.Forms.Label label_Channel;
        private System.Windows.Forms.NumericUpDown numericUpDown_SampleRate;
        private System.Windows.Forms.GroupBox groupBox_GenParamAO;
        private System.Windows.Forms.ComboBox comboBox_rangeLimitAO;
        private System.Windows.Forms.Label label_RangeHigh;
        private System.Windows.Forms.ComboBox comboBox_ChanNoAO;
        private System.Windows.Forms.ComboBox comboBox_boardNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown_UpdateRate;
        private System.Windows.Forms.Button button_stopAIO;
        private System.Windows.Forms.Button button_startAIO;
        private System.Windows.Forms.Timer timer_AIOFetchData;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox_GenparamDO;
        private System.Windows.Forms.GroupBox groupBox_GenparamDI;
        private System.Windows.Forms.Button button_stopDIO;
        private System.Windows.Forms.Button button_startDIO;
        private System.Windows.Forms.GroupBox groupBoxDI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxDO;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button AllHigh;
        private System.Windows.Forms.Button AllLow;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button_stopCIO;
        private System.Windows.Forms.GroupBox groupBox_genParaCI;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox_counterNumberCI;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_measureType;
        private System.Windows.Forms.Button button_startCIO;
        private System.Windows.Forms.GroupBox groupBox_genParaCO;
        private System.Windows.Forms.NumericUpDown numericUpDown_frequency;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_HighLevel;
        private System.Windows.Forms.ComboBox comboBox_counterNumberCO;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Timer timer_DIOFetchData;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private SeeSharpTools.JY.GUI.EasyChartX easyChartX1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private SeeSharpTools.JY.GUI.LEDArray ledArray1;
        private SeeSharpTools.JY.GUI.SwitchArray switchArray1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_CardID;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage JYJY5510_5511;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Values;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

