using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


namespace GraphicTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int width = this.Width;
            int height = this.Height;
            int banJing = 10;
            int ellipseX = (width - banJing * 4) / 2;
            int ellipseY = (height - banJing * 4) / 2;
            int fontX = (width - banJing * 8) / 2;
            int fontY = height / 2;
            //计算中点：width/2,height/2
            Graphics g = e.Graphics;
            Pen pn = new Pen(Color.Green, 10);
            Rectangle rect = new Rectangle(ellipseX, ellipseY, 10, 10);
            g.DrawEllipse(pn, rect);



            Font fnt = new Font("宋体", 16);
            g.DrawString("你好", fnt, new SolidBrush(Color.Red), fontX, fontY);

            int n = 10;
            double average = 360 / n;
            int size = 100;
            for (int i = 1; i < n + 1; i++)
            {
                int ellipseX1 = ellipseX + (int)(Math.Cos(((average * i * Math.PI) / 180.0)) * size);
                int ellipseY1 = ellipseY + (int)(Math.Sin(((average * i * Math.PI) / 180.0)) * size);
                Pen pn1 = new Pen(Color.Green, 10);
                Rectangle rect1 = new Rectangle(ellipseX1, ellipseY1, 10, 10);
                g.DrawEllipse(pn1, rect1);
                //Console.WriteLine("average=" + average + "   " + "average * i=" + average * i);
                //Console.WriteLine("Math.Cos(average * i):" + Math.Cos(average * i) + "      " + "Math.Sin(average * i):" + Math.Sin(average * i));
            }

            int m = 10;
            average = 360 / m;
            size = 150;
            for (int i = 1; i < n + 1; i++)
            {
                int ellipseX1 = ellipseX + (int)(Math.Cos(((average * i * Math.PI) / 180.0)) * size);
                int ellipseY1 = ellipseY + (int)(Math.Sin(((average * i * Math.PI) / 180.0)) * size);
                Pen pn1 = new Pen(Color.Green, 10);
                Rectangle rect1 = new Rectangle(ellipseX1, ellipseY1, 10, 10);
                g.DrawEllipse(pn1, rect1);
                //Console.WriteLine("average=" + average + "   " + "average * i=" + average * i);
                //Console.WriteLine("Math.Cos(average * i):" + Math.Cos(average * i) + "      " + "Math.Sin(average * i):" + Math.Sin(average * i));
            }

            int p = 10;
            average = 360 / p;
            size = 200;
            for (int i = 1; i < n + 1; i++)
            {
                int ellipseX1 = ellipseX + (int)(Math.Cos(((average * i * Math.PI) / 180.0)) * size);
                int ellipseY1 = ellipseY + (int)(Math.Sin(((average * i * Math.PI) / 180.0)) * size);
                Pen pn1 = new Pen(Color.Green, 10);
                Rectangle rect1 = new Rectangle(ellipseX1, ellipseY1, 10, 10);
                g.DrawEllipse(pn1, rect1);
                //Console.WriteLine("average=" + average + "   " + "average * i=" + average * i);
                //Console.WriteLine("Math.Cos(average * i):" + Math.Cos(average * i) + "      " + "Math.Sin(average * i):" + Math.Sin(average * i));
            }
        }

    }
}
