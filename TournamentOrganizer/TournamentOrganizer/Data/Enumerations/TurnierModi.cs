using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentOrganizer.Data.Enumerations
{
    public enum TurnierModi
    {
        RoundRobin = 0,
        SingleElim = 1,
        DoubleElim = 2,
        Swiss = 3,
        DoubleRoundRobin = 4,
        QuadraRoundRobin = 5,
        Gauntlet = 6
    }
}
