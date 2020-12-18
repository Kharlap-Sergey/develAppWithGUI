using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;


namespace Lab_1
{
    public partial class Form2 : Form
    {
        
        private Chart edit_chart;
        private Series s2;
       
        public Form2(Chart the_best_chart_in_your_life, Series lovely)
        {
           
            InitializeComponent();
            textBox1.ForeColor = Color.White;
            string[] lines = { "Пунктирная", "Сплошная", "Точечная" };
            string[] types = { "Тип диаграммы с областями", "Линейчатая", "Сплайн" };
            string[] colours = { "Розовый", "Зелёный", "Красный", "Жёлтый", "Синий" };
            comboBox1.Items.AddRange(lines);
            comboBox2.Items.AddRange(types);
            listBox1.Items.AddRange(colours);
            edit_chart = the_best_chart_in_your_life;
            s2 = lovely;
        }
        static void graphic(ComboBox comboBox2, Chart edit_chart, Series s2)
        {
            string str = Convert.ToString(comboBox2.SelectedItem);
            if (str == "Сплайн")
            {
                edit_chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                s2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }
            if (str == "Тип диаграммы с областями")
            {
                edit_chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                s2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            }
            if (str == "Линейчатая")
            {
                edit_chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                s2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            }
        }

        static void colours(ListBox listBox1, Chart edit_chart, Series s2)
        {
            string str = Convert.ToString(listBox1.SelectedItem);
            if (str == "Розовый")
            {
                edit_chart.Series[0].Color = Color.DeepPink;
                s2.Color = Color.DeepPink;
            }
            if (str == "Зелёный")
            {
                edit_chart.Series[0].Color = Color.LightGreen;
                s2.Color = Color.LightGreen;
            }
            if (str == "Красный")
            {
                edit_chart.Series[0].Color = Color.IndianRed;
                s2.Color = Color.IndianRed;
            }
            if (str == "Жёлтый")
            {
                edit_chart.Series[0].Color = Color.Yellow;
                s2.Color = Color.Yellow;
            }
            if (str == "Синий")
            {
                edit_chart.Series[0].Color = Color.Blue;
                s2.Color = Color.Blue;
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = vScrollBar1.Value.ToString();
            textBox1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar1.Value, vScrollBar1.Value);

        }

        static void lines(ComboBox comboBox1, Chart edit_chart)
        {
            string str = Convert.ToString(comboBox1.SelectedItem);
            if (str == "Пунктирная")
            {
                edit_chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
                edit_chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            }
            if (str == "Сплошная")
            {
                edit_chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
                edit_chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
            }
            if (str == "Точечная")
            {
                edit_chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
                edit_chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lines(comboBox1, edit_chart);
            graphic(comboBox2, edit_chart, s2);
            colours(listBox1, edit_chart, s2);
            edit_chart.ChartAreas[0].AxisY.MajorGrid.LineColor = textBox1.BackColor;
            edit_chart.ChartAreas[0].AxisX.MajorGrid.LineColor = textBox1.BackColor;
            s2.BorderWidth = Int32.Parse(textBox2.Text);
            edit_chart.Series[0].BorderWidth = Int32.Parse(textBox2.Text);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edit_chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightBlue;
            edit_chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightBlue;
            edit_chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            edit_chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            edit_chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            s2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            edit_chart.Series[0].Color = Color.LightGreen;
            s2.Color = Color.DeepPink;
            s2.BorderWidth = 1;
            edit_chart.Series[0].BorderWidth = 1;
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На данной форме Вы можете изменить основные параметры по интерфейсной части графика. Если Вас всё устраивает в текущем графике, нажмите кнопку 'Установить значения по умолчанию'", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

             
        }
    }
}
