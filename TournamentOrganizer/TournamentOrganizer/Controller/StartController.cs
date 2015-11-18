using System.Threading;
using System.Windows.Forms;

namespace EventOrganizer.Controller
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

                    //Application.EnableVisualStyles();
                    //Application.SetCompatibleTextRenderingDefault(false);
                    //Application.Run(new FormMain());

                    // Anmeldeform anzeigen
                    //using (FormLogin login = new FormLogin())
                    //{
                    //    DialogResult result = login.ShowDialog();
                    //    if (result == DialogResult.OK)
                    //    {
                    //        // Programm starten
                    //        Application.EnableVisualStyles();
                    //        Application.SetCompatibleTextRenderingDefault(false);
                    //        Application.Run(new FormLogin());

                    //    }
                    //}
                }
                else
                {
                    MessageBox.Show("Das Programm \"Tournament Organizer\" kann nur einmal gestartet werden!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
