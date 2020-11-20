namespace lab3
{
    partial class Form1
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
            this.textBox_x1 = new System.Windows.Forms.TextBox();
            this.textBox_x2 = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.textBox_h = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_res = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "x1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "x2:";
            // 
            // textBox_x1
            // 
            this.textBox_x1.Location = new System.Drawing.Point(167, 71);
            this.textBox_x1.Name = "textBox_x1";
            this.textBox_x1.Size = new System.Drawing.Size(230, 22);
            this.textBox_x1.TabIndex = 2;
            // 
            // textBox_x2
            // 
            this.textBox_x2.Location = new System.Drawing.Point(167, 151);
            this.textBox_x2.Name = "textBox_x2";
            this.textBox_x2.Size = new System.Drawing.Size(230, 22);
            this.textBox_x2.TabIndex = 3;
            this.textBox_x2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(496, 71);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(214, 22);
            this.textBox_n.TabIndex = 4;
            // 
            // textBox_h
            // 
            this.textBox_h.Enabled = false;
            this.textBox_h.Location = new System.Drawing.Point(496, 149);
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(214, 22);
            this.textBox_h.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "N:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "H:";
            // 
            // textBox_res
            // 
            this.textBox_res.Location = new System.Drawing.Point(167, 214);
            this.textBox_res.Multiline = true;
            this.textBox_res.Name = "textBox_res";
            this.textBox_res.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_res.Size = new System.Drawing.Size(543, 121);
            this.textBox_res.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(543, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_res);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_h);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.textBox_x2);
            this.Controls.Add(this.textBox_x1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_x1;
        private System.Windows.Forms.TextBox textBox_x2;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_h;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_res;
        private System.Windows.Forms.Button button1;
    }
}

