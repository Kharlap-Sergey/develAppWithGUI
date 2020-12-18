using System.Windows.Forms;

namespace lab2
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
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.textBox_z = new System.Windows.Forms.TextBox();
            this.label_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.label_z = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label_res = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(199, 45);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(185, 22);
            this.textBox_x.TabIndex = 0;
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(199, 100);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(185, 22);
            this.textBox_y.TabIndex = 1;
            // 
            // textBox_z
            // 
            this.textBox_z.Location = new System.Drawing.Point(199, 159);
            this.textBox_z.Name = "textBox_z";
            this.textBox_z.Size = new System.Drawing.Size(185, 22);
            this.textBox_z.TabIndex = 2;
            this.textBox_z.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(109, 48);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(55, 17);
            this.label_x.TabIndex = 3;
            this.label_x.Text = "Write x:";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(109, 104);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(56, 17);
            this.label_y.TabIndex = 4;
            this.label_y.Text = "Write y:";
            // 
            // label_z
            // 
            this.label_z.AutoSize = true;
            this.label_z.Location = new System.Drawing.Point(109, 159);
            this.label_z.Name = "label_z";
            this.label_z.Size = new System.Drawing.Size(56, 17);
            this.label_z.TabIndex = 5;
            this.label_z.Text = "Write z:";
            this.label_z.Click += new System.EventHandler(this.label3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 21);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "sh(x)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 21);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "х^2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 75);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(50, 21);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "e^x";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioGroupBox
            // 
            this.radioGroupBox.Controls.Add(this.radioButton1);
            this.radioGroupBox.Controls.Add(this.radioButton3);
            this.radioGroupBox.Controls.Add(this.radioButton2);
            this.radioGroupBox.Location = new System.Drawing.Point(511, 104);
            this.radioGroupBox.Name = "radioGroupBox";
            this.radioGroupBox.Size = new System.Drawing.Size(200, 111);
            this.radioGroupBox.TabIndex = 10;
            this.radioGroupBox.TabStop = false;
            this.radioGroupBox.Text = "f(x)";
            this.radioGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(199, 230);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_result.Size = new System.Drawing.Size(254, 133);
            this.textBox_result.TabIndex = 11;
            // 
            // label_res
            // 
            this.label_res.AutoSize = true;
            this.label_res.Location = new System.Drawing.Point(112, 239);
            this.label_res.Name = "label_res";
            this.label_res.Size = new System.Drawing.Size(52, 17);
            this.label_res.TabIndex = 12;
            this.label_res.Text = "Result:";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(199, 390);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(185, 23);
            this.submit.TabIndex = 13;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(511, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label_res);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.radioGroupBox);
            this.Controls.Add(this.label_z);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.textBox_z);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.textBox_x);
            this.Name = "Form1";
            this.Text = "Form1";
            this.radioGroupBox.ResumeLayout(false);
            this.radioGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.TextBox textBox_z;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_z;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox radioGroupBox;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label_res;
        private System.Windows.Forms.Button submit;
        private CheckBox checkBox1;
    }
}

