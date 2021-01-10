using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextConnectorHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        
        /// <summary>
        /// Saves a new prize to a text file.
        /// </summary>
        /// <param name="model">The prize info.</param>
        /// <returns>The prize info with unique Id.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load text file and convert text to a list of prize model
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the Max id
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            
            // Add the new record with the new ID (max + 1)
            prizes.Add(model);
            
            // Save to file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}