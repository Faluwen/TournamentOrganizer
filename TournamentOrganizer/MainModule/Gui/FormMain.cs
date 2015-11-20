using MainModule.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityModule.Data;

namespace MainModule.Gui
{
    public partial class FormMain : Form
    {
        Session session; 
        public FormMain()
        {
            InitializeComponent();
            tabControlRibbon.TabPages.Remove(tabPageAdmin);
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControlRibbon.TabPages.Remove(tabPageStartseite);
            tabControlRibbon.TabPages.Add(tabPageAdmin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControlRibbon.TabPages.Remove(tabPageAdmin);
            tabControlRibbon.TabPages.Add(tabPageStartseite);
        }

        private void buttonSwiss_Click(object sender, EventArgs e)
        {
            controlCreateSwiss.Visible = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            session = StartController.Instance.HandleLogin();
            FixLabels();
        }

        private void FixLabels()
        {
            Point locationLogout = Point.Empty;
            locationLogout.Y = 4;
            locationLogout.X = this.Size.Width - linkLabelLogout.Width - 21;
            linkLabelLogout.Location = locationLogout;

            labelEingeloggtAls.Text = "Eingeloggt als: " + session.Username;
            Point locationEingeloggt = Point.Empty;
            locationEingeloggt.Y = 4;
            locationEingeloggt.X = linkLabelLogout.Location.X - 3 - labelEingeloggtAls.Width;
            labelEingeloggtAls.Location = locationEingeloggt;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void ShowSettings()
        {
            using (FormSettings settings = new FormSettings())
            {
                settings.ShowDialog();
            }
        }
    }
}
