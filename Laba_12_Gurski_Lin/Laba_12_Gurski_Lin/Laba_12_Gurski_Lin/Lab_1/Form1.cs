using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightBlue;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightBlue;

            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bool check_data = (String.IsNullOrEmpty(toolStripTextBox1.Text)

                              || String.IsNullOrEmpty(toolStripTextBox2.Text)

                               || String.IsNullOrEmpty(toolStripTextBox3.Text));

            if (!check_data)

            {

                double x = Convert.ToDouble(toolStripTextBox1.Text);

                double y = Convert.ToDouble(toolStripTextBox2.Text);

                double h = Convert.ToDouble(toolStripTextBox3.Text);

                chart1.Series[0].Points.Clear();

                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                List<double> X2 = new List<double>();
                List<double> Y2 = new List<double>();
                try
                {
                    String msg = "";
                    int count = 0;

                    const int N = 100;
                    for (int i = 0; i < N; i++)
                    {
                        double answer = 2 / Math.Exp(x) + Math.Exp(y) + Math.Sqrt(x) - 3;
                        X2.Add(x);
                        Y2.Add(answer);
                        chart1.Series[0].Points.AddXY(x, answer);
                        x += h;

                        msg = (count + 1) + ") X = " + x + Environment.NewLine + "Y = " + y + Environment.NewLine
                       + "G = "
                        + Math.Round((answer),3) + Environment.NewLine + Environment.NewLine;
                        textBox4.Text += msg;
                        count++;
                    }
                    Series s1 = new Series("SMO");
                    s1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    s1.Color = Color.DeepPink;
                    s1.Points.DataBindXY(Y2, X2);
                    try
                    {
                        chart1.Series.Add(s1);
                    }
                    catch{

                    }
                    chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{0,#}";
                    chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0,#}";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введено не число!", "Error!");
                }
            }

            else

            {

                MessageBox.Show("Не все данные введены!!!");

            }


        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (chart1.ChartAreas[0].AxisX.MajorGrid.Enabled == false || chart1.ChartAreas[0].AxisY.MajorGrid.Enabled == false)
            {
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            }
            else
            {
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            }

        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
