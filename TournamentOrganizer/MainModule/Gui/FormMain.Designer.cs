namespace MainModule.Gui
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
            this.tabPageStartseite = new System.Windows.Forms.TabPage();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.panelContent = new System.Windows.Forms.Panel();
            this.controlCreateSwiss = new EventModule.Gui.ControlCreateSwiss();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonSwiss = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonBeenden2 = new System.Windows.Forms.Button();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.labelEingeloggtAls = new System.Windows.Forms.Label();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRibbon)).BeginInit();
            this.splitContainerRibbon.Panel1.SuspendLayout();
            this.splitContainerRibbon.Panel2.SuspendLayout();
            this.splitContainerRibbon.SuspendLayout();
            this.tabControlRibbon.SuspendLayout();
            this.tabPageStartseite.SuspendLayout();
            this.tabPageAdmin.SuspendLayout();
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
            this.tabControlRibbon.Controls.Add(this.tabPageStartseite);
            this.tabControlRibbon.Controls.Add(this.tabPageAdmin);
            this.tabControlRibbon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRibbon.Location = new System.Drawing.Point(0, 0);
            this.tabControlRibbon.Name = "tabControlRibbon";
            this.tabControlRibbon.SelectedIndex = 0;
            this.tabControlRibbon.Size = new System.Drawing.Size(875, 97);
            this.tabControlRibbon.TabIndex = 0;
            // 
            // tabPageStartseite
            // 
            this.tabPageStartseite.BackColor = System.Drawing.Color.White;
            this.tabPageStartseite.Controls.Add(this.buttonSettings);
            this.tabPageStartseite.Controls.Add(this.buttonSwiss);
            this.tabPageStartseite.Controls.Add(this.buttonBeenden);
            this.tabPageStartseite.Location = new System.Drawing.Point(4, 22);
            this.tabPageStartseite.Name = "tabPageStartseite";
            this.tabPageStartseite.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStartseite.Size = new System.Drawing.Size(867, 71);
            this.tabPageStartseite.TabIndex = 0;
            this.tabPageStartseite.Text = "Startseite";
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.buttonBeenden2);
            this.tabPageAdmin.Controls.Add(this.buttonAddEvent);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdmin.Size = new System.Drawing.Size(867, 71);
            this.tabPageAdmin.TabIndex = 1;
            this.tabPageAdmin.Text = "Adminbereich";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.controlCreateSwiss);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(875, 461);
            this.panelContent.TabIndex = 0;
            // 
            // controlCreateSwiss
            // 
            this.controlCreateSwiss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlCreateSwiss.Location = new System.Drawing.Point(0, 0);
            this.controlCreateSwiss.Name = "controlCreateSwiss";
            this.controlCreateSwiss.Size = new System.Drawing.Size(875, 461);
            this.controlCreateSwiss.TabIndex = 0;
            this.controlCreateSwiss.Visible = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.BackColor = System.Drawing.Color.White;
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Image = global::MainModule.Properties.Resources.process_idle_kde;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSettings.Location = new System.Drawing.Point(700, 6);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(88, 60);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.Text = "Einstellungen";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonSwiss
            // 
            this.buttonSwiss.BackColor = System.Drawing.Color.White;
            this.buttonSwiss.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSwiss.FlatAppearance.BorderSize = 0;
            this.buttonSwiss.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSwiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwiss.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwiss.Image = global::MainModule.Properties.Resources.joypad;
            this.buttonSwiss.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSwiss.Location = new System.Drawing.Point(8, 6);
            this.buttonSwiss.Name = "buttonSwiss";
            this.buttonSwiss.Size = new System.Drawing.Size(80, 60);
            this.buttonSwiss.TabIndex = 2;
            this.buttonSwiss.Text = "Swiss Event";
            this.buttonSwiss.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSwiss.UseVisualStyleBackColor = false;
            this.buttonSwiss.Click += new System.EventHandler(this.buttonSwiss_Click);
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
            this.buttonBeenden.Image = global::MainModule.Properties.Resources.exit;
            this.buttonBeenden.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonBeenden.Location = new System.Drawing.Point(794, 6);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(65, 60);
            this.buttonBeenden.TabIndex = 1;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBeenden.UseVisualStyleBackColor = false;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // buttonBeenden2
            // 
            this.buttonBeenden2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBeenden2.BackColor = System.Drawing.Color.White;
            this.buttonBeenden2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBeenden2.FlatAppearance.BorderSize = 0;
            this.buttonBeenden2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBeenden2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBeenden2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBeenden2.Image = global::MainModule.Properties.Resources.exit;
            this.buttonBeenden2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonBeenden2.Location = new System.Drawing.Point(794, 6);
            this.buttonBeenden2.Name = "buttonBeenden2";
            this.buttonBeenden2.Size = new System.Drawing.Size(65, 60);
            this.buttonBeenden2.TabIndex = 2;
            this.buttonBeenden2.Text = "Beenden";
            this.buttonBeenden2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBeenden2.UseVisualStyleBackColor = false;
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.BackColor = System.Drawing.Color.White;
            this.buttonAddEvent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAddEvent.FlatAppearance.BorderSize = 0;
            this.buttonAddEvent.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEvent.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEvent.Image = global::MainModule.Properties.Resources.address_book_add;
            this.buttonAddEvent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddEvent.Location = new System.Drawing.Point(8, 6);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(97, 60);
            this.buttonAddEvent.TabIndex = 1;
            this.buttonAddEvent.Text = "Event erstellen";
            this.buttonAddEvent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddEvent.UseVisualStyleBackColor = false;
            this.buttonAddEvent.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelEingeloggtAls
            // 
            this.labelEingeloggtAls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEingeloggtAls.AutoSize = true;
            this.labelEingeloggtAls.BackColor = System.Drawing.Color.White;
            this.labelEingeloggtAls.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEingeloggtAls.Location = new System.Drawing.Point(250, 5);
            this.labelEingeloggtAls.Name = "labelEingeloggtAls";
            this.labelEingeloggtAls.Size = new System.Drawing.Size(135, 14);
            this.labelEingeloggtAls.TabIndex = 4;
            this.labelEingeloggtAls.Text = "Eingeloggt als: Faluwen";
            this.labelEingeloggtAls.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.BackColor = System.Drawing.Color.White;
            this.linkLabelLogout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogout.Location = new System.Drawing.Point(450, 5);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(64, 14);
            this.linkLabelLogout.TabIndex = 5;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Ausloggen";
            this.linkLabelLogout.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 562);
            this.Controls.Add(this.labelEingeloggtAls);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.splitContainerRibbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournament Organizer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainerRibbon.Panel1.ResumeLayout(false);
            this.splitContainerRibbon.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRibbon)).EndInit();
            this.splitContainerRibbon.ResumeLayout(false);
            this.tabControlRibbon.ResumeLayout(false);
            this.tabPageStartseite.ResumeLayout(false);
            this.tabPageAdmin.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerRibbon;
        private System.Windows.Forms.TabControl tabControlRibbon;
        private System.Windows.Forms.TabPage tabPageStartseite;
        private System.Windows.Forms.TabPage tabPageAdmin;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.Button buttonSwiss;
        private System.Windows.Forms.Button buttonBeenden2;
        private EventModule.Gui.ControlCreateSwiss controlCreateSwiss;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.Label labelEingeloggtAls;
    }
}