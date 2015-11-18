namespace EventModule.Gui
{
    partial class ControlCreateEventPhase1
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
            this.labelUeberschrift = new System.Windows.Forms.Label();
            this.labelGame = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.panelUeberschrift = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxPlayers = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGame = new System.Windows.Forms.ComboBox();
            this.buttonWeiter = new System.Windows.Forms.Button();
            this.comboBoxS1 = new System.Windows.Forms.ComboBox();
            this.comboBoxS3 = new System.Windows.Forms.ComboBox();
            this.comboBoxS2 = new System.Windows.Forms.ComboBox();
            this.labelStages = new System.Windows.Forms.Label();
            this.labelS1 = new System.Windows.Forms.Label();
            this.labelS2 = new System.Windows.Forms.Label();
            this.comboBoxStages = new System.Windows.Forms.ComboBox();
            this.labelS3 = new System.Windows.Forms.Label();
            this.panelUeberschrift.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUeberschrift
            // 
            this.labelUeberschrift.AutoSize = true;
            this.labelUeberschrift.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUeberschrift.Location = new System.Drawing.Point(203, 30);
            this.labelUeberschrift.Name = "labelUeberschrift";
            this.labelUeberschrift.Size = new System.Drawing.Size(386, 39);
            this.labelUeberschrift.TabIndex = 0;
            this.labelUeberschrift.Text = "Eventerstellung Phase 1/3";
            // 
            // labelGame
            // 
            this.labelGame.AutoSize = true;
            this.labelGame.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGame.Location = new System.Drawing.Point(15, 15);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(106, 16);
            this.labelGame.TabIndex = 1;
            this.labelGame.Text = "Spiel auswählen:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(15, 75);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(50, 16);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Datum:";
            // 
            // panelUeberschrift
            // 
            this.panelUeberschrift.Controls.Add(this.labelUeberschrift);
            this.panelUeberschrift.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUeberschrift.Location = new System.Drawing.Point(0, 0);
            this.panelUeberschrift.Name = "panelUeberschrift";
            this.panelUeberschrift.Size = new System.Drawing.Size(800, 100);
            this.panelUeberschrift.TabIndex = 3;
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
            this.splitContainer1.Panel1.Controls.Add(this.buttonCancel);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxPlayers);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTime);
            this.splitContainer1.Panel1.Controls.Add(this.labelTime);
            this.splitContainer1.Panel1.Controls.Add(this.labelPlayers);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxGame);
            this.splitContainer1.Panel1.Controls.Add(this.labelDate);
            this.splitContainer1.Panel1.Controls.Add(this.labelGame);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonWeiter);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxS1);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxS3);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxS2);
            this.splitContainer1.Panel2.Controls.Add(this.labelStages);
            this.splitContainer1.Panel2.Controls.Add(this.labelS1);
            this.splitContainer1.Panel2.Controls.Add(this.labelS2);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxStages);
            this.splitContainer1.Panel2.Controls.Add(this.labelS3);
            this.splitContainer1.Size = new System.Drawing.Size(800, 350);
            this.splitContainer1.SplitterDistance = 398;
            this.splitContainer1.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(18, 286);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 50);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // textBoxPlayers
            // 
            this.textBoxPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPlayers.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayers.Location = new System.Drawing.Point(18, 214);
            this.textBoxPlayers.Name = "textBoxPlayers";
            this.textBoxPlayers.Size = new System.Drawing.Size(365, 23);
            this.textBoxPlayers.TabIndex = 8;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTime.Location = new System.Drawing.Point(18, 155);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(365, 23);
            this.textBoxTime.TabIndex = 7;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(15, 135);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(61, 16);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Startzeit:";
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayers.Location = new System.Drawing.Point(15, 195);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(149, 16);
            this.labelPlayers.TabIndex = 5;
            this.labelPlayers.Text = "maximale Spieleranzahl:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(365, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // comboBoxGame
            // 
            this.comboBoxGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGame.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGame.FormattingEnabled = true;
            this.comboBoxGame.Location = new System.Drawing.Point(18, 34);
            this.comboBoxGame.Name = "comboBoxGame";
            this.comboBoxGame.Size = new System.Drawing.Size(365, 24);
            this.comboBoxGame.TabIndex = 3;
            // 
            // buttonWeiter
            // 
            this.buttonWeiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWeiter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonWeiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWeiter.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWeiter.Location = new System.Drawing.Point(243, 286);
            this.buttonWeiter.Name = "buttonWeiter";
            this.buttonWeiter.Size = new System.Drawing.Size(140, 50);
            this.buttonWeiter.TabIndex = 18;
            this.buttonWeiter.Text = "Weiter";
            this.buttonWeiter.UseVisualStyleBackColor = false;
            this.buttonWeiter.Click += new System.EventHandler(this.buttonWeiter_Click);
            // 
            // comboBoxS1
            // 
            this.comboBoxS1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxS1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxS1.FormattingEnabled = true;
            this.comboBoxS1.Location = new System.Drawing.Point(18, 92);
            this.comboBoxS1.Name = "comboBoxS1";
            this.comboBoxS1.Size = new System.Drawing.Size(365, 24);
            this.comboBoxS1.TabIndex = 17;
            // 
            // comboBoxS3
            // 
            this.comboBoxS3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxS3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxS3.FormattingEnabled = true;
            this.comboBoxS3.Location = new System.Drawing.Point(18, 214);
            this.comboBoxS3.Name = "comboBoxS3";
            this.comboBoxS3.Size = new System.Drawing.Size(365, 24);
            this.comboBoxS3.TabIndex = 16;
            // 
            // comboBoxS2
            // 
            this.comboBoxS2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxS2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxS2.FormattingEnabled = true;
            this.comboBoxS2.Location = new System.Drawing.Point(18, 154);
            this.comboBoxS2.Name = "comboBoxS2";
            this.comboBoxS2.Size = new System.Drawing.Size(365, 24);
            this.comboBoxS2.TabIndex = 15;
            // 
            // labelStages
            // 
            this.labelStages.AutoSize = true;
            this.labelStages.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStages.Location = new System.Drawing.Point(15, 15);
            this.labelStages.Name = "labelStages";
            this.labelStages.Size = new System.Drawing.Size(94, 16);
            this.labelStages.TabIndex = 9;
            this.labelStages.Text = "Anzahl Stages:";
            // 
            // labelS1
            // 
            this.labelS1.AutoSize = true;
            this.labelS1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS1.Location = new System.Drawing.Point(15, 75);
            this.labelS1.Name = "labelS1";
            this.labelS1.Size = new System.Drawing.Size(98, 16);
            this.labelS1.TabIndex = 10;
            this.labelS1.Text = "Modus Stage 1:";
            // 
            // labelS2
            // 
            this.labelS2.AutoSize = true;
            this.labelS2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS2.Location = new System.Drawing.Point(15, 135);
            this.labelS2.Name = "labelS2";
            this.labelS2.Size = new System.Drawing.Size(98, 16);
            this.labelS2.TabIndex = 14;
            this.labelS2.Text = "Modus Stage 2:";
            // 
            // comboBoxStages
            // 
            this.comboBoxStages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStages.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStages.FormattingEnabled = true;
            this.comboBoxStages.Location = new System.Drawing.Point(18, 34);
            this.comboBoxStages.Name = "comboBoxStages";
            this.comboBoxStages.Size = new System.Drawing.Size(365, 24);
            this.comboBoxStages.TabIndex = 11;
            // 
            // labelS3
            // 
            this.labelS3.AutoSize = true;
            this.labelS3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS3.Location = new System.Drawing.Point(15, 195);
            this.labelS3.Name = "labelS3";
            this.labelS3.Size = new System.Drawing.Size(98, 16);
            this.labelS3.TabIndex = 13;
            this.labelS3.Text = "Modus Stage 3:";
            // 
            // ControlCreateEventPhase1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelUeberschrift);
            this.Name = "ControlCreateEventPhase1";
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

        private System.Windows.Forms.Label labelUeberschrift;
        private System.Windows.Forms.Label labelGame;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Panel panelUeberschrift;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxPlayers;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxGame;
        private System.Windows.Forms.Button buttonWeiter;
        private System.Windows.Forms.ComboBox comboBoxS1;
        private System.Windows.Forms.ComboBox comboBoxS3;
        private System.Windows.Forms.ComboBox comboBoxS2;
        private System.Windows.Forms.Label labelStages;
        private System.Windows.Forms.Label labelS1;
        private System.Windows.Forms.Label labelS2;
        private System.Windows.Forms.ComboBox comboBoxStages;
        private System.Windows.Forms.Label labelS3;
    }
}
