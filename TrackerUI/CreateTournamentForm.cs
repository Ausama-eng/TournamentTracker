using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availbelTeams = GlobalConfig.Connection.GetAll_Team();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = GlobalConfig.Connection.GetAll_Prize();

        public CreateTournamentForm()
        {
            InitializeComponent();
            initializeLists();
        }

        private void teamoneScoretext_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {

        }

        private void selectTeamLabel_Click(object sender, EventArgs e)
        {

        }
        private void initializeLists()
        {
            selectteamDropDown.DataSource = null;
            selectteamDropDown.DataSource = availbelTeams;
            selectteamDropDown.DisplayMember = "TeamName";

            tournamentPlayerList.DataSource = null;
            tournamentPlayerList.DataSource = selectedTeams;
            tournamentPlayerList.DisplayMember = "TeamName";

            prizesList.DataSource = null;
            prizesList.DataSource = selectedPrizes;
            prizesList.DisplayMember = "PlaceName";
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectteamDropDown.SelectedItem;

            if (t != null)
            {
                availbelTeams.Remove(t);
                selectedTeams.Add(t);
            }
            initializeLists();
        }

        private void createPriceButton_Click(object sender, EventArgs e)
        {
            CreatePrizeForm cfm = new CreatePrizeForm(this);
            cfm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            initializeLists();
        }

        public void TeamComplete(TeamModel model)
        {
            availbelTeams.Add(model);
            initializeLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm ctf = new CreateTeamForm(this);
            ctf.Show();
        }

        private void deleteSelectedPlayerButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentPlayerList.SelectedItem;

            if(t != null)
            {
                selectedTeams.Remove(t);
                availbelTeams.Add(t);
                initializeLists();
            }
        }

        private void deleteSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesList.SelectedItem;

            if(p != null)
            {
                selectedPrizes.Remove(p);
                initializeLists();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = TournamentNameValue.Text;
            //Validate data
            bool FeeChecker = decimal.TryParse(EntryFeeValue.Text, out decimal fee);
            if(!FeeChecker)
            {
                MessageBox.Show("Please, enter valid fee", "Error invalidate fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tm.EntryFee = fee;
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            //Wire our matchups
            TournamentLogic.CreateRounds(tm);


            GlobalConfig.Connection.CreateTournament(tm);
            this.Close();

        }
    }
}
