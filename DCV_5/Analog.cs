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
    public partial class Analog : UserControl
    {

        public bool ShowSeconds { get; set; }

        private Graphics g;
        private static Color backColor;

        public Analog(Clock parent)
        {
            InitializeComponent();

            backColor = parent.BackColor;
            ShowSeconds = true;
        }

        public void Draw(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.Clear(backColor);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Font f = new("Arial", 12, FontStyle.Bold);

            int diameter, radius;

            if (Width > Height)
            {
                diameter = Height - 20;
                radius = diameter / 2;
            }
            else
            {
                diameter = Width - 20;
                radius = diameter / 2;
            }

            g.DrawEllipse(Pens.Black, Width / 2 - diameter / 2, Height / 2 - diameter / 2, diameter, diameter);

            double i_h = DateTime.Now.Hour + DateTime.Now.Minute / 60.0 + DateTime.Now.Second / 3600.0;
            double i_min = DateTime.Now.Minute;
            double i_sec = DateTime.Now.Second;

            int x_sec = Width / 2 + (int)(diameter / 3 * Math.Sin(2 * Math.PI * i_sec / 60));
            int y_sec = Height / 2 - (int)(diameter / 3 * Math.Cos(2 * Math.PI * i_sec / 60));
            int x_min = Width / 2 + (int)(0.8 * diameter / 3 * Math.Sin(2 * Math.PI * i_min / 60));
            int y_min = Height / 2 - (int)(0.8 * diameter / 3 * Math.Cos(2 * Math.PI * i_min / 60));
            int x_h = Width / 2 + (int)(0.5 * diameter / 3 * Math.Sin(2 * Math.PI * i_h / 12));
            int y_h = Height / 2 - (int)(0.5 * diameter / 3 * Math.Cos(2 * Math.PI * i_h / 12));

            if (ShowSeconds)
            {
                g.DrawLine(new Pen(Color.Black, 2), Width / 2, Height / 2, x_sec, y_sec);
            }

            g.DrawLine(new Pen(Color.Black, 3), Width / 2, Height / 2, x_min, y_min);
            g.DrawLine(new Pen(Color.Black, 4), Width / 2, Height / 2, x_h, y_h);

            for (int j = 1; j <= 12; j++)
            {
                g.DrawString("" + j, f, Brushes.Black,
                  Width / 2 + (int)((radius - 20) * Math.Sin(j * Math.PI / 6))
                  - (int)g.MeasureString("" + j, f).Width / 2,
                  Height / 2 - (int)((radius - 20) * Math.Cos(j * Math.PI / 6))
                  - (int)g.MeasureString("" + j, f).Height / 2);
            }
        }

        private void Analog_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
