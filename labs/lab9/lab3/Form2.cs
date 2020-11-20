using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form2 : Form
    {
        public List<int> customRgbValue = new List<int>() { 0, 0, 0 };
        Func<List<int>, string> funct;
        public Form2(List<bool> controlValue, List<int> rgbValue, Func<List<int>, string> func)
        {
            InitializeComponent();
            funct = func;
            vScrollBar1.Minimum = vScrollBar2.Minimum = vScrollBar3.Minimum = 0;
            vScrollBar1.Maximum = vScrollBar2.Maximum = vScrollBar3.Maximum = 264;

            vScrollBar3.Value = rgbValue[0];
            vScrollBar1.Value = rgbValue[1];
            vScrollBar2.Value = rgbValue[2];

            customRgbValue = rgbValue;

            vScrollBar1.Enabled = controlValue[0];
            vScrollBar2.Enabled = controlValue[1];
            vScrollBar3.Enabled = controlValue[2];

            label4.Text = vScrollBar3.Value.ToString();
            label5.Text = vScrollBar1.Value.ToString();
            label6.Text = vScrollBar2.Value.ToString();
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = vScrollBar3.Value.ToString();
            customRgbValue[0] = vScrollBar3.Value;
            label1.ForeColor = Color.FromArgb(vScrollBar3.Value, 0, 0);
            funct(customRgbValue);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label5.Text = vScrollBar1.Value.ToString();
            customRgbValue[1] = vScrollBar1.Value;
            label2.ForeColor = Color.FromArgb(0, vScrollBar1.Value, 0);
            funct(customRgbValue);
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label6.Text = vScrollBar2.Value.ToString();
            customRgbValue[2] = vScrollBar2.Value;
            label3.ForeColor = Color.FromArgb(0, 0, vScrollBar2.Value);
            funct(customRgbValue);
        }
    }
}
