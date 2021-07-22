﻿namespace Winform_DO_ContinuousNoWrapping_Write_Digital_Trigger
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
            this.comboBox_SoltNumber = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_SampleRate = new System.Windows.Forms.Label();
            this.numericUpDown_updateRate = new System.Windows.Forms.NumericUpDown();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label6 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.groupBox_genParam = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_cardID = new System.Windows.Forms.ComboBox();
            this.button_stop = new System.Windows.Forms.Button();
            this.timer_FetchData = new System.Windows.Forms.Timer(this.components);
            this.groupBox_TrigParam = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_triggerSource = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_triggerEdge = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_Port3 = new System.Windows.Forms.CheckBox();
            this.checkBox_Port2 = new System.Windows.Forms.CheckBox();
            this.checkBox_Port1 = new System.Windows.Forms.CheckBox();
            this.checkBox_Port0 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_port3_Frequency = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_port2_Frequency = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_port1_Frequency = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_port3_duty = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_port2_duty = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_port1_duty = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_port0_duty = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_port0_Frequency = new System.Windows.Forms.NumericUpDown();
            this.easyChartX1 = new SeeSharpTools.JY.GUI.EasyChartX();
            this.button_Update = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_updateRate)).BeginInit();
            this.groupBox_genParam.SuspendLayout();
            this.groupBox_TrigParam.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port3_Frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port2_Frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port1_Frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port3_duty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port2_duty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port1_duty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port0_duty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port0_Frequency)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.comboBox_SoltNumber.Location = new System.Drawing.Point(133, 37);
            this.comboBox_SoltNumber.Name = "comboBox_SoltNumber";
            this.comboBox_SoltNumber.Size = new System.Drawing.Size(73, 22);
            this.comboBox_SoltNumber.TabIndex = 63;
            this.comboBox_SoltNumber.Tag = "ParaConfig";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(133, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 14);
            this.label7.TabIndex = 64;
            this.label7.Text = "Slot Number ";
            // 
            // label_SampleRate
            // 
            this.label_SampleRate.AutoSize = true;
            this.label_SampleRate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SampleRate.Location = new System.Drawing.Point(257, 18);
            this.label_SampleRate.Name = "label_SampleRate";
            this.label_SampleRate.Size = new System.Drawing.Size(133, 14);
            this.label_SampleRate.TabIndex = 1;
            this.label_SampleRate.Text = "Update Rate(Sa/s) ";
            // 
            // numericUpDown_updateRate
            // 
            this.numericUpDown_updateRate.Location = new System.Drawing.Point(257, 35);
            this.numericUpDown_updateRate.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_updateRate.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_updateRate.Name = "numericUpDown_updateRate";
            this.numericUpDown_updateRate.Size = new System.Drawing.Size(106, 23);
            this.numericUpDown_updateRate.TabIndex = 5;
            this.numericUpDown_updateRate.Tag = "ParaConfig";
            this.numericUpDown_updateRate.ThousandsSeparator = true;
            this.numericUpDown_updateRate.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1240, 80);
            this.splitter1.TabIndex = 105;
            this.splitter1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label6.Font = new System.Drawing.Font("宋体", 23F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(654, 31);
            this.label6.TabIndex = 104;
            this.label6.Text = "JYUSB61902Single Channel 有限点 output";
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_start.Location = new System.Drawing.Point(40, 351);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(111, 30);
            this.button_start.TabIndex = 103;
            this.button_start.Tag = "ParaConfig";
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // groupBox_genParam
            // 
            this.groupBox_genParam.Controls.Add(this.label9);
            this.groupBox_genParam.Controls.Add(this.comboBox_cardID);
            this.groupBox_genParam.Controls.Add(this.comboBox_SoltNumber);
            this.groupBox_genParam.Controls.Add(this.label7);
            this.groupBox_genParam.Controls.Add(this.label_SampleRate);
            this.groupBox_genParam.Controls.Add(this.numericUpDown_updateRate);
            this.groupBox_genParam.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_genParam.Location = new System.Drawing.Point(26, 16);
            this.groupBox_genParam.Name = "groupBox_genParam";
            this.groupBox_genParam.Size = new System.Drawing.Size(416, 66);
            this.groupBox_genParam.TabIndex = 102;
            this.groupBox_genParam.TabStop = false;
            this.groupBox_genParam.Text = "Basic Param Configuration";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(16, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 14);
            this.label9.TabIndex = 91;
            this.label9.Text = "Card ID";
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
            this.comboBox_cardID.Location = new System.Drawing.Point(16, 38);
            this.comboBox_cardID.Name = "comboBox_cardID";
            this.comboBox_cardID.Size = new System.Drawing.Size(73, 22);
            this.comboBox_cardID.TabIndex = 90;
            this.comboBox_cardID.Tag = "ParaConfig";
            this.comboBox_cardID.SelectedIndexChanged += new System.EventHandler(this.comboBox_cardID_SelectedIndexChanged);
            // 
            // button_stop
            // 
            this.button_stop.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_stop.Location = new System.Drawing.Point(296, 351);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(115, 30);
            this.button_stop.TabIndex = 107;
            this.button_stop.Tag = "ParaConfig";
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // timer_FetchData
            // 
            this.timer_FetchData.Tick += new System.EventHandler(this.timer_FetchData_Tick);
            // 
            // groupBox_TrigParam
            // 
            this.groupBox_TrigParam.Controls.Add(this.label3);
            this.groupBox_TrigParam.Controls.Add(this.comboBox_triggerSource);
            this.groupBox_TrigParam.Controls.Add(this.label5);
            this.groupBox_TrigParam.Controls.Add(this.comboBox_triggerEdge);
            this.groupBox_TrigParam.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_TrigParam.Location = new System.Drawing.Point(26, 88);
            this.groupBox_TrigParam.Name = "groupBox_TrigParam";
            this.groupBox_TrigParam.Size = new System.Drawing.Size(416, 73);
            this.groupBox_TrigParam.TabIndex = 115;
            this.groupBox_TrigParam.TabStop = false;
            this.groupBox_TrigParam.Text = "Trigger Param Configuration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(8, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 53;
            this.label3.Text = "Trigger Source";
            // 
            // comboBox_triggerSource
            // 
            this.comboBox_triggerSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_triggerSource.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_triggerSource.FormattingEnabled = true;
            this.comboBox_triggerSource.Location = new System.Drawing.Point(133, 13);
            this.comboBox_triggerSource.Name = "comboBox_triggerSource";
            this.comboBox_triggerSource.Size = new System.Drawing.Size(123, 20);
            this.comboBox_triggerSource.TabIndex = 8;
            this.comboBox_triggerSource.Tag = "ParaConfig";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 55;
            this.label5.Text = "Trigger Edge";
            // 
            // comboBox_triggerEdge
            // 
            this.comboBox_triggerEdge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_triggerEdge.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_triggerEdge.FormattingEnabled = true;
            this.comboBox_triggerEdge.Location = new System.Drawing.Point(133, 44);
            this.comboBox_triggerEdge.Name = "comboBox_triggerEdge";
            this.comboBox_triggerEdge.Size = new System.Drawing.Size(123, 20);
            this.comboBox_triggerEdge.TabIndex = 9;
            this.comboBox_triggerEdge.Tag = "ParaConfig";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label2.Font = new System.Drawing.Font("宋体", 23F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(124, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(986, 31);
            this.label2.TabIndex = 116;
            this.label2.Text = "PCIe/PXIe 5500 Series Continuous NoWrapping";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("宋体", 23F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1045, 42);
            this.label1.TabIndex = 117;
            this.label1.Text = "Digital Signal Output(Digital Trigger)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_Port3);
            this.groupBox1.Controls.Add(this.checkBox_Port2);
            this.groupBox1.Controls.Add(this.checkBox_Port1);
            this.groupBox1.Controls.Add(this.checkBox_Port0);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericUpDown_port3_Frequency);
            this.groupBox1.Controls.Add(this.numericUpDown_port2_Frequency);
            this.groupBox1.Controls.Add(this.numericUpDown_port1_Frequency);
            this.groupBox1.Controls.Add(this.numericUpDown_port3_duty);
            this.groupBox1.Controls.Add(this.numericUpDown_port2_duty);
            this.groupBox1.Controls.Add(this.numericUpDown_port1_duty);
            this.groupBox1.Controls.Add(this.numericUpDown_port0_duty);
            this.groupBox1.Controls.Add(this.numericUpDown_port0_Frequency);
            this.groupBox1.Location = new System.Drawing.Point(26, 166);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(416, 166);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Channel Configuration";
            // 
            // checkBox_Port3
            // 
            this.checkBox_Port3.AutoSize = true;
            this.checkBox_Port3.Location = new System.Drawing.Point(4, 137);
            this.checkBox_Port3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Port3.Name = "checkBox_Port3";
            this.checkBox_Port3.Size = new System.Drawing.Size(54, 16);
            this.checkBox_Port3.TabIndex = 103;
            this.checkBox_Port3.Text = "Port3";
            this.checkBox_Port3.UseVisualStyleBackColor = true;
            // 
            // checkBox_Port2
            // 
            this.checkBox_Port2.AutoSize = true;
            this.checkBox_Port2.Location = new System.Drawing.Point(4, 106);
            this.checkBox_Port2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Port2.Name = "checkBox_Port2";
            this.checkBox_Port2.Size = new System.Drawing.Size(54, 16);
            this.checkBox_Port2.TabIndex = 103;
            this.checkBox_Port2.Text = "Port2";
            this.checkBox_Port2.UseVisualStyleBackColor = true;
            // 
            // checkBox_Port1
            // 
            this.checkBox_Port1.AutoSize = true;
            this.checkBox_Port1.Location = new System.Drawing.Point(4, 73);
            this.checkBox_Port1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Port1.Name = "checkBox_Port1";
            this.checkBox_Port1.Size = new System.Drawing.Size(54, 16);
            this.checkBox_Port1.TabIndex = 103;
            this.checkBox_Port1.Text = "Port1";
            this.checkBox_Port1.UseVisualStyleBackColor = true;
            // 
            // checkBox_Port0
            // 
            this.checkBox_Port0.AutoSize = true;
            this.checkBox_Port0.Location = new System.Drawing.Point(4, 38);
            this.checkBox_Port0.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Port0.Name = "checkBox_Port0";
            this.checkBox_Port0.Size = new System.Drawing.Size(54, 16);
            this.checkBox_Port0.TabIndex = 103;
            this.checkBox_Port0.Text = "Port0";
            this.checkBox_Port0.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(82, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 14);
            this.label4.TabIndex = 70;
            this.label4.Text = "Signal Frequency";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(222, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 70;
            this.label8.Text = "Duty Cycle";
            // 
            // numericUpDown_port3_Frequency
            // 
            this.numericUpDown_port3_Frequency.Location = new System.Drawing.Point(84, 135);
            this.numericUpDown_port3_Frequency.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_port3_Frequency.Name = "numericUpDown_port3_Frequency";
            this.numericUpDown_port3_Frequency.Size = new System.Drawing.Size(112, 21);
            this.numericUpDown_port3_Frequency.TabIndex = 71;
            this.numericUpDown_port3_Frequency.Tag = "ParaConfig";
            this.numericUpDown_port3_Frequency.ThousandsSeparator = true;
            this.numericUpDown_port3_Frequency.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numericUpDown_port2_Frequency
            // 
            this.numericUpDown_port2_Frequency.Location = new System.Drawing.Point(84, 106);
            this.numericUpDown_port2_Frequency.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_port2_Frequency.Name = "numericUpDown_port2_Frequency";
            this.numericUpDown_port2_Frequency.Size = new System.Drawing.Size(112, 21);
            this.numericUpDown_port2_Frequency.TabIndex = 71;
            this.numericUpDown_port2_Frequency.Tag = "ParaConfig";
            this.numericUpDown_port2_Frequency.ThousandsSeparator = true;
            this.numericUpDown_port2_Frequency.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // numericUpDown_port1_Frequency
            // 
            this.numericUpDown_port1_Frequency.Location = new System.Drawing.Point(84, 72);
            this.numericUpDown_port1_Frequency.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_port1_Frequency.Name = "numericUpDown_port1_Frequency";
            this.numericUpDown_port1_Frequency.Size = new System.Drawing.Size(112, 21);
            this.numericUpDown_port1_Frequency.TabIndex = 71;
            this.numericUpDown_port1_Frequency.Tag = "ParaConfig";
            this.numericUpDown_port1_Frequency.ThousandsSeparator = true;
            this.numericUpDown_port1_Frequency.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numericUpDown_port3_duty
            // 
            this.numericUpDown_port3_duty.DecimalPlaces = 1;
            this.numericUpDown_port3_duty.Location = new System.Drawing.Point(224, 136);
            this.numericUpDown_port3_duty.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_port3_duty.Name = "numericUpDown_port3_duty";
            this.numericUpDown_port3_duty.Size = new System.Drawing.Size(112, 21);
            this.numericUpDown_port3_duty.TabIndex = 71;
            this.numericUpDown_port3_duty.Tag = "ParaConfig";
            this.numericUpDown_port3_duty.ThousandsSeparator = true;
            this.numericUpDown_port3_duty.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numericUpDown_port2_duty
            // 
            this.numericUpDown_port2_duty.DecimalPlaces = 1;
            this.numericUpDown_port2_duty.Location = new System.Drawing.Point(224, 106);
            this.numericUpDown_port2_duty.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_port2_duty.Name = "numericUpDown_port2_duty";
            this.numericUpDown_port2_duty.Size = new System.Drawing.Size(112, 21);
            this.numericUpDown_port2_duty.TabIndex = 71;
            this.numericUpDown_port2_duty.Tag = "ParaConfig";
            this.numericUpDown_port2_duty.ThousandsSeparator = true;
            this.numericUpDown_port2_duty.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numericUpDown_port1_duty
            // 
            this.numericUpDown_port1_duty.DecimalPlaces = 1;
            this.numericUpDown_port1_duty.Location = new System.Drawing.Point(224, 73);
            this.numericUpDown_port1_duty.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_port1_duty.Name = "numericUpDown_port1_duty";
            this.numericUpDown_port1_duty.Size = new System.Drawing.Size(112, 21);
            this.numericUpDown_port1_duty.TabIndex = 71;
            this.numericUpDown_port1_duty.Tag = "ParaConfig";
            this.numericUpDown_port1_duty.ThousandsSeparator = true;
            this.numericUpDown_port1_duty.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numericUpDown_port0_duty
            // 
            this.numericUpDown_port0_duty.DecimalPlaces = 1;
            this.numericUpDown_port0_duty.Location = new System.Drawing.Point(224, 38);
            this.numericUpDown_port0_duty.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_port0_duty.Name = "numericUpDown_port0_duty";
            this.numericUpDown_port0_duty.Size = new System.Drawing.Size(112, 21);
            this.numericUpDown_port0_duty.TabIndex = 71;
            this.numericUpDown_port0_duty.Tag = "ParaConfig";
            this.numericUpDown_port0_duty.ThousandsSeparator = true;
            this.numericUpDown_port0_duty.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numericUpDown_port0_Frequency
            // 
            this.numericUpDown_port0_Frequency.Location = new System.Drawing.Point(84, 38);
            this.numericUpDown_port0_Frequency.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_port0_Frequency.Name = "numericUpDown_port0_Frequency";
            this.numericUpDown_port0_Frequency.Size = new System.Drawing.Size(112, 21);
            this.numericUpDown_port0_Frequency.TabIndex = 71;
            this.numericUpDown_port0_Frequency.Tag = "ParaConfig";
            this.numericUpDown_port0_Frequency.ThousandsSeparator = true;
            this.numericUpDown_port0_Frequency.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
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
            this.easyChartX1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.easyChartX1.Location = new System.Drawing.Point(0, 0);
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
            this.easyChartX1.Size = new System.Drawing.Size(775, 389);
            this.easyChartX1.SplitView = false;
            this.easyChartX1.TabIndex = 119;
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
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Update.Location = new System.Drawing.Point(170, 351);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(112, 33);
            this.button_Update.TabIndex = 120;
            this.button_Update.Tag = "ParaConfig";
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.easyChartX1);
            this.panel1.Location = new System.Drawing.Point(3, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 389);
            this.panel1.TabIndex = 121;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox_genParam);
            this.panel2.Controls.Add(this.button_Update);
            this.panel2.Controls.Add(this.button_stop);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.button_start);
            this.panel2.Controls.Add(this.groupBox_TrigParam);
            this.panel2.Location = new System.Drawing.Point(785, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 389);
            this.panel2.TabIndex = 122;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCIe/PXIe 5500 Continuous NoWrapping Digital Signal Output（Digital Trigger）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_updateRate)).EndInit();
            this.groupBox_genParam.ResumeLayout(false);
            this.groupBox_genParam.PerformLayout();
            this.groupBox_TrigParam.ResumeLayout(false);
            this.groupBox_TrigParam.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port3_Frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port2_Frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port1_Frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port3_duty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port2_duty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port1_duty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port0_duty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port0_Frequency)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_SoltNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_SampleRate;
        private System.Windows.Forms.NumericUpDown numericUpDown_updateRate;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.GroupBox groupBox_genParam;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Timer timer_FetchData;
        private System.Windows.Forms.GroupBox groupBox_TrigParam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_triggerSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_triggerEdge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_cardID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_Port3;
        private System.Windows.Forms.CheckBox checkBox_Port2;
        private System.Windows.Forms.CheckBox checkBox_Port1;
        private System.Windows.Forms.CheckBox checkBox_Port0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_port3_Frequency;
        private System.Windows.Forms.NumericUpDown numericUpDown_port2_Frequency;
        private System.Windows.Forms.NumericUpDown numericUpDown_port1_Frequency;
        private System.Windows.Forms.NumericUpDown numericUpDown_port3_duty;
        private System.Windows.Forms.NumericUpDown numericUpDown_port2_duty;
        private System.Windows.Forms.NumericUpDown numericUpDown_port1_duty;
        private System.Windows.Forms.NumericUpDown numericUpDown_port0_duty;
        private System.Windows.Forms.NumericUpDown numericUpDown_port0_Frequency;
        private SeeSharpTools.JY.GUI.EasyChartX easyChartX1;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
