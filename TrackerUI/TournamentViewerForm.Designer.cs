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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreText = new System.Windows.Forms.TextBox();
            this.versusLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreText = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.headerLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(214, 56);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            this.headerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tournamentName
            // 
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tournamentName.ForeColor = System.Drawing.Color.SteelBlue;
            this.tournamentName.Location = new System.Drawing.Point(232, 9);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(438, 56);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.roundLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.roundLabel.Location = new System.Drawing.Point(12, 92);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(100, 34);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(132, 97);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(199, 29);
            this.roundDropDown.TabIndex = 3;
            this.roundDropDown.SelectedIndexChanged += new System.EventHandler(this.roundDropDown_SelectedIndexChanged);
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.unplayedOnlyCheckBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(132, 132);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(199, 42);
            this.unplayedOnlyCheckBox.TabIndex = 4;
            this.unplayedOnlyCheckBox.Text = "Unplayed Only";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            this.unplayedOnlyCheckBox.CheckedChanged += new System.EventHandler(this.unplayedOnlyCheckBox_CheckedChanged);
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 21;
            this.matchupListBox.Location = new System.Drawing.Point(26, 180);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(305, 233);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.teamOneName.ForeColor = System.Drawing.Color.SteelBlue;
            this.teamOneName.Location = new System.Drawing.Point(373, 180);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(164, 34);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.teamOneScoreLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(373, 214);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(138, 34);
            this.teamOneScoreLabel.TabIndex = 7;
            this.teamOneScoreLabel.Text = "Score";
            this.teamOneScoreLabel.Click += new System.EventHandler(this.teamOneScoreLabel_Click);
            // 
            // teamOneScoreText
            // 
            this.teamOneScoreText.Location = new System.Drawing.Point(460, 219);
            this.teamOneScoreText.Name = "teamOneScoreText";
            this.teamOneScoreText.Size = new System.Drawing.Size(100, 29);
            this.teamOneScoreText.TabIndex = 8;
            this.teamOneScoreText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // versusLabel
            // 
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.versusLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.versusLabel.Location = new System.Drawing.Point(415, 285);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(82, 34);
            this.versusLabel.TabIndex = 12;
            this.versusLabel.Text = "- VS -";
            this.versusLabel.Click += new System.EventHandler(this.vsLabel_Click);
            // 
            // teamTwoScoreText
            // 
            this.teamTwoScoreText.Location = new System.Drawing.Point(460, 383);
            this.teamTwoScoreText.Name = "teamTwoScoreText";
            this.teamTwoScoreText.Size = new System.Drawing.Size(100, 29);
            this.teamTwoScoreText.TabIndex = 15;
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(373, 378);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(138, 34);
            this.teamTwoScoreLabel.TabIndex = 14;
            this.teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.teamTwoName.ForeColor = System.Drawing.Color.SteelBlue;
            this.teamTwoName.Location = new System.Drawing.Point(373, 344);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(164, 34);
            this.teamTwoName.TabIndex = 13;
            this.teamTwoName.Text = "<team two>";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.scoreButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.scoreButton.Location = new System.Drawing.Point(579, 283);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(124, 50);
            this.scoreButton.TabIndex = 16;
            this.scoreButton.Text = "Submit Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 452);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.teamTwoScoreText);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamOneScoreText);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TournamentViewerForm";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button scoreButton;

        private System.Windows.Forms.Label teamTwoScoreLabel;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.TextBox teamTwoScoreText;

        private System.Windows.Forms.Label versusLabel;

        private System.Windows.Forms.TextBox teamOneScoreText;

        private System.Windows.Forms.Label teamOneScoreLabel;

        private System.Windows.Forms.Label teamOneName;

        private System.Windows.Forms.ListBox matchupListBox;

        private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;

        private System.Windows.Forms.ComboBox roundDropDown;

        private System.Windows.Forms.Label roundLabel;

        private System.Windows.Forms.Label tournamentName;

        private System.Windows.Forms.Label headerLabel;

        #endregion
    }
}