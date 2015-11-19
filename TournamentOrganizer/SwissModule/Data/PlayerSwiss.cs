using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityModule.Data;

namespace SwissModule.Data
{
    internal class PlayerSwiss : Player
    {
        internal int Points
        {
            get;
            set;
        } = 0;

        internal int Ratio
        {
            get;
            set;
        } = 0;

        internal List<PlayerSwiss> MetOpponnents
        {
            get;
            set;
        } = new List<PlayerSwiss>();
    }
}
