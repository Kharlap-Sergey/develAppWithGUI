using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;


namespace Lab_1
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
            //tabControl1.TabPages[0].Text = "Ввод данных";
            //tabControl1.TabPages[1].Text = "Расчёт данных";
            //tabControl1.TabPages[2].Text = "График";
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightBlue;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightBlue;

            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
        }

       
        private void button2_Click(object sender, EventArgs e)
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

        private void CalculateDate()
        {
            double numX, numY, numZ, numH;
            int count = 0;
            String msg = "";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            List<double> X2 = new List<double>();
            List<double> Y2 = new List<double>();
            try
            {
                numX = Convert.ToDouble(textBox1.Text);
                numY = Convert.ToDouble(textBox2.Text);

                numZ = Convert.ToDouble(textBox3.Text);
                numH = Convert.ToDouble(textBox5.Text);
                textBox4.Text = "";
                const int N = 100;
                for (int i = 0; i < N; i++)
                {
                    double answer = 2 / Math.Exp(numX) + Math.Exp(numY) + Math.Sqrt(numX) - 3;
                    X2.Add(numX);
                    Y2.Add(answer);
                    chart1.Series[0].Points.AddXY(numX, answer);
                    numX += numH;

                    msg = (count + 1) + ") X = " + numX + Environment.NewLine + "Y = " + numY + Environment.NewLine
                    + "Z = " + numZ + Environment.NewLine + "G = "
                    + Math.Round(answer) + Environment.NewLine + Environment.NewLine;
                    textBox4.Text += msg;
                    count++;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число!", "Error!");
            }
        }

        private void DrawChart()
        {
            double numX, numY, numZ, numH;
            int count = 0;
            String msg = "";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            List<double> X2 = new List<double>();
            List<double> Y2 = new List<double>();
            try
            {
                numX = Convert.ToDouble(textBox1.Text);
                numY = Convert.ToDouble(textBox2.Text);

                numZ = Convert.ToDouble(textBox3.Text);
                numH = Convert.ToDouble(textBox5.Text);
                textBox4.Text = "";
                const int N = 100;
                for (int i = 0; i < N; i++)
                {
                    double answer = 2 / Math.Exp(numX) + Math.Exp(numY) + Math.Sqrt(numX) - 3;
                    X2.Add(numX);
                    Y2.Add(answer);
                    chart1.Series[0].Points.AddXY(numX, answer);
                    numX += numH;

                    msg = (count + 1) + ") X = " + numX + Environment.NewLine + "Y = " + numY + Environment.NewLine
                    + "Z = " + numZ + Environment.NewLine + "G = "
                    + Math.Round(answer) + Environment.NewLine + Environment.NewLine;
                    textBox4.Text += msg;
                    count++;
                }
                Series s1 = new Series("SMO");
                s1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                s1.Color = Color.DeepPink;
                s1.Points.DataBindXY(Y2, X2);
                chart1.Series.Clear();
                chart1.Series.Add(s1);
                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{0,#}";
                chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0,#}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число!", "Error!");
            }
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            var tp = (TabControl)sender;
            var selected = tp.SelectedTab;
            if(selected.Name == "tabPage2")
            {
                this.CalculateDate();
            }else if (selected.Name == "tabPage3")
            {
                this.DrawChart();
            }
        }
    }
}
