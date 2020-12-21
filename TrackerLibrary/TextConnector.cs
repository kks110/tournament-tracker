namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        // TODO - Make the CreatePrize Method actually save
        /// <summary>
        /// Saves a new prize to a text file.
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