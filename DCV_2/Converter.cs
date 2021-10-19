using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCV_2
{
    public partial class Converter : Form
    {
        Int16 numberOfBits = 0;
        bool[] binary;

        public Converter()
        {
            InitializeComponent();
        }

        #region RadioButtons
        private void radioBtn8_CheckedChanged(object sender, EventArgs e)
        {
            numberOfBits = 8;
            ParseInput();
            SetCheckboxes();
            SetBits();
        }

        private void radioBtn16_CheckedChanged(object sender, EventArgs e)
        {
            numberOfBits = 16;
            ParseInput();
            SetCheckboxes();
            SetBits();

        }

        private void radioBtn32_CheckedChanged(object sender, EventArgs e)
        {
            numberOfBits = 32;
            ParseInput();
            SetCheckboxes();
            SetBits();
        } 
        #endregion

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ParseInput();
            SetBits();
        }

        private void ParseInput()
        {
            if (int.TryParse(textBoxInput.Text, out int input))
            {
                Update(input);
            }
            else
            {
                MessageBox.Show("Zadejte číslo v rozsahu od -2147483648 do 2147483647", "Chybný vstup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetCheckboxes()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = numberOfBits - 1; i >= 0; i--)
            {
                CheckBox checkBox = new()
                {
                    Tag = i,
                    Text = i.ToString(),
                    Width = 24,
                    Height = 40,
                    CheckAlign = ContentAlignment.BottomCenter,
                    TextAlign = ContentAlignment.BottomCenter,
                    Margin = Padding.Empty
                };

                checkBox.Click += checkboxOnClick;

                flowLayoutPanel1.Controls.Add(checkBox);
            }
        }
        private void SetBits()
        {
            CheckBox box;
            for (int i = 0; i <= (numberOfBits - 1); i++)
            {
                box = flowLayoutPanel1.Controls[i] as CheckBox;
                if (binary[(numberOfBits - 1) - i] == true)
                {
                    box.Checked = true;
                }
                else
                {
                    box.Checked = false;
                }
            }
        }

        private void checkboxOnClick(object sender, EventArgs e)
        {
            int cisloZBitu = 0;
            for (int i = 0; i <= (numberOfBits - 1); i++)
            {
                CheckBox box = flowLayoutPanel1.Controls[i] as CheckBox;
                if (box.Checked)
                    cisloZBitu |= 1 << (int)box.Tag;
                else
                    cisloZBitu &= ~(1 << (int)box.Tag);

            }
            Update(cisloZBitu);
        }

        private void Update(int value)
        {
            binary = ToBinary(value, numberOfBits);
            string binaryOutput = null;
            for (int i = numberOfBits - 1; i >= 0; i--)
            {
                binaryOutput += (binary[i] == true) ? "1" : "0";
                if ((i + 1) % 8 == 1 && numberOfBits != 8)
                {
                    binaryOutput += " ";
                }
            }
            textBoxDec.Text = value.ToString();
            textBoxHex.Text = string.Join(" ", BitConverter.GetBytes(value).Reverse().Select(x => x.ToString("X")));
            textBoxBin.Text = binaryOutput;
        }

        private static bool[] ToBinary(int input, short bits)
        {
            bool[] binary = new bool[bits];

            for (int i = 0; i <= (short)(bits - 1); i++)
            {
                int mask = 1 << i;
                binary[i] = (input & mask) != 0;
            }

            return binary;
        }
    }
}
