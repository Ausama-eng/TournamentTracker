using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represent one match in a tournament
    /// </summary>
    public class MatchModel
    {
        /// <summary>
        /// The unique identifier for the matchup.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The set of teams that were involved in this match.
        /// </summary>
        public List<MatchEntryModel> Entries { get; set; } = new List<MatchEntryModel>();
        
        /// <summary>
        /// The ID from the database that will be used to identify the winner.
        /// </summary>
        public int Winnerid { get; set; }

        /// <summary>
        /// the winner of the match.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Which round this match is a part of.
        /// </summary>
        public  int MatchupRound { get; set; }

        /// <summary>
        /// The name of the match that displays in team viewer.
        /// </summary>
        public string DisplayName
        { get
            {
                string output = "";
                foreach (MatchEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {me.TeamCompeting.TeamName}";
                        } 
                    }
                    else
                    {
                        output = "Matchup Not Yet Determined!!";
                        break;
                    }
                }
                return output;
            } }
    }   
}
