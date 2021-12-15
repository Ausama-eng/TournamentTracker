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
    public partial class CreateTeamForm : Form
    {
        ITeamRequester CallForm;
        private List<Person> availableMemebers = GlobalConfig.Connection.GetAll_Persons();
        private List<Person> selectedTeamMembers = new List<Person>();

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            CallForm = caller;

            //Sample();

            WireUpLists();
        }

        private void Sample()
        {
            availableMemebers.Add(new Person { FirstName = "Tim", LastName = "Ali" });
            availableMemebers.Add(new Person { FirstName = "Caleb", LastName = "Abas" });

            selectedTeamMembers.Add(new Person { FirstName = "Nory", LastName = "Almal" });
            selectedTeamMembers.Add(new Person { FirstName = "ada", LastName = "addw" });
        }
        private void WireUpLists()
        {
            selectteamMemeberDropDown.DataSource = null;
            selectteamMemeberDropDown.DataSource = availableMemebers;
            selectteamMemeberDropDown.DisplayMember = "FullName";

            teamMemberList.DataSource = null;
            teamMemberList.DataSource = selectedTeamMembers;
            teamMemberList.DisplayMember = "FullName";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidatForm())
            {
                Person p = new Person(
                    firstNameValue.Text,
                    lastNameValue.Text,
                    emailValue.Text,
                    cellphoneValue.Text
                    );

                p = GlobalConfig.Connection.CreatePerson(p);

                availableMemebers.Add(p);

                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";

            }
            else
            {
                MessageBox.Show("You need to full all fields");
            }

        }

        private bool ValidatForm()
        {
            
            if (firstNameValue.Text.Length == 0 || lastNameValue.Text.Length == 0 || 
                emailValue.Text.Length == 0 || cellphoneValue.Text.Length == 0 )
            {
                return false;
            }

            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            Person p = (Person) selectteamMemeberDropDown.SelectedItem;

            if (p != null)
            {
                availableMemebers.Remove(p);
                selectedTeamMembers.Add(p);

            }
            WireUpLists();

        }

        private void deletSelectedMemberButton_Click(object sender, EventArgs e)
        {
            Person p = (Person)teamMemberList.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);

                availableMemebers.Add(p);
            }
            WireUpLists();
        }

        private void CreateTeamMember_Click(object sender, EventArgs e)
        {
            if (TeamNameValue.Text != "")
            {
                TeamModel t = new TeamModel();
                t.TeamName = TeamNameValue.Text;
                t.TeamMember = selectedTeamMembers;

                t = GlobalConfig.Connection.CreateTeam(t);
                CallForm.TeamComplete(t);

                this.Close();
            }
            else
            {
                MessageBox.Show("Verify team name!!","Erorr",MessageBoxButtons.OKCancel);
            }
        }
    }
}
