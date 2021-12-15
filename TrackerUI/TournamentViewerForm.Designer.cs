
namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedCheckBox = new System.Windows.Forms.CheckBox();
            this.matchUpList = new System.Windows.Forms.ListBox();
            this.teamonelabel = new System.Windows.Forms.Label();
            this.teamoneScoreLabel = new System.Windows.Forms.Label();
            this.teamoneScoretext = new System.Windows.Forms.TextBox();
            this.teamtwoScoreText = new System.Windows.Forms.TextBox();
            this.teamtwoScoreLabel = new System.Windows.Forms.Label();
            this.teamtwoLabel = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.headerLabel.Location = new System.Drawing.Point(38, 29);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(284, 62);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament: ";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TournamentName.Location = new System.Drawing.Point(301, 29);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(189, 62);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<none>";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RoundLabel.Location = new System.Drawing.Point(38, 124);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(94, 37);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(138, 117);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(232, 44);
            this.roundDropDown.TabIndex = 3;
            this.roundDropDown.SelectedIndexChanged += new System.EventHandler(this.roundDropDown_SelectedIndexChanged);
            // 
            // unplayedCheckBox
            // 
            this.unplayedCheckBox.AutoSize = true;
            this.unplayedCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedCheckBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unplayedCheckBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.unplayedCheckBox.Location = new System.Drawing.Point(117, 167);
            this.unplayedCheckBox.Name = "unplayedCheckBox";
            this.unplayedCheckBox.Size = new System.Drawing.Size(211, 41);
            this.unplayedCheckBox.TabIndex = 4;
            this.unplayedCheckBox.Text = "Unplayed Only";
            this.unplayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchUpList
            // 
            this.matchUpList.FormattingEnabled = true;
            this.matchUpList.ItemHeight = 36;
            this.matchUpList.Location = new System.Drawing.Point(38, 227);
            this.matchUpList.Name = "matchUpList";
            this.matchUpList.Size = new System.Drawing.Size(332, 292);
            this.matchUpList.TabIndex = 5;
            this.matchUpList.SelectedIndexChanged += new System.EventHandler(this.matchUpList_SelectedIndexChanged);
            // 
            // teamonelabel
            // 
            this.teamonelabel.AutoSize = true;
            this.teamonelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamonelabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.teamonelabel.Location = new System.Drawing.Point(397, 234);
            this.teamonelabel.Name = "teamonelabel";
            this.teamonelabel.Size = new System.Drawing.Size(165, 37);
            this.teamonelabel.TabIndex = 6;
            this.teamonelabel.Text = "<team one>";
            // 
            // teamoneScoreLabel
            // 
            this.teamoneScoreLabel.AutoSize = true;
            this.teamoneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamoneScoreLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.teamoneScoreLabel.Location = new System.Drawing.Point(397, 289);
            this.teamoneScoreLabel.Name = "teamoneScoreLabel";
            this.teamoneScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.teamoneScoreLabel.TabIndex = 7;
            this.teamoneScoreLabel.Text = "Score";
            // 
            // teamoneScoretext
            // 
            this.teamoneScoretext.Location = new System.Drawing.Point(485, 289);
            this.teamoneScoretext.Name = "teamoneScoretext";
            this.teamoneScoretext.Size = new System.Drawing.Size(90, 42);
            this.teamoneScoretext.TabIndex = 8;
            this.teamoneScoretext.TextChanged += new System.EventHandler(this.teamoneScoretext_TextChanged);
            // 
            // teamtwoScoreText
            // 
            this.teamtwoScoreText.Location = new System.Drawing.Point(485, 444);
            this.teamtwoScoreText.Name = "teamtwoScoreText";
            this.teamtwoScoreText.Size = new System.Drawing.Size(90, 42);
            this.teamtwoScoreText.TabIndex = 11;
            this.teamtwoScoreText.TextChanged += new System.EventHandler(this.teamtwoScoreText_TextChanged);
            // 
            // teamtwoScoreLabel
            // 
            this.teamtwoScoreLabel.AutoSize = true;
            this.teamtwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamtwoScoreLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.teamtwoScoreLabel.Location = new System.Drawing.Point(397, 449);
            this.teamtwoScoreLabel.Name = "teamtwoScoreLabel";
            this.teamtwoScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.teamtwoScoreLabel.TabIndex = 10;
            this.teamtwoScoreLabel.Text = "Score";
            // 
            // teamtwoLabel
            // 
            this.teamtwoLabel.AutoSize = true;
            this.teamtwoLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamtwoLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.teamtwoLabel.Location = new System.Drawing.Point(397, 392);
            this.teamtwoLabel.Name = "teamtwoLabel";
            this.teamtwoLabel.Size = new System.Drawing.Size(165, 37);
            this.teamtwoLabel.TabIndex = 9;
            this.teamtwoLabel.Text = "<team two>";
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versusLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.versusLabel.Location = new System.Drawing.Point(453, 350);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(70, 37);
            this.versusLabel.TabIndex = 12;
            this.versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            this.scoreButton.BackColor = System.Drawing.Color.White;
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.scoreButton.Location = new System.Drawing.Point(612, 350);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(109, 51);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = false;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 539);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamtwoScoreText);
            this.Controls.Add(this.teamtwoScoreLabel);
            this.Controls.Add(this.teamtwoLabel);
            this.Controls.Add(this.teamoneScoretext);
            this.Controls.Add(this.teamoneScoreLabel);
            this.Controls.Add(this.teamonelabel);
            this.Controls.Add(this.matchUpList);
            this.Controls.Add(this.unplayedCheckBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Form";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedCheckBox;
        private System.Windows.Forms.ListBox matchUpList;
        private System.Windows.Forms.Label teamonelabel;
        private System.Windows.Forms.Label teamoneScoreLabel;
        private System.Windows.Forms.TextBox teamoneScoretext;
        private System.Windows.Forms.TextBox teamtwoScoreText;
        private System.Windows.Forms.Label teamtwoScoreLabel;
        private System.Windows.Forms.Label teamtwoLabel;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

