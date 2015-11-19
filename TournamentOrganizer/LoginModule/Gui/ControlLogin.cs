using LoginModule.Controller;
using System;
using System.Windows.Forms;
using UtilityModule.Data;
using UtilityModule.Manager;

namespace LoginModule.Gui
{
    public partial class ControlLogin : UserControl
    {
        internal Session session;
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
            return !String.IsNullOrEmpty(this.textBoxPassword.Text);
        }

        private bool ValidateUsername()
        {
            return !String.IsNullOrEmpty(this.textBoxUsername.Text);
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
            if (ValidateTextEdits())
            {
                session = LoginController.Instance.Login(this.textBoxUsername.Text, CryptManager.Encrypt(this.textBoxPassword.Text));
                if (session != null)
                {
                    (this.ParentForm as FormLogin).DialogResult = DialogResult.OK;
                }
            }
        }

        internal Session Session
        {
            get
            {
                return this.session;
            }
        }
    }
}
