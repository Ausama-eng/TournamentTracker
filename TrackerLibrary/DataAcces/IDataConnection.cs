using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public interface IDataConnection
    {
        void CreatePrizes(PrizeModel model);
        void CreatePerson(Person model);
        List<Person> GetAll_Persons();
        void CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);
        void updateMatchups(MatchModel model);
        List<TeamModel> GetAll_Team();
        List<PrizeModel> GetAll_Prize();
        List<TournamentModel> GetAll_Tournaments();
    }
}
