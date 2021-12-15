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
        List<int> rounds = new List<int>();
        List<MatchModel> selectedMatchups = new List<MatchModel>();

        BindingSource roundBinding = new BindingSource();
        BindingSource matchBinding = new BindingSource();
        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;
            LoadFormual();
            LoadRound();
        }

        private void LoadFormual()
        {
            TournamentName.Text = tournament.TournamentName;
        }

        private void LoadRound()
        {
            rounds = new List<int>();
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
            WireUpRoundsList();
        }

        private void WireUpRoundsList()
        {
            //roundDropDown.DataSource = null;
            roundBinding.DataSource = rounds;
            roundDropDown.DataSource = roundBinding;
        }

        private void WireUpMatchupList()
        {
            //matchUpList.DataSource = null;
            matchBinding.DataSource = selectedMatchups;
            matchUpList.DataSource = matchBinding;
            matchUpList.DisplayMember = "DisplayName";
        }

        private void TournamentViewerForm_Load(object sender, EventArgs e)
        {

        }

        private void teamoneScoretext_TextChanged(object sender, EventArgs e)
        {

        }

        private void teamtwoScoreText_TextChanged(object sender, EventArgs e)
        {

        }

        private void scoreButton_Click(object sender, EventArgs e)
        {

        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }
        private void LoadMatchups()
        {
            int round = (int)roundDropDown.SelectedItem;

            //selectedMatchups = tournament.Rounds[round - 1];
            foreach (List<MatchModel> matches in tournament.Rounds)
            {
                if (matches.First().MatchUpRound == round)
                {
                    selectedMatchups = matches;
                }
            }
            WireUpMatchupList();
        }

        private void LoadMatch()
        {
            MatchModel m = (MatchModel)matchUpList.SelectedItem;

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
            LoadMatch();
        }
    }
}
