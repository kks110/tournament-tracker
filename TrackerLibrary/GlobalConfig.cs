using System.Collections.Generic;
using TrackerLibrary.DataAccess;
using System.Configuration;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connection { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnection(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - Create SQL Connection
                SqlConnector sql = new SqlConnector();
                Connection.Add(sql);
            }

            if (textFiles)
            {
                // TODO - Create Text Connection
                TextConnector text = new TextConnector();
                Connection.Add(text);
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}