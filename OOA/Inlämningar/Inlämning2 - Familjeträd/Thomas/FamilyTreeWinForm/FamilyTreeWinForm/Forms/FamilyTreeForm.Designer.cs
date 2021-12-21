// -----------------------------------------------------------------------------------------------
//  FamilyTreeForm.Designer.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Forms
{
    partial class FamilyTreeForm
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
            this.l_pGrandFather = new System.Windows.Forms.Label();
            this.tb_pGrandFather = new System.Windows.Forms.TextBox();
            this.tb_pGrandMother = new System.Windows.Forms.TextBox();
            this.l_pGrandMother = new System.Windows.Forms.Label();
            this.tb_mGrandMother = new System.Windows.Forms.TextBox();
            this.l_mGrandMother = new System.Windows.Forms.Label();
            this.tb_mGrandFather = new System.Windows.Forms.TextBox();
            this.l_mGrandFather = new System.Windows.Forms.Label();
            this.l_mother = new System.Windows.Forms.Label();
            this.tb_father = new System.Windows.Forms.TextBox();
            this.l_father = new System.Windows.Forms.Label();
            this.tb_personData = new System.Windows.Forms.TextBox();
            this.l_person_data = new System.Windows.Forms.Label();
            this.lb_pUncleAunt = new System.Windows.Forms.ListBox();
            this.lb_mUncleAunt = new System.Windows.Forms.ListBox();
            this.lb_siblings = new System.Windows.Forms.ListBox();
            this.lb_mCousins = new System.Windows.Forms.ListBox();
            this.lb_children = new System.Windows.Forms.ListBox();
            this.l_siblings = new System.Windows.Forms.Label();
            this.l_mCousins = new System.Windows.Forms.Label();
            this.l_children = new System.Windows.Forms.Label();
            this.l_mUncleAunt = new System.Windows.Forms.Label();
            this.l_pUncleAunt = new System.Windows.Forms.Label();
            this.l_pCousins = new System.Windows.Forms.Label();
            this.lb_pCousins = new System.Windows.Forms.ListBox();
            this.tb_personName = new System.Windows.Forms.TextBox();
            this.tb_partnerName = new System.Windows.Forms.TextBox();
            this.tb_mother = new System.Windows.Forms.TextBox();
            this.cb_selectPerson = new System.Windows.Forms.ComboBox();
            this.l_selectPerson = new System.Windows.Forms.Label();
            this.b_go = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.l_selectPerson0 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_pGrandFather
            // 
            this.l_pGrandFather.AutoSize = true;
            this.l_pGrandFather.BackColor = System.Drawing.SystemColors.Control;
            this.l_pGrandFather.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_pGrandFather.Location = new System.Drawing.Point(12, 8);
            this.l_pGrandFather.Name = "l_pGrandFather";
            this.l_pGrandFather.Size = new System.Drawing.Size(162, 21);
            this.l_pGrandFather.TabIndex = 0;
            this.l_pGrandFather.Text = "Paternal Grandfather:";
            // 
            // tb_pGrandFather
            // 
            this.tb_pGrandFather.BackColor = System.Drawing.SystemColors.Control;
            this.tb_pGrandFather.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pGrandFather.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_pGrandFather.Location = new System.Drawing.Point(12, 32);
            this.tb_pGrandFather.Name = "tb_pGrandFather";
            this.tb_pGrandFather.ReadOnly = true;
            this.tb_pGrandFather.Size = new System.Drawing.Size(224, 20);
            this.tb_pGrandFather.TabIndex = 1;
            this.tb_pGrandFather.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_pGrandFather.DoubleClick += new System.EventHandler(this.Textbox_DoubleClick);
            // 
            // tb_pGrandMother
            // 
            this.tb_pGrandMother.BackColor = System.Drawing.SystemColors.Control;
            this.tb_pGrandMother.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pGrandMother.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_pGrandMother.Location = new System.Drawing.Point(242, 32);
            this.tb_pGrandMother.Name = "tb_pGrandMother";
            this.tb_pGrandMother.ReadOnly = true;
            this.tb_pGrandMother.Size = new System.Drawing.Size(224, 20);
            this.tb_pGrandMother.TabIndex = 3;
            this.tb_pGrandMother.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_pGrandMother.DoubleClick += new System.EventHandler(this.Textbox_DoubleClick);
            // 
            // l_pGrandMother
            // 
            this.l_pGrandMother.AutoSize = true;
            this.l_pGrandMother.BackColor = System.Drawing.SystemColors.Control;
            this.l_pGrandMother.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_pGrandMother.Location = new System.Drawing.Point(242, 8);
            this.l_pGrandMother.Name = "l_pGrandMother";
            this.l_pGrandMother.Size = new System.Drawing.Size(172, 21);
            this.l_pGrandMother.TabIndex = 2;
            this.l_pGrandMother.Text = "Paternal Grandmother:";
            // 
            // tb_mGrandMother
            // 
            this.tb_mGrandMother.BackColor = System.Drawing.SystemColors.Control;
            this.tb_mGrandMother.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_mGrandMother.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mGrandMother.Location = new System.Drawing.Point(762, 32);
            this.tb_mGrandMother.Name = "tb_mGrandMother";
            this.tb_mGrandMother.ReadOnly = true;
            this.tb_mGrandMother.Size = new System.Drawing.Size(224, 20);
            this.tb_mGrandMother.TabIndex = 7;
            this.tb_mGrandMother.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_mGrandMother.DoubleClick += new System.EventHandler(this.Textbox_DoubleClick);
            // 
            // l_mGrandMother
            // 
            this.l_mGrandMother.AutoSize = true;
            this.l_mGrandMother.BackColor = System.Drawing.SystemColors.Control;
            this.l_mGrandMother.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_mGrandMother.Location = new System.Drawing.Point(762, 8);
            this.l_mGrandMother.Name = "l_mGrandMother";
            this.l_mGrandMother.Size = new System.Drawing.Size(178, 21);
            this.l_mGrandMother.TabIndex = 6;
            this.l_mGrandMother.Text = "Maternal Grandmother:";
            // 
            // tb_mGrandFather
            // 
            this.tb_mGrandFather.BackColor = System.Drawing.SystemColors.Control;
            this.tb_mGrandFather.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_mGrandFather.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mGrandFather.Location = new System.Drawing.Point(532, 32);
            this.tb_mGrandFather.Name = "tb_mGrandFather";
            this.tb_mGrandFather.ReadOnly = true;
            this.tb_mGrandFather.Size = new System.Drawing.Size(224, 20);
            this.tb_mGrandFather.TabIndex = 5;
            this.tb_mGrandFather.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_mGrandFather.DoubleClick += new System.EventHandler(this.Textbox_DoubleClick);
            // 
            // l_mGrandFather
            // 
            this.l_mGrandFather.AutoSize = true;
            this.l_mGrandFather.BackColor = System.Drawing.SystemColors.Control;
            this.l_mGrandFather.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_mGrandFather.Location = new System.Drawing.Point(532, 8);
            this.l_mGrandFather.Name = "l_mGrandFather";
            this.l_mGrandFather.Size = new System.Drawing.Size(168, 21);
            this.l_mGrandFather.TabIndex = 4;
            this.l_mGrandFather.Text = "Maternal Grandfather:";
            // 
            // l_mother
            // 
            this.l_mother.AutoSize = true;
            this.l_mother.BackColor = System.Drawing.SystemColors.Control;
            this.l_mother.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_mother.Location = new System.Drawing.Point(532, 88);
            this.l_mother.Name = "l_mother";
            this.l_mother.Size = new System.Drawing.Size(68, 21);
            this.l_mother.TabIndex = 12;
            this.l_mother.Text = "Mother:";
            // 
            // tb_father
            // 
            this.tb_father.BackColor = System.Drawing.SystemColors.Control;
            this.tb_father.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_father.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_father.Location = new System.Drawing.Point(266, 109);
            this.tb_father.Name = "tb_father";
            this.tb_father.ReadOnly = true;
            this.tb_father.Size = new System.Drawing.Size(224, 17);
            this.tb_father.TabIndex = 11;
            this.tb_father.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_father.DoubleClick += new System.EventHandler(this.Textbox_DoubleClick);
            // 
            // l_father
            // 
            this.l_father.AutoSize = true;
            this.l_father.BackColor = System.Drawing.SystemColors.Control;
            this.l_father.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_father.Location = new System.Drawing.Point(312, 88);
            this.l_father.Name = "l_father";
            this.l_father.Size = new System.Drawing.Size(60, 21);
            this.l_father.TabIndex = 10;
            this.l_father.Text = "Father:";
            // 
            // tb_personData
            // 
            this.tb_personData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_personData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_personData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_personData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_personData.Location = new System.Drawing.Point(518, 273);
            this.tb_personData.Multiline = true;
            this.tb_personData.Name = "tb_personData";
            this.tb_personData.ReadOnly = true;
            this.tb_personData.Size = new System.Drawing.Size(191, 94);
            this.tb_personData.TabIndex = 23;
            // 
            // l_person_data
            // 
            this.l_person_data.AutoSize = true;
            this.l_person_data.BackColor = System.Drawing.SystemColors.Control;
            this.l_person_data.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_person_data.Location = new System.Drawing.Point(518, 249);
            this.l_person_data.Name = "l_person_data";
            this.l_person_data.Size = new System.Drawing.Size(110, 21);
            this.l_person_data.TabIndex = 22;
            this.l_person_data.Text = "Personal data:";
            // 
            // lb_pUncleAunt
            // 
            this.lb_pUncleAunt.BackColor = System.Drawing.SystemColors.Control;
            this.lb_pUncleAunt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_pUncleAunt.DisplayMember = "FullNameAndLifeTime";
            this.lb_pUncleAunt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_pUncleAunt.FormattingEnabled = true;
            this.lb_pUncleAunt.ItemHeight = 19;
            this.lb_pUncleAunt.Location = new System.Drawing.Point(12, 112);
            this.lb_pUncleAunt.Name = "lb_pUncleAunt";
            this.lb_pUncleAunt.Size = new System.Drawing.Size(214, 76);
            this.lb_pUncleAunt.TabIndex = 9;
            this.lb_pUncleAunt.ValueMember = "PersonId";
            this.lb_pUncleAunt.DoubleClick += new System.EventHandler(this.ListBox_DoubleClick);
            // 
            // lb_mUncleAunt
            // 
            this.lb_mUncleAunt.BackColor = System.Drawing.SystemColors.Control;
            this.lb_mUncleAunt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_mUncleAunt.DisplayMember = "FullNameAndLifeTime";
            this.lb_mUncleAunt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_mUncleAunt.FormattingEnabled = true;
            this.lb_mUncleAunt.ItemHeight = 19;
            this.lb_mUncleAunt.Location = new System.Drawing.Point(775, 112);
            this.lb_mUncleAunt.Name = "lb_mUncleAunt";
            this.lb_mUncleAunt.Size = new System.Drawing.Size(214, 76);
            this.lb_mUncleAunt.TabIndex = 15;
            this.lb_mUncleAunt.ValueMember = "PersonId";
            this.lb_mUncleAunt.DoubleClick += new System.EventHandler(this.ListBox_DoubleClick);
            // 
            // lb_siblings
            // 
            this.lb_siblings.BackColor = System.Drawing.SystemColors.Control;
            this.lb_siblings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_siblings.DisplayMember = "FullNameAndLifeTime";
            this.lb_siblings.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_siblings.FormattingEnabled = true;
            this.lb_siblings.ItemHeight = 19;
            this.lb_siblings.Location = new System.Drawing.Point(266, 273);
            this.lb_siblings.Name = "lb_siblings";
            this.lb_siblings.Size = new System.Drawing.Size(214, 76);
            this.lb_siblings.TabIndex = 21;
            this.lb_siblings.ValueMember = "PersonId";
            this.lb_siblings.DoubleClick += new System.EventHandler(this.ListBox_DoubleClick);
            // 
            // lb_mCousins
            // 
            this.lb_mCousins.BackColor = System.Drawing.SystemColors.Control;
            this.lb_mCousins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_mCousins.DisplayMember = "FullNameAndLifeTime";
            this.lb_mCousins.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_mCousins.FormattingEnabled = true;
            this.lb_mCousins.ItemHeight = 19;
            this.lb_mCousins.Location = new System.Drawing.Point(775, 273);
            this.lb_mCousins.Name = "lb_mCousins";
            this.lb_mCousins.Size = new System.Drawing.Size(214, 76);
            this.lb_mCousins.TabIndex = 25;
            this.lb_mCousins.ValueMember = "PersonId";
            this.lb_mCousins.DoubleClick += new System.EventHandler(this.ListBox_DoubleClick);
            // 
            // lb_children
            // 
            this.lb_children.BackColor = System.Drawing.SystemColors.Control;
            this.lb_children.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_children.DisplayMember = "FullNameAndLifeTime";
            this.lb_children.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_children.FormattingEnabled = true;
            this.lb_children.ItemHeight = 19;
            this.lb_children.Location = new System.Drawing.Point(353, 391);
            this.lb_children.Name = "lb_children";
            this.lb_children.Size = new System.Drawing.Size(295, 76);
            this.lb_children.TabIndex = 27;
            this.lb_children.ValueMember = "PersonId";
            this.lb_children.DoubleClick += new System.EventHandler(this.ListBox_DoubleClick);
            // 
            // l_siblings
            // 
            this.l_siblings.AutoSize = true;
            this.l_siblings.BackColor = System.Drawing.SystemColors.Control;
            this.l_siblings.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_siblings.Location = new System.Drawing.Point(266, 249);
            this.l_siblings.Name = "l_siblings";
            this.l_siblings.Size = new System.Drawing.Size(68, 21);
            this.l_siblings.TabIndex = 20;
            this.l_siblings.Text = "Siblings:";
            // 
            // l_mCousins
            // 
            this.l_mCousins.AutoSize = true;
            this.l_mCousins.BackColor = System.Drawing.SystemColors.Control;
            this.l_mCousins.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_mCousins.Location = new System.Drawing.Point(775, 249);
            this.l_mCousins.Name = "l_mCousins";
            this.l_mCousins.Size = new System.Drawing.Size(135, 21);
            this.l_mCousins.TabIndex = 24;
            this.l_mCousins.Text = "Maternal cousins:";
            // 
            // l_children
            // 
            this.l_children.AutoSize = true;
            this.l_children.BackColor = System.Drawing.SystemColors.Control;
            this.l_children.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_children.Location = new System.Drawing.Point(462, 367);
            this.l_children.Name = "l_children";
            this.l_children.Size = new System.Drawing.Size(73, 21);
            this.l_children.TabIndex = 26;
            this.l_children.Text = "Children:";
            // 
            // l_mUncleAunt
            // 
            this.l_mUncleAunt.AutoSize = true;
            this.l_mUncleAunt.BackColor = System.Drawing.SystemColors.Control;
            this.l_mUncleAunt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_mUncleAunt.Location = new System.Drawing.Point(775, 88);
            this.l_mUncleAunt.Name = "l_mUncleAunt";
            this.l_mUncleAunt.Size = new System.Drawing.Size(200, 21);
            this.l_mUncleAunt.TabIndex = 14;
            this.l_mUncleAunt.Text = "Maternal uncles and aunts:";
            // 
            // l_pUncleAunt
            // 
            this.l_pUncleAunt.AutoSize = true;
            this.l_pUncleAunt.BackColor = System.Drawing.SystemColors.Control;
            this.l_pUncleAunt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_pUncleAunt.Location = new System.Drawing.Point(12, 88);
            this.l_pUncleAunt.Name = "l_pUncleAunt";
            this.l_pUncleAunt.Size = new System.Drawing.Size(194, 21);
            this.l_pUncleAunt.TabIndex = 8;
            this.l_pUncleAunt.Text = "Paternal uncles and aunts:";
            // 
            // l_pCousins
            // 
            this.l_pCousins.AutoSize = true;
            this.l_pCousins.BackColor = System.Drawing.SystemColors.Control;
            this.l_pCousins.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_pCousins.Location = new System.Drawing.Point(12, 249);
            this.l_pCousins.Name = "l_pCousins";
            this.l_pCousins.Size = new System.Drawing.Size(129, 21);
            this.l_pCousins.TabIndex = 18;
            this.l_pCousins.Text = "Paternal cousins:";
            // 
            // lb_pCousins
            // 
            this.lb_pCousins.BackColor = System.Drawing.SystemColors.Control;
            this.lb_pCousins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_pCousins.DisplayMember = "FullNameAndLifeTime";
            this.lb_pCousins.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_pCousins.FormattingEnabled = true;
            this.lb_pCousins.ItemHeight = 19;
            this.lb_pCousins.Location = new System.Drawing.Point(12, 273);
            this.lb_pCousins.Name = "lb_pCousins";
            this.lb_pCousins.Size = new System.Drawing.Size(214, 76);
            this.lb_pCousins.TabIndex = 19;
            this.lb_pCousins.ValueMember = "PersonId";
            this.lb_pCousins.DoubleClick += new System.EventHandler(this.ListBox_DoubleClick);
            // 
            // tb_personName
            // 
            this.tb_personName.BackColor = System.Drawing.SystemColors.Control;
            this.tb_personName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_personName.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_personName.Location = new System.Drawing.Point(321, 163);
            this.tb_personName.Name = "tb_personName";
            this.tb_personName.ReadOnly = true;

            this.tb_personName.Size = new System.Drawing.Size(356, 54);
            this.tb_personName.TabIndex = 16;
            this.tb_personName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_partnerName
            // 
            this.tb_partnerName.BackColor = System.Drawing.SystemColors.Control;
            this.tb_partnerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_partnerName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_partnerName.Location = new System.Drawing.Point(453, 212);
            this.tb_partnerName.Name = "tb_partnerName";
            this.tb_partnerName.ReadOnly = true;
            this.tb_partnerName.Size = new System.Drawing.Size(224, 20);
            this.tb_partnerName.TabIndex = 17;
            this.tb_partnerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_partnerName.DoubleClick += new System.EventHandler(this.Textbox_DoubleClick);
            // 
            // tb_mother
            // 
            this.tb_mother.BackColor = System.Drawing.SystemColors.Control;
            this.tb_mother.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_mother.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mother.Location = new System.Drawing.Point(496, 109);
            this.tb_mother.Multiline = true;
            this.tb_mother.Name = "tb_mother";
            this.tb_mother.ReadOnly = true;
            this.tb_mother.Size = new System.Drawing.Size(224, 23);
            this.tb_mother.TabIndex = 13;
            this.tb_mother.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_mother.DoubleClick += new System.EventHandler(this.Textbox_DoubleClick);
            // 
            // cb_selectPerson
            // 
            this.cb_selectPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_selectPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_selectPerson.DisplayMember = "FullName";
            this.cb_selectPerson.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_selectPerson.FormattingEnabled = true;
            this.cb_selectPerson.Location = new System.Drawing.Point(728, 426);
            this.cb_selectPerson.Name = "cb_selectPerson";
            this.cb_selectPerson.Size = new System.Drawing.Size(224, 27);
            this.cb_selectPerson.TabIndex = 29;
            this.cb_selectPerson.ValueMember = "PersonId";
            // 
            // l_selectPerson
            // 
            this.l_selectPerson.AutoSize = true;
            this.l_selectPerson.BackColor = System.Drawing.SystemColors.Control;
            this.l_selectPerson.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_selectPerson.Location = new System.Drawing.Point(728, 401);
            this.l_selectPerson.Name = "l_selectPerson";
            this.l_selectPerson.Size = new System.Drawing.Size(261, 21);
            this.l_selectPerson.TabIndex = 28;
            this.l_selectPerson.Text = "from list to re-center family tree on:";
            // 
            // b_go
            // 
            this.b_go.AutoSize = true;
            this.b_go.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_go.Location = new System.Drawing.Point(959, 425);
            this.b_go.Name = "b_go";
            this.b_go.Size = new System.Drawing.Size(75, 31);
            this.b_go.TabIndex = 30;
            this.b_go.Text = "Go!";
            this.b_go.UseVisualStyleBackColor = true;
            this.b_go.Click += new System.EventHandler(this.B_go_Click);
            // 
            // b_close
            // 
            this.b_close.AutoSize = true;
            this.b_close.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_close.Location = new System.Drawing.Point(959, 465);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(75, 31);
            this.b_close.TabIndex = 31;
            this.b_close.Text = "Close";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.B_close_Click);
            // 
            // l_selectPerson0
            // 
            this.l_selectPerson0.AutoSize = true;
            this.l_selectPerson0.Location = new System.Drawing.Point(728, 380);
            this.l_selectPerson0.Name = "l_selectPerson0";
            this.l_selectPerson0.Size = new System.Drawing.Size(279, 21);
            this.l_selectPerson0.TabIndex = 32;
            this.l_selectPerson0.Text = "Double click a name or select someone";
            // 
            // FamilyTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.b_close;
            this.ClientSize = new System.Drawing.Size(1046, 500);
            this.Controls.Add(this.l_selectPerson0);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.b_go);
            this.Controls.Add(this.l_selectPerson);
            this.Controls.Add(this.cb_selectPerson);
            this.Controls.Add(this.tb_mother);
            this.Controls.Add(this.tb_partnerName);
            this.Controls.Add(this.tb_personName);
            this.Controls.Add(this.l_pCousins);
            this.Controls.Add(this.lb_pCousins);
            this.Controls.Add(this.l_pUncleAunt);
            this.Controls.Add(this.l_mUncleAunt);
            this.Controls.Add(this.l_children);
            this.Controls.Add(this.l_mCousins);
            this.Controls.Add(this.l_siblings);
            this.Controls.Add(this.lb_children);
            this.Controls.Add(this.lb_mCousins);
            this.Controls.Add(this.lb_siblings);
            this.Controls.Add(this.lb_mUncleAunt);
            this.Controls.Add(this.lb_pUncleAunt);
            this.Controls.Add(this.tb_personData);
            this.Controls.Add(this.l_person_data);
            this.Controls.Add(this.l_mother);
            this.Controls.Add(this.tb_father);
            this.Controls.Add(this.l_father);
            this.Controls.Add(this.tb_mGrandMother);
            this.Controls.Add(this.l_mGrandMother);
            this.Controls.Add(this.tb_mGrandFather);
            this.Controls.Add(this.l_mGrandFather);
            this.Controls.Add(this.tb_pGrandMother);
            this.Controls.Add(this.l_pGrandMother);
            this.Controls.Add(this.tb_pGrandFather);
            this.Controls.Add(this.l_pGrandFather);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FamilyTreeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Family Tree";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FamilyTreeForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label l_pGrandFather;
        private TextBox tb_pGrandFather;
        private TextBox tb_pGrandMother;
        private Label l_pGrandMother;
        private TextBox tb_mGrandMother;
        private Label l_mGrandMother;
        private TextBox tb_mGrandFather;
        private Label l_mGrandFather;
        private Label l_mother;
        private TextBox tb_father;
        private Label l_father;
        private TextBox tb_personData;
        private Label l_person_data;
        private ListBox lb_pUncleAunt;
        private ListBox lb_mUncleAunt;
        private ListBox lb_siblings;
        private ListBox lb_mCousins;
        private ListBox lb_children;
        private Label l_siblings;
        private Label l_mCousins;
        private Label l_children;
        private Label l_mUncleAunt;
        private Label l_pUncleAunt;
        private Label l_pCousins;
        private ListBox lb_pCousins;
        private TextBox tb_personName;
        private TextBox tb_partnerName;
        private TextBox tb_mother;
        private ComboBox cb_selectPerson;
        private Label l_selectPerson;
        private Button b_go;
        private Button b_close;
        private Label l_selectPerson0;
    }
}