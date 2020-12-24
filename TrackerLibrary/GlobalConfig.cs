using System.Collections.Generic;
using TrackerLibrary.DataAccess;
using System.Configuration;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnection(DatabaseType db)
        {
            switch (db)
            {
                case DatabaseType.Sql:
                {
                    // TODO - Create SQL Connection
                    SqlConnector sql = new SqlConnector();
                    Connection = sql;
                    break;
                }
                case DatabaseType.TextFile:
                {
                    // TODO - Create Text Connection
                    TextConnector text = new TextConnector();
                    Connection = text;
                    break;
                }
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}