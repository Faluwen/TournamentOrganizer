using System;
using TournamentOrganizer.Controller;

namespace TournamentOrganizer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StartController.Instance.Start();
        }
    }
}
