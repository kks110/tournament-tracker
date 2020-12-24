using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreatePrize Method actually save
        /// <summary>
        /// Saves a new prize to the database.
        /// </summary>
        /// <param name="model">The prize info.</param>
        /// <returns>The prize info with unique Id.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}