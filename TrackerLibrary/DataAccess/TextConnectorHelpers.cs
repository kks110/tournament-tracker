using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextConnectorHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $@"{ConfigurationManager.AppSettings["filePath"]}\{ fileName }";
        }

        public static List<String> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<String> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceName = cols[1];
                p.PlaceNumber = int.Parse(cols[2]);
                p.PrizeAmount = Decimal.Parse(cols[3]);
                p.PrizePercentage = Double.Parse(cols[4]);
                output.Add(p);
            }

            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{ p.Id },{ p.PlaceName },{ p.PlaceNumber },{ p.PrizeAmount },{ p.PrizePercentage }");
            }
            
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
