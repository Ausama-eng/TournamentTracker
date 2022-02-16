using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAcces.TextHelper;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        public void CompleteTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile.
                FullFilePath().
                LoadFile().
                ConvertToTorunamentModel();

            tournaments.Remove(model);

            tournaments.SaveToTournamentFile();
            TournamentLogic.UpdateTournamentResult(model);
        }

        public void CreatePerson(Person model)
        {
            List<Person> people = GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPersonModel();

            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentId;

            people.Add(model);

            people.SavePerson();
        }

        public void CreatePrizes(PrizeModel model)
        {
            List<PrizeModel> prizes = GlobalConfig.PrizeFile.FullFilePath().LoadFile().ConverToPrizeModel();

            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentId;

            prizes.Add(model);

            prizes.SavePrizesFile();

        }

        public void CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();

            //Find max id
            int currentid = 1;
            if (teams.Count>0)
            {
                currentid = teams.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentid;

            teams.Add(model);

            teams.SaveTeam();
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile.
                FullFilePath().
                LoadFile().
                ConvertToTorunamentModel();

            int currentid = 1;
            if (tournaments.Count > 0)
            {
                currentid = tournaments.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentid;

            model.SaveRoundToFile();
            tournaments.Add(model);

            tournaments.SaveToTournamentFile();
            TournamentLogic.UpdateTournamentResult(model);

        }

        public List<Person> GetAll_Persons()
        {
            return GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }

        public List<PrizeModel> GetAll_Prize()
        {
            return GlobalConfig.PrizeFile.FullFilePath().LoadFile().ConverToPrizeModel();
        }

        public List<TeamModel> GetAll_Team()
        {
            return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();
        }

        public List<TournamentModel> GetAll_Tournaments()
        {
            return GlobalConfig.TournamentFile.FullFilePath().LoadFile().
                ConvertToTorunamentModel();
        }

        public void updateMatchups(MatchModel model)
        {
            model.updateMatchupToFile();
        }
    }
}
