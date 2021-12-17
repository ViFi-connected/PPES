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
        private TableLayoutPanel tableLayoutPanelBoard;

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
            tableLayoutPanelBoard = new TableLayoutPanel{ Dock = DockStyle.Fill, ColumnCount = columns, RowCount = rows };
            boardPanel.Controls.Clear();
            boardPanel.Controls.Add(tableLayoutPanelBoard);
            tableLayoutPanelBoard.SuspendLayout();

            panels = new Panel[columns, rows];

            for (var n = 0; n < columns; n++)
            {
                tableLayoutPanelBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5));
                for (var m = 0; m < rows; m++)
                {
                    tableLayoutPanelBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
                    var panel = new Panel { Dock = DockStyle.Fill };

                    var btn = new Button
                    {
                        Dock = DockStyle.Fill,
                        FlatStyle = FlatStyle.Flat,
                        Tag = (m + 1).ToString() + " " + (n + 1).ToString()
                    };
                    btn.Click += BtnOnClick;

                    panel.Controls.Add(btn);

                    tableLayoutPanelBoard.Controls.Add(panel, n, m);

                    panels[n, m] = panel;

                    if (n % 2 == 0)
                        panel.BackColor = m % 2 != 0 ? color2 : color1;
                    else
                        panel.BackColor = m % 2 != 0 ? color1 : color2;
                }
            }
            tableLayoutPanelBoard.ResumeLayout();
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
