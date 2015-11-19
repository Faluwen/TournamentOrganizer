using LoginModule.Gui;
using MainModule.Gui;
using System.Threading;
using System.Windows.Forms;
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
                    //Anmeldeform anzeigen
                    using (FormLogin login = new FormLogin())
                    {
                        DialogResult result = login.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            // Programm starten
                            
                            Application.Run(new FormMain());

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Das Programm \"Tournament Organizer\" kann nur einmal gestartet werden!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
