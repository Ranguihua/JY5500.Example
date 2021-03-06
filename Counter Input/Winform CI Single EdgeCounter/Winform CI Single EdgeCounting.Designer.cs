namespace Winform_CI_Single_EdgeCounter
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_genPara = new System.Windows.Forms.GroupBox();
            this.numericUpDown_initCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_cardID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_countDIR = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_SoltNumber = new System.Windows.Forms.ComboBox();
            this.comboBox_counterNumber = new System.Windows.Forms.ComboBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.timer_FetchData = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox_countResult = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_countValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.JYJY5510_5511 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox_genPara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_initCount)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.groupBox_countResult.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.JYJY5510_5511.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(756, 80);
            this.splitter1.TabIndex = 82;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("宋体", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 31);
            this.label1.TabIndex = 83;
            this.label1.Text = "PCIe/PXIe 5500 Series Single EdgeCounting";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_genPara
            // 
            this.groupBox_genPara.Controls.Add(this.numericUpDown_initCount);
            this.groupBox_genPara.Controls.Add(this.label3);
            this.groupBox_genPara.Controls.Add(this.label4);
            this.groupBox_genPara.Controls.Add(this.comboBox_cardID);
            this.groupBox_genPara.Controls.Add(this.label2);
            this.groupBox_genPara.Controls.Add(this.comboBox_countDIR);
            this.groupBox_genPara.Controls.Add(this.label7);
            this.groupBox_genPara.Controls.Add(this.label5);
            this.groupBox_genPara.Controls.Add(this.comboBox_SoltNumber);
            this.groupBox_genPara.Controls.Add(this.comboBox_counterNumber);
            this.groupBox_genPara.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_genPara.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_genPara.Location = new System.Drawing.Point(0, 0);
            this.groupBox_genPara.Name = "groupBox_genPara";
            this.groupBox_genPara.Size = new System.Drawing.Size(358, 131);
            this.groupBox_genPara.TabIndex = 84;
            this.groupBox_genPara.TabStop = false;
            this.groupBox_genPara.Text = "Basic Param Configuration";
            // 
            // numericUpDown_initCount
            // 
            this.numericUpDown_initCount.Location = new System.Drawing.Point(185, 97);
            this.numericUpDown_initCount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_initCount.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.numericUpDown_initCount.Name = "numericUpDown_initCount";
            this.numericUpDown_initCount.Size = new System.Drawing.Size(119, 23);
            this.numericUpDown_initCount.TabIndex = 161;
            this.numericUpDown_initCount.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(184, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 160;
            this.label3.Text = "Init Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(17, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 159;
            this.label4.Text = "Card ID";
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
            this.comboBox_cardID.Location = new System.Drawing.Point(18, 48);
            this.comboBox_cardID.Name = "comboBox_cardID";
            this.comboBox_cardID.Size = new System.Drawing.Size(86, 22);
            this.comboBox_cardID.TabIndex = 158;
            this.comboBox_cardID.Tag = "ParaConfig";
            this.comboBox_cardID.SelectedIndexChanged += new System.EventHandler(this.comboBox_cardID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(224, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 68;
            this.label2.Text = "Counter ID";
            // 
            // comboBox_countDIR
            // 
            this.comboBox_countDIR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_countDIR.FormattingEnabled = true;
            this.comboBox_countDIR.Location = new System.Drawing.Point(20, 98);
            this.comboBox_countDIR.Name = "comboBox_countDIR";
            this.comboBox_countDIR.Size = new System.Drawing.Size(117, 22);
            this.comboBox_countDIR.TabIndex = 73;
            this.comboBox_countDIR.Tag = "ParaConfig";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(120, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 14);
            this.label7.TabIndex = 66;
            this.label7.Text = "Slot Number ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 14);
            this.label5.TabIndex = 74;
            this.label5.Text = "Counter Direction";
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
            this.comboBox_SoltNumber.Location = new System.Drawing.Point(123, 48);
            this.comboBox_SoltNumber.Name = "comboBox_SoltNumber";
            this.comboBox_SoltNumber.Size = new System.Drawing.Size(86, 22);
            this.comboBox_SoltNumber.TabIndex = 65;
            this.comboBox_SoltNumber.Tag = "ParaConfig";
            // 
            // comboBox_counterNumber
            // 
            this.comboBox_counterNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_counterNumber.FormattingEnabled = true;
            this.comboBox_counterNumber.Location = new System.Drawing.Point(227, 48);
            this.comboBox_counterNumber.Name = "comboBox_counterNumber";
            this.comboBox_counterNumber.Size = new System.Drawing.Size(87, 22);
            this.comboBox_counterNumber.TabIndex = 67;
            this.comboBox_counterNumber.Tag = "ParaConfig";
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Start.Location = new System.Drawing.Point(65, 26);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(72, 29);
            this.button_Start.TabIndex = 87;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click_1);
            // 
            // button_stop
            // 
            this.button_stop.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_stop.Location = new System.Drawing.Point(185, 26);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 29);
            this.button_stop.TabIndex = 89;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // timer_FetchData
            // 
            this.timer_FetchData.Tick += new System.EventHandler(this.timer_FetchData_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 281);
            this.panel1.TabIndex = 106;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(756, 281);
            this.splitContainer1.SplitterDistance = 358;
            this.splitContainer1.TabIndex = 126;
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
            this.splitContainer2.Size = new System.Drawing.Size(358, 281);
            this.splitContainer2.SplitterDistance = 131;
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
            this.splitContainer3.Panel1.Controls.Add(this.groupBox_countResult);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer3.Size = new System.Drawing.Size(358, 146);
            this.splitContainer3.SplitterDistance = 75;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox_countResult
            // 
            this.groupBox_countResult.Controls.Add(this.label6);
            this.groupBox_countResult.Controls.Add(this.textBox_countValue);
            this.groupBox_countResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_countResult.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_countResult.Location = new System.Drawing.Point(0, 0);
            this.groupBox_countResult.Name = "groupBox_countResult";
            this.groupBox_countResult.Size = new System.Drawing.Size(358, 75);
            this.groupBox_countResult.TabIndex = 87;
            this.groupBox_countResult.TabStop = false;
            this.groupBox_countResult.Text = "Count Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(23, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 14);
            this.label6.TabIndex = 79;
            this.label6.Text = "Counter Value";
            // 
            // textBox_countValue
            // 
            this.textBox_countValue.Location = new System.Drawing.Point(150, 22);
            this.textBox_countValue.Name = "textBox_countValue";
            this.textBox_countValue.Size = new System.Drawing.Size(117, 23);
            this.textBox_countValue.TabIndex = 78;
            this.textBox_countValue.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_stop);
            this.groupBox1.Controls.Add(this.button_Start);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 67);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.JYJY5510_5511);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(394, 281);
            this.tabControl1.TabIndex = 123;
            // 
            // JYJY5510_5511
            // 
            this.JYJY5510_5511.Controls.Add(this.pictureBox1);
            this.JYJY5510_5511.Location = new System.Drawing.Point(4, 22);
            this.JYJY5510_5511.Name = "JYJY5510_5511";
            this.JYJY5510_5511.Padding = new System.Windows.Forms.Padding(3);
            this.JYJY5510_5511.Size = new System.Drawing.Size(386, 255);
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
            this.pictureBox1.Size = new System.Drawing.Size(380, 249);
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
            this.tabPage2.Size = new System.Drawing.Size(386, 255);
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
            this.pictureBox2.Size = new System.Drawing.Size(380, 249);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 109;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCIe/PXIe 5500 Series Single Mode EdgeCounting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox_genPara.ResumeLayout(false);
            this.groupBox_genPara.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_initCount)).EndInit();
            this.panel1.ResumeLayout(false);
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
            this.groupBox_countResult.ResumeLayout(false);
            this.groupBox_countResult.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.JYJY5510_5511.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       //private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_genPara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_countDIR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_SoltNumber;
        private System.Windows.Forms.ComboBox comboBox_counterNumber;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Timer timer_FetchData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_cardID;
        private System.Windows.Forms.GroupBox groupBox_countResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_countValue;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage JYJY5510_5511;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown_initCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

