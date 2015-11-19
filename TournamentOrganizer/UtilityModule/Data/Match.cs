using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityModule.Data.Enumerations;

namespace UtilityModule.Data
{
    internal class Match
    {
        internal Player Player1
        {
            get;
            set;
        } = new Player();

        internal Player Player2
        {
            get;
            set;
        } = new Player();

        internal DateTime TimeOfMatch
        {
            get;
            set;
        } = new DateTime();

        internal MatchFormate MatchFormat
        {
            get;
            set;
        } = MatchFormate.Bo5;
    }
}
