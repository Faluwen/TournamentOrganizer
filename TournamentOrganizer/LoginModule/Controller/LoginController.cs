using System;
using UtilityModule.Data;
using UtilityModule.Manager;

namespace LoginModule.Controller
{
    public class LoginController
    {
        internal static readonly LoginController Instance = new LoginController();

        private LoginController() { }

        internal Session Login(string username, string password)
        {
            return FileManager.Instance.Login(username, password);
        }

        internal void Register(string username, string password, out string fehlermeldung)
        {
            fehlermeldung = String.Empty;
        }
    }
}
