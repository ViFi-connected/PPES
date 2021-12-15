using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCV_5
{
    public partial class Clock : Form
    {
        Timer t = new();
        private static bool showSeconds = true, showAnalog = false;

        Analog analogView = new();
        Digital digitalView = new();

        public Clock()
        {
            InitializeComponent();

            tableLayoutPanel1.Controls.Add(analogView);
            analogView.Dock = DockStyle.Fill;
            tableLayoutPanel1.SetColumnSpan(analogView, 2);

            t.Interval = 1000;
            t.Tick += new EventHandler(Draw);
            t.Enabled = true;

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        private void Draw(object o, EventArgs e)
        {
            int width = analogView.pictureBox1.Width;
            int height = analogView.pictureBox1.Height;

            Bitmap bmp = new Bitmap(width, height);

            Graphics g = Graphics.FromImage(bmp);
            g.Clear(BackColor);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Font f = new("Arial", 12, FontStyle.Bold);

            int diameter, radius;
            
            if (width > height)
            {
                diameter = height - 20;
                radius = diameter / 2;
            }
            else
            {
                diameter = width - 20;
                radius = diameter / 2;
            }

            g.DrawEllipse(Pens.Black, width / 2 - diameter / 2, height / 2 - diameter / 2, diameter, diameter);

            double i_h = DateTime.Now.Hour + DateTime.Now.Minute / 60.0 + DateTime.Now.Second / 3600.0;
            double i_min = DateTime.Now.Minute;
            double i_sec = DateTime.Now.Second;

            int x_sec = width / 2 + (int)(diameter / 3 * Math.Sin(2 * Math.PI * i_sec / 60));
            int y_sec = height / 2 - (int)(diameter / 3 * Math.Cos(2 * Math.PI * i_sec / 60));
            int x_min = width / 2 + (int)(0.8 * diameter / 3 * Math.Sin(2 * Math.PI * i_min / 60));
            int y_min = height / 2 - (int)(0.8 * diameter / 3 * Math.Cos(2 * Math.PI * i_min / 60));
            int x_h = width / 2 + (int)(0.5 * diameter / 3 * Math.Sin(2 * Math.PI * i_h / 12));
            int y_h = height / 2 - (int)(0.5 * diameter / 3 * Math.Cos(2 * Math.PI * i_h / 12));

            if (showSeconds)
            {
                g.DrawLine(new Pen(Color.Black, 2), width / 2, height / 2, x_sec, y_sec);
            }
            
            g.DrawLine(new Pen(Color.Black, 3), width / 2, height / 2, x_min, y_min);
            g.DrawLine(new Pen(Color.Black, 4), width / 2, height / 2, x_h, y_h);
            this.Text = "Clock " + DateTime.Now.ToLongTimeString();

            for (int j = 1; j <= 12; j++)
            {
                g.DrawString("" + j, f, Brushes.Black,
                  width / 2 + (int)((radius - 20) * Math.Sin(j * Math.PI / 6))
                  - (int)g.MeasureString("" + j, f).Width / 2,
                  height / 2 - (int)((radius - 20) * Math.Cos(j * Math.PI / 6))
                  - (int)g.MeasureString("" + j, f).Height / 2);
            }
            analogView.pictureBox1.Image = bmp;
            digitalView.textBox1.Text = DateTime.Now.ToLongTimeString();
           
            g.Dispose();
        }

        private void btnToggleSec_Click(object sender, EventArgs e)
        {
            if (showSeconds)
            {
                showSeconds = false;
                btnToggleSec.Text = "Show Seconds";
            }
            else
            {
                showSeconds = true;
                btnToggleSec.Text = "Hide Seconds";
            }
            Draw(null, null);
        }

        private void btnToggleType_Click(object sender, EventArgs e)
        {
            
            if (showAnalog)
            {
                tableLayoutPanel1.Controls.Remove(digitalView);
                tableLayoutPanel1.Controls.Add(analogView);
                analogView.Dock = DockStyle.Fill;
                tableLayoutPanel1.SetColumnSpan(analogView, 2);
                btnToggleSec.Visible = true;

                showAnalog = false;
                btnToggleType.Text = "Digital";
            }
            else
            {
                tableLayoutPanel1.Controls.Remove(analogView);
                tableLayoutPanel1.Controls.Add(digitalView);
                digitalView.Dock = DockStyle.Fill;
                tableLayoutPanel1.SetColumnSpan(digitalView, 2);
                btnToggleSec.Visible = false;

                showAnalog = true;
                btnToggleType.Text = "Analog";
            }
        }
    }
}