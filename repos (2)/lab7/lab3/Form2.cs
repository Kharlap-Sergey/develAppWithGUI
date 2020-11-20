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
        public Form2()
        {
            InitializeComponent();
            vScrollBar1.Minimum = vScrollBar2.Minimum = vScrollBar3.Minimum = 0;
            vScrollBar1.Maximum = vScrollBar2.Maximum = vScrollBar3.Maximum = 264;

            label4.Text = vScrollBar3.Value.ToString();
            label5.Text = vScrollBar1.Value.ToString();
            label6.Text = vScrollBar2.Value.ToString();

        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = vScrollBar3.Value.ToString();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label5.Text = vScrollBar1.Value.ToString();

        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label6.Text = vScrollBar2.Value.ToString();
        }
    }
}
