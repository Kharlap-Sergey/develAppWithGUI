using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ClassLibrary1;

namespace lab3
{
    public partial class Form1 : Form
    {
        int typeFunc = 1;
        List<bool> controlList = new List<bool>() { false, false, false};
        private List<int> rgbValue = new List<int>() { 0, 0, 0 };
                
        public Form1()
        {
            InitializeComponent();
            this.textBox_res.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string x1 = this.textBox_x1.Text;
            string x2 = this.textBox_x2.Text;
            string n = this.textBox_n.Text;

            try
            {
                double X1 = Convert.ToDouble(x1);
                double X2 = Convert.ToDouble(x2);
                if (X1 > X2)
                {
                    textBox_res.Text += "X2 must be > X1";
                    return;
                }
                double N = Convert.ToDouble(n);
                double H = (X2 - X1) / N;

                this.textBox_h.Text = H.ToString();

                List<KeyValuePair<double, double>> result = Functions.calcResult(X1, X2, H, N, typeFunc);
                if (typeFunc == 1) {
                    for (int i = 0; i < result.Count; i++)
                    {
                        double y = result[i].Key;
                        double res = result[i].Value;
                        textBox_res.Text += "X = " + Math.Round(y, 3).ToString() + " res 1: " + Math.Round(res, 3).ToString() + "; res 2: " + Math.Round((y * Math.Atan(y) - Math.Log(Math.Sqrt(1 + y * y))), 3).ToString() + "\r\n";
                    }
                } else
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        double y = result[i].Key;
                        double res = result[i].Value;
                        textBox_res.Text += "X = " + Math.Round(y, 3).ToString() + " res 1: " + Math.Round(res, 3).ToString() + "; res 2: " + Math.Round(Math.Atan(y), 3).ToString() + "\r\n";
                    }
                }
            } catch
            {
                textBox_res.Text = "Неправильно введены данные";
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            typeFunc = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            typeFunc = 0;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(controlList, rgbValue, func);
            if (form2.ShowDialog() == DialogResult.OK)
            {
               rgbValue = form2.customRgbValue;
               textBox_res.ForeColor = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            }
            else
            {
               rgbValue = form2.customRgbValue;
               textBox_res.ForeColor = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            controlList[2] = !controlList[2];
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            controlList[0] = !controlList[0];
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            controlList[1] = !controlList[1];
        }

        public string func(List<int> colorList)
        {
            rgbValue = colorList;
            textBox_res.ForeColor = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return "ff";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form2 = new Form2(controlList, rgbValue, func);
            form2.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
