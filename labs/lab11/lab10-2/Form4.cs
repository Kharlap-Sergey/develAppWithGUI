using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10_2
{
    public partial class Form4 : Form
    {
        public Point current = new Point();
        public Point old = new Point();
        public Pen p = new Pen(Color.Black, 5);
        public Pen p2 = new Pen(Form4.DefaultBackColor, 5);
        public Graphics g;
        bool flag = false;
        Image buffer;
        string type = "rectangle";
        GraphicsState state;
        Color color = Color.Black;

        public Form4()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();

            textBox1.BackColor = color;
            state = g.Save();


        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && flag)
            {
                current = e.Location;
            }
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            old = e.Location;
            flag = true;
        }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            var X = Math.Min(old.X, current.X);
            var Y = Math.Min(old.Y, current.Y);
            var lineX = Math.Abs(old.X - current.X);
            var lineY = Math.Abs(old.Y - current.Y);


            if (type == "line")
            {
                g.DrawLine(p, old, current);
            }
            else if (type == "text")
            {
                StringFormat drawFormat = new StringFormat();
                g.DrawString(textBox2.Text, new Font("Arial", 35), new SolidBrush(this.color),
                    old.X, old.Y, drawFormat);
            }
            else if (type == "elipse")
            {
                Rectangle r = new Rectangle(X, Y, lineX, lineY);
                g.DrawEllipse(p, r);
            }
            else
            {
                Rectangle r = new Rectangle(X, Y, lineX, lineY);
                g.DrawRectangle(p, r);
            }
            current = e.Location;

            flag = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            type = "rectangle";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            type = "elipse";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            type = "line";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = color;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                p.Color = MyDialog.Color;
                this.color = p.Color;
                textBox1.BackColor = MyDialog.Color;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            type = "text";
        }
    }
}
