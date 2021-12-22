using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public interface IDataConnection
    {
        PrizeModel CreatePrizes(PrizeModel model);
        Person CreatePerson(Person model);
        List<Person> GetAll_Persons();
        TeamModel CreateTeam(TeamModel model);
        TournamentModel CreateTournament(TournamentModel model);
        void updateMatchups(MatchModel model);
        List<TeamModel> GetAll_Team();
        List<PrizeModel> GetAll_Prize();
        List<TournamentModel> GetAll_Tournaments();
    }
}
