namespace Winform_CI_Finite_PulseMeasure_Digital_Trigger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_stop = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.timer_FetchData = new System.Windows.Forms.Timer(this.components);
            this.button_start = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_Values = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_TrigParam = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_triggerSource = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_triggerEdge = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.JYJY5510_5511 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox_genPara = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_cardID = new System.Windows.Forms.ComboBox();
            this.numericUpDown_samples = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_sampleRate = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_SampleClockSource = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_SoltNumber = new System.Windows.Forms.ComboBox();
            this.comboBox_counterNumber = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_TrigParam.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.JYJY5510_5511.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox_genPara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_samples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            // button_stop
            // 
            this.button_stop.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_stop.Location = new System.Drawing.Point(15, 52);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 32);
            this.button_stop.TabIndex = 130;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoEllipsis = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label9.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(27, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(801, 24);
            this.label9.TabIndex = 129;
            this.label9.Text = "PCIe/PXIe 5500 Series Finite Pulse Measure（Digital Trigger）";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(840, 80);
            this.splitter1.TabIndex = 127;
            this.splitter1.TabStop = false;
            // 
            // timer_FetchData
            // 
            this.timer_FetchData.Tick += new System.EventHandler(this.time_FetchData_Tick);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_start.Location = new System.Drawing.Point(15, 14);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 32);
            this.button_start.TabIndex = 126;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Values,
            this.Column1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(462, 513);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column_Values
            // 
            this.Column_Values.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Values.HeaderText = "High Pulse Measurea(S)";
            this.Column_Values.MinimumWidth = 225;
            this.Column_Values.Name = "Column_Values";
            this.Column_Values.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Low Pulse Measurea(S)";
            this.Column1.MinimumWidth = 225;
            this.Column1.Name = "Column1";
            // 
            // groupBox_TrigParam
            // 
            this.groupBox_TrigParam.Controls.Add(this.label1);
            this.groupBox_TrigParam.Controls.Add(this.comboBox_triggerSource);
            this.groupBox_TrigParam.Controls.Add(this.label3);
            this.groupBox_TrigParam.Controls.Add(this.comboBox_triggerEdge);
            this.groupBox_TrigParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_TrigParam.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_TrigParam.Location = new System.Drawing.Point(0, 0);
            this.groupBox_TrigParam.Name = "groupBox_TrigParam";
            this.groupBox_TrigParam.Size = new System.Drawing.Size(260, 94);
            this.groupBox_TrigParam.TabIndex = 139;
            this.groupBox_TrigParam.TabStop = false;
            this.groupBox_TrigParam.Text = "Trigger Param Configuration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 53;
            this.label1.Text = "Trigger Source";
            // 
            // comboBox_triggerSource
            // 
            this.comboBox_triggerSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_triggerSource.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_triggerSource.FormattingEnabled = true;
            this.comboBox_triggerSource.Location = new System.Drawing.Point(109, 24);
            this.comboBox_triggerSource.Name = "comboBox_triggerSource";
            this.comboBox_triggerSource.Size = new System.Drawing.Size(137, 20);
            this.comboBox_triggerSource.TabIndex = 8;
            this.comboBox_triggerSource.Tag = "ParaConfig";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 55;
            this.label3.Text = "Trigger Edge";
            // 
            // comboBox_triggerEdge
            // 
            this.comboBox_triggerEdge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_triggerEdge.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_triggerEdge.FormattingEnabled = true;
            this.comboBox_triggerEdge.Location = new System.Drawing.Point(109, 58);
            this.comboBox_triggerEdge.Name = "comboBox_triggerEdge";
            this.comboBox_triggerEdge.Size = new System.Drawing.Size(137, 20);
            this.comboBox_triggerEdge.TabIndex = 9;
            this.comboBox_triggerEdge.Tag = "ParaConfig";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.JYJY5510_5511);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(374, 251);
            this.tabControl1.TabIndex = 144;
            // 
            // JYJY5510_5511
            // 
            this.JYJY5510_5511.Controls.Add(this.pictureBox1);
            this.JYJY5510_5511.Location = new System.Drawing.Point(4, 22);
            this.JYJY5510_5511.Name = "JYJY5510_5511";
            this.JYJY5510_5511.Padding = new System.Windows.Forms.Padding(3);
            this.JYJY5510_5511.Size = new System.Drawing.Size(366, 225);
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
            this.pictureBox1.Size = new System.Drawing.Size(360, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(366, 225);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "5515_5516";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 219);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 109;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox_genPara
            // 
            this.groupBox_genPara.Controls.Add(this.label2);
            this.groupBox_genPara.Controls.Add(this.comboBox_cardID);
            this.groupBox_genPara.Controls.Add(this.numericUpDown_samples);
            this.groupBox_genPara.Controls.Add(this.label6);
            this.groupBox_genPara.Controls.Add(this.numericUpDown_sampleRate);
            this.groupBox_genPara.Controls.Add(this.label10);
            this.groupBox_genPara.Controls.Add(this.comboBox_SampleClockSource);
            this.groupBox_genPara.Controls.Add(this.label11);
            this.groupBox_genPara.Controls.Add(this.textBox2);
            this.groupBox_genPara.Controls.Add(this.label12);
            this.groupBox_genPara.Controls.Add(this.label13);
            this.groupBox_genPara.Controls.Add(this.comboBox_SoltNumber);
            this.groupBox_genPara.Controls.Add(this.comboBox_counterNumber);
            this.groupBox_genPara.Controls.Add(this.label14);
            this.groupBox_genPara.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_genPara.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_genPara.Location = new System.Drawing.Point(0, 0);
            this.groupBox_genPara.Name = "groupBox_genPara";
            this.groupBox_genPara.Size = new System.Drawing.Size(374, 160);
            this.groupBox_genPara.TabIndex = 132;
            this.groupBox_genPara.TabStop = false;
            this.groupBox_genPara.Text = "Basic Param Configuration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 129;
            this.label2.Text = "Card ID";
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
            this.comboBox_cardID.Location = new System.Drawing.Point(105, 25);
            this.comboBox_cardID.Name = "comboBox_cardID";
            this.comboBox_cardID.Size = new System.Drawing.Size(120, 22);
            this.comboBox_cardID.TabIndex = 128;
            this.comboBox_cardID.Tag = "ParaConfig";
            this.comboBox_cardID.SelectedIndexChanged += new System.EventHandler(this.comboBox_cardID_SelectedIndexChanged_1);
            // 
            // numericUpDown_samples
            // 
            this.numericUpDown_samples.Location = new System.Drawing.Point(241, 129);
            this.numericUpDown_samples.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_samples.Name = "numericUpDown_samples";
            this.numericUpDown_samples.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_samples.TabIndex = 77;
            this.numericUpDown_samples.ThousandsSeparator = true;
            this.numericUpDown_samples.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 14);
            this.label6.TabIndex = 76;
            this.label6.Text = "Samples to Acquire";
            // 
            // numericUpDown_sampleRate
            // 
            this.numericUpDown_sampleRate.Location = new System.Drawing.Point(241, 82);
            this.numericUpDown_sampleRate.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.Name = "numericUpDown_sampleRate";
            this.numericUpDown_sampleRate.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_sampleRate.TabIndex = 75;
            this.numericUpDown_sampleRate.ThousandsSeparator = true;
            this.numericUpDown_sampleRate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 14);
            this.label10.TabIndex = 74;
            this.label10.Text = "Sample Rate";
            // 
            // comboBox_SampleClockSource
            // 
            this.comboBox_SampleClockSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SampleClockSource.FormattingEnabled = true;
            this.comboBox_SampleClockSource.Location = new System.Drawing.Point(241, 36);
            this.comboBox_SampleClockSource.Name = "comboBox_SampleClockSource";
            this.comboBox_SampleClockSource.Size = new System.Drawing.Size(121, 22);
            this.comboBox_SampleClockSource.TabIndex = 73;
            this.comboBox_SampleClockSource.Tag = "ParaConfig";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(241, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 14);
            this.label11.TabIndex = 72;
            this.label11.Text = "Clock Source";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 23);
            this.textBox2.TabIndex = 71;
            this.textBox2.Text = "PulseMeasure";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(6, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 14);
            this.label12.TabIndex = 68;
            this.label12.Text = "Counter ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(6, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 14);
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
            this.comboBox_SoltNumber.Location = new System.Drawing.Point(105, 58);
            this.comboBox_SoltNumber.Name = "comboBox_SoltNumber";
            this.comboBox_SoltNumber.Size = new System.Drawing.Size(120, 22);
            this.comboBox_SoltNumber.TabIndex = 65;
            this.comboBox_SoltNumber.Tag = "ParaConfig";
            // 
            // comboBox_counterNumber
            // 
            this.comboBox_counterNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_counterNumber.FormattingEnabled = true;
            this.comboBox_counterNumber.Location = new System.Drawing.Point(105, 94);
            this.comboBox_counterNumber.Name = "comboBox_counterNumber";
            this.comboBox_counterNumber.Size = new System.Drawing.Size(120, 22);
            this.comboBox_counterNumber.TabIndex = 67;
            this.comboBox_counterNumber.Tag = "ParaConfig";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(6, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 14);
            this.label14.TabIndex = 70;
            this.label14.Text = "Measure Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_stop);
            this.groupBox1.Controls.Add(this.button_start);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 94);
            this.groupBox1.TabIndex = 146;
            this.groupBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 80);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(840, 513);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.TabIndex = 147;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox_genPara);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(374, 513);
            this.splitContainer2.SplitterDistance = 160;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer3.Size = new System.Drawing.Size(374, 349);
            this.splitContainer3.SplitterDistance = 94;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupBox_TrigParam);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer4.Size = new System.Drawing.Size(374, 94);
            this.splitContainer4.SplitterDistance = 260;
            this.splitContainer4.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 593);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCIe/PXIe 5500 Series Finite Mode Pulse Measure（Digital Trigger）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_TrigParam.ResumeLayout(false);
            this.groupBox_TrigParam.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.JYJY5510_5511.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox_genPara.ResumeLayout(false);
            this.groupBox_genPara.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_samples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Timer timer_FetchData;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.GroupBox groupBox_TrigParam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_triggerSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_triggerEdge;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage JYJY5510_5511;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox_genPara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_cardID;
        private System.Windows.Forms.NumericUpDown numericUpDown_samples;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_sampleRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_SampleClockSource;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_SoltNumber;
        private System.Windows.Forms.ComboBox comboBox_counterNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Values;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

