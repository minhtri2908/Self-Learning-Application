
namespace WindowsFormsApp1
{
    partial class ptbac3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_kq = new System.Windows.Forms.Label();
            this.lbl_pt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(169, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 47);
            this.label1.TabIndex = 13;
            this.label1.Text = "Giải phương trình bậc 3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 38);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hệ số a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hệ số b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 38);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hệ số c:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 38);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hệ số d:";
            // 
            // txt_a
            // 
            this.txt_a.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_a.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_a.Location = new System.Drawing.Point(263, 102);
            this.txt_a.Margin = new System.Windows.Forms.Padding(4);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(132, 46);
            this.txt_a.TabIndex = 18;
            this.txt_a.TextChanged += new System.EventHandler(this.txt_a_TextChanged);
            // 
            // txt_b
            // 
            this.txt_b.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_b.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_b.Location = new System.Drawing.Point(263, 170);
            this.txt_b.Margin = new System.Windows.Forms.Padding(4);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(132, 46);
            this.txt_b.TabIndex = 19;
            this.txt_b.TextChanged += new System.EventHandler(this.txt_b_TextChanged);
            // 
            // txt_c
            // 
            this.txt_c.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_c.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_c.Location = new System.Drawing.Point(263, 234);
            this.txt_c.Margin = new System.Windows.Forms.Padding(4);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(132, 46);
            this.txt_c.TabIndex = 20;
            this.txt_c.TextChanged += new System.EventHandler(this.txt_c_TextChanged);
            // 
            // txt_d
            // 
            this.txt_d.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_d.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_d.Location = new System.Drawing.Point(263, 298);
            this.txt_d.Margin = new System.Windows.Forms.Padding(4);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(132, 46);
            this.txt_d.TabIndex = 21;
            this.txt_d.TextChanged += new System.EventHandler(this.txt_d_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(529, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 48);
            this.button1.TabIndex = 22;
            this.button1.Text = "Giải";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(529, 187);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 48);
            this.button2.TabIndex = 23;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(529, 263);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 48);
            this.button3.TabIndex = 24;
            this.button3.Text = "Đóng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_kq
            // 
            this.lbl_kq.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_kq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_kq.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kq.Location = new System.Drawing.Point(127, 433);
            this.lbl_kq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kq.Name = "lbl_kq";
            this.lbl_kq.Size = new System.Drawing.Size(521, 148);
            this.lbl_kq.TabIndex = 25;
            // 
            // lbl_pt
            // 
            this.lbl_pt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_pt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pt.Location = new System.Drawing.Point(140, 369);
            this.lbl_pt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pt.Name = "lbl_pt";
            this.lbl_pt.Size = new System.Drawing.Size(492, 44);
            this.lbl_pt.TabIndex = 26;
            this.lbl_pt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbac3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.lbl_pt);
            this.Controls.Add(this.lbl_kq);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_d);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ptbac3";
            this.Text = "ptbac3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_kq;
        private System.Windows.Forms.Label lbl_pt;
    }
}