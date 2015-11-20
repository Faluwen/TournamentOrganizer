using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainModule.Gui
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Username) && !String.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                checkBoxRemember.Checked = true;
            }
        }

        private void Save()
        {
            if (!checkBoxRemember.Checked)
            {
                Properties.Settings.Default.Username = String.Empty;
                Properties.Settings.Default.Password = String.Empty;
                Properties.Settings.Default.AccLevel = 0;
                Properties.Settings.Default.Save();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
