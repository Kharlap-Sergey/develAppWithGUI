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
        IniFIle iniFIle;
        List<string> comboBoxList = new List<string>();
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            iniFIle = new IniFIle();
            iniFIle.IniFile(@"C:\Users\Maxim\source\repos\lab10\lab5\Settings.ini");
            string comboBoxCacheValue = iniFIle.Read("comboBox");
            string text = iniFIle.Read("text");
            string s = "";
            for (int j = 0; j < text.Length; j++)
            {
                if (text[j] == '|')
                {
                    s = s.Trim();
                    textBox2.Text += s + "\r\n";

                    s = "";
                    continue;
                }
                s += text[j];
            }
            s = s.Trim();
            text += s;

            s = "";
            for (int j = 0; j < comboBoxCacheValue.Length; j++)
            {
                if (comboBoxCacheValue[j] == '|')
                {
                    s = s.Trim();
                    comboBox1.Items.Add(s);
                    comboBoxList.Add(s);
                    s = "";
                    continue;
                }
                s += comboBoxCacheValue[j];
            }
            s = s.Trim();

            if (s != "")
            {
                comboBox1.Items.Add(s);
            }
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
                    comboBoxList.Add(comboBox1.Text);
                    KeyValuePair<string, int> result = findMinWord(comboBox1.Text);
                    textBox2.Text += comboBox1.Text + " " + result.Key.Length.ToString() + " " + result.Value.ToString() + "\r\n";
                    comboBox1.Text = "";
                    string textRes = "";
                    string s = "";
                    for (int i = 0; i < textBox2.Text.Length; i++)
                    {
                        
                        if (textBox2.Text[i] == '\n' || textBox2.Text[i] == '\r')
                        {
                            if (textBox2.Text[i] == '\r')
                            {
                                continue;
                            }
                            textRes += s + " | ";
                            s = "";
                            continue;
                        }
                        s += textBox2.Text[i];
                    }
                    iniFIle.Write("text", textRes);

                    string res = "";
                    for (int i = 0; i < comboBoxList.Count; i++)
                    {
                        res += comboBoxList[i];
                        if (i != comboBoxList.Count - 1)
                        {
                            res += " | ";
                        }
                    }
                    iniFIle.Write("comboBox", res);
                }
            }
        }
    }
}
