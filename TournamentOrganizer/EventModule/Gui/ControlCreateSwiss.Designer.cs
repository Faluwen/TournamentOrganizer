namespace EventModule.Gui
{
    partial class ControlCreateSwiss
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.splitContainerContent = new System.Windows.Forms.SplitContainer();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEntfernen = new System.Windows.Forms.Button();
            this.textBoxNewPlayer = new System.Windows.Forms.TextBox();
            this.labelFormat = new System.Windows.Forms.Label();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.comboBoxBO = new System.Windows.Forms.ComboBox();
            this.checkBoxFinalists = new System.Windows.Forms.CheckBox();
            this.buttonDOIT = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).BeginInit();
            this.splitContainerContent.Panel1.SuspendLayout();
            this.splitContainerContent.Panel2.SuspendLayout();
            this.splitContainerContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUeberschrift
            // 
            this.labelUeberschrift.AutoSize = true;
            this.labelUeberschrift.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUeberschrift.Location = new System.Drawing.Point(217, 31);
            this.labelUeberschrift.Name = "labelUeberschrift";
            this.labelUeberschrift.Size = new System.Drawing.Size(357, 39);
            this.labelUeberschrift.TabIndex = 1;
            this.labelUeberschrift.Text = "Swiss Turnier Erstellung";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelUeberschrift);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 100);
            this.panelTop.TabIndex = 3;
            // 
            // splitContainerContent
            // 
            this.splitContainerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerContent.IsSplitterFixed = true;
            this.splitContainerContent.Location = new System.Drawing.Point(0, 100);
            this.splitContainerContent.Name = "splitContainerContent";
            // 
            // splitContainerContent.Panel1
            // 
            this.splitContainerContent.Panel1.Controls.Add(this.textBoxNewPlayer);
            this.splitContainerContent.Panel1.Controls.Add(this.buttonEntfernen);
            this.splitContainerContent.Panel1.Controls.Add(this.buttonAdd);
            this.splitContainerContent.Panel1.Controls.Add(this.labelPlayers);
            this.splitContainerContent.Panel1.Controls.Add(this.listBoxPlayers);
            // 
            // splitContainerContent.Panel2
            // 
            this.splitContainerContent.Panel2.Controls.Add(this.buttonDOIT);
            this.splitContainerContent.Panel2.Controls.Add(this.checkBoxFinalists);
            this.splitContainerContent.Panel2.Controls.Add(this.comboBoxBO);
            this.splitContainerContent.Panel2.Controls.Add(this.comboBoxFormat);
            this.splitContainerContent.Panel2.Controls.Add(this.labelFormat);
            this.splitContainerContent.Size = new System.Drawing.Size(800, 350);
            this.splitContainerContent.SplitterDistance = 398;
            this.splitContainerContent.TabIndex = 4;
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayers.Location = new System.Drawing.Point(3, 3);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(53, 16);
            this.labelPlayers.TabIndex = 4;
            this.labelPlayers.Text = "Spieler:";
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPlayers.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.ItemHeight = 16;
            this.listBoxPlayers.Location = new System.Drawing.Point(6, 22);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(389, 274);
            this.listBoxPlayers.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(213, 302);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 33);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Hinzufügen";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEntfernen
            // 
            this.buttonEntfernen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEntfernen.BackColor = System.Drawing.Color.LightCoral;
            this.buttonEntfernen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntfernen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntfernen.Location = new System.Drawing.Point(307, 302);
            this.buttonEntfernen.Name = "buttonEntfernen";
            this.buttonEntfernen.Size = new System.Drawing.Size(88, 33);
            this.buttonEntfernen.TabIndex = 6;
            this.buttonEntfernen.Text = "Entfernen";
            this.buttonEntfernen.UseVisualStyleBackColor = false;
            this.buttonEntfernen.Click += new System.EventHandler(this.buttonEntfernen_Click);
            // 
            // textBoxNewPlayer
            // 
            this.textBoxNewPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNewPlayer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPlayer.Location = new System.Drawing.Point(6, 307);
            this.textBoxNewPlayer.Name = "textBoxNewPlayer";
            this.textBoxNewPlayer.Size = new System.Drawing.Size(201, 23);
            this.textBoxNewPlayer.TabIndex = 7;
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormat.Location = new System.Drawing.Point(3, 3);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(61, 16);
            this.labelFormat.TabIndex = 8;
            this.labelFormat.Text = "Formate:";
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFormat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(6, 22);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(389, 24);
            this.comboBoxFormat.TabIndex = 9;
            // 
            // comboBoxBO
            // 
            this.comboBoxBO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBO.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBO.FormattingEnabled = true;
            this.comboBoxBO.Location = new System.Drawing.Point(6, 52);
            this.comboBoxBO.Name = "comboBoxBO";
            this.comboBoxBO.Size = new System.Drawing.Size(389, 24);
            this.comboBoxBO.TabIndex = 10;
            // 
            // checkBoxFinalists
            // 
            this.checkBoxFinalists.AutoSize = true;
            this.checkBoxFinalists.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFinalists.Location = new System.Drawing.Point(6, 82);
            this.checkBoxFinalists.Name = "checkBoxFinalists";
            this.checkBoxFinalists.Size = new System.Drawing.Size(287, 20);
            this.checkBoxFinalists.TabIndex = 11;
            this.checkBoxFinalists.Text = "Finalisten in der ersten Runde gegeneinander";
            this.checkBoxFinalists.UseVisualStyleBackColor = true;
            // 
            // buttonDOIT
            // 
            this.buttonDOIT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDOIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonDOIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDOIT.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDOIT.Location = new System.Drawing.Point(6, 108);
            this.buttonDOIT.Name = "buttonDOIT";
            this.buttonDOIT.Size = new System.Drawing.Size(389, 239);
            this.buttonDOIT.TabIndex = 8;
            this.buttonDOIT.Text = "DO IT!";
            this.buttonDOIT.UseVisualStyleBackColor = false;
            // 
            // ControlCreateSwiss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerContent);
            this.Controls.Add(this.panelTop);
            this.Name = "ControlCreateSwiss";
            this.Size = new System.Drawing.Size(800, 450);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainerContent.Panel1.ResumeLayout(false);
            this.splitContainerContent.Panel1.PerformLayout();
            this.splitContainerContent.Panel2.ResumeLayout(false);
            this.splitContainerContent.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).EndInit();
            this.splitContainerContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUeberschrift;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.SplitContainer splitContainerContent;
        private System.Windows.Forms.TextBox textBoxNewPlayer;
        private System.Windows.Forms.Button buttonEntfernen;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.Button buttonDOIT;
        private System.Windows.Forms.CheckBox checkBoxFinalists;
        private System.Windows.Forms.ComboBox comboBoxBO;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Label labelFormat;
    }
}
