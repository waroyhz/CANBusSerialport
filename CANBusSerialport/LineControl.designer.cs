namespace UserControl
{
    partial class LineControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_dataID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_data = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_data2 = new System.Windows.Forms.Label();
            this.button_remove = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_dataID
            // 
            this.textBox_dataID.Location = new System.Drawing.Point(60, 3);
            this.textBox_dataID.Name = "textBox_dataID";
            this.textBox_dataID.Size = new System.Drawing.Size(100, 21);
            this.textBox_dataID.TabIndex = 0;
            this.textBox_dataID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_dataID_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "锁定ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据区：";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.textBox_dataID);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label_data);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.label_data2);
            this.flowLayoutPanel1.Controls.Add(this.button_remove);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1137, 27);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Location = new System.Drawing.Point(235, 0);
            this.label_data.Name = "label_data";
            this.label_data.Padding = new System.Windows.Forms.Padding(5);
            this.label_data.Size = new System.Drawing.Size(10, 22);
            this.label_data.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "  数据分析结果：";
            // 
            // label_data2
            // 
            this.label_data2.AutoSize = true;
            this.label_data2.Location = new System.Drawing.Point(368, 0);
            this.label_data2.Name = "label_data2";
            this.label_data2.Padding = new System.Windows.Forms.Padding(5);
            this.label_data2.Size = new System.Drawing.Size(51, 22);
            this.label_data2.TabIndex = 3;
            this.label_data2.Text = "      ";
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(425, 3);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(25, 23);
            this.button_remove.TabIndex = 4;
            this.button_remove.Text = "X";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // LineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "LineControl";
            this.Size = new System.Drawing.Size(1137, 27);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_dataID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_data2;
        private System.Windows.Forms.Button button_remove;
    }
}
