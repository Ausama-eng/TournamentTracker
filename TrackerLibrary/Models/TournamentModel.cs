using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents the tournament and it's all rounds, prizes and Teams
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// The unique identifier for the tournaments.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Amount of money the each team needs to put up to enter.
        /// </summary>
        public decimal Entryfee { get; set; }

        /// <summary>
        /// The set of teams that entered.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// The list of prizes for various places
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// The matchup per rounds
        /// </summary>
        public List<List<MatchModel>> Rounds { get; set; } = new List<List<MatchModel>>();


    }
}
