using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        int N = 0, M = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            try
            {
                dataGrid.Rows.Clear();
                dataGrid.Columns.Clear();
                dataGrid.Refresh();
                int n = Convert.ToInt32(textBox_n.Text);
                int m = Convert.ToInt32(textBox_m.Text);
                N = n;
                M = m;

                dataGrid.ColumnCount = M;
                for (int i = 0; i < M; i++)
                {
                    dataGrid.Columns[i].Name = (i + 1).ToString();
                }

                for (int i = 0; i < N; i++)
                {
                    var str = new String[M];
                    for (int j = 0; j < M; j++)
                    {
                        str[j] = (rand.Next(-100, 100)).ToString();
                    }

                    this.dataGrid.Rows.Add(str);
                    dataGrid.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            } catch
            {
                textBox_n.Text = "Write integer";
                textBox_m.Text = "Write integer";
            }
            
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int max = 0;
            int col = 0, row = 0; 
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    int val = Convert.ToInt32(dataGrid.Rows[i].Cells[j].Value);
                    if (Math.Abs(val) >= max)
                    {
                        max = Math.Abs(val);
                        col = j + 1;
                        row = i + 1;
                    }
                }
            }
            string rows = row.ToString();

            if (N == 1)
            {
                dataGrid.Rows.RemoveAt(row - 1);
                for (int i = 0; i < M; i++)
                {
                    dataGrid.Columns.Remove((i + 1).ToString());
                }
                N = 0;
                M = 0;
                textBox_deleted.Text = "row: " + rows + ", col: " + col.ToString() + " element: " + max.ToString();

            }
            else if (M == 1)
            {
                for (int i = N - 1; i >= 0; i--)
                {
                    dataGrid.Rows.RemoveAt(i);
                }
                dataGrid.Columns.Remove(1.ToString());
                M = 0;
                N = 0;
                textBox_deleted.Text = "row: " + rows + ", col: " + col.ToString() + " element: " + max.ToString();

            }
            else
            {
                dataGrid.Rows.RemoveAt(row - 1);
                dataGrid.Columns.Remove(col.ToString());
                textBox_deleted.Text = "row: " + rows + ", col: " + col.ToString() + " element: " + max.ToString();
                for (int i = 0; i < N - 1; i++)
                {
                    dataGrid.Rows[i].HeaderCell.Value = (i + 1).ToString();

                }
                for (int i = 0; i < M - 1; i++)
                {
                    dataGrid.Columns[i].Name = (i + 1).ToString();
                }
                N -= 1;
                M -= 1;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
