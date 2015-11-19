using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UtilityModule.Data;

namespace UtilityModule.Manager
{
    internal class FileManager
    {
        internal static readonly FileManager Instance = new FileManager();

        private FileManager() { }

        //provisorium bis eine DB existiert
        internal Session Login(string username, string password)
        {
            Session session = null;
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "login.txt");

            if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password))
            {
                string line;

                // Read the file and display it line by line.
                StreamReader file = new StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    string[] accData = line.Split('|');
                    if (username == accData[0] && password == accData[1])
                    {
                        session = new Session();
                        session.Acclevel = Int32.Parse(accData[2]);
                        session.Username = username;
                        break;
                    }
                }
                file.Close();
            }
            return session;
        }

        internal Tuple<Player, Player> LastSwissFinalists()
        {
            Tuple<Player, Player> lastSwissFinalists = new Tuple<Player, Player>(new Player(), new Player());

            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "swissFinalists.txt");

            string line;

            // Read the file and display it line by line.
            StreamReader file = new StreamReader(path);
            line = file.ReadLine();

            string[] swissData = line.Split('|');
            lastSwissFinalists.Item1.Name = swissData[0];
            lastSwissFinalists.Item2.Name = swissData[1];

            file.Close();

            return lastSwissFinalists;
        }
    }
}
