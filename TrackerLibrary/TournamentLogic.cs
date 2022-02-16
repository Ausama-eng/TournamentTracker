using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

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
            int rounds = FindNumberOfRounds(model.EnteredTeams.Count);
            int byes = numberOfBys(rounds, model.EnteredTeams.Count);

            model.Rounds.Add(CreateFirstRound(byes, model.EnteredTeams));

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
                    curr.MatchupRound = 1;
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
                        currMatchup.MatchupRound = round;
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

        public static void UpdateTournamentResult(TournamentModel model)
        {
            int startingRound = model.checkCurrentRound();
            List<MatchModel> toScore = new List<MatchModel>();

            foreach (List<MatchModel> round in model.Rounds)
            {
                foreach (MatchModel rm in round)
                {
                    if (rm.Winner == null &&(rm.Entries.Any(x => x.Score != 0) || rm.Entries.Count == 1))
                    {
                        toScore.Add(rm);
                    }
                }
            }

            MarkTheWinner(toScore);

            AdvanceWinners(toScore, model);

            toScore.ForEach(x => GlobalConfig.Connection.updateMatchups(x));

            int endingRound = model.checkCurrentRound();
            if (endingRound > startingRound)
            {
                model.AlertUsersToNewRounds();
            }
        }


        public static void AlertUsersToNewRounds(this TournamentModel model)
        {
            int curRoundNumber = model.checkCurrentRound();
            List<MatchModel> currRound = model.Rounds.Where(x => x.First().MatchupRound == curRoundNumber).First();

            foreach (MatchModel matchup in currRound)
            {
                foreach (MatchEntryModel me in matchup.Entries)
                {
                    foreach (Person p in me.TeamCompeting.TeamMember)
                    {
                        AlertPersonToNewRound(p, me.TeamCompeting.TeamName, matchup.Entries.Where(x => x.TeamCompeting != me.TeamCompeting).FirstOrDefault());

                    }
                }
            }
        }

        private static void AlertPersonToNewRound(Person p, string teamName, MatchEntryModel competitor)
        {
            if(p.EmailAddress.Length == 0)
            {
                return;
            }
            string to = "";
            string subject = "";
            StringBuilder body = new StringBuilder();

            if (competitor != null)
            {
                subject = $"You have a new matchup with {competitor.TeamCompeting.TeamName}";
                body.Append("<h1> You have a new matchup</h1>");
                body.AppendLine("<strong>Competitor: </strong>");
                body.Append(competitor.TeamCompeting.TeamName);
                body.AppendLine();
                body.AppendLine();
                body.AppendLine("Have a great time!");
                body.AppendLine("~Tournament Tracker");
            }
            else
            {
                subject = "You have a bye week this round";
                body.AppendLine("Enjoy your rounf off!!");
                body.AppendLine("~Tournament Tracker");
            }
            to = p.EmailAddress;

            EmailLogic.sendEmail(to, subject, body.ToString());
        }

        private static void MarkTheWinner(List<MatchModel> model)
        {
            //greater or lesser
            string greaterWins = ConfigurationManager.AppSettings["greaterWins"];

            foreach (MatchModel m in model)
            {
                //checks for bye week entry
                if (m.Entries.Count == 1)
                {
                    m.Winner = m.Entries[0].TeamCompeting;
                    continue;
                }
                //Low score wins if 0
                if (greaterWins == "0")
                {
                    if (m.Entries[0].Score < m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if (m.Entries[1].Score < m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We don't allow Tied Match");
                    }
                }
                else
                {
                    //i mean higher score wins
                    if (m.Entries[0].Score > m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if (m.Entries[1].Score > m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We don't allow Tied Match");
                    }
                } 
            }
        }

        private static void AdvanceWinners(List<MatchModel> models, TournamentModel tournament)
        {
            foreach (MatchModel m in models)
            {
                foreach (List<MatchModel> round in tournament.Rounds)
                {
                    foreach (MatchModel rm in round)
                    {
                        foreach (MatchEntryModel me in rm.Entries)
                        {
                            if (me.ParentMatch != null)
                            {
                                if (me.ParentMatch.id == m.id)
                                {
                                    me.TeamCompeting = m.Winner;
                                    GlobalConfig.Connection.updateMatchups(rm);
                                }
                            } 
                        }
                    }
                }
            }
        }


        private static int checkCurrentRound(this TournamentModel model)
        {
            int output = 1;

            foreach (List<MatchModel> round in model.Rounds)
            {
                if (round.All(x => x.Winner != null))
                {
                    output += 1;
                }
                else
                {
                    return output;
                }
            }
            completeTournament(model);
            return output - 1;
        }

        private static void completeTournament(TournamentModel model)
        {
            GlobalConfig.Connection.CompleteTournament(model);
            TeamModel winner = model.Rounds.Last().First().Winner;
            TeamModel second = model.Rounds.Last().First().Entries.Where(x => x.TeamCompeting != winner).First().TeamCompeting;

            decimal winnerPrize = 0;
            decimal runnerUpPrize = 0;


            if(model.Prizes.Count>0)
            {
                decimal totalIncome = model.EnteredTeams.Count * model.EntryFee;
                PrizeModel firstPrize = model.Prizes.Where(x => x.PlaceNumber == 1).FirstOrDefault();
                PrizeModel secondPrize = model.Prizes.Where(x => x.PlaceNumber == 2).FirstOrDefault();

                if (firstPrize != null)
                {
                    winnerPrize = firstPrize.CAlculatePrizePayouy(totalIncome);
                }
                if (secondPrize != null)
                {
                    runnerUpPrize = secondPrize.CAlculatePrizePayouy(totalIncome);
                }
            }

            //send Email to all tournaments;
            string subject = "";
            StringBuilder body = new StringBuilder();

            subject = $"In {model.TournamentName} , {winner.TeamName} has won";

            body.AppendLine("<h1>We have a WINNER!</h1>");
            body.AppendLine("<p>Congratulation to our winner on a great tournament.</p>");
            body.AppendLine("<br/>");
            body.AppendLine();

            if (winnerPrize > 0)
            {
                body.AppendLine($"<p> {winner.TeamName} will recieve ${winnerPrize}</p>");
            }
            if (runnerUpPrize > 0)
            {
                body.AppendLine($"<p> {second.TeamName} will recieve ${runnerUpPrize}</p>");
            }
            body.AppendLine("<p>Thanks for a great tournament everyone</p>");
            body.AppendLine("~Tournament Tracker");

            List<string> bcc = new List<string>();

            foreach(TeamModel t in  model.EnteredTeams)
            {
                foreach (Person p in t.TeamMember)
                {
                    bcc.Add(p.EmailAddress);
                }
            }
            EmailLogic.sendEmail(new List<string>(), bcc, subject, body.ToString());
            //Complete Tournament
            model.completeTournament();
        }

        private static decimal CAlculatePrizePayouy(this PrizeModel prize, decimal total)
        {
            decimal output = 0;

            if (prize.PrizeAmount > 0)
            {
                output = prize.PrizeAmount;
            }
            else
            {
                output = decimal.Multiply(total, Convert.ToDecimal(prize.PrizePercentage / 100));
            }

            return output;
        }
    }
}
