
namespace DCV_1
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.result = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.toggle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 46);
            this.textBox1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.result, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.b0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.point, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.div, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.b9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.b8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.b7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.mul, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.b6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.b5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.b4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sub, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.b3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.b2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.b1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.add, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.clear, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.backspace, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.toggle, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 335);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // result
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.result, 2);
            this.result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result.Location = new System.Drawing.Point(157, 283);
            this.result.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(150, 37);
            this.result.TabIndex = 18;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.Result_Click);
            // 
            // b0
            // 
            this.b0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b0.Location = new System.Drawing.Point(80, 283);
            this.b0.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(71, 37);
            this.b0.TabIndex = 17;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.B0_Click);
            // 
            // point
            // 
            this.point.Dock = System.Windows.Forms.DockStyle.Fill;
            this.point.Location = new System.Drawing.Point(3, 283);
            this.point.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(71, 37);
            this.point.TabIndex = 16;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.Point_Click);
            // 
            // div
            // 
            this.div.Dock = System.Windows.Forms.DockStyle.Fill;
            this.div.Location = new System.Drawing.Point(234, 216);
            this.div.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(73, 37);
            this.div.TabIndex = 15;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.Div_Click);
            // 
            // b9
            // 
            this.b9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b9.Location = new System.Drawing.Point(157, 216);
            this.b9.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(71, 37);
            this.b9.TabIndex = 14;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.B9_Click);
            // 
            // b8
            // 
            this.b8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b8.Location = new System.Drawing.Point(80, 216);
            this.b8.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(71, 37);
            this.b8.TabIndex = 13;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.B8_Click);
            // 
            // b7
            // 
            this.b7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b7.Location = new System.Drawing.Point(3, 216);
            this.b7.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(71, 37);
            this.b7.TabIndex = 12;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.B7_Click);
            // 
            // mul
            // 
            this.mul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mul.Location = new System.Drawing.Point(234, 149);
            this.mul.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(73, 37);
            this.mul.TabIndex = 11;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // b6
            // 
            this.b6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b6.Location = new System.Drawing.Point(157, 149);
            this.b6.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(71, 37);
            this.b6.TabIndex = 10;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.B6_Click);
            // 
            // b5
            // 
            this.b5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b5.Location = new System.Drawing.Point(80, 149);
            this.b5.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(71, 37);
            this.b5.TabIndex = 9;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.B5_Click);
            // 
            // b4
            // 
            this.b4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b4.Location = new System.Drawing.Point(3, 149);
            this.b4.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(71, 37);
            this.b4.TabIndex = 8;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.B4_Click);
            // 
            // sub
            // 
            this.sub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sub.Location = new System.Drawing.Point(234, 82);
            this.sub.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(73, 37);
            this.sub.TabIndex = 7;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // b3
            // 
            this.b3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b3.Location = new System.Drawing.Point(157, 82);
            this.b3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(71, 37);
            this.b3.TabIndex = 6;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.B3_Click);
            // 
            // b2
            // 
            this.b2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b2.Location = new System.Drawing.Point(80, 82);
            this.b2.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(71, 37);
            this.b2.TabIndex = 5;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.B2_Click);
            // 
            // b1
            // 
            this.b1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b1.Location = new System.Drawing.Point(3, 82);
            this.b1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(71, 37);
            this.b1.TabIndex = 4;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.B1_Click);
            // 
            // add
            // 
            this.add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add.Location = new System.Drawing.Point(234, 15);
            this.add.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(73, 37);
            this.add.TabIndex = 3;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // clear
            // 
            this.clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clear.Location = new System.Drawing.Point(157, 15);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(71, 37);
            this.clear.TabIndex = 2;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // backspace
            // 
            this.backspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backspace.Location = new System.Drawing.Point(80, 15);
            this.backspace.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(71, 37);
            this.backspace.TabIndex = 1;
            this.backspace.Text = "<<";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // toggle
            // 
            this.toggle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggle.Location = new System.Drawing.Point(3, 15);
            this.toggle.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.toggle.Name = "toggle";
            this.toggle.Size = new System.Drawing.Size(71, 37);
            this.toggle.TabIndex = 0;
            this.toggle.Text = "OFF";
            this.toggle.UseVisualStyleBackColor = true;
            this.toggle.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button toggle;
    }
}

