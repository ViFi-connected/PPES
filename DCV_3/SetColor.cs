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
    public partial class SetColor : Form
    {
        public Color color1;
        public Color color2;

        public SetColor(ChessBoard parent)
        {
            InitializeComponent();
            color1 = parent.color1;
            color2 = parent.color2;

            btnColor1.BackColor = color1;
            btnColor2.BackColor = color2;
        }

        private void btnColor1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color1 = colorDialog1.Color;
                btnColor1.BackColor = color1;
            }
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color2 = colorDialog1.Color;
                btnColor2.BackColor = color2;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
