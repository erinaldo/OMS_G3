﻿namespace Ordermanagement_01.Abstractor
{
    partial class Abstractor_Order_Preview
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
            this.crViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crViewer
            // 
            this.crViewer.ActiveViewIndex = -1;
            this.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewer.Location = new System.Drawing.Point(0, 12);
            this.crViewer.Name = "crViewer";
            this.crViewer.Size = new System.Drawing.Size(1058, 509);
            this.crViewer.TabIndex = 4;
            // 
            // Abstractor_Order_Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 554);
            this.Controls.Add(this.crViewer);
            this.Name = "Abstractor_Order_Preview";
            this.Text = "Abstractor_Order_Preview";
            this.Load += new System.EventHandler(this.Abstractor_Order_Preview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer;
    }
}