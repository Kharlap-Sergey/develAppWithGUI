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
        public Form1()
        {
            InitializeComponent();
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "f(x, y, z)",
                    Values = new ChartValues<ObservablePoint>()
                },
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void textBox_x_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_h_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string x = this.textBox_x.Text;
            string y = this.textBox_y.Text;
            string z = this.textBox_z.Text;
            string h = textBox_h.Text;

            try
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
            catch
            {
                this.textBox_x.Text = "Неправильно введены значения";
                this.textBox_y.Text = "Неправильно введены значения";
                this.textBox_z.Text = "Неправильно введены значения";
                this.textBox_h.Text = "Неправильно введены значения";
            }
        }
    }
}
   
