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
        private string baseInfo = "Результаты ст. гр./10701319 Тилюпо М.Э. \n".Replace("\n", Environment.NewLine);

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

        private void submit_Click(object sender, EventArgs e)
        {
            string x = this.textBox_x.Text;
            string y = this.textBox_y.Text;
            string z = this.textBox_z.Text;

            if (checkOnChar(x) || checkOnChar(y) || checkOnChar(z))
            {
                if (checkOnChar(x))
                {
                    this.textBox_x.Text = "Введите корректное значение";
                }
                if (checkOnChar(y))
                {
                    this.textBox_y.Text = "Введите корректное значение";
                }
                if (checkOnChar(z))
                {
                    this.textBox_z.Text = "Введите корректное значение";
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

        private void imageControl_Click(object sender, EventArgs e)
        {

        }
    }
}
