using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represent a team in a match
    /// </summary>
    public class MatchEntryModel
    {
        /// <summary>
        /// The unique identifier of the match entry
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represent identifier for a team
        /// </summary>
        public int TeamCompetingId { get; set; }

        /// <summary>
        /// Represent one team in the match.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        
        /// <summary>
        /// Represent the score for this particular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represent the identifier of parent match
        /// </summary>
        public int ParentMatchId { get; set; }

        /// <summary>
        /// Represent the match that this team came 
        /// from as the winner
        /// </summary>
        public MatchModel ParentMatch { get; set; }
    }
    
}
