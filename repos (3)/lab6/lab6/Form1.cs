using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

struct Good
{
    public string category;
    public string date;
    public string name;
    public bool isDone;

    public Good(string category, string name, string date, bool isDone)
    {
        this.category = category;
        this.date = date;
        this.name = name;
        this.isDone = isDone;
    }
}

namespace lab6
{
    public partial class Form1 : Form
    {
        List<Good> goods = new List<Good>();
        bool isDone = true;
        string defaultPath = @"C:\Users\Maxim\source\repos\lab6\text.txt";
        string scanPath = @"C:\Users\Maxim\source\repos\lab6\text.txt";
        string writePath = @"C:\Users\Maxim\source\repos\lab6\text.txt";
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string category = textBox1.Text;
                string date = dateTimePicker1.Value.ToString();
                string name = textBox2.Text;
                bool goodIsDone = isDone;
                Good good = new Good();

                this.goods.Add( new Good(category, date, name, goodIsDone));
                this.updateText();
                this.isDone = true;
                radioButton1.Checked = true;
            }
            catch
            {

            }
        }

        private string updateText()
        {
            string result = "";
            goods = goods.OrderBy(val => val.category).ToList();
            for (int i = 0; i < this.goods.Count; i++)
            {
                if (i != 0 && this.goods[i - 1].category != this.goods[i].category)
                {
                    result += "\r\n";
                }
                result += goods[i].category + " " + goods[i].name + " " + goods[i].date + " is done: " + goods[i].isDone.ToString() + "\r\n";
            }

            textBox5.Text = result;
            return result;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isDone = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            isDone = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = goods.Aggregate("", (res, b) => (res + b.category + ", " + b.name + ", " + b.date + ", " + b.isDone.ToString() + "\r\n"));
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(result);
                this.updateText();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(this.scanPath))
            {
                string line;
                goods.Clear();
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == "")
                    {
                        continue;
                    }
                    string[] args = line.Split(' ');
                    bool flag = args[3] == "True" ? true : false;
                    goods.Add(new Good(args[0], args[1], args[2], flag));
                }
                this.updateText();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                scanPath = openFileDialog1.FileName;
                MessageBox.Show(scanPath);
            }
            else
            {
                scanPath = @"" + defaultPath;
            }
            MessageBox.Show(scanPath);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                writePath = openFileDialog1.FileName;
                MessageBox.Show(scanPath);
            }
            else
            {
                writePath = @"" + defaultPath;
            }
            MessageBox.Show(writePath);
        }
    }
}
