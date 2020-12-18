using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private string baseInfo = "Результаты ст. гр./10701219 Харлап С.А. \n".Replace("\n", Environment.NewLine);

        string XX = "", YY = "", ZZ = "";
        public Form1()
        {
            InitializeComponent();
            this.result.Text = baseInfo;
        }

        public bool checkOnChar(string str)
        {
            bool flag = false;
            if (str.Length == 0)
            {
                return true;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.')
                {
                    if (flag)
                    {
                        return true;
                    }
                    flag = true;
                    continue;
                }
                if (str[i] < '0' || str[i] > '9')
                {
                    return true;
                }
            }

            return false;
        }

        private string formatOutput(string x, string y, string z, string res)
        {
            string result = "";
            result += "X = " + x + "\nY = ".Replace("\n", Environment.NewLine) + y + "\nZ = ".Replace("\n", Environment.NewLine) + z + "\nResult: ".Replace("\n", Environment.NewLine) + res;
            return result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Clickk()
        {
            string x = this.XX;
            string y = this.YY;
            string z = this.ZZ;

            if (checkOnChar(x) || checkOnChar(y) || checkOnChar(z))
            {
                if (checkOnChar(x))
                {
                    MessageBox.Show("Введите корректное значение X");
                    XX = "Введите корректное значение";
                }
                if (checkOnChar(y))
                {
                    MessageBox.Show("Введите корректное значение Y");
                    YY = "Введите корректное значение";
                }
                if (checkOnChar(z))
                {
                    MessageBox.Show("Введите корректное значение Z");
                    ZZ = "Введите корректное значение";
                }
            } else
            {
                double X = Convert.ToDouble(x);
                double Y = Convert.ToDouble(y);
                double Z = Convert.ToDouble(z);
                double res = (Math.Pow(X, Y + 1) + Math.Exp(Y - 1)) / (1 + X * Math.Abs(Y - Math.Tan(Z))) * (1 + Math.Abs(Y - X)) + Math.Pow(Math.Abs(Y - X), 2) / 2.0 - Math.Pow(Math.Abs(Y - X), 3) / 3.0;
                res = Math.Round(res, 3);
                string strRes = formatOutput(x, y, z, res.ToString());
                this.result.Text = this.result.Text + "\r\n" + strRes;
            }
            //MessageBox.Show("hi");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_y_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.submit_Clickk();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            result.Text = "";
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(XX);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                XX = f2.text;
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(YY);
            if (f3.ShowDialog() == DialogResult.OK)
            {
                YY = f3.text;
            }
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(ZZ);
            if (f4.ShowDialog() == DialogResult.OK)
            {
                ZZ = f4.text;
            }
        }
    }
}
