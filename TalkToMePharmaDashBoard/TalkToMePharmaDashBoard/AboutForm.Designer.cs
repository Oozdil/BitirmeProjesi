﻿namespace TalkToMePharmaDashBoard
{
    partial class AboutForm
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
            this.webBrowserAbout = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserAbout
            // 
            this.webBrowserAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserAbout.Location = new System.Drawing.Point(0, 0);
            this.webBrowserAbout.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserAbout.Name = "webBrowserAbout";
            this.webBrowserAbout.Size = new System.Drawing.Size(1035, 583);
            this.webBrowserAbout.TabIndex = 0;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1035, 583);
            this.Controls.Add(this.webBrowserAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserAbout;


    }
}