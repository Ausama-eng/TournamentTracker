using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
	public class SqlConnector : IDataConnection
	{
		private const string db = "Tournaments";

        //public void CompleteTournament(TournamentModel model)
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// To save a team member into database by using dapper
        /// </summary>
        /// <param name="model">The person information</param>
        /// <returns>   the person information, including unique id</returns>
        public void CreatePerson(Person model)
		{
			using (IDbConnection cnn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
			{
				var p = new DynamicParameters();
				p.Add("@FirstName", model.FirstName);
				p.Add("@LastName", model.LastName);
				p.Add("@Email", model.EmailAddress);
				p.Add("@Cellphone", model.CellphoneNumber);
				p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

				cnn.Execute("dbo.spPerson_Insert", p, commandType: CommandType.StoredProcedure);

				model.id = p.Get<int>("@id");

			}

		}

		/// <summary>
		/// Save a new prize to the database by using dapper
		/// </summary>
		/// <param name="model">The prize information</param>
		/// <returns>The prize information, including unique identifier</returns>
		public void CreatePrizes(PrizeModel model)
		{
			using (IDbConnection cnn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
			{
				var p = new DynamicParameters();
				p.Add("@PlaceNumber", model.PlaceNumber);
				p.Add("@PlaceName", model.PlaceName);
				p.Add("@PrizeAmount", model.PrizeAmount);
				p.Add("@PrizePercent", model.PrizePercentage);
				p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

				cnn.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

				model.id = p.Get<int>("@id");

			}

		}

        public void CreateTeam(TeamModel model)
        {
			using(IDbConnection cnn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
				var p = new DynamicParameters();
				p.Add("@teamName", model.TeamName);
				p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

				cnn.Execute("dbo.spTeams_Insert", p, commandType:CommandType.StoredProcedure);

				model.id = p.Get<int>("@id");

				foreach(Person tm in model.TeamMember)
                {
					p = new DynamicParameters();
					p.Add("@Teamid", model.id);
					p.Add("@Personid", tm.id);

					cnn.Execute("dbo.spTeamMember_Insert", p, commandType: CommandType.StoredProcedure);

				}
			}
        }

        public void CreateTournament(TournamentModel model)
        {
			using (IDbConnection cnn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
			{
				//Save tournament name and fees and id
				var p = new DynamicParameters();
				p.Add("@TournamentName", model.TournamentName);
				p.Add("@EntryFee", model.EntryFee);
				p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

				cnn.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);

				model.id = p.Get<int>("@Id");

				//Save prize of a torunament
				foreach (PrizeModel tp in model.Prizes)
				{
					p = new DynamicParameters();
					p.Add("@TournamentId", model.id);
					p.Add("@PrizeId", tp.id);
					p.Add("@Id", dbType: DbType.Int32, direction: ParameterDirection.Output);

					cnn.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
                }

				//Save a tournament entries
				foreach (TeamModel tm in model.EnteredTeams)
				{
					p = new DynamicParameters();
					p.Add("@TournamentId", model.id);
					p.Add("@TeamId", tm.id);
					p.Add("@Id", dbType: DbType.Int32, direction: ParameterDirection.Output);

					cnn.Execute("dbo.TournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);

				}

                //Save a tournanemts rounds
                foreach (List<MatchModel> round in model.Rounds)
                {
                    for (int i = 0; i < round.Count; i++)
                    {
                        p = new DynamicParameters();
                        p.Add("@TournamentId", model.id);
                        p.Add("@MatchupRound", round[i].MatchupRound);
                        p.Add("@Id", dbType: DbType.Int32, direction: ParameterDirection.Output);

                        cnn.Execute("dbo.spMatchups_Insert", p, commandType: CommandType.StoredProcedure);

                        round[i].id = p.Get<int>("@Id");
                        foreach (MatchEntryModel en in round[i].Entries)
                        {
                            p = new DynamicParameters();
                            p.Add("@MatchupId", round[i].id);
                            if (en.ParentMatch == null)
                            {
                                p.Add("@ParentMatchup", null);
                            }
                            else
                            {
                                p.Add("@ParentMatchup", en.ParentMatch.id);
                            }
                            if (en.TeamCompeting == null)
                            {
                                p.Add("@TeamCompetingId", null);

                            }
                            else
                            {
                                p.Add("@TeamCompetingId", en.TeamCompeting.id);
                            }
                            p.Add("@Id", dbType: DbType.Int32, direction: ParameterDirection.Output);

                            cnn.Execute("dbo.spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);

                            en.id = p.Get<int>("@Id");
                        } 
                        
                        
					}
				}

			}
			TournamentLogic.UpdateTournamentResult(model);
		}

        public List<Person> GetAll_Persons()
		{
			List<Person> output = new List<Person>();

			using(IDbConnection cnn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
			{
				output = cnn.Query<Person>("dbo.spPerson_GetAll").ToList();
			}

			return output;
		}

        public List<PrizeModel> GetAll_Prize()
        {
			List<PrizeModel> output = new List<PrizeModel>();
            using (IDbConnection cnn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
				output = cnn.Query<PrizeModel>("dbo.spPrize_GetAll", commandType:CommandType.StoredProcedure).ToList();
            }
			return output;
        }

        public List<TeamModel> GetAll_Team()
        {
			List<TeamModel> output = new List<TeamModel>();

			using (IDbConnection cnn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
			{
				output = cnn.Query<TeamModel>("dbo.spTeams_GetAll").ToList();

                foreach (TeamModel team in output)
                {
					DynamicParameters p = new DynamicParameters();
					p.Add("@Id", team.id);
					team.TeamMember = cnn.Query<Person>("dbo.spTeamMember_GetByTeam", p, commandType:CommandType.StoredProcedure).ToList();
                }
			}
			return output;
        }

        public List<TournamentModel> GetAll_Tournaments()
        {
			List<TournamentModel> output = new List<TournamentModel>();

			using(IDbConnection cnn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
				output = cnn.Query<TournamentModel>("dbo.spTournaments_GetAll").ToList();

                foreach (TournamentModel t in output)
                {
					DynamicParameters p = new DynamicParameters();
					p.Add("@TournamentId", t.id);
					t.Prizes = cnn.Query<PrizeModel>("dbo.spPrizes_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

					t.EnteredTeams = cnn.Query<TeamModel>("dbo.spTeams_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

					foreach (TeamModel team in t.EnteredTeams)
					{
						p = new DynamicParameters();
						p.Add("@Id", team.id);
						team.TeamMember = cnn.Query<Person>("dbo.spTeamMember_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
					}
					p = new DynamicParameters();
					p.Add("@TournamentId", t.id);
					List<MatchModel> matches = cnn.Query<MatchModel>("dbo.spMatchups_GetByTournament", p, commandType:CommandType.StoredProcedure).ToList();

                    foreach (MatchModel match in matches)
                    {
						p = new DynamicParameters();
						p.Add("@MatchId", match.id);

						match.Entries = cnn.Query<MatchEntryModel>("dbo.spMatchupEntries_GetByMatchup", p, commandType: CommandType.StoredProcedure).ToList();

						List<TeamModel> allTeams = GetAll_Team();
						if(match.Winnerid > 0)
                        {
							match.Winner = allTeams.Where(x => x.id == match.Winnerid).First();
                        }
                        foreach (MatchEntryModel entry in match.Entries)
                        {
							if(entry.TeamCompetingid > 0)
                            {
								entry.TeamCompeting = allTeams.Where(x => x.id == entry.TeamCompetingid).First();
                            }
							if(entry.ParentMatchupid > 0)
                            {
								entry.ParentMatch = matches.Where(x => x.id == entry.ParentMatchupid).First();
                            }
                        }
					}
					matches = matches.OrderBy(x => x.MatchupRound).ToList();
					//Saving match into its round depending on roundNumber
					List<MatchModel> currMatchup = new List<MatchModel>();
					int currRound = 1;
                    foreach (MatchModel m in matches)
                    {
						if (m.MatchupRound > currRound)
                        {
							t.Rounds.Add(currMatchup);
							currRound += 1;
							currMatchup = new List<MatchModel>();
                        }
						currMatchup.Add(m);
                    }
					t.Rounds.Add(currMatchup);
				}
            }
			return output;
        }

        public void updateMatchups(MatchModel model)
        {
			using (IDbConnection cnn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
			{
				DynamicParameters p = new DynamicParameters();
                if (model.Winner != null)
                {
                    p.Add("@id", model.id);
                    p.Add("@winnerId", model.Winner.id);

                    cnn.Execute("dbo.spMatchups_Update", p, commandType: CommandType.StoredProcedure);
                }
                foreach (MatchEntryModel me in model.Entries)
                    if (me.TeamCompeting != null)
                    {
                        {
                            p = new DynamicParameters();
                            p.Add("@id", me.id);
                            p.Add("@teamCompeting", me.TeamCompeting.id);
                            p.Add("@score", me.Score);

                            cnn.Execute("dbo.spMatchupEntries_Update", p, commandType: CommandType.StoredProcedure);
                        } 
                    }
			}
		}
	}
}
