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
            this.textBoxNewPlayer = new System.Windows.Forms.TextBox();
            this.buttonEntfernen = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.splitContainerRechts = new System.Windows.Forms.SplitContainer();
            this.splitContainerFinalists = new System.Windows.Forms.SplitContainer();
            this.comboBoxGewinner = new System.Windows.Forms.ComboBox();
            this.labelWinner = new System.Windows.Forms.Label();
            this.comboBoxFinalist = new System.Windows.Forms.ComboBox();
            this.labelFinalist = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxFinalists = new System.Windows.Forms.CheckBox();
            this.labelFormat = new System.Windows.Forms.Label();
            this.comboBoxBO = new System.Windows.Forms.ComboBox();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.buttonDOIT = new System.Windows.Forms.Button();
            this.splitContainerFormat = new System.Windows.Forms.SplitContainer();
            this.labelBO = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).BeginInit();
            this.splitContainerContent.Panel1.SuspendLayout();
            this.splitContainerContent.Panel2.SuspendLayout();
            this.splitContainerContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRechts)).BeginInit();
            this.splitContainerRechts.Panel1.SuspendLayout();
            this.splitContainerRechts.Panel2.SuspendLayout();
            this.splitContainerRechts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFinalists)).BeginInit();
            this.splitContainerFinalists.Panel1.SuspendLayout();
            this.splitContainerFinalists.Panel2.SuspendLayout();
            this.splitContainerFinalists.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFormat)).BeginInit();
            this.splitContainerFormat.Panel1.SuspendLayout();
            this.splitContainerFormat.Panel2.SuspendLayout();
            this.splitContainerFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUeberschrift
            // 
            this.labelUeberschrift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUeberschrift.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUeberschrift.Location = new System.Drawing.Point(0, 0);
            this.labelUeberschrift.Name = "labelUeberschrift";
            this.labelUeberschrift.Size = new System.Drawing.Size(800, 100);
            this.labelUeberschrift.TabIndex = 1;
            this.labelUeberschrift.Text = "Swiss Turnier Erstellung";
            this.labelUeberschrift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.splitContainerContent.Panel2.Controls.Add(this.splitContainerRechts);
            this.splitContainerContent.Size = new System.Drawing.Size(800, 350);
            this.splitContainerContent.SplitterDistance = 398;
            this.splitContainerContent.TabIndex = 4;
            // 
            // textBoxNewPlayer
            // 
            this.textBoxNewPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewPlayer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPlayer.Location = new System.Drawing.Point(6, 312);
            this.textBoxNewPlayer.Name = "textBoxNewPlayer";
            this.textBoxNewPlayer.Size = new System.Drawing.Size(201, 23);
            this.textBoxNewPlayer.TabIndex = 7;
            // 
            // buttonEntfernen
            // 
            this.buttonEntfernen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEntfernen.BackColor = System.Drawing.Color.LightCoral;
            this.buttonEntfernen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntfernen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntfernen.Location = new System.Drawing.Point(307, 307);
            this.buttonEntfernen.Name = "buttonEntfernen";
            this.buttonEntfernen.Size = new System.Drawing.Size(88, 33);
            this.buttonEntfernen.TabIndex = 6;
            this.buttonEntfernen.Text = "Entfernen";
            this.buttonEntfernen.UseVisualStyleBackColor = false;
            this.buttonEntfernen.Click += new System.EventHandler(this.buttonEntfernen_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(213, 307);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 33);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Hinzufügen";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            this.listBoxPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPlayers.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayers.ItemHeight = 16;
            this.listBoxPlayers.Location = new System.Drawing.Point(6, 22);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(389, 276);
            this.listBoxPlayers.TabIndex = 3;
            // 
            // splitContainerRechts
            // 
            this.splitContainerRechts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRechts.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerRechts.IsSplitterFixed = true;
            this.splitContainerRechts.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRechts.Name = "splitContainerRechts";
            this.splitContainerRechts.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRechts.Panel1
            // 
            this.splitContainerRechts.Panel1.Controls.Add(this.splitContainerFinalists);
            this.splitContainerRechts.Panel1.Controls.Add(this.panel1);
            this.splitContainerRechts.Panel1.Controls.Add(this.splitContainerFormat);
            // 
            // splitContainerRechts.Panel2
            // 
            this.splitContainerRechts.Panel2.Controls.Add(this.buttonDOIT);
            this.splitContainerRechts.Size = new System.Drawing.Size(398, 350);
            this.splitContainerRechts.SplitterDistance = 136;
            this.splitContainerRechts.TabIndex = 0;
            // 
            // splitContainerFinalists
            // 
            this.splitContainerFinalists.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainerFinalists.Enabled = false;
            this.splitContainerFinalists.Location = new System.Drawing.Point(0, 81);
            this.splitContainerFinalists.Name = "splitContainerFinalists";
            // 
            // splitContainerFinalists.Panel1
            // 
            this.splitContainerFinalists.Panel1.Controls.Add(this.comboBoxGewinner);
            this.splitContainerFinalists.Panel1.Controls.Add(this.labelWinner);
            // 
            // splitContainerFinalists.Panel2
            // 
            this.splitContainerFinalists.Panel2.Controls.Add(this.comboBoxFinalist);
            this.splitContainerFinalists.Panel2.Controls.Add(this.labelFinalist);
            this.splitContainerFinalists.Size = new System.Drawing.Size(398, 55);
            this.splitContainerFinalists.SplitterDistance = 197;
            this.splitContainerFinalists.TabIndex = 1;
            // 
            // comboBoxGewinner
            // 
            this.comboBoxGewinner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGewinner.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGewinner.FormattingEnabled = true;
            this.comboBoxGewinner.Location = new System.Drawing.Point(6, 22);
            this.comboBoxGewinner.Name = "comboBoxGewinner";
            this.comboBoxGewinner.Size = new System.Drawing.Size(188, 24);
            this.comboBoxGewinner.TabIndex = 12;
            // 
            // labelWinner
            // 
            this.labelWinner.AutoSize = true;
            this.labelWinner.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinner.Location = new System.Drawing.Point(3, 3);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(67, 16);
            this.labelWinner.TabIndex = 12;
            this.labelWinner.Text = "Gewinner:";
            // 
            // comboBoxFinalist
            // 
            this.comboBoxFinalist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFinalist.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFinalist.FormattingEnabled = true;
            this.comboBoxFinalist.Location = new System.Drawing.Point(6, 22);
            this.comboBoxFinalist.Name = "comboBoxFinalist";
            this.comboBoxFinalist.Size = new System.Drawing.Size(188, 24);
            this.comboBoxFinalist.TabIndex = 13;
            // 
            // labelFinalist
            // 
            this.labelFinalist.AutoSize = true;
            this.labelFinalist.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalist.Location = new System.Drawing.Point(3, 3);
            this.labelFinalist.Name = "labelFinalist";
            this.labelFinalist.Size = new System.Drawing.Size(53, 16);
            this.labelFinalist.TabIndex = 13;
            this.labelFinalist.Text = "Finalist:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxFinalists);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 25);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxFinalists
            // 
            this.checkBoxFinalists.AutoSize = true;
            this.checkBoxFinalists.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFinalists.Location = new System.Drawing.Point(6, 3);
            this.checkBoxFinalists.Name = "checkBoxFinalists";
            this.checkBoxFinalists.Size = new System.Drawing.Size(287, 20);
            this.checkBoxFinalists.TabIndex = 11;
            this.checkBoxFinalists.Text = "Finalisten in der ersten Runde gegeneinander";
            this.checkBoxFinalists.UseVisualStyleBackColor = true;
            this.checkBoxFinalists.CheckedChanged += new System.EventHandler(this.checkBoxFinalists_CheckedChanged);
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormat.Location = new System.Drawing.Point(3, 3);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(54, 16);
            this.labelFormat.TabIndex = 8;
            this.labelFormat.Text = "Format:";
            // 
            // comboBoxBO
            // 
            this.comboBoxBO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBO.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBO.FormattingEnabled = true;
            this.comboBoxBO.Location = new System.Drawing.Point(6, 22);
            this.comboBoxBO.Name = "comboBoxBO";
            this.comboBoxBO.Size = new System.Drawing.Size(188, 24);
            this.comboBoxBO.TabIndex = 10;
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFormat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(6, 22);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(188, 24);
            this.comboBoxFormat.TabIndex = 9;
            // 
            // buttonDOIT
            // 
            this.buttonDOIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonDOIT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDOIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDOIT.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDOIT.Location = new System.Drawing.Point(0, 0);
            this.buttonDOIT.Name = "buttonDOIT";
            this.buttonDOIT.Size = new System.Drawing.Size(398, 210);
            this.buttonDOIT.TabIndex = 8;
            this.buttonDOIT.Text = "DO IT!";
            this.buttonDOIT.UseVisualStyleBackColor = false;
            // 
            // splitContainerFormat
            // 
            this.splitContainerFormat.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainerFormat.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFormat.Name = "splitContainerFormat";
            // 
            // splitContainerFormat.Panel1
            // 
            this.splitContainerFormat.Panel1.Controls.Add(this.labelFormat);
            this.splitContainerFormat.Panel1.Controls.Add(this.comboBoxFormat);
            // 
            // splitContainerFormat.Panel2
            // 
            this.splitContainerFormat.Panel2.Controls.Add(this.labelBO);
            this.splitContainerFormat.Panel2.Controls.Add(this.comboBoxBO);
            this.splitContainerFormat.Size = new System.Drawing.Size(398, 56);
            this.splitContainerFormat.SplitterDistance = 197;
            this.splitContainerFormat.TabIndex = 2;
            // 
            // labelBO
            // 
            this.labelBO.AutoSize = true;
            this.labelBO.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBO.Location = new System.Drawing.Point(3, 3);
            this.labelBO.Name = "labelBO";
            this.labelBO.Size = new System.Drawing.Size(64, 16);
            this.labelBO.TabIndex = 10;
            this.labelBO.Text = "Best of X:";
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
            this.splitContainerContent.Panel1.ResumeLayout(false);
            this.splitContainerContent.Panel1.PerformLayout();
            this.splitContainerContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).EndInit();
            this.splitContainerContent.ResumeLayout(false);
            this.splitContainerRechts.Panel1.ResumeLayout(false);
            this.splitContainerRechts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRechts)).EndInit();
            this.splitContainerRechts.ResumeLayout(false);
            this.splitContainerFinalists.Panel1.ResumeLayout(false);
            this.splitContainerFinalists.Panel1.PerformLayout();
            this.splitContainerFinalists.Panel2.ResumeLayout(false);
            this.splitContainerFinalists.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFinalists)).EndInit();
            this.splitContainerFinalists.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainerFormat.Panel1.ResumeLayout(false);
            this.splitContainerFormat.Panel1.PerformLayout();
            this.splitContainerFormat.Panel2.ResumeLayout(false);
            this.splitContainerFormat.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFormat)).EndInit();
            this.splitContainerFormat.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonDOIT;
        private System.Windows.Forms.CheckBox checkBoxFinalists;
        private System.Windows.Forms.ComboBox comboBoxBO;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.SplitContainer splitContainerRechts;
        private System.Windows.Forms.SplitContainer splitContainerFinalists;
        private System.Windows.Forms.ComboBox comboBoxGewinner;
        private System.Windows.Forms.Label labelWinner;
        private System.Windows.Forms.ComboBox comboBoxFinalist;
        private System.Windows.Forms.Label labelFinalist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.SplitContainer splitContainerFormat;
        private System.Windows.Forms.Label labelBO;
    }
}
