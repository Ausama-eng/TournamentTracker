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
                if (matches.First().MatchUpRound > currRound)
                {
                    currRound = matches.First().MatchUpRound;
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


        private void scoreButton_Click(object sender, EventArgs e)
        {

        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropDown.SelectedItem);
        }
        private void LoadMatchups(int round)
        {

            selectedMatchups.Clear();

            foreach(MatchModel m in tournament.Rounds[round - 1])
            {
                selectedMatchups.Add(m);
            }
            LoadMatch(selectedMatchups.First());
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
    }
}
