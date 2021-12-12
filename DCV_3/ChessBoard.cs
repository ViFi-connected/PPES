using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCV_3
{
    public partial class ChessBoard : Form
    {
        private Panel[,] panels;

        public int columns = 12;
        public int rows = 12;
        public Color color1 = Color.White;
        public Color color2 = Color.DarkGray;

        public ChessBoard()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            DrawBoard(columns, rows, color1, color2);
        }

        private void DrawBoard(int columns, int rows, Color color1, Color color2)
        {
            boardPanel.SuspendLayout();
            boardPanel.Controls.Clear();

            const int tileSize = 40;

            // initialize the "chess board"
            panels = new Panel[columns, rows];

            // double for loop to handle all rows and columns
            for (var n = 0; n < columns; n++)
            {
                for (var m = 0; m < rows; m++)
                {
                    // create new Panel control which will be one 
                    // chess board tile
                    var panel = new Panel
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(tileSize * n, tileSize * m),
                    };

                    var btn = new Button
                    {
                        Dock = DockStyle.Fill,
                        FlatStyle = FlatStyle.Flat,
                        Tag = (m + 1).ToString() + " " + (n + 1).ToString()
                    };
                    btn.Click += BtnOnClick;

                    panel.Controls.Add(btn);

                    // add to Form's Controls so that they show up
                    boardPanel.Controls.Add(panel);

                    // add to our 2d array of panels for future use
                    panels[n, m] = panel;

                    // color the backgrounds
                    if (n % 2 == 0)
                        panel.BackColor = m % 2 != 0 ? color2 : color1;
                    else
                        panel.BackColor = m % 2 != 0 ? color1 : color2;
                }
            }
            boardPanel.ResumeLayout();
        }

        private void ChangeColors(Color color1, Color color2)
        {
            for (int x = 0; x < panels.GetLength(0); x++)
            {
                for (int y = 0; y < panels.GetLength(1); y++)
                {
                    if (x % 2 == 0)
                        panels[x, y].BackColor = y % 2 != 0 ? color2 : color1;
                    else
                        panels[x, y].BackColor = y % 2 != 0 ? color1 : color2;
                }
            }
        }

        void BtnOnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            logTextBox.AppendText(btn.Tag.ToString());
            logTextBox.AppendText(Environment.NewLine);
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            SetColor setColor = new SetColor(this);

            if (setColor.ShowDialog(this) == DialogResult.OK)
            {
                color1 = setColor.color1;
                color2 = setColor.color2;

                ChangeColors(color1, color2);
                boardPanel.Refresh();
            }
            else return;
        }

        private void btnSetSize_Click(object sender, EventArgs e)
        {
            SetSize setSize = new SetSize(this);

            if (setSize.ShowDialog(this) == DialogResult.OK)
            {

                columns = setSize.columns;
                rows = setSize.rows;

                DrawBoard(columns, rows, color1, color2);
            }
            else return;
        }
    }
}
