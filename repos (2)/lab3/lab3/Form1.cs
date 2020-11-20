using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox_res.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            string x1 = this.textBox_x1.Text;
            string x2 = this.textBox_x2.Text;
            string n = this.textBox_n.Text;

            if (checkOnChar(x1) || checkOnChar(x2) || checkOnChar(n))
            {
                if (checkOnChar(x1))
                {
                    this.textBox_x1.Text = "Введите корректное значение";
                }
                if (checkOnChar(x2))
                {
                    this.textBox_x2.Text = "Введите корректное значение";
                }
                if (checkOnChar(n))
                {
                    this.textBox_n.Text = "Введите корректное значение";
                }
                
            }
            else
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

                for (double y = X1; y < X2; y += H)
                {
                    double res = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        double preres = Math.Pow(y, (2 * i)) * Math.Pow(-1, i + 1);
                        double fac = 2 * i * (2 * i - 1);
                        preres /= fac;
                        res += preres;
                    }


                    textBox_res.Text += "X = " + Math.Round(y, 3).ToString() + " res 1: " + Math.Round(res, 3).ToString() + "; res 2: " + Math.Round((y * Math.Atan(y) - Math.Log(Math.Sqrt(1 + y * y))), 3).ToString() + "\r\n";
                }
                
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
