// -----------------------------------------------------------------------------------------------
//  AddEditPerson.Designer.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Forms
{
    partial class AddEditPersonForm
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
            this.l_firstName = new System.Windows.Forms.Label();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.l_lastName = new System.Windows.Forms.Label();
            this.num_birthYear = new System.Windows.Forms.NumericUpDown();
            this.l_birthYear = new System.Windows.Forms.Label();
            this.cb_birthCity = new System.Windows.Forms.ComboBox();
            this.l_birthCity = new System.Windows.Forms.Label();
            this.l_countryOfBirth = new System.Windows.Forms.Label();
            this.cb_birthCountry = new System.Windows.Forms.ComboBox();
            this.l_deathCountry = new System.Windows.Forms.Label();
            this.l_deathCity = new System.Windows.Forms.Label();
            this.cb_deathCity = new System.Windows.Forms.ComboBox();
            this.l_deathYear = new System.Windows.Forms.Label();
            this.num_deathYear = new System.Windows.Forms.NumericUpDown();
            this.l_father = new System.Windows.Forms.Label();
            this.cb_father = new System.Windows.Forms.ComboBox();
            this.l_mother = new System.Windows.Forms.Label();
            this.cb_mother = new System.Windows.Forms.ComboBox();
            this.b_submit = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_addCity = new System.Windows.Forms.Button();
            this.b_addCountry = new System.Windows.Forms.Button();
            this.cb_deathCountry = new System.Windows.Forms.ComboBox();
            this.check_deceased = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_birthYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_deathYear)).BeginInit();
            this.SuspendLayout();
            // 
            // l_firstName
            // 
            this.l_firstName.AutoSize = true;
            this.l_firstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_firstName.Location = new System.Drawing.Point(52, 15);
            this.l_firstName.Name = "l_firstName";
            this.l_firstName.Size = new System.Drawing.Size(98, 24);
            this.l_firstName.TabIndex = 0;
            this.l_firstName.Text = "First name";
            // 
            // tb_firstName
            // 
            this.tb_firstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_firstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_firstName.Location = new System.Drawing.Point(170, 7);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(269, 32);
            this.tb_firstName.TabIndex = 1;
            // 
            // tb_lastName
            // 
            this.tb_lastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_lastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_lastName.Location = new System.Drawing.Point(170, 45);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(269, 32);
            this.tb_lastName.TabIndex = 3;
            // 
            // l_lastName
            // 
            this.l_lastName.AutoSize = true;
            this.l_lastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_lastName.Location = new System.Drawing.Point(53, 48);
            this.l_lastName.Name = "l_lastName";
            this.l_lastName.Size = new System.Drawing.Size(95, 24);
            this.l_lastName.TabIndex = 2;
            this.l_lastName.Text = "Last name";
            // 
            // num_birthYear
            // 
            this.num_birthYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_birthYear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_birthYear.Location = new System.Drawing.Point(170, 83);
            this.num_birthYear.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.num_birthYear.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.num_birthYear.Name = "num_birthYear";
            this.num_birthYear.Size = new System.Drawing.Size(70, 32);
            this.num_birthYear.TabIndex = 5;
            this.num_birthYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_birthYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // l_birthYear
            // 
            this.l_birthYear.AutoSize = true;
            this.l_birthYear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_birthYear.Location = new System.Drawing.Point(41, 85);
            this.l_birthYear.Name = "l_birthYear";
            this.l_birthYear.Size = new System.Drawing.Size(114, 24);
            this.l_birthYear.TabIndex = 4;
            this.l_birthYear.Text = "Year of birth";
            // 
            // cb_birthCity
            // 
            this.cb_birthCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_birthCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_birthCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_birthCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_birthCity.FormattingEnabled = true;
            this.cb_birthCity.Location = new System.Drawing.Point(170, 121);
            this.cb_birthCity.Name = "cb_birthCity";
            this.cb_birthCity.Size = new System.Drawing.Size(137, 32);
            this.cb_birthCity.TabIndex = 8;
            // 
            // l_birthCity
            // 
            this.l_birthCity.AutoSize = true;
            this.l_birthCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_birthCity.Location = new System.Drawing.Point(44, 124);
            this.l_birthCity.Name = "l_birthCity";
            this.l_birthCity.Size = new System.Drawing.Size(110, 24);
            this.l_birthCity.TabIndex = 7;
            this.l_birthCity.Text = "City of birth";
            // 
            // l_countryOfBirth
            // 
            this.l_countryOfBirth.AutoSize = true;
            this.l_countryOfBirth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_countryOfBirth.Location = new System.Drawing.Point(19, 165);
            this.l_countryOfBirth.Name = "l_countryOfBirth";
            this.l_countryOfBirth.Size = new System.Drawing.Size(145, 24);
            this.l_countryOfBirth.TabIndex = 10;
            this.l_countryOfBirth.Text = "Country of birth";
            // 
            // cb_birthCountry
            // 
            this.cb_birthCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_birthCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_birthCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_birthCountry.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_birthCountry.FormattingEnabled = true;
            this.cb_birthCountry.Location = new System.Drawing.Point(170, 159);
            this.cb_birthCountry.Name = "cb_birthCountry";
            this.cb_birthCountry.Size = new System.Drawing.Size(137, 32);
            this.cb_birthCountry.TabIndex = 11;
            // 
            // l_deathCountry
            // 
            this.l_deathCountry.AutoSize = true;
            this.l_deathCountry.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_deathCountry.Location = new System.Drawing.Point(12, 352);
            this.l_deathCountry.Name = "l_deathCountry";
            this.l_deathCountry.Size = new System.Drawing.Size(153, 24);
            this.l_deathCountry.TabIndex = 21;
            this.l_deathCountry.Text = "Country of death";
            this.l_deathCountry.Visible = false;
            // 
            // l_deathCity
            // 
            this.l_deathCity.AutoSize = true;
            this.l_deathCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_deathCity.Location = new System.Drawing.Point(37, 314);
            this.l_deathCity.Name = "l_deathCity";
            this.l_deathCity.Size = new System.Drawing.Size(118, 24);
            this.l_deathCity.TabIndex = 19;
            this.l_deathCity.Text = "City of death";
            this.l_deathCity.Visible = false;
            // 
            // cb_deathCity
            // 
            this.cb_deathCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_deathCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_deathCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_deathCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_deathCity.FormattingEnabled = true;
            this.cb_deathCity.Location = new System.Drawing.Point(170, 311);
            this.cb_deathCity.Name = "cb_deathCity";
            this.cb_deathCity.Size = new System.Drawing.Size(269, 32);
            this.cb_deathCity.TabIndex = 20;
            this.cb_deathCity.Visible = false;
            // 
            // l_deathYear
            // 
            this.l_deathYear.AutoSize = true;
            this.l_deathYear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_deathYear.Location = new System.Drawing.Point(34, 275);
            this.l_deathYear.Name = "l_deathYear";
            this.l_deathYear.Size = new System.Drawing.Size(122, 24);
            this.l_deathYear.TabIndex = 17;
            this.l_deathYear.Text = "Year of death";
            this.l_deathYear.Visible = false;
            // 
            // num_deathYear
            // 
            this.num_deathYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_deathYear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_deathYear.Location = new System.Drawing.Point(170, 273);
            this.num_deathYear.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.num_deathYear.Name = "num_deathYear";
            this.num_deathYear.Size = new System.Drawing.Size(79, 32);
            this.num_deathYear.TabIndex = 18;
            this.num_deathYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_deathYear.Visible = false;
            // 
            // l_father
            // 
            this.l_father.AutoSize = true;
            this.l_father.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_father.Location = new System.Drawing.Point(79, 200);
            this.l_father.Name = "l_father";
            this.l_father.Size = new System.Drawing.Size(63, 24);
            this.l_father.TabIndex = 13;
            this.l_father.Text = "Father";
            // 
            // cb_father
            // 
            this.cb_father.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_father.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_father.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_father.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_father.FormattingEnabled = true;
            this.cb_father.Location = new System.Drawing.Point(170, 197);
            this.cb_father.Name = "cb_father";
            this.cb_father.Size = new System.Drawing.Size(269, 32);
            this.cb_father.TabIndex = 14;
            // 
            // l_mother
            // 
            this.l_mother.AutoSize = true;
            this.l_mother.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_mother.Location = new System.Drawing.Point(73, 238);
            this.l_mother.Name = "l_mother";
            this.l_mother.Size = new System.Drawing.Size(73, 24);
            this.l_mother.TabIndex = 15;
            this.l_mother.Text = "Mother";
            // 
            // cb_mother
            // 
            this.cb_mother.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_mother.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_mother.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_mother.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_mother.FormattingEnabled = true;
            this.cb_mother.Location = new System.Drawing.Point(170, 235);
            this.cb_mother.Name = "cb_mother";
            this.cb_mother.Size = new System.Drawing.Size(269, 32);
            this.cb_mother.TabIndex = 16;
            // 
            // b_submit
            // 
            this.b_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_submit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_submit.Location = new System.Drawing.Point(160, 382);
            this.b_submit.Name = "b_submit";
            this.b_submit.Size = new System.Drawing.Size(89, 34);
            this.b_submit.TabIndex = 23;
            this.b_submit.Text = "Submit";
            this.b_submit.UseVisualStyleBackColor = true;
            this.b_submit.Click += new System.EventHandler(this.B_submit_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_cancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_cancel.Location = new System.Drawing.Point(255, 382);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(89, 34);
            this.b_cancel.TabIndex = 24;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.B_cancel_Click);
            // 
            // b_addCity
            // 
            this.b_addCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_addCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_addCity.Location = new System.Drawing.Point(313, 121);
            this.b_addCity.Name = "b_addCity";
            this.b_addCity.Size = new System.Drawing.Size(126, 34);
            this.b_addCity.TabIndex = 9;
            this.b_addCity.Text = "Add City";
            this.b_addCity.UseVisualStyleBackColor = true;
            this.b_addCity.Click += new System.EventHandler(this.B_addCity_Click);
            // 
            // b_addCountry
            // 
            this.b_addCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_addCountry.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_addCountry.Location = new System.Drawing.Point(313, 157);
            this.b_addCountry.Name = "b_addCountry";
            this.b_addCountry.Size = new System.Drawing.Size(126, 34);
            this.b_addCountry.TabIndex = 12;
            this.b_addCountry.Text = "Add Country";
            this.b_addCountry.UseVisualStyleBackColor = true;
            this.b_addCountry.Click += new System.EventHandler(this.B_addCountry_Click);
            // 
            // cb_deathCountry
            // 
            this.cb_deathCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_deathCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_deathCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_deathCountry.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_deathCountry.FormattingEnabled = true;
            this.cb_deathCountry.Location = new System.Drawing.Point(170, 349);
            this.cb_deathCountry.Name = "cb_deathCountry";
            this.cb_deathCountry.Size = new System.Drawing.Size(269, 32);
            this.cb_deathCountry.TabIndex = 22;
            this.cb_deathCountry.Visible = false;
            // 
            // check_deceased
            // 
            this.check_deceased.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.check_deceased.AutoSize = true;
            this.check_deceased.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check_deceased.Location = new System.Drawing.Point(246, 84);
            this.check_deceased.Name = "check_deceased";
            this.check_deceased.Size = new System.Drawing.Size(111, 28);
            this.check_deceased.TabIndex = 6;
            this.check_deceased.Text = "Deceased";
            this.check_deceased.UseVisualStyleBackColor = true;
            this.check_deceased.CheckedChanged += new System.EventHandler(this.Check_deceased_CheckedChanged);
            // 
            // AddEditPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.b_cancel;
            this.ClientSize = new System.Drawing.Size(456, 430);
            this.Controls.Add(this.l_firstName);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.check_deceased);
            this.Controls.Add(this.cb_deathCountry);
            this.Controls.Add(this.b_addCountry);
            this.Controls.Add(this.b_addCity);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_submit);
            this.Controls.Add(this.l_mother);
            this.Controls.Add(this.cb_mother);
            this.Controls.Add(this.l_father);
            this.Controls.Add(this.cb_father);
            this.Controls.Add(this.l_deathCountry);
            this.Controls.Add(this.l_deathCity);
            this.Controls.Add(this.cb_deathCity);
            this.Controls.Add(this.l_deathYear);
            this.Controls.Add(this.num_deathYear);
            this.Controls.Add(this.l_countryOfBirth);
            this.Controls.Add(this.cb_birthCountry);
            this.Controls.Add(this.l_birthCity);
            this.Controls.Add(this.cb_birthCity);
            this.Controls.Add(this.l_birthYear);
            this.Controls.Add(this.num_birthYear);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.l_lastName);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "AddEditPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add / Edit Person";
            this.Load += new System.EventHandler(this.AddEditPersonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_birthYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_deathYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label l_firstName;
        private TextBox tb_firstName;
        private TextBox tb_lastName;
        private Label l_lastName;
        private NumericUpDown num_birthYear;
        private Label l_birthYear;
        private ComboBox cb_birthCity;
        private Label l_birthCity;
        private Label l_countryOfBirth;
        private ComboBox cb_birthCountry;
        private Label l_deathCountry;
        private Label l_deathCity;
        private ComboBox cb_deathCity;
        private Label l_deathYear;
        private NumericUpDown num_deathYear;
        private Label l_father;
        private ComboBox cb_father;
        private Label l_mother;
        private ComboBox cb_mother;
        private Button b_submit;
        private Button b_cancel;
        private Button b_addCity;
        private Button b_addCountry;
        private ComboBox cb_deathCountry;
        private CheckBox check_deceased;
    }
}