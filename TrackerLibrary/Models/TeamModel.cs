using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// This represent a team.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// This is a unique identfication of a team.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// A name of a team.
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// The members of a team
        /// </summary>
        public List<Person> TeamMember { get; set; } = new List<Person>();
        
    }
}
