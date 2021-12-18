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
        readonly Timer t = new();
        private static bool showAnalog = false;
        Analog analogView;
        Digital digitalView;

        public Clock()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            analogView = new Analog(this);
            digitalView = new();

            tableLayoutPanel1.Controls.Add(analogView);
            analogView.Dock = DockStyle.Fill;
            tableLayoutPanel1.SetColumnSpan(analogView, 2);

            t.Interval = 1000;
            t.Tick += new EventHandler(OnTick);
            t.Enabled = true;
        }

        private void OnTick(object sender, EventArgs e)
        {
            analogView.Refresh();
            digitalView.textBox1.Text = DateTime.Now.ToLongTimeString();
            Text = "Clock " + DateTime.Now.ToLongTimeString();
        }

        private void btnToggleSec_Click(object sender, EventArgs e)
        {
            if (analogView.ShowSeconds)
            {
               analogView.ShowSeconds = false;
                btnToggleSec.Text = "Show Seconds";
            }
            else
            {
                analogView.ShowSeconds = true;
                btnToggleSec.Text = "Hide Seconds";
            }
            analogView.Refresh();
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