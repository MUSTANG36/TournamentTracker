using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class MatchupModel
    {
        public List<MatchupModel> matchups { get; set; } = new List<MatchupModel>();

        public Team Winner { get; set; }

        public int MatchupRound { get; set; }
    }
}
