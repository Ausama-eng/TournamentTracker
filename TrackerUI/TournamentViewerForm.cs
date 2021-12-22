using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchModel> selectedMatchups = new BindingList<MatchModel>();


        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            LoadFormual();
            LoadRound();
            WireUpList();
        }

        private void LoadFormual()
        {
            TournamentName.Text = tournament.TournamentName;
        }

        private void LoadRound()
        {
            rounds.Clear();
            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchModel> matches in tournament.Rounds)
            {
                if (matches.First().MatchupRound > currRound)
                {
                    currRound = matches.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }
            LoadMatchups(1);
        }

        private void WireUpList()
        {
            roundDropDown.DataSource = rounds;
            matchUpList.DataSource = selectedMatchups;
            matchUpList.DisplayMember = "DisplayName";
        }


        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropDown.SelectedItem);
        }
        private void LoadMatchups(int round)
        {

            selectedMatchups.Clear();

            foreach(List<MatchModel> m in tournament.Rounds)
            {
                if (m.First().MatchupRound == round)
                {
                    foreach (MatchModel match in m)
                    {
                        if (match.Winner == null || !unplayedCheckBox.Checked)
                        {
                            selectedMatchups.Add(match);
                        }
                    }
                }
            }
            if (selectedMatchups.Count > 0)
            {
                LoadMatch(selectedMatchups.First());
            }
            DisplayTeamsInfo();
        }

        private void DisplayTeamsInfo()
        {
            bool IsVisible = selectedMatchups.Count > 0;

            teamonelabel.Visible = IsVisible;
            teamoneScoreLabel.Visible = IsVisible;
            teamoneScoretext.Visible = IsVisible;

            teamtwoLabel.Visible = IsVisible;
            teamtwoScoreLabel.Visible = IsVisible;
            teamtwoScoreText.Visible = IsVisible;

            versusLabel.Visible = IsVisible;
            scoreButton.Visible = IsVisible;
            
        }

        private void LoadMatch(MatchModel m)
        {

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[i].TeamCompeting != null)
                    {
                        teamonelabel.Text = m.Entries[i].TeamCompeting.TeamName;
                        teamoneScoretext.Text = m.Entries[i].Score.ToString();

                        teamtwoLabel.Text = "<byes>";
                        teamtwoScoreText.Text = "0";
                    }
                    else
                    {
                        teamonelabel.Text = "Not Yet Set";
                        teamoneScoretext.Text = "";
                    }
                }
                if (i == 1)
                {
                    if (m.Entries[i].TeamCompeting != null)
                    {
                        teamtwoLabel.Text = m.Entries[i].TeamCompeting.TeamName;
                        teamtwoScoreText.Text = m.Entries[i].Score.ToString();
                    }
                    else
                    {
                        teamtwoLabel.Text = "Not Yet Set";
                        teamtwoScoreText.Text = "";
                    }
                }
            }
        }

        private void matchUpList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matchUpList.SelectedItem != null)
            {
                LoadMatch((MatchModel)matchUpList.SelectedItem);
            }
        }

        private void unplayedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropDown.SelectedItem);
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            MatchModel m = (MatchModel)matchUpList.SelectedItem;
            double teamOneScore = 0, teamTwoScore = 0;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        teamonelabel.Text = m.Entries[0].TeamCompeting.TeamName;

                        bool scoreValid = double.TryParse(teamoneScoretext.Text, out teamOneScore);
                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 1.");
                            return;
                        }
                    }
                    else
                    {
                        teamonelabel.Text = "Not Yet Set";
                        teamoneScoretext.Text = "";
                    }
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        teamtwoLabel.Text = m.Entries[1].TeamCompeting.TeamName;

                        bool scoreValid = double.TryParse(teamtwoLabel.Text, out teamTwoScore);
                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 2.");
                            return;
                        }
                    }
                    else
                    {
                        teamtwoLabel.Text = "Not Yet Set";
                        teamtwoScoreText.Text = "";
                    }
                }
            }
            if (teamOneScore > teamTwoScore)
            {
                m.Winner = m.Entries[0].TeamCompeting;
            }
            else if (teamTwoScore > teamOneScore)
            {
                m.Winner = m.Entries[1].TeamCompeting;
            }
            else
            {
                MessageBox.Show("I do not support a tie game");
            }

            foreach (List<MatchModel> round in tournament.Rounds)
            {
                foreach (MatchModel rm  in round)
                {
                    foreach (MatchEntryModel me  in rm.Entries)
                    {
                        if (me.ParentMatch != null)
                        {
                            if (me.ParentMatch.Id == m.Id)
                            {
                                me.TeamCompeting = m.Winner;
                                GlobalConfig.Connection.updateMatchups(rm);
                            } 
                        }
                    }
                }
            }

            LoadMatchups((int)roundDropDown.SelectedItem);

            GlobalConfig.Connection.updateMatchups(m);
        }
    }
}
