using System.Windows.Forms;
using UtilityModule.Data;

namespace LoginModule.Gui
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        internal Session Session
        {
            get
            {
                return controlLogin1.Session;
            }
        }

        internal bool RememberMe
        {
            get
            {
                return controlLogin1.RememberMe;
            }
        }
    }
}
