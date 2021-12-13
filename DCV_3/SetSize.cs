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
    public partial class SetSize : Form
    {
        public int columns;
        public int rows;

        public SetSize(ChessBoard parent)
        {
            InitializeComponent();

            columns = parent.columns;
            rows = parent.rows;

            numericUpDownColumns.Value = columns;
            numericUpDownRows.Value = rows;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            columns = int.Parse(numericUpDownColumns.Text);
            rows = int.Parse(numericUpDownRows.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
