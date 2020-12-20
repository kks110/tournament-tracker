namespace TrackerLibrary
{
    /// <summary>
    /// Represents a prize.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represente the place a team needs to come to win this prize.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// The name of the place, eg winner, second place.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// The value of the prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// The percentage of the prize pool won.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}