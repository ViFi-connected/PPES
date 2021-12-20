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

        #region Buttons

        private void radioBtnCheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            switch (btn.Tag)
            {
                case "8":
                    numberOfBits = 8;
                    break;
                case "16":
                    numberOfBits = 16;
                    break;
                case "32":
                    numberOfBits = 32;
                    break;
                default:
                    break;
            }
            ParseInput();
            SetCheckboxes();
            SetBits();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ParseInput();
            SetBits();
        }

        #endregion

        private void ParseInput()
        {
            if (uint.TryParse(textBoxInput.Text, out uint input))
            {
                Update(input);
            }
            else
            {
                MessageBox.Show("Enter a number from 0 to 4 294 967 295", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            uint cisloZBitu = 0;
            uint bit = 1;
            for (int i = 0; i <= (numberOfBits - 1); i++)
            {
                CheckBox box = flowLayoutPanel1.Controls[i] as CheckBox;
                if (box.Checked)
                    cisloZBitu |= bit << (int)box.Tag;
                else
                    cisloZBitu &= ~(bit << (int)box.Tag);

            }
            Update(cisloZBitu);
        }

        private void Update(uint value)
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
            switch (numberOfBits)
            {
                case 8:
                    textBoxHex.Text = Convert.ToString((byte)value, 16);
                    textBoxBin.Text = Convert.ToString((byte)value, 2);
                    break;
                case 16:
                    textBoxHex.Text = Convert.ToString((ushort)value, 16);
                    textBoxBin.Text = Convert.ToString((ushort)value, 2);
                    break;
                case 32:
                    textBoxHex.Text = Convert.ToString(value, 16);
                    textBoxBin.Text = Convert.ToString(value, 2);
                    break;
                default:
                    break;
            }
            textBoxDec.Text = value.ToString();
        }

        private static bool[] ToBinary(object input, short bits)
        {
            bool[] binary = new bool[bits];

            for (int i = 0; i <= (short)(bits - 1); i++)
            {
                int mask = 1 << i;
                binary[i] = (Convert.ToUInt32(input) & mask) != 0;
            }

            return binary;
        }
    }
}
