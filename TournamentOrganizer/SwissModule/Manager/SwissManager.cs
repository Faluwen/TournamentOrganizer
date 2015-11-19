using SwissModule.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityModule.Data;
using UtilityModule.Data.Enumerations;

namespace SwissModule.Manager
{
    internal class SwissManager
    {
        internal static readonly SwissManager Instance = new SwissManager();

        private SwissManager() { }

        internal List<Match> SwissCreateOpeningRound(List<PlayerSwiss> players, Tuple<PlayerSwiss, PlayerSwiss> lastFinal, DateTime roundStart, MatchFormate format)
        {
            List<Match> result = new List<Match>();
            List<int> alreadyMatchedPlayers = new List<int>();
            Random rnd = new Random();

            if(lastFinal.Item1 != null && lastFinal.Item2 != null)
            {
                Match match = new Match(); 
                match.Player1 = lastFinal.Item1;
                alreadyMatchedPlayers.Add(players.IndexOf(lastFinal.Item1));
                match.Player2 = lastFinal.Item2;
                alreadyMatchedPlayers.Add(players.IndexOf(lastFinal.Item2));

                result.Add(match);
            }

            if (players.Count % 2 == 1)
            {
                int number = rnd.Next(0, players.Count);
                alreadyMatchedPlayers.Add(number);
                Match match = new Match();
                match.Player1 = players[number];
                Player player2 = new Player();
                player2.Name = "FREEWIN";
                match.Player2 = player2;
                match.TimeOfMatch = roundStart;
                match.MatchFormat = format;

                result.Add(match);
            }
            else
            {
                while (alreadyMatchedPlayers.Count < players.Count)
                {
                    int number = rnd.Next(0, players.Count);

                    if (!alreadyMatchedPlayers.Contains(number))
                    {
                        Match match = new Match();
                        match.Player1 = players[number];
                        alreadyMatchedPlayers.Add(number);

                        while (true)
                        {
                            int number2 = rnd.Next(0, players.Count);

                            if (number2 != number && alreadyMatchedPlayers.Contains(number2))
                            {
                                match.Player2 = players[number2];
                                alreadyMatchedPlayers.Add(number2);
                                match.TimeOfMatch = roundStart;
                                match.MatchFormat = format;

                                result.Add(match);
                                break;
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
