namespace FamilyTreeWF.Forms
{
    partial class MainWindow
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
            this.b_addPerson = new System.Windows.Forms.Button();
            this.lb_peopleList = new System.Windows.Forms.ListBox();
            this.b_editPerson = new System.Windows.Forms.Button();
            this.l_father = new System.Windows.Forms.Label();
            this.l_mother = new System.Windows.Forms.Label();
            this.tb_father = new System.Windows.Forms.TextBox();
            this.tb_mother = new System.Windows.Forms.TextBox();
            this.l_siblings = new System.Windows.Forms.Label();
            this.lb_siblings = new System.Windows.Forms.ListBox();
            this.lb_children = new System.Windows.Forms.ListBox();
            this.l_children = new System.Windows.Forms.Label();
            this.b_showFamilyTree = new System.Windows.Forms.Button();
            this.b_deletePerson = new System.Windows.Forms.Button();
            this.b_showCities = new System.Windows.Forms.Button();
            this.b_showCountries = new System.Windows.Forms.Button();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.l_filterBy = new System.Windows.Forms.Label();
            this.l_filter = new System.Windows.Forms.Label();
            this.b_applyFilter = new System.Windows.Forms.Button();
            this.b_resetFilter = new System.Windows.Forms.Button();
            this.rb_firstName = new System.Windows.Forms.RadioButton();
            this.rb_lastName = new System.Windows.Forms.RadioButton();
            this.rb_birthYear = new System.Windows.Forms.RadioButton();
            this.rb_birthCity = new System.Windows.Forms.RadioButton();
            this.rb_birthCountry = new System.Windows.Forms.RadioButton();
            this.l_peopleList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_addPerson
            // 
            this.b_addPerson.AutoSize = true;
            this.b_addPerson.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_addPerson.Location = new System.Drawing.Point(695, 180);
            this.b_addPerson.Name = "b_addPerson";
            this.b_addPerson.Size = new System.Drawing.Size(164, 47);
            this.b_addPerson.TabIndex = 20;
            this.b_addPerson.Text = "Add Person";
            this.b_addPerson.UseVisualStyleBackColor = true;
            this.b_addPerson.Click += new System.EventHandler(this.B_addPerson_Click);
            // 
            // lb_peopleList
            // 
            this.lb_peopleList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_peopleList.DisplayMember = "FullNameAndLifeTime";
            this.lb_peopleList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_peopleList.FormattingEnabled = true;
            this.lb_peopleList.ItemHeight = 24;
            this.lb_peopleList.Location = new System.Drawing.Point(383, 127);
            this.lb_peopleList.Name = "lb_peopleList";
            this.lb_peopleList.Size = new System.Drawing.Size(306, 364);
            this.lb_peopleList.TabIndex = 18;
            this.lb_peopleList.ValueMember = "PersonId";
            this.lb_peopleList.SelectedIndexChanged += new System.EventHandler(this.Lb_peopleList_SelectedIndexChanged);
            // 
            // b_editPerson
            // 
            this.b_editPerson.AutoSize = true;
            this.b_editPerson.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_editPerson.Location = new System.Drawing.Point(695, 233);
            this.b_editPerson.Name = "b_editPerson";
            this.b_editPerson.Size = new System.Drawing.Size(164, 47);
            this.b_editPerson.TabIndex = 21;
            this.b_editPerson.Text = "Edit Person";
            this.b_editPerson.UseVisualStyleBackColor = true;
            this.b_editPerson.Click += new System.EventHandler(this.B_editPerson_Click);
            // 
            // l_father
            // 
            this.l_father.AutoSize = true;
            this.l_father.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_father.Location = new System.Drawing.Point(22, 130);
            this.l_father.Name = "l_father";
            this.l_father.Size = new System.Drawing.Size(63, 24);
            this.l_father.TabIndex = 10;
            this.l_father.Text = "Father";
            // 
            // l_mother
            // 
            this.l_mother.AutoSize = true;
            this.l_mother.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_mother.Location = new System.Drawing.Point(12, 163);
            this.l_mother.Name = "l_mother";
            this.l_mother.Size = new System.Drawing.Size(73, 24);
            this.l_mother.TabIndex = 12;
            this.l_mother.Text = "Mother";
            // 
            // tb_father
            // 
            this.tb_father.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_father.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_father.Location = new System.Drawing.Point(91, 127);
            this.tb_father.Name = "tb_father";
            this.tb_father.ReadOnly = true;
            this.tb_father.Size = new System.Drawing.Size(286, 32);
            this.tb_father.TabIndex = 11;
            this.tb_father.DoubleClick += new System.EventHandler(this.TextOrListBox_DoubleClick);
            // 
            // tb_mother
            // 
            this.tb_mother.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_mother.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mother.Location = new System.Drawing.Point(91, 160);
            this.tb_mother.Name = "tb_mother";
            this.tb_mother.ReadOnly = true;
            this.tb_mother.Size = new System.Drawing.Size(286, 32);
            this.tb_mother.TabIndex = 13;
            this.tb_mother.DoubleClick += new System.EventHandler(this.TextOrListBox_DoubleClick);
            // 
            // l_siblings
            // 
            this.l_siblings.AutoSize = true;
            this.l_siblings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_siblings.Location = new System.Drawing.Point(31, 201);
            this.l_siblings.Name = "l_siblings";
            this.l_siblings.Size = new System.Drawing.Size(78, 24);
            this.l_siblings.TabIndex = 14;
            this.l_siblings.Text = "Siblings:";
            // 
            // lb_siblings
            // 
            this.lb_siblings.BackColor = System.Drawing.SystemColors.Control;
            this.lb_siblings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_siblings.DisplayMember = "FullNameAndLifeTime";
            this.lb_siblings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_siblings.FormattingEnabled = true;
            this.lb_siblings.ItemHeight = 24;
            this.lb_siblings.Location = new System.Drawing.Point(31, 224);
            this.lb_siblings.Name = "lb_siblings";
            this.lb_siblings.Size = new System.Drawing.Size(346, 100);
            this.lb_siblings.TabIndex = 15;
            this.lb_siblings.ValueMember = "PersonId";
            this.lb_siblings.DoubleClick += new System.EventHandler(this.TextOrListBox_DoubleClick);
            // 
            // lb_children
            // 
            this.lb_children.BackColor = System.Drawing.SystemColors.Control;
            this.lb_children.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_children.DisplayMember = "FullNameAndLifeTime";
            this.lb_children.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_children.FormattingEnabled = true;
            this.lb_children.ItemHeight = 24;
            this.lb_children.Location = new System.Drawing.Point(31, 361);
            this.lb_children.Name = "lb_children";
            this.lb_children.Size = new System.Drawing.Size(346, 100);
            this.lb_children.TabIndex = 16;
            this.lb_children.ValueMember = "PersonId";
            this.lb_children.DoubleClick += new System.EventHandler(this.TextOrListBox_DoubleClick);
            // 
            // l_children
            // 
            this.l_children.AutoSize = true;
            this.l_children.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_children.Location = new System.Drawing.Point(31, 334);
            this.l_children.Name = "l_children";
            this.l_children.Size = new System.Drawing.Size(86, 24);
            this.l_children.TabIndex = 17;
            this.l_children.Text = "Children:";
            // 
            // b_showFamilyTree
            // 
            this.b_showFamilyTree.AutoSize = true;
            this.b_showFamilyTree.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_showFamilyTree.Location = new System.Drawing.Point(695, 127);
            this.b_showFamilyTree.Name = "b_showFamilyTree";
            this.b_showFamilyTree.Size = new System.Drawing.Size(164, 47);
            this.b_showFamilyTree.TabIndex = 19;
            this.b_showFamilyTree.Text = "Show Family Tree";
            this.b_showFamilyTree.UseVisualStyleBackColor = true;
            this.b_showFamilyTree.Click += new System.EventHandler(this.B_showFamilyTree_Click);
            // 
            // b_deletePerson
            // 
            this.b_deletePerson.AutoSize = true;
            this.b_deletePerson.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_deletePerson.Location = new System.Drawing.Point(695, 286);
            this.b_deletePerson.Name = "b_deletePerson";
            this.b_deletePerson.Size = new System.Drawing.Size(164, 47);
            this.b_deletePerson.TabIndex = 22;
            this.b_deletePerson.Text = "Delete Person";
            this.b_deletePerson.UseVisualStyleBackColor = true;
            this.b_deletePerson.Click += new System.EventHandler(this.B_deletePerson_Click);
            // 
            // b_showCities
            // 
            this.b_showCities.AutoSize = true;
            this.b_showCities.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_showCities.Location = new System.Drawing.Point(695, 339);
            this.b_showCities.Name = "b_showCities";
            this.b_showCities.Size = new System.Drawing.Size(164, 47);
            this.b_showCities.TabIndex = 23;
            this.b_showCities.Text = "Show Cities";
            this.b_showCities.UseVisualStyleBackColor = true;
            this.b_showCities.Click += new System.EventHandler(this.B_showCities_Click);
            // 
            // b_showCountries
            // 
            this.b_showCountries.AutoSize = true;
            this.b_showCountries.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_showCountries.Location = new System.Drawing.Point(695, 392);
            this.b_showCountries.Name = "b_showCountries";
            this.b_showCountries.Size = new System.Drawing.Size(164, 47);
            this.b_showCountries.TabIndex = 24;
            this.b_showCountries.Text = "Show Countries";
            this.b_showCountries.UseVisualStyleBackColor = true;
            this.b_showCountries.Click += new System.EventHandler(this.B_showCountries_Click);
            // 
            // cb_filter
            // 
            this.cb_filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_filter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Location = new System.Drawing.Point(126, 43);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(236, 32);
            this.cb_filter.TabIndex = 7;
            // 
            // l_filterBy
            // 
            this.l_filterBy.AutoSize = true;
            this.l_filterBy.Location = new System.Drawing.Point(12, 9);
            this.l_filterBy.Name = "l_filterBy";
            this.l_filterBy.Size = new System.Drawing.Size(83, 24);
            this.l_filterBy.TabIndex = 0;
            this.l_filterBy.Text = "Filter by:";
            // 
            // l_filter
            // 
            this.l_filter.AutoSize = true;
            this.l_filter.Location = new System.Drawing.Point(11, 46);
            this.l_filter.Name = "l_filter";
            this.l_filter.Size = new System.Drawing.Size(109, 24);
            this.l_filter.TabIndex = 6;
            this.l_filter.Text = "Filter Value:";
            // 
            // b_applyFilter
            // 
            this.b_applyFilter.AutoSize = true;
            this.b_applyFilter.Location = new System.Drawing.Point(368, 41);
            this.b_applyFilter.Name = "b_applyFilter";
            this.b_applyFilter.Size = new System.Drawing.Size(119, 34);
            this.b_applyFilter.TabIndex = 8;
            this.b_applyFilter.Text = "Apply Filter";
            this.b_applyFilter.UseVisualStyleBackColor = true;
            this.b_applyFilter.Click += new System.EventHandler(this.B_applyFilter_Click);
            // 
            // b_resetFilter
            // 
            this.b_resetFilter.AutoSize = true;
            this.b_resetFilter.Location = new System.Drawing.Point(493, 41);
            this.b_resetFilter.Name = "b_resetFilter";
            this.b_resetFilter.Size = new System.Drawing.Size(122, 34);
            this.b_resetFilter.TabIndex = 9;
            this.b_resetFilter.Text = "Reset Filters";
            this.b_resetFilter.UseVisualStyleBackColor = true;
            this.b_resetFilter.Click += new System.EventHandler(this.B_resetFilter_Click);
            // 
            // rb_firstName
            // 
            this.rb_firstName.AutoSize = true;
            this.rb_firstName.Location = new System.Drawing.Point(101, 7);
            this.rb_firstName.Name = "rb_firstName";
            this.rb_firstName.Size = new System.Drawing.Size(121, 28);
            this.rb_firstName.TabIndex = 1;
            this.rb_firstName.TabStop = true;
            this.rb_firstName.Text = "First Name";
            this.rb_firstName.UseVisualStyleBackColor = true;
            this.rb_firstName.CheckedChanged += new System.EventHandler(this.FilterRadioButtonCheckChanged);
            // 
            // rb_lastName
            // 
            this.rb_lastName.AutoSize = true;
            this.rb_lastName.Location = new System.Drawing.Point(228, 7);
            this.rb_lastName.Name = "rb_lastName";
            this.rb_lastName.Size = new System.Drawing.Size(118, 28);
            this.rb_lastName.TabIndex = 2;
            this.rb_lastName.TabStop = true;
            this.rb_lastName.Text = "Last Name";
            this.rb_lastName.UseVisualStyleBackColor = true;
            this.rb_lastName.CheckedChanged += new System.EventHandler(this.FilterRadioButtonCheckChanged);
            // 
            // rb_birthYear
            // 
            this.rb_birthYear.AutoSize = true;
            this.rb_birthYear.Location = new System.Drawing.Point(352, 7);
            this.rb_birthYear.Name = "rb_birthYear";
            this.rb_birthYear.Size = new System.Drawing.Size(135, 28);
            this.rb_birthYear.TabIndex = 3;
            this.rb_birthYear.TabStop = true;
            this.rb_birthYear.Text = "Year of birth";
            this.rb_birthYear.UseVisualStyleBackColor = true;
            this.rb_birthYear.CheckedChanged += new System.EventHandler(this.FilterRadioButtonCheckChanged);
            // 
            // rb_birthCity
            // 
            this.rb_birthCity.AutoSize = true;
            this.rb_birthCity.Location = new System.Drawing.Point(493, 7);
            this.rb_birthCity.Name = "rb_birthCity";
            this.rb_birthCity.Size = new System.Drawing.Size(131, 28);
            this.rb_birthCity.TabIndex = 4;
            this.rb_birthCity.TabStop = true;
            this.rb_birthCity.Text = "City of birth";
            this.rb_birthCity.UseVisualStyleBackColor = true;
            this.rb_birthCity.CheckedChanged += new System.EventHandler(this.FilterRadioButtonCheckChanged);
            // 
            // rb_birthCountry
            // 
            this.rb_birthCountry.AutoSize = true;
            this.rb_birthCountry.Location = new System.Drawing.Point(621, 7);
            this.rb_birthCountry.Name = "rb_birthCountry";
            this.rb_birthCountry.Size = new System.Drawing.Size(166, 28);
            this.rb_birthCountry.TabIndex = 5;
            this.rb_birthCountry.TabStop = true;
            this.rb_birthCountry.Text = "Country of birth";
            this.rb_birthCountry.UseVisualStyleBackColor = true;
            this.rb_birthCountry.CheckedChanged += new System.EventHandler(this.FilterRadioButtonCheckChanged);
            // 
            // l_peopleList
            // 
            this.l_peopleList.AutoSize = true;
            this.l_peopleList.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_peopleList.Location = new System.Drawing.Point(383, 97);
            this.l_peopleList.Name = "l_peopleList";
            this.l_peopleList.Size = new System.Drawing.Size(80, 27);
            this.l_peopleList.TabIndex = 17;
            this.l_peopleList.Text = "People:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(880, 509);
            this.Controls.Add(this.l_peopleList);
            this.Controls.Add(this.rb_birthCountry);
            this.Controls.Add(this.rb_birthCity);
            this.Controls.Add(this.rb_birthYear);
            this.Controls.Add(this.rb_lastName);
            this.Controls.Add(this.rb_firstName);
            this.Controls.Add(this.b_resetFilter);
            this.Controls.Add(this.b_applyFilter);
            this.Controls.Add(this.l_filter);
            this.Controls.Add(this.l_filterBy);
            this.Controls.Add(this.cb_filter);
            this.Controls.Add(this.b_showCountries);
            this.Controls.Add(this.b_showCities);
            this.Controls.Add(this.b_deletePerson);
            this.Controls.Add(this.b_showFamilyTree);
            this.Controls.Add(this.lb_children);
            this.Controls.Add(this.l_children);
            this.Controls.Add(this.lb_siblings);
            this.Controls.Add(this.l_siblings);
            this.Controls.Add(this.tb_mother);
            this.Controls.Add(this.tb_father);
            this.Controls.Add(this.l_mother);
            this.Controls.Add(this.l_father);
            this.Controls.Add(this.b_editPerson);
            this.Controls.Add(this.lb_peopleList);
            this.Controls.Add(this.b_addPerson);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainWindow";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button b_addPerson;
        private ListBox lb_peopleList;
        private Button b_editPerson;
        private Label l_father;
        private Label l_mother;
        private TextBox tb_father;
        private TextBox tb_mother;
        private Label l_siblings;
        private ListBox lb_siblings;
        private ListBox lb_children;
        private Label l_children;
        private Button b_showFamilyTree;
        private Button b_deletePerson;
        private Button b_showCities;
        private Button b_showCountries;
        private ComboBox cb_filter;
        private Label l_filterBy;
        private Label l_filter;
        private Button b_applyFilter;
        private Button b_resetFilter;
        private RadioButton rb_firstName;
        private RadioButton rb_lastName;
        private RadioButton rb_birthYear;
        private RadioButton rb_birthCity;
        private RadioButton rb_birthCountry;
        private Label l_peopleList;
    }
}