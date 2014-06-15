using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TrailBy_MARK
{
    public partial class Form1 : Form
    {
        int a, b, c, d, f, g, h= 0;
        public Form1()
        {
            InitializeComponent();          
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label2.Hide();
            d = 0;
            f = 0;
            System.Drawing.Graphics graphics = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 5);

            for (int i = 0; i <= 100; i++)
            {
                Random rnd = new Random();
                a = rnd.Next(1, 255);
                b = rnd.Next(1, 255);
                c = rnd.Next(1, 255);
                p.Color = Color.FromArgb(a, b, c);
                g = rnd.Next(1, this.Width);
                h = rnd.Next(1, this.Height);

                graphics.DrawLine(p, d, f, g, h);
                d = g;
                f = h;
                Thread.Sleep(100);
            }
            graphics.Dispose();
        }
        
    }
}
