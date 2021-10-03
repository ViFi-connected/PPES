using System;
using System.Data;
using System.Windows.Forms;

namespace DCV_1
{
    public partial class Calculator : Form
    {
        private bool toggleFlag = true;

        public Calculator()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void B4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void B5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void B6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void B7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void B8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void B9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void B0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }
        private void Mul_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";

        }

        private void Result_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Calc = new();
                var ans = Calc.Compute(textBox1.Text, "");
                textBox1.Text = ans.ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void Point_Click(object sender, EventArgs e)
        {
            string w = textBox1.Text.ToString();
            int len = w.Length;
            if (textBox1.Text[--len] != '.')
            {
                textBox1.Text += ".";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
            {
                textBox1.Text += text[i];
            }
        }

        private void Toggle_Click(object sender, EventArgs e)
        {
            if (toggleFlag)
            {
                Disable();
                toggleFlag = false;

            }
            else
            {
                Enable();
                toggleFlag = true;
            }
        }

        public void Disable()
        {
            textBox1.Enabled = false;
            toggle.Text = "ON";
            b0.Enabled = false;
            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            b4.Enabled = false;
            b5.Enabled = false;
            b6.Enabled = false;
            b7.Enabled = false;
            b8.Enabled = false;
            b9.Enabled = false;
            add.Enabled = false;
            sub.Enabled = false;
            mul.Enabled = false;
            div.Enabled = false;
            point.Enabled = false;
            backspace.Enabled = false;
            clear.Enabled = false;
            result.Enabled = false;
        }

        public void Enable()
        {
            textBox1.Enabled = true;
            toggle.Text = "OFF";
            b0.Enabled = true;
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;
            add.Enabled = true;
            clear.Enabled = true;
            backspace.Enabled = true;
            result.Enabled = true;
            div.Enabled = true;
            sub.Enabled = true;
            mul.Enabled = true;
            point.Enabled = true;
        }
    }
}