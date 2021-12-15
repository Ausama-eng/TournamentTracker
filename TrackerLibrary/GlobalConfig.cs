using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string PrizeFile = "PrizeModels.csv";
        public const string PersonFile = "PersonModel.csv";
        public const string TeamFile = "TeamModel.csv";
        public const string TournamentFile = "TournamentModel.csv";
        public const string MatchupFile = "MatchupModel.csv";
        public const string MatchupEntryFile = "MatchupEntryModel.csv";
        public static IDataConnection Connection { get; private set; } 
        public static void IntializeConnection(DatabaseType CnnType)
        {
            switch (CnnType)
            {
                case DatabaseType.Sql:
                    SqlConnector sql = new SqlConnector();
                    Connection = sql;
                    break;
                case DatabaseType.TextFile:
                    TextConnector text = new TextConnector();
                    Connection = text;
                    break;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
