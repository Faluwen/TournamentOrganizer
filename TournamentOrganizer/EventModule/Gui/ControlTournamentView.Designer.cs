namespace EventModule.Gui
{
    partial class ControlTournamentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlTournamentView));
            this.splitContainerTournament = new System.Windows.Forms.SplitContainer();
            this.panelTiles = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTournament)).BeginInit();
            this.splitContainerTournament.Panel1.SuspendLayout();
            this.splitContainerTournament.Panel2.SuspendLayout();
            this.splitContainerTournament.SuspendLayout();
            this.panelTiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerTournament
            // 
            this.splitContainerTournament.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTournament.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerTournament.IsSplitterFixed = true;
            this.splitContainerTournament.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTournament.Name = "splitContainerTournament";
            // 
            // splitContainerTournament.Panel1
            // 
            this.splitContainerTournament.Panel1.Controls.Add(this.panelTiles);
            // 
            // splitContainerTournament.Panel2
            // 
            this.splitContainerTournament.Panel2.Controls.Add(this.panelContent);
            this.splitContainerTournament.Size = new System.Drawing.Size(815, 472);
            this.splitContainerTournament.SplitterDistance = 220;
            this.splitContainerTournament.TabIndex = 0;
            // 
            // panelTiles
            // 
            this.panelTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTiles.Location = new System.Drawing.Point(0, 0);
            this.panelTiles.Name = "panelTiles";
            this.panelTiles.Size = new System.Drawing.Size(220, 472);
            this.panelTiles.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(591, 472);
            this.panelContent.TabIndex = 0;
            // 
            // ControlTournamentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerTournament);
            this.Name = "ControlTournamentView";
            this.Size = new System.Drawing.Size(815, 472);
            this.splitContainerTournament.Panel1.ResumeLayout(false);
            this.splitContainerTournament.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTournament)).EndInit();
            this.splitContainerTournament.ResumeLayout(false);
            this.panelTiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerTournament;
        private System.Windows.Forms.Panel panelTiles;
        private System.Windows.Forms.Panel panelContent;
    }
}
