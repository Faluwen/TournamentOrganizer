using System;
using EventOrganizer.Controller;

namespace EventOrganizer
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
