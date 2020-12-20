using System.Collections.Generic;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the fee to enter the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents the Teams in the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents the prizes to be won.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents the rounds to be played.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}