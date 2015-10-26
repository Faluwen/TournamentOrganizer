namespace TournamentOrganizer.Gui
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainerRibbon = new System.Windows.Forms.SplitContainer();
            this.tabControlRibbon = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.controlCreateEvent1 = new TournamentOrganizer.Gui.ControlCreateEvent();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRibbon)).BeginInit();
            this.splitContainerRibbon.Panel1.SuspendLayout();
            this.splitContainerRibbon.Panel2.SuspendLayout();
            this.splitContainerRibbon.SuspendLayout();
            this.tabControlRibbon.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerRibbon
            // 
            this.splitContainerRibbon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRibbon.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerRibbon.IsSplitterFixed = true;
            this.splitContainerRibbon.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRibbon.Name = "splitContainerRibbon";
            this.splitContainerRibbon.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRibbon.Panel1
            // 
            this.splitContainerRibbon.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainerRibbon.Panel1.Controls.Add(this.tabControlRibbon);
            // 
            // splitContainerRibbon.Panel2
            // 
            this.splitContainerRibbon.Panel2.Controls.Add(this.panelContent);
            this.splitContainerRibbon.Size = new System.Drawing.Size(875, 562);
            this.splitContainerRibbon.SplitterDistance = 97;
            this.splitContainerRibbon.TabIndex = 0;
            // 
            // tabControlRibbon
            // 
            this.tabControlRibbon.Controls.Add(this.tabPage1);
            this.tabControlRibbon.Controls.Add(this.tabPage2);
            this.tabControlRibbon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRibbon.Location = new System.Drawing.Point(0, 0);
            this.tabControlRibbon.Name = "tabControlRibbon";
            this.tabControlRibbon.SelectedIndex = 0;
            this.tabControlRibbon.Size = new System.Drawing.Size(875, 97);
            this.tabControlRibbon.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.buttonBeenden);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(867, 71);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Startseite";
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBeenden.BackColor = System.Drawing.Color.White;
            this.buttonBeenden.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBeenden.FlatAppearance.BorderSize = 0;
            this.buttonBeenden.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBeenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBeenden.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBeenden.Image = global::TournamentOrganizer.Properties.Resources.exit;
            this.buttonBeenden.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonBeenden.Location = new System.Drawing.Point(780, 6);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(79, 60);
            this.buttonBeenden.TabIndex = 1;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBeenden.UseVisualStyleBackColor = false;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::TournamentOrganizer.Properties.Resources.add1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(8, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hinzufügen";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(867, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::TournamentOrganizer.Properties.Resources.add2;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(8, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hinzufügen";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.controlCreateEvent1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(875, 461);
            this.panelContent.TabIndex = 0;
            // 
            // controlCreateEvent1
            // 
            this.controlCreateEvent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlCreateEvent1.Location = new System.Drawing.Point(0, 0);
            this.controlCreateEvent1.Name = "controlCreateEvent1";
            this.controlCreateEvent1.Size = new System.Drawing.Size(875, 461);
            this.controlCreateEvent1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 562);
            this.Controls.Add(this.splitContainerRibbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournament Organizer";
            this.splitContainerRibbon.Panel1.ResumeLayout(false);
            this.splitContainerRibbon.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRibbon)).EndInit();
            this.splitContainerRibbon.ResumeLayout(false);
            this.tabControlRibbon.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerRibbon;
        private System.Windows.Forms.TabControl tabControlRibbon;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button button2;
        private ControlCreateEvent controlCreateEvent1;
    }
}