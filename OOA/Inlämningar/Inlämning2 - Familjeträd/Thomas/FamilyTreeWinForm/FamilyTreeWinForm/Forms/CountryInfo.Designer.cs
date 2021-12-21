// -----------------------------------------------------------------------------------------------
//  ShowCityInfo.Designer.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Forms
{   
    partial class CountryInfo
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
            this.l_selectCountry = new System.Windows.Forms.Label();
            this.cb_countries = new System.Windows.Forms.ComboBox();
            this.b_select = new System.Windows.Forms.Button();
            this.lb_born = new System.Windows.Forms.ListBox();
            this.lb_dead = new System.Windows.Forms.ListBox();
            this.l_peopleBorn = new System.Windows.Forms.Label();
            this.l_peopleDead = new System.Windows.Forms.Label();
            this.b_addRemoveCountry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_selectCountry
            // 
            this.l_selectCountry.AutoSize = true;
            this.l_selectCountry.Location = new System.Drawing.Point(11, 15);
            this.l_selectCountry.Name = "l_selectCountry";
            this.l_selectCountry.Size = new System.Drawing.Size(136, 24);
            this.l_selectCountry.TabIndex = 0;
            this.l_selectCountry.Text = "Select Country:";
            // 
            // cb_countries
            // 
            this.cb_countries.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_countries.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_countries.FormattingEnabled = true;
            this.cb_countries.Location = new System.Drawing.Point(153, 12);
            this.cb_countries.Name = "cb_countries";
            this.cb_countries.Size = new System.Drawing.Size(210, 32);
            this.cb_countries.TabIndex = 1;
            this.cb_countries.SelectedValueChanged += new System.EventHandler(this.Cb_countries_SelectedValueChanged);
            // 
            // b_select
            // 
            this.b_select.AutoSize = true;
            this.b_select.Location = new System.Drawing.Point(369, 10);
            this.b_select.Name = "b_select";
            this.b_select.Size = new System.Drawing.Size(75, 34);
            this.b_select.TabIndex = 2;
            this.b_select.Text = "Select";
            this.b_select.UseVisualStyleBackColor = true;
            // 
            // lb_born
            // 
            this.lb_born.DisplayMember = "FullNameAndLifeTime";
            this.lb_born.FormattingEnabled = true;
            this.lb_born.ItemHeight = 24;
            this.lb_born.Location = new System.Drawing.Point(11, 79);
            this.lb_born.Name = "lb_born";
            this.lb_born.Size = new System.Drawing.Size(259, 220);
            this.lb_born.TabIndex = 5;
            // 
            // lb_dead
            // 
            this.lb_dead.DisplayMember = "FullNameAndLifeTime";
            this.lb_dead.FormattingEnabled = true;
            this.lb_dead.ItemHeight = 24;
            this.lb_dead.Location = new System.Drawing.Point(276, 79);
            this.lb_dead.Name = "lb_dead";
            this.lb_dead.Size = new System.Drawing.Size(259, 220);
            this.lb_dead.TabIndex = 6;
            // 
            // l_peopleBorn
            // 
            this.l_peopleBorn.AutoSize = true;
            this.l_peopleBorn.Location = new System.Drawing.Point(12, 52);
            this.l_peopleBorn.Name = "l_peopleBorn";
            this.l_peopleBorn.Size = new System.Drawing.Size(207, 24);
            this.l_peopleBorn.TabIndex = 3;
            this.l_peopleBorn.Text = "People born in country:";
            // 
            // l_peopleDead
            // 
            this.l_peopleDead.AutoSize = true;
            this.l_peopleDead.Location = new System.Drawing.Point(276, 52);
            this.l_peopleDead.Name = "l_peopleDead";
            this.l_peopleDead.Size = new System.Drawing.Size(245, 24);
            this.l_peopleDead.TabIndex = 4;
            this.l_peopleDead.Text = "People who died in country:";
            // 
            // b_addRemoveCountry
            // 
            this.b_addRemoveCountry.AutoSize = true;
            this.b_addRemoveCountry.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_addRemoveCountry.Location = new System.Drawing.Point(314, 305);
            this.b_addRemoveCountry.Name = "b_addRemoveCountry";
            this.b_addRemoveCountry.Size = new System.Drawing.Size(221, 34);
            this.b_addRemoveCountry.TabIndex = 7;
            this.b_addRemoveCountry.Text = "Add or Remove Country";
            this.b_addRemoveCountry.UseVisualStyleBackColor = true;
            this.b_addRemoveCountry.Click += new System.EventHandler(this.B_addRemoveCountry_Click);
            // 
            // CountryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(551, 346);
            this.Controls.Add(this.b_addRemoveCountry);
            this.Controls.Add(this.l_peopleDead);
            this.Controls.Add(this.l_peopleBorn);
            this.Controls.Add(this.lb_dead);
            this.Controls.Add(this.lb_born);
            this.Controls.Add(this.b_select);
            this.Controls.Add(this.cb_countries);
            this.Controls.Add(this.l_selectCountry);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CountryInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Country Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label l_selectCountry;
        private ComboBox cb_countries;
        private Button b_select;
        private ListBox lb_born;
        private ListBox lb_dead;
        private Label l_peopleBorn;
        private Label l_peopleDead;
        private Button b_addRemoveCountry;
    }
}