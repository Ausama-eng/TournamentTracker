
namespace TrackerUI
{
    partial class CreateTeamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectteamMemeberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addNewMemberBox = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMemberList = new System.Windows.Forms.ListBox();
            this.deletSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamNameValue.Location = new System.Drawing.Point(27, 120);
            this.TeamNameValue.Margin = new System.Windows.Forms.Padding(4);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(270, 42);
            this.TeamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.teamNameLabel.Location = new System.Drawing.Point(27, 86);
            this.teamNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(157, 37);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.headerLabel.Location = new System.Drawing.Point(27, 15);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(272, 62);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Create Team";
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.Color.White;
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addMemberButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addMemberButton.Location = new System.Drawing.Point(79, 251);
            this.addMemberButton.Margin = new System.Windows.Forms.Padding(4);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(187, 52);
            this.addMemberButton.TabIndex = 19;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = false;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // selectteamMemeberDropDown
            // 
            this.selectteamMemeberDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectteamMemeberDropDown.FormattingEnabled = true;
            this.selectteamMemeberDropDown.Location = new System.Drawing.Point(27, 205);
            this.selectteamMemeberDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.selectteamMemeberDropDown.Name = "selectteamMemeberDropDown";
            this.selectteamMemeberDropDown.Size = new System.Drawing.Size(269, 36);
            this.selectteamMemeberDropDown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(27, 171);
            this.selectTeamMemberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
            this.selectTeamMemberLabel.TabIndex = 17;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberBox
            // 
            this.addNewMemberBox.Controls.Add(this.createMemberButton);
            this.addNewMemberBox.Controls.Add(this.cellphoneValue);
            this.addNewMemberBox.Controls.Add(this.cellphoneLabel);
            this.addNewMemberBox.Controls.Add(this.emailValue);
            this.addNewMemberBox.Controls.Add(this.emailLabel);
            this.addNewMemberBox.Controls.Add(this.lastNameValue);
            this.addNewMemberBox.Controls.Add(this.lastnameLabel);
            this.addNewMemberBox.Controls.Add(this.firstNameValue);
            this.addNewMemberBox.Controls.Add(this.firstNameLabel);
            this.addNewMemberBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewMemberBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addNewMemberBox.Location = new System.Drawing.Point(45, 327);
            this.addNewMemberBox.Margin = new System.Windows.Forms.Padding(4);
            this.addNewMemberBox.Name = "addNewMemberBox";
            this.addNewMemberBox.Padding = new System.Windows.Forms.Padding(4);
            this.addNewMemberBox.Size = new System.Drawing.Size(270, 259);
            this.addNewMemberBox.TabIndex = 20;
            this.addNewMemberBox.TabStop = false;
            this.addNewMemberBox.Text = "Add New Member";
            this.addNewMemberBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // createMemberButton
            // 
            this.createMemberButton.BackColor = System.Drawing.Color.White;
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createMemberButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createMemberButton.Location = new System.Drawing.Point(48, 206);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(170, 46);
            this.createMemberButton.TabIndex = 21;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = false;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cellphoneValue.Location = new System.Drawing.Point(133, 165);
            this.cellphoneValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(129, 34);
            this.cellphoneValue.TabIndex = 16;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cellphoneLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cellphoneLabel.Location = new System.Drawing.Point(9, 169);
            this.cellphoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(122, 32);
            this.cellphoneLabel.TabIndex = 15;
            this.cellphoneLabel.Text = "CellPhone";
            // 
            // emailValue
            // 
            this.emailValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailValue.Location = new System.Drawing.Point(133, 123);
            this.emailValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(129, 34);
            this.emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.emailLabel.Location = new System.Drawing.Point(8, 126);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(71, 32);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameValue.Location = new System.Drawing.Point(133, 81);
            this.lastNameValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(129, 34);
            this.lastNameValue.TabIndex = 12;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastnameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lastnameLabel.Location = new System.Drawing.Point(9, 85);
            this.lastnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(126, 32);
            this.lastnameLabel.TabIndex = 11;
            this.lastnameLabel.Text = "Last Name";
            this.lastnameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstNameValue
            // 
            this.firstNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameValue.Location = new System.Drawing.Point(133, 41);
            this.firstNameValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(129, 34);
            this.firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.firstNameLabel.Location = new System.Drawing.Point(8, 41);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(129, 32);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            // 
            // teamMemberList
            // 
            this.teamMemberList.FormattingEnabled = true;
            this.teamMemberList.ItemHeight = 28;
            this.teamMemberList.Location = new System.Drawing.Point(418, 120);
            this.teamMemberList.Name = "teamMemberList";
            this.teamMemberList.Size = new System.Drawing.Size(309, 452);
            this.teamMemberList.TabIndex = 21;
            // 
            // deletSelectedMemberButton
            // 
            this.deletSelectedMemberButton.BackColor = System.Drawing.Color.White;
            this.deletSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deletSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deletSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deletSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deletSelectedMemberButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.deletSelectedMemberButton.Location = new System.Drawing.Point(753, 316);
            this.deletSelectedMemberButton.Name = "deletSelectedMemberButton";
            this.deletSelectedMemberButton.Size = new System.Drawing.Size(179, 86);
            this.deletSelectedMemberButton.TabIndex = 22;
            this.deletSelectedMemberButton.Text = "Remove Selected";
            this.deletSelectedMemberButton.UseVisualStyleBackColor = false;
            this.deletSelectedMemberButton.Click += new System.EventHandler(this.deletSelectedMemberButton_Click);
            // 
            // createTeamButton
            // 
            this.createTeamButton.BackColor = System.Drawing.Color.White;
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTeamButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createTeamButton.Location = new System.Drawing.Point(326, 599);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(210, 61);
            this.createTeamButton.TabIndex = 22;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = false;
            this.createTeamButton.Click += new System.EventHandler(this.CreateTeamMember_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 683);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deletSelectedMemberButton);
            this.Controls.Add(this.teamMemberList);
            this.Controls.Add(this.addNewMemberBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectteamMemeberDropDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.addNewMemberBox.ResumeLayout(false);
            this.addNewMemberBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox selectteamMemeberDropDown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox addNewMemberBox;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.ListBox teamMemberList;
        private System.Windows.Forms.Button deletSelectedMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}