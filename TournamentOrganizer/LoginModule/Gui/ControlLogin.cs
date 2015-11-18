using System;
using System.Windows.Forms;

namespace LoginModule.Gui
{
    public partial class ControlLogin : UserControl
    {
        public ControlLogin()
        {
            InitializeComponent();
        }

        private bool ValidateTextEdits()
        {
            return (ValidateUsername() & ValidatePassword());
        }

        private bool ValidatePassword()
        {
            return true;
        }

        private bool ValidateUsername()
        {
            return true;
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (this.ParentForm as FormLogin).Visible = false;
            using (FormRegister formRegi = new FormRegister())
            {
                DialogResult result = formRegi.ShowDialog();
            }
            (this.ParentForm as FormLogin).Visible = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // TODO: Login -> Datenbank Q_Q
        }
    }
}
