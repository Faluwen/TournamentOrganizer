﻿namespace TournamentOrganizer.Gui
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.controlRegister1 = new TournamentOrganizer.Gui.ControlRegister();
            this.SuspendLayout();
            // 
            // controlRegister1
            // 
            this.controlRegister1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlRegister1.Location = new System.Drawing.Point(0, 0);
            this.controlRegister1.Name = "controlRegister1";
            this.controlRegister1.Size = new System.Drawing.Size(265, 417);
            this.controlRegister1.TabIndex = 0;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 417);
            this.Controls.Add(this.controlRegister1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrieren";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlRegister controlRegister1;
    }
}