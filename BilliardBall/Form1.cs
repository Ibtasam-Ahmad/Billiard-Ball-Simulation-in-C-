using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gg = CreateGraphics();
            Pen p = new Pen(Color.Red);
            SolidBrush sb = new SolidBrush(Color.Red);
            SolidBrush sb1 = new SolidBrush(this.BackColor);

            gg.DrawRectangle(p, 100, 100, 400, 350);

            double vx = 1, vy = 1, dt = 0.1;
            double x = 200, y = 325;

            for (int i = 0; i < 5000; i++)
            {
                x = x + vx * dt;
                y = y + vy * dt;

                if (x > 490 || x < 100)
                {
                    vx = -vx;
                }
                if (y > 440 || y < 100)
                {
                    vy = -vy;
                }

                gg.FillEllipse(sb, (float)x, (float)y, 10, 10);
                //Thread.Sleep(1);
                gg.FillEllipse(sb1, (float)x, (float)y, 10, 10);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics gg = CreateGraphics();
            Pen p = new Pen(Color.Red);
            SolidBrush sb = new SolidBrush(Color.Red);
            SolidBrush sb1 = new SolidBrush(this.BackColor);

            int height = 400, width = 350;

            gg.DrawRectangle(p, 100, 100, height, width);

            double vx = 1, vy = 1, dt = 0.1;
            double x = 200, y = 325;

            for (int i = 0; i < 50; i++)
            {
                x = x + vx * dt;
                y = y + vy * dt;

                if (x > (height+100-10) || x < 100)
                {
                    vx = -vx;
                }
                if (y > (width + 100 - 10) || y < 100)
                {
                    vy = -vy;
                }

                gg.FillEllipse(sb, (float)x, (float)y, 10, 10);
                //Thread.Sleep(1);
                this.Refresh();
                gg.FillEllipse(sb1, (float)x, (float)y, 10, 10);
            }
        }
    }
}
