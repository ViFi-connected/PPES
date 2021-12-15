
namespace DCV_5
{
    partial class Clock
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnToggleSec = new System.Windows.Forms.Button();
            this.btnToggleType = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnToggleSec, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnToggleType, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnToggleSec
            // 
            this.btnToggleSec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnToggleSec.AutoSize = true;
            this.btnToggleSec.Location = new System.Drawing.Point(60, 3);
            this.btnToggleSec.Name = "btnToggleSec";
            this.btnToggleSec.Size = new System.Drawing.Size(100, 25);
            this.btnToggleSec.TabIndex = 2;
            this.btnToggleSec.Text = "Hide Seconds";
            this.btnToggleSec.UseVisualStyleBackColor = true;
            this.btnToggleSec.Click += new System.EventHandler(this.btnToggleSec_Click);
            // 
            // btnToggleType
            // 
            this.btnToggleType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnToggleType.AutoSize = true;
            this.btnToggleType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnToggleType.Location = new System.Drawing.Point(3, 3);
            this.btnToggleType.Name = "btnToggleType";
            this.btnToggleType.Size = new System.Drawing.Size(51, 25);
            this.btnToggleType.TabIndex = 1;
            this.btnToggleType.Text = "Digital";
            this.btnToggleType.UseVisualStyleBackColor = true;
            this.btnToggleType.Click += new System.EventHandler(this.btnToggleType_Click);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Clock";
            this.ShowIcon = false;
            this.TopMost = true;
            this.Resize += new System.EventHandler(this.DrawAnalog);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnToggleType;
        private System.Windows.Forms.Button btnToggleSec;
    }
}

