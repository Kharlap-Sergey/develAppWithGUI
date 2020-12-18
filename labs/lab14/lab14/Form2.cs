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

namespace lab14
{
    public partial class Form2 : Form
    {

        SeriesCollection series = new SeriesCollection();

        public Form2(List<List<Tuple<int, string>>> data)
        {
            InitializeComponent();
            cartesianChart1.Series = new SeriesCollection { 
                new LineSeries
                    {
                        Title = "Average",
                        Values = new ChartValues<ObservablePoint>(),
                    }
            };
            var sum = 0;
            var itemsCount = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < data.Count; j++)
                {
                    if (data[j][i].Item1 == -1)
                    {
                        continue;
                    }
                    itemsCount++;
                    sum += data[j][i].Item1;
                }
                if (itemsCount == 0)
                {
                    cartesianChart1.Series[0].Values.Add(new ObservablePoint(i + 1, 0));
                }
                else
                {
                    cartesianChart1.Series[0].Values.Add(new ObservablePoint(i + 1, sum / itemsCount));
                }
                itemsCount = 0;
                sum = 0;
            }

            for (int i = 0; i < data.Count; i++)
            {
                cartesianChart1.Series.Add(
                    new LineSeries
                    {
                        Title = data[i][0].Item2,
                        Values = new ChartValues<ObservablePoint>()
                    }
                );
                for (int j = 0; j < data[i].Count; j++)
                {
                    if (data[i][j].Item1 == -1)
                    {
                        continue;
                    }
                    cartesianChart1.Series[i + 1].Values.Add(new ObservablePoint(j + 1, data[i][j].Item1));
                }
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
