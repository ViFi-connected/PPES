using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace DCV_1
{
    public partial class Calculator : Form
    {
        private bool toggleFlag = true;
        private bool clearText = false;
        private double operand, lastOperand;
        private string operation, lastOperation;

        public Calculator()
        {
            InitializeComponent();
        }

        private void NumberOnClick(object sender, EventArgs e)
        {
            if (clearText)
            {
                textBox1.Clear();
                clearText = false;
            }
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        private void OperationOnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            operation = btn.Text;
            operand = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);

            if (operation == lastOperation && lastOperation != null)
            {
                Compute(operation, operand);
            }
            else
            {
                lastOperand = operand;
            }
            lastOperation = operation;
            clearText = true;
        }

        private void Compute(string operation, double operand)
        {
            double result = 0.0;
            switch (operation)
            {
                case "+":
                    result = lastOperand + operand;
                    break;
                case "-":
                    result = lastOperand - operand;
                    break;
                case "*":
                    result = lastOperand * operand; 
                    break;
                case "/":
                    result = lastOperand / operand;
                    break;
                default:
                    break;
            }
            if (double.IsInfinity(result))
            {
                MessageBox.Show("Division by zero not allowed", "Invalid operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                lastOperand = 0;
                lastOperation = null;
            }
            else
            {
                textBox1.Text = result.ToString();
                lastOperand = result;
            }
        }

        private void Result_Click(object sender, EventArgs e)
        {
            operand = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            Compute(lastOperation, operand);
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
            lastOperand = 0;
            lastOperation = null;
            
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