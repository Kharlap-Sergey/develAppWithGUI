using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> comboSource;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;

            //comboSource = new Dictionary<string, string>();
            //comboBox1.DataSource = new BindingSource(comboSource, null);
            //comboBox1.DisplayMember = "Value";
            //comboBox1.ValueMember = "Key";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        KeyValuePair<string, int> findMinWord(string str)
        {
            string result = null;
            string ex = "";
            int resultCount = 0;
            int count = 0;
            str += ' ';

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    if (ex == "")
                    {
                        continue;
                    }
                    count++;
                    if (result == null || result.Length > ex.Length)
                    {
                        result = ex;
                        resultCount = count;
                    }
                    ex = "";
                    continue;
                }

                ex += str[i];
            }

            return new KeyValuePair<string, int>(result, resultCount);
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (comboBox1.Text != " ")
                {
                    comboBox1.Items.Add(comboBox1.Text);
                    KeyValuePair<string, int> result = findMinWord(comboBox1.Text);
                    textBox2.Text += comboBox1.Text + " " + result.Key.Length.ToString() + " " + result.Value.ToString() + "\r\n";
                    comboBox1.Text = "";
                }
            }
        }
    }
}
