using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Repersent a team member.
    /// </summary>
    public class Person
    {
        #region Properties
        /// <summary>
        /// The unique identifier for a person
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// First name of a person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name for a peron
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email of a person
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Cellphone of a person
        /// </summary>
        public string CellphoneNumber { get; set; }

        #endregion
        public Person()
        {

        }

        public Person(string fisrtName, string lastName, string email, string cellPhone)
        {
            FirstName = fisrtName;
            LastName = lastName;
            EmailAddress = email;
            CellphoneNumber = cellPhone;
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        
    }
}
