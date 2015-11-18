using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace EventOrganizer.Utility
{
    public static class ErrorLog
    {
        private static string executingPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string path = Path.Combine(executingPath, "ErrorLog.txt");

        /// <summary>
        /// Schreibt errorMessage mit Benutzer und Datumsstempel in ErrorLog.txt. Falls 
        /// displayMessage auf true gesetzt ist wird diese Fehlermeldung auch dem Nutzer angezeigt.
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <param name="displayMessage"></param>
        public static void LogError(string errorMessage, bool displayMessage)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine("-" + DateTime.Now.ToString() + " " + Environment.UserName + ":");
                    tw.WriteLine(" " + errorMessage);
                }
            }
            else if (File.Exists(path))
            {
                using (TextWriter tw = new StreamWriter(path, true))
                {
                    tw.WriteLine("-" + DateTime.Now.ToString() + " " + Environment.UserName + ":");
                    tw.WriteLine(" " + errorMessage);
                    tw.Close();
                }
            }

            if (displayMessage)
            {
                MessageBox.Show(errorMessage);
            }
        }
    }
}
