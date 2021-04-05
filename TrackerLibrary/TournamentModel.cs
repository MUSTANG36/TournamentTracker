using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class TournamentModel
    {
        public string TournamentName { get; set; }

        public decimal EntryFee { get; set; }

        public List<Team> EnteredTeam { get; set; } = new List<Team>();

        public List<Prizes> Prizes { get; set; } = new List<Prizes>();

        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

       





    }
}
