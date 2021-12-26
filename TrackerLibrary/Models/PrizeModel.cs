using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represent what a prize is for a given place.
    /// </summary>
    public class PrizeModel
    {
        #region Properties
        /// <summary>
        /// The unique identifier for a prize
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// The numeric identifier for the place (2 for the scond place, etc).
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Friendly name for a place(first, second, etc).
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The fixed amount this place earns or zero if it is not used
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The number that represent the percentage of overall take or
        /// if it is not used. the percentage is a fraction of one(0.5 is for
        /// 50%)
        /// </summary>
        public double PrizePercentage { get; set; }
        #endregion
        public PrizeModel()
        {

        }
        public PrizeModel(string placeName, string placeNumber, string priceAmount, string pricePercent)
        {
            PlaceName = placeName;

            int placeNameValue = 0;
            int.TryParse(placeNumber, out placeNameValue);
            PlaceNumber = placeNameValue;

            decimal prizeAmount = 0;
            decimal.TryParse(priceAmount, out prizeAmount);
            PrizeAmount = prizeAmount;

            double percentage = 0;
            double.TryParse(pricePercent, out percentage);
            PrizePercentage = percentage;

        }
    }
}
