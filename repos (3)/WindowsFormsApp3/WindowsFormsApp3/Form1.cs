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
            string x = this.textBox1.Text;
            string y = this.textBox2.Text;
            string z = this.textBox3.Text;
            string h = textBox4.Text;

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
                this.textBox1.Text = "Неправильно введены значения";
                this.textBox2.Text = "Неправильно введены значения";
                this.textBox3.Text = "Неправильно введены значения";
            }
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
    }
}
   
