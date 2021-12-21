// -----------------------------------------------------------------------------------------------
//  ShowCityInfo.Designer.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Forms
{   
    partial class CityInfo
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
            this.l_selectCity = new System.Windows.Forms.Label();
            this.cb_cities = new System.Windows.Forms.ComboBox();
            this.b_select = new System.Windows.Forms.Button();
            this.lb_born = new System.Windows.Forms.ListBox();
            this.lb_dead = new System.Windows.Forms.ListBox();
            this.l_peopleBorn = new System.Windows.Forms.Label();
            this.l_peopleDead = new System.Windows.Forms.Label();
            this.b_addRemoveCity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_selectCity
            // 
            this.l_selectCity.AutoSize = true;
            this.l_selectCity.Location = new System.Drawing.Point(11, 15);
            this.l_selectCity.Name = "l_selectCity";
            this.l_selectCity.Size = new System.Drawing.Size(101, 24);
            this.l_selectCity.TabIndex = 0;
            this.l_selectCity.Text = "Select City:";
            // 
            // cb_cities
            // 
            this.cb_cities.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_cities.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_cities.FormattingEnabled = true;
            this.cb_cities.Location = new System.Drawing.Point(118, 12);
            this.cb_cities.Name = "cb_cities";
            this.cb_cities.Size = new System.Drawing.Size(235, 32);
            this.cb_cities.TabIndex = 1;
            this.cb_cities.SelectedValueChanged += new System.EventHandler(this.Cb_countries_SelectedValueChanged);
            // 
            // b_select
            // 
            this.b_select.AutoSize = true;
            this.b_select.Location = new System.Drawing.Point(359, 10);
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
            this.l_peopleBorn.Size = new System.Drawing.Size(172, 24);
            this.l_peopleBorn.TabIndex = 3;
            this.l_peopleBorn.Text = "People born in city:";
            // 
            // l_peopleDead
            // 
            this.l_peopleDead.AutoSize = true;
            this.l_peopleDead.Location = new System.Drawing.Point(276, 52);
            this.l_peopleDead.Name = "l_peopleDead";
            this.l_peopleDead.Size = new System.Drawing.Size(210, 24);
            this.l_peopleDead.TabIndex = 4;
            this.l_peopleDead.Text = "People who died in city:";
            // 
            // b_addRemoveCity
            // 
            this.b_addRemoveCity.AutoSize = true;
            this.b_addRemoveCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_addRemoveCity.Location = new System.Drawing.Point(349, 305);
            this.b_addRemoveCity.Name = "b_addRemoveCity";
            this.b_addRemoveCity.Size = new System.Drawing.Size(186, 34);
            this.b_addRemoveCity.TabIndex = 7;
            this.b_addRemoveCity.Text = "Add or Remove City";
            this.b_addRemoveCity.UseVisualStyleBackColor = true;
            this.b_addRemoveCity.Click += new System.EventHandler(this.B_addRemoveCity_Click);
            // 
            // CityInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(553, 349);
            this.Controls.Add(this.b_addRemoveCity);
            this.Controls.Add(this.l_peopleDead);
            this.Controls.Add(this.l_peopleBorn);
            this.Controls.Add(this.lb_dead);
            this.Controls.Add(this.lb_born);
            this.Controls.Add(this.b_select);
            this.Controls.Add(this.cb_cities);
            this.Controls.Add(this.l_selectCity);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CityInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "City Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label l_selectCity;
        private ComboBox cb_cities;
        private Button b_select;
        private ListBox lb_born;
        private ListBox lb_dead;
        private Label l_peopleBorn;
        private Label l_peopleDead;
        private Button b_addRemoveCity;
    }
}