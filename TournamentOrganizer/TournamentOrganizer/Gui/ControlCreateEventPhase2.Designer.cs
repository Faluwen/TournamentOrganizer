namespace EventOrganizer.Gui
{
    partial class ControlCreateEventPhase2
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelUeberschrift = new System.Windows.Forms.Panel();
            this.labelUeberschrift = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonWeiter = new System.Windows.Forms.Button();
            this.controlCreateEventPhase2RoundRobin1 = new EventOrganizer.Gui.ControlCreateEventPhase2RoundRobin();
            this.panelUeberschrift.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUeberschrift
            // 
            this.panelUeberschrift.Controls.Add(this.labelUeberschrift);
            this.panelUeberschrift.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUeberschrift.Location = new System.Drawing.Point(0, 0);
            this.panelUeberschrift.Name = "panelUeberschrift";
            this.panelUeberschrift.Size = new System.Drawing.Size(800, 100);
            this.panelUeberschrift.TabIndex = 0;
            // 
            // labelUeberschrift
            // 
            this.labelUeberschrift.AutoSize = true;
            this.labelUeberschrift.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUeberschrift.Location = new System.Drawing.Point(117, 32);
            this.labelUeberschrift.Name = "labelUeberschrift";
            this.labelUeberschrift.Size = new System.Drawing.Size(547, 39);
            this.labelUeberschrift.TabIndex = 1;
            this.labelUeberschrift.Text = "Eventerstellung Phase 2/3, Stage X/X";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.controlCreateEventPhase2RoundRobin1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 275);
            this.panelContent.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonBack);
            this.panelButtons.Controls.Add(this.buttonWeiter);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 375);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(800, 75);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBack.BackColor = System.Drawing.Color.LightCoral;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(18, 11);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 50);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Zurück";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonWeiter
            // 
            this.buttonWeiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWeiter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonWeiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWeiter.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWeiter.Location = new System.Drawing.Point(645, 11);
            this.buttonWeiter.Name = "buttonWeiter";
            this.buttonWeiter.Size = new System.Drawing.Size(140, 50);
            this.buttonWeiter.TabIndex = 20;
            this.buttonWeiter.Text = "Weiter";
            this.buttonWeiter.UseVisualStyleBackColor = false;
            this.buttonWeiter.Click += new System.EventHandler(this.buttonWeiter_Click);
            // 
            // controlCreateEventPhase2RoundRobin1
            // 
            this.controlCreateEventPhase2RoundRobin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlCreateEventPhase2RoundRobin1.Location = new System.Drawing.Point(0, 0);
            this.controlCreateEventPhase2RoundRobin1.Name = "controlCreateEventPhase2RoundRobin1";
            this.controlCreateEventPhase2RoundRobin1.Size = new System.Drawing.Size(800, 275);
            this.controlCreateEventPhase2RoundRobin1.TabIndex = 0;
            // 
            // ControlCreateEventPhase2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelUeberschrift);
            this.Name = "ControlCreateEventPhase2";
            this.Size = new System.Drawing.Size(800, 450);
            this.panelUeberschrift.ResumeLayout(false);
            this.panelUeberschrift.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUeberschrift;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonWeiter;
        private System.Windows.Forms.Label labelUeberschrift;
        private ControlCreateEventPhase2RoundRobin controlCreateEventPhase2RoundRobin1;
    }
}
