namespace EventOrganizer.Gui
{
    partial class ControlCreateEvent
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
            this.controlCreateEventPhase11 = new EventOrganizer.Gui.ControlCreateEventPhase1();
            this.controlCreateEventPhase21 = new EventOrganizer.Gui.ControlCreateEventPhase2();
            this.controlCreateEventPhase31 = new EventOrganizer.Gui.ControlCreateEventPhase3();
            this.SuspendLayout();
            // 
            // controlCreateEventPhase11
            // 
            this.controlCreateEventPhase11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlCreateEventPhase11.Location = new System.Drawing.Point(0, 0);
            this.controlCreateEventPhase11.Name = "controlCreateEventPhase11";
            this.controlCreateEventPhase11.Size = new System.Drawing.Size(800, 450);
            this.controlCreateEventPhase11.TabIndex = 0;
            // 
            // controlCreateEventPhase21
            // 
            this.controlCreateEventPhase21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlCreateEventPhase21.Location = new System.Drawing.Point(0, 0);
            this.controlCreateEventPhase21.Name = "controlCreateEventPhase21";
            this.controlCreateEventPhase21.Size = new System.Drawing.Size(800, 450);
            this.controlCreateEventPhase21.TabIndex = 1;
            // 
            // controlCreateEventPhase31
            // 
            this.controlCreateEventPhase31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlCreateEventPhase31.Location = new System.Drawing.Point(0, 0);
            this.controlCreateEventPhase31.Name = "controlCreateEventPhase31";
            this.controlCreateEventPhase31.Size = new System.Drawing.Size(800, 450);
            this.controlCreateEventPhase31.TabIndex = 2;
            // 
            // ControlCreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlCreateEventPhase11);
            this.Controls.Add(this.controlCreateEventPhase21);
            this.Controls.Add(this.controlCreateEventPhase31);
            this.Name = "ControlCreateEvent";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlCreateEventPhase1 controlCreateEventPhase11;
        private ControlCreateEventPhase2 controlCreateEventPhase21;
        private ControlCreateEventPhase3 controlCreateEventPhase31;
    }
}
