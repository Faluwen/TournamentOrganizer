namespace EventOrganizer.Gui
{
    partial class ControlCreateEventPhase3
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelInformation = new System.Windows.Forms.Label();
            this.textBoxStream = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxVoIP = new System.Windows.Forms.TextBox();
            this.labelVoIP = new System.Windows.Forms.Label();
            this.labelStream = new System.Windows.Forms.Label();
            this.panelUeberschrift.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUeberschrift
            // 
            this.panelUeberschrift.Controls.Add(this.labelUeberschrift);
            this.panelUeberschrift.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUeberschrift.Location = new System.Drawing.Point(0, 0);
            this.panelUeberschrift.Name = "panelUeberschrift";
            this.panelUeberschrift.Size = new System.Drawing.Size(800, 100);
            this.panelUeberschrift.TabIndex = 4;
            // 
            // labelUeberschrift
            // 
            this.labelUeberschrift.AutoSize = true;
            this.labelUeberschrift.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUeberschrift.Location = new System.Drawing.Point(203, 30);
            this.labelUeberschrift.Name = "labelUeberschrift";
            this.labelUeberschrift.Size = new System.Drawing.Size(386, 39);
            this.labelUeberschrift.TabIndex = 0;
            this.labelUeberschrift.Text = "Eventerstellung Phase 3/3";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 100);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonBack);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTime);
            this.splitContainer1.Panel1.Controls.Add(this.labelInformation);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxStream);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxVoIP);
            this.splitContainer1.Panel2.Controls.Add(this.labelVoIP);
            this.splitContainer1.Panel2.Controls.Add(this.labelStream);
            this.splitContainer1.Size = new System.Drawing.Size(800, 350);
            this.splitContainer1.SplitterDistance = 398;
            this.splitContainer1.TabIndex = 5;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBack.BackColor = System.Drawing.Color.LightCoral;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(18, 286);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 50);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Zurück";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTime.Location = new System.Drawing.Point(18, 34);
            this.textBoxTime.Multiline = true;
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(365, 204);
            this.textBoxTime.TabIndex = 7;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.Location = new System.Drawing.Point(15, 15);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(138, 16);
            this.labelInformation.TabIndex = 1;
            this.labelInformation.Text = "Information: (optional)";
            // 
            // textBoxStream
            // 
            this.textBoxStream.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStream.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStream.Location = new System.Drawing.Point(18, 94);
            this.textBoxStream.Name = "textBoxStream";
            this.textBoxStream.Size = new System.Drawing.Size(365, 23);
            this.textBoxStream.TabIndex = 19;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(243, 286);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(140, 50);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // textBoxVoIP
            // 
            this.textBoxVoIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVoIP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVoIP.Location = new System.Drawing.Point(18, 34);
            this.textBoxVoIP.Name = "textBoxVoIP";
            this.textBoxVoIP.Size = new System.Drawing.Size(365, 23);
            this.textBoxVoIP.TabIndex = 8;
            // 
            // labelVoIP
            // 
            this.labelVoIP.AutoSize = true;
            this.labelVoIP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoIP.Location = new System.Drawing.Point(15, 15);
            this.labelVoIP.Name = "labelVoIP";
            this.labelVoIP.Size = new System.Drawing.Size(161, 16);
            this.labelVoIP.TabIndex = 9;
            this.labelVoIP.Text = "VoIP Treffpunkt: (optional)";
            // 
            // labelStream
            // 
            this.labelStream.AutoSize = true;
            this.labelStream.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStream.Location = new System.Drawing.Point(15, 75);
            this.labelStream.Name = "labelStream";
            this.labelStream.Size = new System.Drawing.Size(140, 16);
            this.labelStream.TabIndex = 10;
            this.labelStream.Text = "Stream Link: (optional)";
            // 
            // ControlCreateEventPhase3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelUeberschrift);
            this.Name = "ControlCreateEventPhase3";
            this.Size = new System.Drawing.Size(800, 450);
            this.panelUeberschrift.ResumeLayout(false);
            this.panelUeberschrift.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUeberschrift;
        private System.Windows.Forms.Label labelUeberschrift;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxVoIP;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelVoIP;
        private System.Windows.Forms.Label labelStream;
        private System.Windows.Forms.TextBox textBoxStream;
    }
}
