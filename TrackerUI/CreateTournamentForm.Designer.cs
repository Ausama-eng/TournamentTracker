
namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.selectteamDropDown = new System.Windows.Forms.ComboBox();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPriceButton = new System.Windows.Forms.Button();
            this.tournamentPlayerList = new System.Windows.Forms.ListBox();
            this.tournamentsPlayerLabel = new System.Windows.Forms.Label();
            this.deleteSelectedPlayerButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prizesList = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(403, 62);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament";
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Location = new System.Drawing.Point(12, 105);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(360, 42);
            this.TournamentNameValue.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tournamentNameLabel.Location = new System.Drawing.Point(12, 72);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(236, 37);
            this.tournamentNameLabel.TabIndex = 9;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Location = new System.Drawing.Point(178, 167);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(99, 42);
            this.EntryFeeValue.TabIndex = 12;
            this.EntryFeeValue.Text = "0";
            this.EntryFeeValue.TextChanged += new System.EventHandler(this.teamoneScoretext_TextChanged);
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.entryFeeLabel.Location = new System.Drawing.Point(29, 172);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(125, 37);
            this.entryFeeLabel.TabIndex = 11;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.selectTeamLabel.Location = new System.Drawing.Point(12, 226);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(156, 37);
            this.selectTeamLabel.TabIndex = 13;
            this.selectTeamLabel.Text = "Select Team";
            this.selectTeamLabel.Click += new System.EventHandler(this.selectTeamLabel_Click);
            // 
            // selectteamDropDown
            // 
            this.selectteamDropDown.FormattingEnabled = true;
            this.selectteamDropDown.Location = new System.Drawing.Point(12, 266);
            this.selectteamDropDown.Name = "selectteamDropDown";
            this.selectteamDropDown.Size = new System.Drawing.Size(360, 44);
            this.selectteamDropDown.TabIndex = 14;
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createNewTeamLink.Location = new System.Drawing.Point(243, 232);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(129, 31);
            this.createNewTeamLink.TabIndex = 15;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "create_new";
            this.createNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLink_LinkClicked);
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.Color.White;
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTeamButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addTeamButton.Location = new System.Drawing.Point(88, 354);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(184, 49);
            this.addTeamButton.TabIndex = 16;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = false;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createPriceButton
            // 
            this.createPriceButton.BackColor = System.Drawing.Color.White;
            this.createPriceButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPriceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPriceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPriceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPriceButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createPriceButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createPriceButton.Location = new System.Drawing.Point(88, 426);
            this.createPriceButton.Name = "createPriceButton";
            this.createPriceButton.Size = new System.Drawing.Size(184, 49);
            this.createPriceButton.TabIndex = 17;
            this.createPriceButton.Text = "Create Prize";
            this.createPriceButton.UseVisualStyleBackColor = false;
            this.createPriceButton.Click += new System.EventHandler(this.createPriceButton_Click);
            // 
            // tournamentPlayerList
            // 
            this.tournamentPlayerList.FormattingEnabled = true;
            this.tournamentPlayerList.ItemHeight = 36;
            this.tournamentPlayerList.Location = new System.Drawing.Point(517, 105);
            this.tournamentPlayerList.Name = "tournamentPlayerList";
            this.tournamentPlayerList.Size = new System.Drawing.Size(271, 184);
            this.tournamentPlayerList.TabIndex = 18;
            // 
            // tournamentsPlayerLabel
            // 
            this.tournamentsPlayerLabel.AutoSize = true;
            this.tournamentsPlayerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentsPlayerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tournamentsPlayerLabel.Location = new System.Drawing.Point(517, 65);
            this.tournamentsPlayerLabel.Name = "tournamentsPlayerLabel";
            this.tournamentsPlayerLabel.Size = new System.Drawing.Size(198, 37);
            this.tournamentsPlayerLabel.TabIndex = 19;
            this.tournamentsPlayerLabel.Text = "Teams / Players";
            // 
            // deleteSelectedPlayerButton
            // 
            this.deleteSelectedPlayerButton.BackColor = System.Drawing.Color.White;
            this.deleteSelectedPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayerButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedPlayerButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.deleteSelectedPlayerButton.Location = new System.Drawing.Point(877, 152);
            this.deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            this.deleteSelectedPlayerButton.Size = new System.Drawing.Size(137, 74);
            this.deleteSelectedPlayerButton.TabIndex = 20;
            this.deleteSelectedPlayerButton.Text = "Remove Selected";
            this.deleteSelectedPlayerButton.UseVisualStyleBackColor = false;
            this.deleteSelectedPlayerButton.Click += new System.EventHandler(this.deleteSelectedPlayerButton_Click);
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.BackColor = System.Drawing.Color.White;
            this.deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedPrizeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(877, 398);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(137, 77);
            this.deleteSelectedPrizeButton.TabIndex = 23;
            this.deleteSelectedPrizeButton.Text = "Remove Selected";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = false;
            this.deleteSelectedPrizeButton.Click += new System.EventHandler(this.deleteSelectedPrizeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(517, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Prizes";
            // 
            // prizesList
            // 
            this.prizesList.FormattingEnabled = true;
            this.prizesList.ItemHeight = 36;
            this.prizesList.Location = new System.Drawing.Point(517, 343);
            this.prizesList.Name = "prizesList";
            this.prizesList.Size = new System.Drawing.Size(271, 184);
            this.prizesList.TabIndex = 21;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.White;
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createTournamentButton.Location = new System.Drawing.Point(272, 552);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(264, 56);
            this.createTournamentButton.TabIndex = 24;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 647);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prizesList);
            this.Controls.Add(this.deleteSelectedPlayerButton);
            this.Controls.Add(this.tournamentsPlayerLabel);
            this.Controls.Add(this.tournamentPlayerList);
            this.Controls.Add(this.createPriceButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectteamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox TournamentNameValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox EntryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.ComboBox selectteamDropDown;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPriceButton;
        private System.Windows.Forms.ListBox tournamentPlayerList;
        private System.Windows.Forms.Label tournamentsPlayerLabel;
        private System.Windows.Forms.Button deleteSelectedPlayerButton;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox prizesList;
        private System.Windows.Forms.Button createTournamentButton;
    }
}