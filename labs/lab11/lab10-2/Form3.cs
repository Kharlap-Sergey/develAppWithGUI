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
    public partial class Form3 : Form
    {

        public Point current = new Point();
        public Point old = new Point();
        public Pen p = new Pen(Color.Black, 5);
        public Graphics g;
        GraphicsState state;
        bool flag;
        public Form3()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            state = g.Save();
            //p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
            flag = true;
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && flag)
            {
                current = e.Location;
            }
        }
        //private void panel1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        current = e.Location;
        //        g.DrawLine(p, old, current);

        //        old = current;
        //    }
        //}
        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            var X = Math.Min(old.X, current.X);
            var Y = Math.Min(old.Y, current.Y);
            var lineX = Math.Abs(old.X - current.X);
            var lineY = Math.Abs(old.Y - current.Y);
            Rectangle r = new Rectangle(X, Y, lineX, lineY);
            g.DrawRectangle(p, r);
            for(int i = 1; i < 2000; i++)
            {
                Rectangle rr = new Rectangle(X, Y, lineX, lineY);
                g.DrawRectangle(p, r);
                g.RotateTransform((float)0.01);
            }

            flag = false;
        }
    }
}
