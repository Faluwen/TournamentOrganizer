using MainModule.Controller;
using System;

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
