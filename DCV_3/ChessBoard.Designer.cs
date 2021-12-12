
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DCV_3
{
    partial class ChessBoard
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
            this.logPanel = new System.Windows.Forms.Panel();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.btnSetSize = new System.Windows.Forms.Button();
            this.boardPanel = new System.Windows.Forms.Panel();
            this.logPanel.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logPanel
            // 
            this.logPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logPanel.Controls.Add(this.logTextBox);
            this.logPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.logPanel.Location = new System.Drawing.Point(0, 0);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(60, 450);
            this.logPanel.TabIndex = 0;
            // 
            // logTextBox
            // 
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.Location = new System.Drawing.Point(0, 0);
            this.logTextBox.MinimumSize = new System.Drawing.Size(40, 23);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(60, 450);
            this.logTextBox.TabIndex = 0;
            // 
            // btnPanel
            // 
            this.btnPanel.AutoSize = true;
            this.btnPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPanel.Controls.Add(this.tableLayoutPanel1);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanel.Location = new System.Drawing.Point(60, 0);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(740, 34);
            this.btnPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnSetColor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSetSize, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(142, 31);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSetColor
            // 
            this.btnSetColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSetColor.AutoSize = true;
            this.btnSetColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetColor.Location = new System.Drawing.Point(3, 3);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(65, 25);
            this.btnSetColor.TabIndex = 0;
            this.btnSetColor.Text = "Set Color";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // btnSetSize
            // 
            this.btnSetSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSetSize.AutoSize = true;
            this.btnSetSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetSize.Location = new System.Drawing.Point(78, 3);
            this.btnSetSize.Name = "btnSetSize";
            this.btnSetSize.Size = new System.Drawing.Size(56, 25);
            this.btnSetSize.TabIndex = 1;
            this.btnSetSize.Text = "Set Size";
            this.btnSetSize.UseVisualStyleBackColor = true;
            this.btnSetSize.Click += new System.EventHandler(this.btnSetSize_Click);
            // 
            // boardPanel
            // 
            this.boardPanel.AutoSize = true;
            this.boardPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardPanel.Location = new System.Drawing.Point(60, 34);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(740, 416);
            this.boardPanel.TabIndex = 2;
            // 
            // ChessBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boardPanel);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.logPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeBox = false;
            this.Name = "ChessBoard";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ChessBoard";
            this.Load += new System.EventHandler(this.Form_Load);
            this.logPanel.ResumeLayout(false);
            this.logPanel.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            this.btnPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel logPanel;
        private Panel btnPanel;
        private Panel boardPanel;
        private TextBox logTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSetColor;
        private Button btnSetSize;
    }
}

