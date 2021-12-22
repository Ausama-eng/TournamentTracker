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
        private const string PrizeFile = "PrizeModels.csv";
        private const string PersonFile = "PersonModel.csv";
        private const string TeamFile = "TeamModel.csv";
        private const string TournamentFile = "TournamentModel.csv";


        public Person CreatePerson(Person model)
        {
            List<Person> people = PersonFile.FullFilePath().LoadFile().ConvertToPersonModel();

            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            people.Add(model);

            people.SavePerson(PersonFile);

            return model;
        }

        public PrizeModel CreatePrizes(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizeFile.FullFilePath().LoadFile().ConverToPrizeModel();

            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            prizes.Add(model);

            prizes.SavePrizesFile(PrizeFile);

            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(PersonFile);

            //Find max id
            int currentid = 1;
            if (teams.Count>0)
            {
                currentid = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentid;

            teams.Add(model);

            teams.SaveTeam(TeamFile);

            return model;
        }

        public TournamentModel CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile.
                FullFilePath().
                LoadFile().
                ConvertToTorunamentModel(PersonFile, TeamFile,PrizeFile);

            int currentid = 1;
            if (tournaments.Count > 0)
            {
                currentid = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentid;

            model.SaveRoundToFile();
            tournaments.Add(model);

            tournaments.SaveToTournamentFile(TournamentFile);
            return model;
        }

        public List<Person> GetAll_Persons()
        {
            return PersonFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }

        public List<PrizeModel> GetAll_Prize()
        {
            return PrizeFile.FullFilePath().LoadFile().ConverToPrizeModel();
        }

        public List<TeamModel> GetAll_Team()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(PersonFile);
        }

        public List<TournamentModel> GetAll_Tournaments()
        {
            return TournamentFile.FullFilePath().LoadFile().
                ConvertToTorunamentModel(PersonFile, TeamFile, PrizeFile);
        }

        public void updateMatchups(MatchModel model)
        {

        }
    }
}
