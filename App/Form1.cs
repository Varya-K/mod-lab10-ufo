using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        long start_x, start_y;
        long finish_x, finish_y;
        long x, y;
        double distance;
        long step;
        int n;
        long r;
        double alpha,cos_alpha,sin_alpha;


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            long dx = start_x - finish_x;
            long dy = start_y - finish_y;
            long w = panel1.Width, h = panel1.Height;
            g.TranslateTransform(w / 2, h / 2);
            float sx = (float)3 / 5 * w / Math.Max(Math.Abs(dx),100);
            float sy = (float)3 / 5 * h / Math.Max(Math.Abs(dy),100);
            float s = Math.Min(sx, sy);
            g.ScaleTransform(s,s);
            long e_r = (long)Math.Round(10 / s);
            long e_r1 = (long)Math.Round(8 / s);
            g.FillEllipse(new SolidBrush(Color.Red), dx / 2 - e_r, dy / 2 - e_r, e_r*2, e_r*2);//рисуем начальную точку
            g.FillEllipse(new SolidBrush(Color.Blue),dx / 2 - dx - e_r, dy/2 - dy - e_r, e_r*2, e_r*2);//рисуем конечную точку
            g.FillEllipse(new SolidBrush(Color.Black), dx / 2 - (start_x-x) - e_r1, dy / 2 - (start_y-y) - e_r1, e_r1 * 2, e_r1 * 2);//рисуем движующуюся точку
            g.DrawEllipse(new Pen(Color.Orange, 2 / s), dx / 2 - dx - r, dy / 2 - dy - r, r * 2, r * 2);
            l_x.Text = x.ToString();
            l_y.Text = y.ToString();
        }

        private void restart()
        {
            start_x = (long)nUD_start_x.Value;
            start_y = (long)nUD_start_y.Value;
            finish_x = (long)nUD_finish_x.Value;
            finish_y = (long)nUD_finish_y.Value;
            x = start_x;
            y = start_y;
            step = (long)nUD_step.Value;
            r = (long)nUD_r.Value;
            l_n.Text = "";
            l_d.Text = "";
            distance = Math.Sqrt((x - finish_x)* (x - finish_x) + (y - finish_y)* (y - finish_y));
            panel1.Invalidate();
            b_start.Enabled = true;
            b_pause.Enabled = false;
            timer1.Interval = (int)nUD_timer.Value;
            timer1.Enabled = false;
        }


        private int find_n(double r)
        {
            int n1 = 1;
            while (n1<100)
            {
                alpha = Functiouns.Arctg((double)(start_y - finish_y) / (start_x - finish_x), n1, finish_x - start_x > 0, finish_y - start_y > 0);
                cos_alpha = Functiouns.Cos(alpha, n1);
                sin_alpha = Functiouns.Sin(alpha, n1);
                long x1 = start_x;
                long y1 = start_y;
                double d1 = Math.Sqrt((x1 - finish_x) * (x1 - finish_x) + (y1 - finish_y) * (y1 - finish_y));
                long x2 = x1 + (long)Math.Round(step * cos_alpha);
                long y2 = y1 + (long)Math.Round(step * sin_alpha);
                double d2 = Math.Sqrt((x2 - finish_x) * (x2 - finish_x) + (y2 - finish_y) * (y2 - finish_y));
                while (d1 > r && d2 < d1)
                {
                    x1 = x2;
                    y1 = y2;
                    d1 = d2;
                    x2 = x1 + (long)Math.Round(step * cos_alpha);
                    y2 = y1 + (long)Math.Round(step * sin_alpha);
                    d2= Math.Sqrt((x2 - finish_x) * (x2 - finish_x) + (y2 - finish_y) * (y2 - finish_y));
                }
                if (d1 <= r ) break;
                else n1 += 1;
            }
            return n1;
        }
        private void Calculate()
        {
             x += (long)Math.Round(step * cos_alpha);
             y += (long)Math.Round(step * sin_alpha);
             distance = Math.Sqrt((x - finish_x) * (x - finish_x) + (y - finish_y) * (y - finish_y));
             if (distance<=r)
             {
                l_d.Text = Math.Round(distance, 6).ToString();
                timer1.Enabled = false;
                b_start.Enabled = false;
             }
        }
        private void nUD_start_x_ValueChanged(object sender, EventArgs e)
        {
            restart();
        }

        private void nUD_start_y_ValueChanged(object sender, EventArgs e)
        {
            restart();
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            restart();
            n = find_n((double)r);
            if (n == 100)
            {
                l_n.Text = "Маленькая область";
            }
            else
            {
                l_n.Text = n.ToString();
                timer1.Enabled = true;
                b_start.Enabled = false;
                b_pause.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Calculate();
            panel1.Invalidate();
        }

        private void nUD_step_ValueChanged(object sender, EventArgs e)
        {
            restart();
        }

        private void nUD_n_ValueChanged(object sender, EventArgs e)
        {
            restart();
        }

        private void nUD_timer_ValueChanged(object sender, EventArgs e)
        {
            restart();
        }

        private void b_Сreate_graph_Click(object sender, EventArgs e)
        {
            restart();
            double d = Math.Sqrt((start_x - finish_x) * (start_x - finish_x) + (start_y - finish_y) * (start_y - finish_y));
            List<double> list_n = new List<double>();
            List<double> list_relative_radius = new List<double>();
            double prev_r=d/2;
            int prev_n=1;
            int now_n = 1;
            for (double r1 = d / 2; r1 > 0; r1 -= step / 2)
            {
                now_n = find_n(r1);
                if (now_n != prev_n)
                {
                    list_n.Add((double)prev_n);
                    list_relative_radius.Add(prev_r/d);
                    prev_n = now_n;
                }
                if (now_n == 100) break;
                prev_r = r1;
            }
            if (now_n != prev_n)
            {
                list_n.Add((double)prev_n);
                list_relative_radius.Add(prev_r / d);
                prev_n = now_n;
            }
            var plot = new ScottPlot.Plot(800, 600);
            plot.AddScatter(list_relative_radius.ToArray(), list_n.ToArray());
            plot.Title("Зависимость точности расчётов от радиуса зоны попадания вокруг конечной точки");
            plot.XLabel("Отношение радиуса зоны попадания к расстоянию между начальной и конечной точкой");
            plot.YLabel("Достаточное количество членов ряда");
            plot.SaveFig("dia.png");
            MessageBox.Show("График, основанный на введёных данных, сохранён!", "Успешное сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void b_restart_Click(object sender, EventArgs e)
        {
            restart();
        }

        private void b_pause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            b_pause.Enabled = false;
            b_start.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            l_x.Text = "0";
            l_y.Text = "0";
            l_n.Text = "";
            l_d.Text = "";
            restart();
        }

        private void nUD_finish_x_ValueChanged(object sender, EventArgs e)
        {
            restart();
        }

        private void nUD_finish_y_ValueChanged(object sender, EventArgs e)
        {
            restart();
        }



    }
}
