using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        //Order our teams randomly
        //Check if it is big enough - if not, add in byes - 2*2*2*2 - 2^4
        //Create out first round of matchups
        //Create every round after that - 8 matchups - 4 matchups - 2 matchups - 1 matchups

        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> RandomizedTeams = RandomizeTeamsOrders(model.EnteredTeams);
            model.EnteredTeams = RandomizedTeams;
            int rounds = FindNumberOfRounds(RandomizedTeams.Count);
            int byes = numberOfBys(rounds, RandomizedTeams.Count);

            model.Rounds.Add(CreateFirstRound(rounds, RandomizedTeams));

            CreateOtherRounds(model, rounds);
        }

        private static List<MatchModel> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchModel> output = new List<MatchModel>();
            MatchModel curr = new MatchModel();
            foreach(TeamModel team in teams)
            {
                curr.Entries.Add(new MatchEntryModel { TeamCompeting = team });
                if (byes > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchUpRound = 1;
                    output.Add(curr);
                    curr = new MatchModel();
                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }
            return output;
        }
        
        private static int numberOfBys(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;
            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }
            output = totalTeams - numberOfTeams;
            return output;
        }

        private static int FindNumberOfRounds(int TeamsCount)
        {
            int output = 1;
            int val = 2;
            while(val < TeamsCount)
            {
                output += 1;
                val += 2;
            }
            return output;
        }

        private static List<TeamModel> RandomizeTeamsOrders(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }

        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchModel> previousRound = model.Rounds[0];
            List<MatchModel> currRound = new List<MatchModel>();
            MatchModel currMatchup = new MatchModel();

            while(round <= rounds)
            {
                foreach (MatchModel match in previousRound)
                {
                    currMatchup.Entries.Add(new MatchEntryModel { ParentMatch = match });

                    if(currMatchup.Entries.Count >1)
                    {
                        currMatchup.MatchUpRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchModel();
                    }
                }
                model.Rounds.Add(currRound);
                previousRound = currRound;

                currRound = new List<MatchModel>();
                round += 1;
            }
        }
    }
}
