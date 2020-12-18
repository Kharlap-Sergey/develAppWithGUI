using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;


namespace Lab_1
{
    public partial class Form1 : Form

    {
        Class1 INI = new Class1("config.ini");
        Form2 secForm;
        Series s1 = new Series("SMO");
        public Form1()
        {
            InitializeComponent();
            tabControl1.TabPages[0].Text = "Ввод данных";
            tabControl1.TabPages[1].Text = "Расчёт данных";
            tabControl1.TabPages[2].Text = "График";
            
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightBlue;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightBlue;

            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
        }


        private void tabControl1_Click(object sender, EventArgs e)
        {
            String msg = "";
            double numX, numY, numZ, numH;
            int count = 0;

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            List<double> X2 = new List<double>();
            List<double> Y2 = new List<double>();
            try
            {
                numX = Convert.ToDouble(textBox1.Text);
                numY = Convert.ToDouble(textBox2.Text);

                numZ = Convert.ToDouble(textBox3.Text);
                numH = Convert.ToDouble(textBox5.Text);

                const int N = 100;
                for (int i = 0; i < N; i++)
                {
                    double answer = 2 / Math.Exp(numX) + Math.Exp(numY) + Math.Sqrt(numX) - 3;
                    X2.Add(numX);
                    Y2.Add(answer);
                    chart1.Series[0].Points.AddXY(numX, answer);
                    chart1.Series[0].Color = Color.LightGreen;
                    numX += numH;

                    msg = (count + 1) + ") X = " + numX + Environment.NewLine + "Y = " + numY + Environment.NewLine
                    + "Z = " + numZ + Environment.NewLine + "G = "
                    + Math.Round(answer) + Environment.NewLine + Environment.NewLine;
                    textBox4.Text += msg;
                    count++;
                }

                s1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                s1.Color = Color.DeepPink;
                s1.Points.DataBindXY(Y2, X2);
                chart1.Series.Add(s1);
                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{0,#}";
                chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0,#}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число!", "Error!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void auto_read()
        {
            textBox1.Text = INI.ReadINI("Parameter of X", "String");
            textBox2.Text = INI.ReadINI("Parameter of Y", "String");
            textBox3.Text = INI.ReadINI("Parameter of Z", "String");
            textBox5.Text = INI.ReadINI("Parameter of H", "String");
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            INI.WriteINI("Parameter of X", "String", textBox1.Text);
            INI.WriteINI("Parameter of Y", "String", textBox2.Text);
            INI.WriteINI("Parameter of Z", "String", textBox3.Text);
            INI.WriteINI("Parameter of H", "String", textBox5.Text);
            MessageBox.Show("Настройки Parameters сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        { 
              auto_read();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            secForm = new Form2(chart1, s1);
            secForm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
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
    }
}
