using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentOrganizer.Manager
{
    public class DatabaseManager
    {
        internal static readonly DatabaseManager Instance = new DatabaseManager();

        private DatabaseManager() { }

        internal bool Login(string username, string password, out string fehlermeldung)
        {
            fehlermeldung = "";
            return false;
        }
    }
}
