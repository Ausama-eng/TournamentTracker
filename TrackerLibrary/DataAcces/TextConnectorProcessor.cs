﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace TrackerLibrary.DataAcces.TextHelper
{
    static class TextConnectorProcessor
    {
        /// <summary>
        /// Provide Full path of a certain folder
        /// </summary>
        /// <param name="fileName"> Name of file inside a certain location</param>
        /// <returns> Returns file location in a string type</returns>
        public static string FullFilePath(this string fileName) => $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";

        public static List<string> LoadFile(this string file)
        {
            if(!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        #region Prize
        public static List<PrizeModel>ConverToPrizeModel(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach(var line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int .Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                output.Add(p);

            }
            return output;
        }

        public static void SavePrizesFile(this List<PrizeModel> prizes, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in prizes)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        #endregion

        #region Person
        public static List<Person> ConvertToPersonModel(this List<string> lines)
        {
            List<Person> output = new List<Person>();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');
                Person p = new Person(cols[1], cols[2], cols[3], cols[4])
                {
                    Id = int.Parse(cols[0])
                };
               
                output.Add(p);
            }
            return output;
        }

        public static void SavePerson(this List<Person> people, string fileName)
        {
            List<string> lines = new List<string>();

            foreach(Person p in people)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        #endregion

        #region Team

        public static List<TeamModel> ConvertToTeamModel(this List<string> lines, string peopleFile)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<Person> people = peopleFile.FullFilePath().LoadFile().ConvertToPersonModel();

            foreach(string line in lines)
            {
                string[] col = line.Split(',');
                TeamModel t = new TeamModel
                {
                    Id = int.Parse(col[0]),
                    TeamName = col[1]
                };

                string[] personIds = col[2].Split('|');

                foreach(string id in personIds)
                {
                    t.TeamMember.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);
            }

            return output;
        }

        public static void SaveTeam(this List<TeamModel> teams, string file)
        {
            List<string> lines = new List<string>();

            foreach(TeamModel t in teams)
            {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleToString(t.TeamMember)}");
            }
            File.WriteAllLines(file.FullFilePath(), lines);
        }

        private static string ConvertPeopleToString (List<Person> people)
        {
            string output = "";

            if (people.Count == 0)
            {
                return "";
            }

            foreach(Person p in people)
            {
                output += $"{p.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        #endregion

        #region Tournament

        public static List<TournamentModel> ConvertToTorunamentModel(this List<string> lines,
            string PeopleFile,
            string TeamFile,
            string PrizeFile)
        {
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(PeopleFile);
            List<PrizeModel> Prizes = PrizeFile.FullFilePath().LoadFile().ConverToPrizeModel();
            List<MatchModel> matchupes = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModel();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');
                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.Entryfee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');

                foreach (string id in teamIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                if (cols[4].Length > 0)
                {
                    string[] PrizeIds = cols[4].Split("|");

                    foreach (string id in PrizeIds)
                    {
                        tm.Prizes.Add(Prizes.Where(x => x.Id == int.Parse(id)).First());
                    }
                }
                string[] rounds = cols[5].Split("|");

                foreach (string round in rounds)
                {

                    List<MatchModel> ms = new List<MatchModel>();
                    string[] Modelids = round.Split('^');
                    if (matchupes.Count > 0)
                    {
                        foreach (string id in Modelids)
                        {
                            ms.Add(matchupes.Where(x => x.Id == int.Parse(id)).First());
                        }
                    }
                    tm.Rounds.Add(ms);
                }
                output.Add(tm);
            }
            return output;
        }

        public static void SaveRoundToFile(this TournamentModel rounds)
        {
            foreach (List<MatchModel> round in rounds.Rounds)
            {
                foreach (MatchModel matchup in round)
                {
                    matchup.saveMatchupFile();
                }
            }
            //throw new NotImplementedException();
        }

        public static void saveMatchupFile(this MatchModel matchup)
        {
            List<MatchModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModel();

            int cuurentId = 1;
            if(matchups.Count > 0)
            {
                cuurentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }
            matchup.Id = cuurentId;

            matchups.Add(matchup);

            foreach (MatchEntryModel entry in matchup.Entries)
            {
                entry.SaveEntrytoFile();
            }
            List<string> lines = new List<string>();

            foreach (MatchModel match in matchups)
            {
                string winner = "";
                if (match.Winner != null)
                {
                    winner = match.Winner.Id.ToString();
                }
                lines.Add($"{match.Id},{ConvertMatchupEntryToString(match.Entries)},{winner},{match.MatchUpRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);

        }

        public static void SaveEntrytoFile(this MatchEntryModel entry)
        {
            List<MatchEntryModel> Entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntry();

            int cuurentId = 1;
            if (Entries.Count > 0)
            {
                cuurentId = Entries.OrderByDescending(x => x.Id).First().Id + 1;
            }
            entry.Id = cuurentId;

            Entries.Add(entry);

            List<string> lines = new List<string>();

            foreach (MatchEntryModel e in Entries)
            {
                string parent = "";
                if(e.ParentMatch != null)
                {
                    parent = $"{e.ParentMatch.Id}";
                }

                string teamCompet = "";
                if (e.TeamCompeting != null)
                {
                    teamCompet = $"{e.TeamCompeting.Id}";
                }
                lines.Add($"{e.Id},{teamCompet},{e.Score},{parent}");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }

        private static TeamModel LookpTeamId(int Id)
        {
            List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();

            foreach (string team in teams)
            {
                string[] cols = team.Split(',');
                if(cols[0] == Id.ToString())
                {
                    List<string> matchingTeam = new List<string>();
                    matchingTeam.Add(team);
                    return matchingTeam.ConvertToTeamModel(GlobalConfig.PersonFile).First();
                }
            }
            return null;
        }
        private static MatchModel LookupMatchup(int id)
        {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();
            foreach (string match in matchups)
            {
                string[] cols = match.Split(',');
                if (cols[0] == id.ToString())
                {
                    List<string> matchingMatch = new List<string>();
                    matchingMatch.Add(match);
                    return matchingMatch.ConvertToMatchupModel().First();
                }
            }
            return null;
        }

        private static string ConvertMatchupEntryToString(List<MatchEntryModel> entries)
        {
            string output = "";
            if (entries.Count == 0)
            {
                return "";
            }
            foreach (MatchEntryModel e in entries)
            {
                output += $"{e.Id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
        private static List<MatchEntryModel> ConvertStringToMatchupEntry(string input)
        {
            string[] ids = input.Split('|');
            List<MatchEntryModel> output = new List<MatchEntryModel>();
            List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
            List<string> matchingEntry = new List<string>();

            foreach (string id in ids)
            {
                foreach (string entry in entries)
                {
                    string[] cols = entry.Split(",");
                    if(cols[0] == id)
                    {
                        matchingEntry.Add(entry);
                    }
                }
            }
            output = matchingEntry.ConvertToMatchupEntry();
            return output;
        }

        private static List<MatchEntryModel> ConvertToMatchupEntry(this List<string> lines)
        {
            List<MatchEntryModel> output = new List<MatchEntryModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MatchEntryModel m = new MatchEntryModel {
                    Id = int.Parse(cols[0]),
                    Score = double.Parse(cols[2])};

                if(cols[1].Length == 0)
                {
                    m.TeamCompeting = null;
                }
                else
                {
                    m.TeamCompeting = LookpTeamId(int.Parse(cols[1]));
                }

                if(int.TryParse(cols[3], out int parentId))
                {
                    m.ParentMatch = LookupMatchup(parentId);
                }
                else
                {
                    m.ParentMatch = null;
                }
                output.Add(m);
            }
            return output;
        }

        public static List<MatchModel> ConvertToMatchupModel(this List<string> lines)
        {
            List<MatchModel> output = new List<MatchModel>();
            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                MatchModel p = new MatchModel();
                p.Id = int.Parse(cols[0]);
                p.Entries = ConvertStringToMatchupEntry(cols[1]);
                if (int.TryParse(cols[2], out int WinnerId))
                {
                    p.Winner = LookpTeamId(WinnerId);
                }
                else
                {
                    p.Winner = null;
                }
                p.MatchUpRound = int.Parse(cols[3]);

                output.Add(p);
            }
            return output;
        }

        public static void SaveToTournamentFile(this List<TournamentModel> models, string file)
        {
            List<string> lines = new List<string>();

            foreach (TournamentModel tm in models)
            {
                lines.Add($"{tm.Id},{tm.TournamentName},{tm.Entryfee},{ConvertTeamToString(tm.EnteredTeams)},{ConvertPrizeToString(tm.Prizes)},{ConvertRoundToString(tm.Rounds)}");
            }
            File.WriteAllLines(file.FullFilePath(), lines);
        }
        private static string ConvertTeamToString(List<TeamModel> teams)
        {
            string output = "";
            if(teams.Count ==0)
            {
                return "";
            }
            foreach (TeamModel t in teams)
            {
                output += $"{t.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertPrizeToString(List<PrizeModel> prizes)
        {
            string output = "";
            if (prizes.Count == 0)
            {
                return "";
            }
            foreach (PrizeModel t in prizes)
            {
                output += $"{t.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertRoundToString(List<List<MatchModel>> rounds)
        {
            string output = "";
            if (rounds.Count == 0)
            {
                return "";
            }
            foreach (List<MatchModel> r in rounds)
            {
                output += $"{ConvertMatchupToString(r)}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertMatchupToString(List<MatchModel> matchups)
        {
            string output = "";
            if (matchups.Count == 0)
            {
                return "";
            }
            foreach (MatchModel m in matchups)
            {
                output += $"{m.Id}^";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        #endregion
    }
}
