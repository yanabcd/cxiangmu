namespace 项目学生成绩统计程序
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtmark = new System.Windows.Forms.TextBox();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.txtsum = new System.Windows.Forms.TextBox();
            this.txtave = new System.Windows.Forms.TextBox();
            this.txtshow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "成绩";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "人数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "总分";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "平均";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "统计";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(177, 62);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(84, 21);
            this.txtno.TabIndex = 6;
            // 
            // txtmark
            // 
            this.txtmark.Location = new System.Drawing.Point(620, 50);
            this.txtmark.Name = "txtmark";
            this.txtmark.Size = new System.Drawing.Size(70, 21);
            this.txtmark.TabIndex = 7;
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(660, 162);
            this.txtcount.Name = "txtcount";
            this.txtcount.ReadOnly = true;
            this.txtcount.Size = new System.Drawing.Size(103, 21);
            this.txtcount.TabIndex = 8;
            this.txtcount.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtsum
            // 
            this.txtsum.Location = new System.Drawing.Point(660, 212);
            this.txtsum.Name = "txtsum";
            this.txtsum.ReadOnly = true;
            this.txtsum.Size = new System.Drawing.Size(103, 21);
            this.txtsum.TabIndex = 9;
            // 
            // txtave
            // 
            this.txtave.Location = new System.Drawing.Point(660, 271);
            this.txtave.Name = "txtave";
            this.txtave.ReadOnly = true;
            this.txtave.Size = new System.Drawing.Size(103, 21);
            this.txtave.TabIndex = 10;
            // 
            // txtshow
            // 
            this.txtshow.Location = new System.Drawing.Point(105, 174);
            this.txtshow.Multiline = true;
            this.txtshow.Name = "txtshow";
            this.txtshow.ReadOnly = true;
            this.txtshow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtshow.Size = new System.Drawing.Size(382, 263);
            this.txtshow.TabIndex = 11;
            this.txtshow.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 494);
            this.Controls.Add(this.txtshow);
            this.Controls.Add(this.txtave);
            this.Controls.Add(this.txtsum);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.txtmark);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txtmark;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.TextBox txtsum;
        private System.Windows.Forms.TextBox txtave;
        private System.Windows.Forms.TextBox txtshow;
    }
}

