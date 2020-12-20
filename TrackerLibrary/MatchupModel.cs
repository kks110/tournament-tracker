using System.Collections.Generic;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents a list of teams in the matchup.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the winning team.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the currnet round.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}