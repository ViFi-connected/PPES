
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
            this.tableLayoutPanelBtn = new System.Windows.Forms.TableLayoutPanel();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.btnSetSize = new System.Windows.Forms.Button();
            this.boardPanel = new System.Windows.Forms.Panel();
            this.logPanel.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.tableLayoutPanelBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // logPanel
            // 
            this.logPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logPanel.Controls.Add(this.logTextBox);
            this.logPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.logPanel.Location = new System.Drawing.Point(0, 0);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(60, 761);
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
            this.logTextBox.Size = new System.Drawing.Size(60, 761);
            this.logTextBox.TabIndex = 0;
            // 
            // btnPanel
            // 
            this.btnPanel.AutoSize = true;
            this.btnPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPanel.Controls.Add(this.tableLayoutPanelBtn);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanel.Location = new System.Drawing.Point(60, 0);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(724, 34);
            this.btnPanel.TabIndex = 1;
            // 
            // tableLayoutPanelBtn
            // 
            this.tableLayoutPanelBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanelBtn.AutoSize = true;
            this.tableLayoutPanelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelBtn.ColumnCount = 2;
            this.tableLayoutPanelBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBtn.Controls.Add(this.btnSetColor, 0, 0);
            this.tableLayoutPanelBtn.Controls.Add(this.btnSetSize, 1, 0);
            this.tableLayoutPanelBtn.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBtn.Name = "tableLayoutPanelBtn";
            this.tableLayoutPanelBtn.RowCount = 1;
            this.tableLayoutPanelBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBtn.Size = new System.Drawing.Size(142, 31);
            this.tableLayoutPanelBtn.TabIndex = 0;
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
            this.boardPanel.Size = new System.Drawing.Size(724, 727);
            this.boardPanel.TabIndex = 2;
            // 
            // ChessBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.boardPanel);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.logPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeBox = false;
            this.Name = "ChessBoard";
            this.ShowIcon = false;
            this.Text = "ChessBoard";
            this.Load += new System.EventHandler(this.Form_Load);
            this.logPanel.ResumeLayout(false);
            this.logPanel.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            this.btnPanel.PerformLayout();
            this.tableLayoutPanelBtn.ResumeLayout(false);
            this.tableLayoutPanelBtn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel logPanel;
        private Panel btnPanel;
        private Panel boardPanel;
        private TextBox logTextBox;
        private TableLayoutPanel tableLayoutPanelBtn;
        private Button btnSetColor;
        private Button btnSetSize;
    }
}

