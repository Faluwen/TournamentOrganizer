using LoginModule.Gui;
using MainModule.Gui;
using System;
using System.Threading;
using System.Windows.Forms;
using UtilityModule.Data;
using UtilityModule.Manager;

namespace MainModule.Controller
{
    public class StartController
    {
        internal static readonly StartController Instance = new StartController();

        private StartController() { }

        internal void Start()
        {
            bool neugestartet;
            // Pruefen ob das Programm schon lokal laeuft
            using (Mutex mutex = new Mutex(true, "TournamentOrganizer", out neugestartet))
            {
                if (neugestartet)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FormMain());
                }
                else
                {
                    MessageBox.Show("Das Programm \"Tournament Organizer\" kann nur einmal gestartet werden!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        internal Session HandleLogin()
        {
            Session session = new Session();

            // Pruefen ob Remember me
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Username) && !String.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                session.Username = Properties.Settings.Default.Username;
                session.Password = Properties.Settings.Default.Password;
                session.Acclevel = Properties.Settings.Default.AccLevel;
            }
            else
            {
                //Anmeldeform anzeigen
                using (FormLogin login = new FormLogin())
                {
                    DialogResult result = login.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        session = login.Session;
                        if (login.RememberMe)
                        {
                            Properties.Settings.Default.Username = session.Username;
                            Properties.Settings.Default.Password = session.Password;
                            Properties.Settings.Default.AccLevel = session.Acclevel;
                            Properties.Settings.Default.Save();
                        }
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            return session;
        }
    }
}
