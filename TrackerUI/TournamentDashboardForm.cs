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
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetAll_Tournaments();
        public TournamentDashboardForm()
        {
            InitializeComponent();
            WireUpList();
        }

        private void WireUpList()
        {
            loadExistingTournamentDropDown.DataSource = null;
            loadExistingTournamentDropDown.DataSource = tournaments;
            loadExistingTournamentDropDown.DisplayMember = "TournamentName";
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void TournamentDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void loadTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentViewerForm frm = new TournamentViewerForm((TournamentModel)loadExistingTournamentDropDown.SelectedItem);
            frm.Show();
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm ctm = new CreateTournamentForm();
            ctm.Show();
        }
    }
}
