﻿namespace Pong
{
    partial class startscreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startscreen));
            this.start = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InfoBTN = new System.Windows.Forms.Button();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Bisque;
            this.start.Cursor = System.Windows.Forms.Cursors.Cross;
            this.start.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.start.Location = new System.Drawing.Point(27, 114);
            this.start.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(235, 84);
            this.start.TabIndex = 0;
            this.start.Text = "Start Game";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Right;
            this.webBrowser1.Location = new System.Drawing.Point(516, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(30, 31);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(534, 812);
            this.webBrowser1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(27, 282);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 480);
            this.textBox1.TabIndex = 4;
            // 
            // InfoBTN
            // 
            this.InfoBTN.BackColor = System.Drawing.Color.Bisque;
            this.InfoBTN.Cursor = System.Windows.Forms.Cursors.Cross;
            this.InfoBTN.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBTN.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.InfoBTN.Location = new System.Drawing.Point(27, 222);
            this.InfoBTN.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.InfoBTN.Name = "InfoBTN";
            this.InfoBTN.Size = new System.Drawing.Size(161, 39);
            this.InfoBTN.TabIndex = 5;
            this.InfoBTN.Text = "Infos";
            this.InfoBTN.UseVisualStyleBackColor = false;
            this.InfoBTN.Click += new System.EventHandler(this.InfoBTN_Click);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(875, 808);
            this.webBrowser2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(16, 17);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(205, 208);
            this.webBrowser2.TabIndex = 6;
            // 
            // startscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 812);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.InfoBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.start);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "startscreen";
            this.Text = "startscreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button InfoBTN;
        private System.Windows.Forms.WebBrowser webBrowser2;
    }
}