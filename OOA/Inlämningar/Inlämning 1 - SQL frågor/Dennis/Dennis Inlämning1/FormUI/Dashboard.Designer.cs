
namespace FormUI
{
    partial class Dashboard
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
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.lastnameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchLastNameButton = new System.Windows.Forms.Button();
            this.headLabel = new System.Windows.Forms.Label();
            this.searchAllButton = new System.Windows.Forms.Button();
            this.myNameLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.LatestUpdateLabel = new System.Windows.Forms.Label();
            this.searchIdButton = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.searchFirstnameButton = new System.Windows.Forms.Button();
            this.FirstNameButton = new System.Windows.Forms.Label();
            this.firstnameText = new System.Windows.Forms.TextBox();
            this.searchUsernameButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.searchEmailButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.searchPasswordButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.searchCountryButton = new System.Windows.Forms.Button();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countryText = new System.Windows.Forms.TextBox();
            this.howManyCountriesLabel = new System.Windows.Forms.Button();
            this.PressButtonLabel = new System.Windows.Forms.Label();
            this.listTop10LLabel = new System.Windows.Forms.Button();
            this.DestrictLabel = new System.Windows.Forms.Button();
            this.sameInitialsLabel = new System.Windows.Forms.Button();
            this.mostCommonCountryLabel = new System.Windows.Forms.Button();
            this.ScandinaviaButton = new System.Windows.Forms.Button();
            this.nordicButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.BackColor = System.Drawing.Color.LightGray;
            this.peopleFoundListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 20;
            this.peopleFoundListbox.Location = new System.Drawing.Point(23, 451);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(1203, 304);
            this.peopleFoundListbox.TabIndex = 0;
            // 
            // lastnameText
            // 
            this.lastnameText.Location = new System.Drawing.Point(26, 226);
            this.lastnameText.Name = "lastnameText";
            this.lastnameText.Size = new System.Drawing.Size(144, 20);
            this.lastnameText.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(25, 213);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Lastname:";
            // 
            // searchLastNameButton
            // 
            this.searchLastNameButton.BackColor = System.Drawing.Color.PeachPuff;
            this.searchLastNameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchLastNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchLastNameButton.Location = new System.Drawing.Point(174, 225);
            this.searchLastNameButton.Name = "searchLastNameButton";
            this.searchLastNameButton.Size = new System.Drawing.Size(117, 22);
            this.searchLastNameButton.TabIndex = 3;
            this.searchLastNameButton.Text = "Search Lastname";
            this.searchLastNameButton.UseVisualStyleBackColor = false;
            this.searchLastNameButton.Click += new System.EventHandler(this.searchLastNameButton_Click);
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Font = new System.Drawing.Font("Poor Richard", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLabel.Location = new System.Drawing.Point(363, 6);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(513, 63);
            this.headLabel.TabIndex = 4;
            this.headLabel.Text = "SQL DATABASE BY:";
            // 
            // searchAllButton
            // 
            this.searchAllButton.BackColor = System.Drawing.Color.PeachPuff;
            this.searchAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchAllButton.Location = new System.Drawing.Point(26, 86);
            this.searchAllButton.Name = "searchAllButton";
            this.searchAllButton.Size = new System.Drawing.Size(265, 34);
            this.searchAllButton.TabIndex = 5;
            this.searchAllButton.Text = "Search All";
            this.searchAllButton.UseVisualStyleBackColor = false;
            this.searchAllButton.Click += new System.EventHandler(this.searchAllButton_Click);
            // 
            // myNameLabel
            // 
            this.myNameLabel.AutoSize = true;
            this.myNameLabel.Font = new System.Drawing.Font("Vivaldi", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myNameLabel.Location = new System.Drawing.Point(469, 70);
            this.myNameLabel.Name = "myNameLabel";
            this.myNameLabel.Size = new System.Drawing.Size(301, 57);
            this.myNameLabel.TabIndex = 6;
            this.myNameLabel.Text = "Dennis Byberg";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.Location = new System.Drawing.Point(24, 759);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(78, 15);
            this.VersionLabel.TabIndex = 7;
            this.VersionLabel.Text = "Version 1.0.6";
            // 
            // LatestUpdateLabel
            // 
            this.LatestUpdateLabel.AutoSize = true;
            this.LatestUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatestUpdateLabel.Location = new System.Drawing.Point(1075, 759);
            this.LatestUpdateLabel.Name = "LatestUpdateLabel";
            this.LatestUpdateLabel.Size = new System.Drawing.Size(153, 15);
            this.LatestUpdateLabel.TabIndex = 8;
            this.LatestUpdateLabel.Text = "Latest Update: 2021-11-21";
            // 
            // searchIdButton
            // 
            this.searchIdButton.BackColor = System.Drawing.Color.PeachPuff;
            this.searchIdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchIdButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchIdButton.Location = new System.Drawing.Point(174, 145);
            this.searchIdButton.Name = "searchIdButton";
            this.searchIdButton.Size = new System.Drawing.Size(117, 22);
            this.searchIdButton.TabIndex = 11;
            this.searchIdButton.Text = "Search ID";
            this.searchIdButton.UseVisualStyleBackColor = false;
            this.searchIdButton.Click += new System.EventHandler(this.searchIdButton_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(25, 133);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 10;
            this.IdLabel.Text = "Id:";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(26, 146);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(144, 20);
            this.idText.TabIndex = 0;
            // 
            // searchFirstnameButton
            // 
            this.searchFirstnameButton.BackColor = System.Drawing.Color.PeachPuff;
            this.searchFirstnameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchFirstnameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchFirstnameButton.Location = new System.Drawing.Point(174, 185);
            this.searchFirstnameButton.Name = "searchFirstnameButton";
            this.searchFirstnameButton.Size = new System.Drawing.Size(117, 22);
            this.searchFirstnameButton.TabIndex = 14;
            this.searchFirstnameButton.Text = "Search Firstname";
            this.searchFirstnameButton.UseVisualStyleBackColor = false;
            this.searchFirstnameButton.Click += new System.EventHandler(this.searchFirstnameButton_Click);
            // 
            // FirstNameButton
            // 
            this.FirstNameButton.AutoSize = true;
            this.FirstNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameButton.Location = new System.Drawing.Point(25, 173);
            this.FirstNameButton.Name = "FirstNameButton";
            this.FirstNameButton.Size = new System.Drawing.Size(55, 13);
            this.FirstNameButton.TabIndex = 13;
            this.FirstNameButton.Text = "Firstname:";
            // 
            // firstnameText
            // 
            this.firstnameText.Location = new System.Drawing.Point(26, 186);
            this.firstnameText.Name = "firstnameText";
            this.firstnameText.Size = new System.Drawing.Size(144, 20);
            this.firstnameText.TabIndex = 1;
            // 
            // searchUsernameButton
            // 
            this.searchUsernameButton.BackColor = System.Drawing.Color.PeachPuff;
            this.searchUsernameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchUsernameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchUsernameButton.Location = new System.Drawing.Point(174, 304);
            this.searchUsernameButton.Name = "searchUsernameButton";
            this.searchUsernameButton.Size = new System.Drawing.Size(117, 22);
            this.searchUsernameButton.TabIndex = 23;
            this.searchUsernameButton.Text = "Search Username";
            this.searchUsernameButton.UseVisualStyleBackColor = false;
            this.searchUsernameButton.Click += new System.EventHandler(this.searchUsernameButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(25, 292);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 22;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(26, 305);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(144, 20);
            this.usernameText.TabIndex = 4;
            // 
            // searchEmailButton
            // 
            this.searchEmailButton.BackColor = System.Drawing.Color.PeachPuff;
            this.searchEmailButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchEmailButton.Location = new System.Drawing.Point(174, 264);
            this.searchEmailButton.Name = "searchEmailButton";
            this.searchEmailButton.Size = new System.Drawing.Size(117, 22);
            this.searchEmailButton.TabIndex = 20;
            this.searchEmailButton.Text = "Search Email";
            this.searchEmailButton.UseVisualStyleBackColor = false;
            this.searchEmailButton.Click += new System.EventHandler(this.searchEmailButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(25, 252);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 19;
            this.emailLabel.Text = "Email:";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(26, 265);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(144, 20);
            this.emailText.TabIndex = 3;
            // 
            // searchPasswordButton
            // 
            this.searchPasswordButton.BackColor = System.Drawing.Color.PeachPuff;
            this.searchPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchPasswordButton.Location = new System.Drawing.Point(174, 344);
            this.searchPasswordButton.Name = "searchPasswordButton";
            this.searchPasswordButton.Size = new System.Drawing.Size(117, 22);
            this.searchPasswordButton.TabIndex = 17;
            this.searchPasswordButton.Text = "Search Password";
            this.searchPasswordButton.UseVisualStyleBackColor = false;
            this.searchPasswordButton.Click += new System.EventHandler(this.searchPasswordButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(25, 332);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 16;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(26, 345);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(144, 20);
            this.passwordText.TabIndex = 5;
            // 
            // searchCountryButton
            // 
            this.searchCountryButton.BackColor = System.Drawing.Color.PeachPuff;
            this.searchCountryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchCountryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchCountryButton.Location = new System.Drawing.Point(174, 384);
            this.searchCountryButton.Name = "searchCountryButton";
            this.searchCountryButton.Size = new System.Drawing.Size(117, 22);
            this.searchCountryButton.TabIndex = 26;
            this.searchCountryButton.Text = "Search Country";
            this.searchCountryButton.UseVisualStyleBackColor = false;
            this.searchCountryButton.Click += new System.EventHandler(this.searchCountryButton_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(25, 372);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(46, 13);
            this.countryLabel.TabIndex = 25;
            this.countryLabel.Text = "Country:";
            // 
            // countryText
            // 
            this.countryText.Location = new System.Drawing.Point(26, 385);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(144, 20);
            this.countryText.TabIndex = 6;
            // 
            // howManyCountriesLabel
            // 
            this.howManyCountriesLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.howManyCountriesLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.howManyCountriesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.howManyCountriesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.howManyCountriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howManyCountriesLabel.Location = new System.Drawing.Point(968, 80);
            this.howManyCountriesLabel.Name = "howManyCountriesLabel";
            this.howManyCountriesLabel.Size = new System.Drawing.Size(224, 50);
            this.howManyCountriesLabel.TabIndex = 28;
            this.howManyCountriesLabel.Text = "How many different countries are represented?";
            this.howManyCountriesLabel.UseVisualStyleBackColor = false;
            this.howManyCountriesLabel.Click += new System.EventHandler(this.howManyCountriesLabel_Click);
            // 
            // PressButtonLabel
            // 
            this.PressButtonLabel.AutoSize = true;
            this.PressButtonLabel.BackColor = System.Drawing.Color.DarkGray;
            this.PressButtonLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PressButtonLabel.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressButtonLabel.Location = new System.Drawing.Point(914, 43);
            this.PressButtonLabel.Name = "PressButtonLabel";
            this.PressButtonLabel.Size = new System.Drawing.Size(318, 26);
            this.PressButtonLabel.TabIndex = 29;
            this.PressButtonLabel.Text = "press the buttons below  to see the results";
            // 
            // listTop10LLabel
            // 
            this.listTop10LLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.listTop10LLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listTop10LLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listTop10LLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTop10LLabel.Location = new System.Drawing.Point(968, 304);
            this.listTop10LLabel.Name = "listTop10LLabel";
            this.listTop10LLabel.Size = new System.Drawing.Size(224, 57);
            this.listTop10LLabel.TabIndex = 30;
            this.listTop10LLabel.Text = "10 first List of the first 10 users whose last name begins with the letter L";
            this.listTop10LLabel.UseVisualStyleBackColor = false;
            this.listTop10LLabel.Click += new System.EventHandler(this.listTop10LLabel_Click);
            // 
            // DestrictLabel
            // 
            this.DestrictLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.DestrictLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DestrictLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DestrictLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestrictLabel.Location = new System.Drawing.Point(968, 248);
            this.DestrictLabel.Name = "DestrictLabel";
            this.DestrictLabel.Size = new System.Drawing.Size(224, 50);
            this.DestrictLabel.TabIndex = 31;
            this.DestrictLabel.Text = "Are all usernames and passwords unique?";
            this.DestrictLabel.UseVisualStyleBackColor = false;
            this.DestrictLabel.Click += new System.EventHandler(this.DestrictLabel_Click);
            // 
            // sameInitialsLabel
            // 
            this.sameInitialsLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.sameInitialsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sameInitialsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sameInitialsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sameInitialsLabel.Location = new System.Drawing.Point(968, 192);
            this.sameInitialsLabel.Name = "sameInitialsLabel";
            this.sameInitialsLabel.Size = new System.Drawing.Size(224, 50);
            this.sameInitialsLabel.TabIndex = 32;
            this.sameInitialsLabel.Text = "All users whose first and last names have the same initials";
            this.sameInitialsLabel.UseVisualStyleBackColor = false;
            this.sameInitialsLabel.Click += new System.EventHandler(this.sameInitialsLabel_Click);
            // 
            // mostCommonCountryLabel
            // 
            this.mostCommonCountryLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.mostCommonCountryLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mostCommonCountryLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mostCommonCountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostCommonCountryLabel.Location = new System.Drawing.Point(968, 136);
            this.mostCommonCountryLabel.Name = "mostCommonCountryLabel";
            this.mostCommonCountryLabel.Size = new System.Drawing.Size(224, 50);
            this.mostCommonCountryLabel.TabIndex = 33;
            this.mostCommonCountryLabel.Text = "Which is the most common country?";
            this.mostCommonCountryLabel.UseVisualStyleBackColor = false;
            this.mostCommonCountryLabel.Click += new System.EventHandler(this.mostCommonCountryLabel_Click);
            // 
            // ScandinaviaButton
            // 
            this.ScandinaviaButton.BackColor = System.Drawing.Color.PeachPuff;
            this.ScandinaviaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScandinaviaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ScandinaviaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScandinaviaButton.Location = new System.Drawing.Point(968, 367);
            this.ScandinaviaButton.Name = "ScandinaviaButton";
            this.ScandinaviaButton.Size = new System.Drawing.Size(106, 70);
            this.ScandinaviaButton.TabIndex = 34;
            this.ScandinaviaButton.Text = "How many users are from the scandinavian countries?";
            this.ScandinaviaButton.UseVisualStyleBackColor = false;
            this.ScandinaviaButton.Click += new System.EventHandler(this.ScandinaviaButton_Click);
            // 
            // nordicButton
            // 
            this.nordicButton.BackColor = System.Drawing.Color.PeachPuff;
            this.nordicButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nordicButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nordicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nordicButton.Location = new System.Drawing.Point(1086, 367);
            this.nordicButton.Name = "nordicButton";
            this.nordicButton.Size = new System.Drawing.Size(106, 70);
            this.nordicButton.TabIndex = 35;
            this.nordicButton.Text = "How many users are from the nordic countries?";
            this.nordicButton.UseVisualStyleBackColor = false;
            this.nordicButton.Click += new System.EventHandler(this.nordicButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1244, 780);
            this.Controls.Add(this.nordicButton);
            this.Controls.Add(this.ScandinaviaButton);
            this.Controls.Add(this.mostCommonCountryLabel);
            this.Controls.Add(this.sameInitialsLabel);
            this.Controls.Add(this.DestrictLabel);
            this.Controls.Add(this.listTop10LLabel);
            this.Controls.Add(this.PressButtonLabel);
            this.Controls.Add(this.howManyCountriesLabel);
            this.Controls.Add(this.searchCountryButton);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.countryText);
            this.Controls.Add(this.searchUsernameButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.searchEmailButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.searchPasswordButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.searchFirstnameButton);
            this.Controls.Add(this.FirstNameButton);
            this.Controls.Add(this.firstnameText);
            this.Controls.Add(this.searchIdButton);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.LatestUpdateLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.myNameLabel);
            this.Controls.Add(this.searchAllButton);
            this.Controls.Add(this.headLabel);
            this.Controls.Add(this.searchLastNameButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastnameText);
            this.Controls.Add(this.peopleFoundListbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Dashboard";
            this.Text = "SQL Data Access";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.TextBox lastnameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchLastNameButton;
        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.Button searchAllButton;
        private System.Windows.Forms.Label myNameLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label LatestUpdateLabel;
        private System.Windows.Forms.Button searchIdButton;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Button searchFirstnameButton;
        private System.Windows.Forms.Label FirstNameButton;
        private System.Windows.Forms.TextBox firstnameText;
        private System.Windows.Forms.Button searchUsernameButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Button searchEmailButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Button searchPasswordButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button searchCountryButton;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox countryText;
        private System.Windows.Forms.Button howManyCountriesLabel;
        private System.Windows.Forms.Label PressButtonLabel;
        private System.Windows.Forms.Button listTop10LLabel;
        private System.Windows.Forms.Button DestrictLabel;
        private System.Windows.Forms.Button sameInitialsLabel;
        private System.Windows.Forms.Button mostCommonCountryLabel;
        private System.Windows.Forms.Button ScandinaviaButton;
        private System.Windows.Forms.Button nordicButton;
    }
}

