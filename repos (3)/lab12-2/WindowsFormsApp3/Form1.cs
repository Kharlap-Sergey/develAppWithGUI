using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string XX = "", YY = "", ZZ = "", HH = "";

        public Form1()
        {
            InitializeComponent();
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "f(x, y, z, h)",
                    Values = new ChartValues<ObservablePoint>()
                },
            };
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
                if (i == 0 && str[i] == '-')
                {
                    continue;
                }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            findSolution();
        }

        public void findSolution()
        {
            string x = this.XX;
            string y = this.YY;
            string z = this.ZZ;
            string h = this.HH;

            if (checkOnChar(x) || checkOnChar(y) || checkOnChar(z) || checkOnChar(h))
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
                if (checkOnChar(h))
                {
                    MessageBox.Show("Введите корректное значение H");
                    HH = "Введите корректное значение";
                }
            }
            else
            {
                double X = Convert.ToDouble(x);
                double Y = Convert.ToDouble(y);
                double Z = Convert.ToDouble(z);
                double H = Convert.ToDouble(h);

                cartesianChart1.Series[0].Values.Clear();
                for (double i = 0; i < 20; i++)
                {

                    double res = (Math.Pow(X, Y + 1) + Math.Exp(Y - 1)) / (1 + X * Math.Abs(Y - Math.Tan(Z))) * (1 + Math.Abs(Y - X)) + Math.Pow(Math.Abs(Y - X), 2) / 2.0 - Math.Pow(Math.Abs(Y - X), 3) / 3.0;
                    res = Math.Round(res, 3);

                    cartesianChart1.Series[0].Values.Add(new ObservablePoint(X, res));
                    X += H;
                }
            }
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(HH);
            if (f5.ShowDialog() == DialogResult.OK)
            {
                HH = f5.text;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.findSolution();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            cartesianChart1.Series[0].Values.Clear();
        }
    }
}
   
