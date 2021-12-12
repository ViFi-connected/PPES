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

            textBoxColumns.Text = columns.ToString();
            textBoxRows.Text = rows.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            columns = int.Parse(textBoxColumns.Text);
            rows = int.Parse(textBoxRows.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
