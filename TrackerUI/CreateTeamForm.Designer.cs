using System.ComponentModel;

namespace TrackerUI
{
    partial class CreateTeamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.selectTeamMemberDropdown = new System.Windows.Forms.ComboBox();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.createMemeberButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.phonenumberLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.MembersLabel = new System.Windows.Forms.Label();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(20, 120);
            this.tournamentNameValue.Margin = new System.Windows.Forms.Padding(5);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(512, 43);
            this.tournamentNameValue.TabIndex = 13;
            this.tournamentNameValue.TextChanged += new System.EventHandler(this.tournamentNameValue_TextChanged);
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.teamNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.teamNameLabel.Location = new System.Drawing.Point(20, 73);
            this.teamNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(515, 42);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Team Name";
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.createTeamLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.createTeamLabel.Location = new System.Drawing.Point(20, 16);
            this.createTeamLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(538, 99);
            this.createTeamLabel.TabIndex = 11;
            this.createTeamLabel.Text = "Create Team";
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(20, 178);
            this.selectTeamMemberLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(515, 44);
            this.selectTeamMemberLabel.TabIndex = 14;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            this.selectTeamMemberLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // selectTeamMemberDropdown
            // 
            this.selectTeamMemberDropdown.FormattingEnabled = true;
            this.selectTeamMemberDropdown.Location = new System.Drawing.Point(20, 225);
            this.selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            this.selectTeamMemberDropdown.Size = new System.Drawing.Size(512, 45);
            this.selectTeamMemberDropdown.TabIndex = 15;
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.addMemberButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.addMemberButton.Location = new System.Drawing.Point(164, 291);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(218, 60);
            this.addMemberButton.TabIndex = 19;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // addNewMemberGroupBox
            // 
            this.addNewMemberGroupBox.Controls.Add(this.createMemeberButton);
            this.addNewMemberGroupBox.Controls.Add(this.textBox3);
            this.addNewMemberGroupBox.Controls.Add(this.phonenumberLabel);
            this.addNewMemberGroupBox.Controls.Add(this.textBox2);
            this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
            this.addNewMemberGroupBox.Controls.Add(this.textBox1);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.addNewMemberGroupBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(23, 380);
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(512, 297);
            this.addNewMemberGroupBox.TabIndex = 20;
            this.addNewMemberGroupBox.TabStop = false;
            this.addNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemeberButton
            // 
            this.createMemeberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemeberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.createMemeberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.createMemeberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemeberButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.createMemeberButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.createMemeberButton.Location = new System.Drawing.Point(6, 231);
            this.createMemeberButton.Name = "createMemeberButton";
            this.createMemeberButton.Size = new System.Drawing.Size(496, 60);
            this.createMemeberButton.TabIndex = 21;
            this.createMemeberButton.Text = "Create Member";
            this.createMemeberButton.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(189, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(313, 43);
            this.textBox3.TabIndex = 16;
            // 
            // phonenumberLabel
            // 
            this.phonenumberLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.phonenumberLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.phonenumberLabel.Location = new System.Drawing.Point(6, 181);
            this.phonenumberLabel.Name = "phonenumberLabel";
            this.phonenumberLabel.Size = new System.Drawing.Size(177, 34);
            this.phonenumberLabel.TabIndex = 15;
            this.phonenumberLabel.Text = "Phonenumber";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(313, 43);
            this.textBox2.TabIndex = 14;
            // 
            // emailLabel
            // 
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.emailLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.emailLabel.Location = new System.Drawing.Point(6, 132);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(138, 34);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 43);
            this.textBox1.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 83);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(138, 34);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(189, 34);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(313, 43);
            this.firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 37);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(138, 34);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.teamOneScoreLabel_Click);
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.deleteSelectedMemberButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(864, 76);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(72, 31);
            this.deleteSelectedMemberButton.TabIndex = 25;
            this.deleteSelectedMemberButton.Text = "Delete";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // MembersLabel
            // 
            this.MembersLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.MembersLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.MembersLabel.Location = new System.Drawing.Point(604, 73);
            this.MembersLabel.Name = "MembersLabel";
            this.MembersLabel.Size = new System.Drawing.Size(254, 34);
            this.MembersLabel.TabIndex = 24;
            this.MembersLabel.Text = "Members";
            this.MembersLabel.Click += new System.EventHandler(this.tournamentPlayersLabel_Click_1);
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 37;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(608, 120);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(328, 557);
            this.tournamentPlayersListBox.TabIndex = 23;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.BorderSize = 2;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.createTeamButton.Location = new System.Drawing.Point(248, 721);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(514, 55);
            this.createTeamButton.TabIndex = 27;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 794);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.MembersLabel);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberDropdown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.createTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewMemberGroupBox.ResumeLayout(false);
            this.addNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button createTeamButton;

        private System.Windows.Forms.Button deleteSelectedMemberButton;
        private System.Windows.Forms.Label MembersLabel;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;

        private System.Windows.Forms.Button createMemeberButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label phonenumberLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;

        private System.Windows.Forms.GroupBox addNewMemberGroupBox;

        private System.Windows.Forms.Button addMemberButton;

        private System.Windows.Forms.ComboBox selectTeamMemberDropdown;

        private System.Windows.Forms.Label selectTeamMemberLabel;

        private System.Windows.Forms.ColorDialog colorDialog1;

        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;

        #endregion
    }
}