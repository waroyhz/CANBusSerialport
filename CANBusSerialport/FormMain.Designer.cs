namespace CANBusSerialport
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboPortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBaudrate = new System.Windows.Forms.ComboBox();
            this.buttonOpenClose = new System.Windows.Forms.Button();
            this.labelGetCount = new System.Windows.Forms.Label();
            this.labelSendCount = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txGet = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.txSend = new System.Windows.Forms.TextBox();
            this.checkBoxHexSend = new System.Windows.Forms.CheckBox();
            this.checkBoxNewlineSend = new System.Windows.Forms.CheckBox();
            this.checkBoxHexView = new System.Windows.Forms.CheckBox();
            this.checkBoxNewlineGet = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_line = new System.Windows.Forms.GroupBox();
            this.button_addMonitor = new System.Windows.Forms.Button();
            this.linePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox_newLineFor8D = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_line.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboPortName
            // 
            this.comboPortName.BackColor = System.Drawing.Color.White;
            this.comboPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPortName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboPortName.FormattingEnabled = true;
            this.comboPortName.Location = new System.Drawing.Point(73, 7);
            this.comboPortName.Name = "comboPortName";
            this.comboPortName.Size = new System.Drawing.Size(121, 20);
            this.comboPortName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "串口名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率";
            // 
            // comboBaudrate
            // 
            this.comboBaudrate.BackColor = System.Drawing.Color.White;
            this.comboBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBaudrate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBaudrate.FormattingEnabled = true;
            this.comboBaudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBaudrate.Location = new System.Drawing.Point(259, 7);
            this.comboBaudrate.Name = "comboBaudrate";
            this.comboBaudrate.Size = new System.Drawing.Size(121, 20);
            this.comboBaudrate.TabIndex = 5;
            // 
            // buttonOpenClose
            // 
            this.buttonOpenClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenClose.Font = new System.Drawing.Font("宋体", 9F);
            this.buttonOpenClose.ForeColor = System.Drawing.Color.Black;
            this.buttonOpenClose.Location = new System.Drawing.Point(400, 6);
            this.buttonOpenClose.Name = "buttonOpenClose";
            this.buttonOpenClose.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenClose.TabIndex = 0;
            this.buttonOpenClose.Text = "打开";
            this.buttonOpenClose.UseVisualStyleBackColor = true;
            this.buttonOpenClose.Click += new System.EventHandler(this.buttonOpenClose_Click);
            // 
            // labelGetCount
            // 
            this.labelGetCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGetCount.AutoSize = true;
            this.labelGetCount.Font = new System.Drawing.Font("宋体", 9F);
            this.labelGetCount.Location = new System.Drawing.Point(726, 4);
            this.labelGetCount.Name = "labelGetCount";
            this.labelGetCount.Size = new System.Drawing.Size(35, 12);
            this.labelGetCount.TabIndex = 9;
            this.labelGetCount.Text = "Get:0";
            // 
            // labelSendCount
            // 
            this.labelSendCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSendCount.AutoSize = true;
            this.labelSendCount.Font = new System.Drawing.Font("宋体", 9F);
            this.labelSendCount.Location = new System.Drawing.Point(731, -1);
            this.labelSendCount.Name = "labelSendCount";
            this.labelSendCount.Size = new System.Drawing.Size(41, 12);
            this.labelSendCount.TabIndex = 13;
            this.labelSendCount.Text = "Send:0";
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset.Font = new System.Drawing.Font("宋体", 9F);
            this.buttonReset.ForeColor = System.Drawing.Color.Black;
            this.buttonReset.Location = new System.Drawing.Point(481, 6);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "复位";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox_newLineFor8D);
            this.groupBox1.Controls.Add(this.txGet);
            this.groupBox1.Controls.Add(this.labelGetCount);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口数据                               ";
            // 
            // txGet
            // 
            this.txGet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txGet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txGet.Location = new System.Drawing.Point(7, 20);
            this.txGet.Multiline = true;
            this.txGet.Name = "txGet";
            this.txGet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txGet.Size = new System.Drawing.Size(795, 124);
            this.txGet.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonSend);
            this.groupBox2.Controls.Add(this.labelSendCount);
            this.groupBox2.Controls.Add(this.txSend);
            this.groupBox2.Location = new System.Drawing.Point(5, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 54);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送数据                          ";
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSend.Font = new System.Drawing.Font("宋体", 9F);
            this.buttonSend.ForeColor = System.Drawing.Color.Black;
            this.buttonSend.Location = new System.Drawing.Point(718, 20);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "发送";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // txSend
            // 
            this.txSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txSend.Location = new System.Drawing.Point(6, 22);
            this.txSend.Name = "txSend";
            this.txSend.Size = new System.Drawing.Size(706, 21);
            this.txSend.TabIndex = 1;
            // 
            // checkBoxHexSend
            // 
            this.checkBoxHexSend.AutoSize = true;
            this.checkBoxHexSend.Location = new System.Drawing.Point(74, 10);
            this.checkBoxHexSend.Name = "checkBoxHexSend";
            this.checkBoxHexSend.Size = new System.Drawing.Size(60, 16);
            this.checkBoxHexSend.TabIndex = 11;
            this.checkBoxHexSend.Text = "16进制";
            this.checkBoxHexSend.UseVisualStyleBackColor = true;
            // 
            // checkBoxNewlineSend
            // 
            this.checkBoxNewlineSend.AutoSize = true;
            this.checkBoxNewlineSend.Location = new System.Drawing.Point(141, 10);
            this.checkBoxNewlineSend.Name = "checkBoxNewlineSend";
            this.checkBoxNewlineSend.Size = new System.Drawing.Size(72, 16);
            this.checkBoxNewlineSend.TabIndex = 12;
            this.checkBoxNewlineSend.Text = "发送换行";
            this.checkBoxNewlineSend.UseVisualStyleBackColor = true;
            // 
            // checkBoxHexView
            // 
            this.checkBoxHexView.AutoSize = true;
            this.checkBoxHexView.Location = new System.Drawing.Point(74, 5);
            this.checkBoxHexView.Name = "checkBoxHexView";
            this.checkBoxHexView.Size = new System.Drawing.Size(84, 16);
            this.checkBoxHexView.TabIndex = 7;
            this.checkBoxHexView.Text = "16进制显示";
            this.checkBoxHexView.UseVisualStyleBackColor = true;
            // 
            // checkBoxNewlineGet
            // 
            this.checkBoxNewlineGet.AutoSize = true;
            this.checkBoxNewlineGet.Location = new System.Drawing.Point(163, 5);
            this.checkBoxNewlineGet.Name = "checkBoxNewlineGet";
            this.checkBoxNewlineGet.Size = new System.Drawing.Size(72, 16);
            this.checkBoxNewlineGet.TabIndex = 8;
            this.checkBoxNewlineGet.Text = "自动换行";
            this.checkBoxNewlineGet.UseVisualStyleBackColor = true;
            this.checkBoxNewlineGet.CheckedChanged += new System.EventHandler(this.checkBoxNewlineGet_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxNewlineGet);
            this.panel1.Controls.Add(this.checkBoxHexView);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 158);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboPortName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBaudrate);
            this.panel2.Controls.Add(this.buttonOpenClose);
            this.panel2.Controls.Add(this.buttonReset);
            this.panel2.Location = new System.Drawing.Point(4, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 36);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.checkBoxHexSend);
            this.panel3.Controls.Add(this.checkBoxNewlineSend);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(4, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(814, 71);
            this.panel3.TabIndex = 16;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(4, 55);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_line);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(816, 324);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 17;
            // 
            // groupBox_line
            // 
            this.groupBox_line.Controls.Add(this.button_addMonitor);
            this.groupBox_line.Controls.Add(this.linePanel);
            this.groupBox_line.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_line.Location = new System.Drawing.Point(0, 0);
            this.groupBox_line.Name = "groupBox_line";
            this.groupBox_line.Size = new System.Drawing.Size(816, 162);
            this.groupBox_line.TabIndex = 0;
            this.groupBox_line.TabStop = false;
            this.groupBox_line.Text = "监听区                     ";
            // 
            // button_addMonitor
            // 
            this.button_addMonitor.Location = new System.Drawing.Point(54, -1);
            this.button_addMonitor.Name = "button_addMonitor";
            this.button_addMonitor.Size = new System.Drawing.Size(103, 20);
            this.button_addMonitor.TabIndex = 1;
            this.button_addMonitor.Text = "添加一个监听";
            this.button_addMonitor.UseVisualStyleBackColor = true;
            this.button_addMonitor.Click += new System.EventHandler(this.button_addMonitor_Click);
            // 
            // linePanel
            // 
            this.linePanel.AutoScroll = true;
            this.linePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linePanel.Location = new System.Drawing.Point(3, 17);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(810, 142);
            this.linePanel.TabIndex = 0;
            // 
            // checkBox_newLineFor8D
            // 
            this.checkBox_newLineFor8D.AutoSize = true;
            this.checkBox_newLineFor8D.Location = new System.Drawing.Point(236, 0);
            this.checkBox_newLineFor8D.Name = "checkBox_newLineFor8D";
            this.checkBox_newLineFor8D.Size = new System.Drawing.Size(60, 16);
            this.checkBox_newLineFor8D.TabIndex = 9;
            this.checkBox_newLineFor8D.Text = "8D换行";
            this.checkBox_newLineFor8D.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 468);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "FormMain";
            this.Text = "Serial tool CANBus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_line.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBaudrate;
        private System.Windows.Forms.Button buttonOpenClose;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelSendCount;
        private System.Windows.Forms.Label labelGetCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txGet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxNewlineSend;
        private System.Windows.Forms.CheckBox checkBoxHexSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox txSend;
        private System.Windows.Forms.CheckBox checkBoxHexView;
        private System.Windows.Forms.CheckBox checkBoxNewlineGet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_addMonitor;
        public System.Windows.Forms.GroupBox groupBox_line;
        public System.Windows.Forms.FlowLayoutPanel linePanel;
        private System.Windows.Forms.CheckBox checkBox_newLineFor8D;
    }
}

