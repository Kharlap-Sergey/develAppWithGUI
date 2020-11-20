using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        private int f_type = 1;
        private string baseInfo = "Результаты ст. гр./10701319 Тилюпо М.Э. \n".Replace("\n", Environment.NewLine);
        private bool flag = false;
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            this.textBox_result.Text = baseInfo;
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

        private double f(double value)
        {
            if (f_type == 1)
            {
                return Math.Sinh(value);
            } else if (f_type == 2)
            {
                return value * value;
            } else
            {
                return Math.Exp(value);
            }
        }

        private string formatOutput(string x, string y, string z, string res)
        {
            string result = "";
            result += "X = " + x + "\nY = ".Replace("\n", Environment.NewLine) + y + "\nZ = ".Replace("\n", Environment.NewLine) + z + "\nResult: ".Replace("\n", Environment.NewLine) + res;
            return result;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
            }
            else
            {
                double X = Convert.ToDouble(x);
                double Y = Convert.ToDouble(y);
                double Z = Convert.ToDouble(z);



                double res = Math.Max(Math.Min(f(X), Y), Z);


                string strRes = formatOutput(x, y, z, res.ToString());

                if (flag)
                {
                    this.textBox_result.Text = baseInfo;
                    this.textBox_result.Text += "\r\n" + strRes;
                }
                else
                {
                    this.textBox_result.Text += "\r\n" + strRes;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            f_type = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            f_type = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            f_type = 3;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
            } else
            {
                flag = true;
            }
        }
    }
}
