// -----------------------------------------------------------------------------------------------
//  FamilyTreeForm.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Forms
{
    using FamilyTreeWF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using static Helpers.PersonHelper;

    public partial class FamilyTreeForm : Form
    {
        private Person person = new();
        private List<Person> children = new();
        private List<Person> siblings = new();
        private List<Person> cousins = new();
        private List<Person> parents = new();
        private List<Person> unclesAndAunts = new();
        private List<Person> grandParents = new();
        private List<Person> familyTree = new();
        public FamilyTreeForm(Person person)
        {
            InitializeComponent();
            this.person = person;
            GetDataForFamilyTree();
            SetUpValues();
            this.Text = "Family tree for " + person.FullNameAndLifeTime;
        }

        private void SetUpValues()
        {
            SetUpPersonData();

            l_person_data.Text = person.FirstName + " " + person.LastName + " details:";
            tb_personName.Text = person.FirstName + " " + person.LastName;

            SetupRelatives();

            familyTree.Insert(0, new Person() { PersonId = -1, });
            cb_selectPerson.DataSource = familyTree;
        }

        private void SetUpPersonData()
        {
            var personData = $@"Born: {person.BirthYear}
{(person.BirthCity == null ? "" : "in " + person.BirthCity.Name)}
{(person.BirthCountry == null ? "" : person.BirthCountry.Name)}
{(person.DeathYear == null || person.DeathYear == 0 ? "" : "Deceased: " + person.DeathYear)}
{ ((person.DeathYear == null || person.DeathYear == 0) && person.DeathCity == null ? "" : "in " + person.DeathCity?.Name)}
{ ((person.DeathYear == null || person.DeathYear == 0) && person.DeathCountry == null ? "" : person.DeathCountry?.Name)}";
            tb_personData.Text = personData;
        }

        private void SetupRelatives()
        {
            SetUpPartner();
            SetUpParents();
            SetUpPaternalUnclesAndAunts();
            SetUpMaternalUnclesAndAunts();
            SetUpChildren();
            SetUpSiblings();
            SetUpGrandParents();
        }

        private void SetUpPartner()
        {
            if (children.Count > 0)
            {
                var partnerId = children[0].FatherId == person.PersonId ? children[0].MotherId ?? 0 : children[0].FatherId ?? 0;
                if (partnerId != 0)
                {
                    var partner = GetPersonById(partnerId);
                    tb_partnerName.Text = partner.FullNameAndLifeTime;
                    familyTree.Add(partner);
                }
            }
        }

        private void SetUpParents()
        {
            tb_father.Text = person.Father != null ? person.Father?.FullNameAndLifeTime : "No data found in database";
            tb_mother.Text = person.Mother != null ? person.Mother?.FullNameAndLifeTime : "No data found in database";
        }

        private void PopulateFamilyTreeList()
        {
            familyTree = new List<Person>();
            familyTree.AddRange(children);
            familyTree.AddRange(siblings);
            familyTree.AddRange(cousins);
            familyTree.AddRange(parents);
            familyTree.AddRange(unclesAndAunts);
            familyTree.AddRange(grandParents);
        }

        private void SetUpMaternalUnclesAndAunts()
        {
            var mUnclesAndAunts = unclesAndAunts.Where(p => p.FatherId == person.Mother?.FatherId || p.MotherId == person.Mother?.MotherId).ToList();
            if (mUnclesAndAunts.Count > 0 && cousins.Count > 0) SetUpMaternalCousins(mUnclesAndAunts);
            else SetNotFound(lb_mCousins);
            if (mUnclesAndAunts.Count > 0) lb_mUncleAunt.DataSource = mUnclesAndAunts;
            else SetNotFound(lb_mUncleAunt);
        }

        private static void SetNotFound(ListBox listBox)
        {
            listBox.DataSource = new List<Person> { new Person { FirstName = "No data found in database" } };
            listBox.DisplayMember = "FirstName";
        }

        private void SetUpMaternalCousins(List<Person> mUnclesAndAunts)
        {
            var mCousins = new List<Person>();
            foreach (var m in mUnclesAndAunts)
            {
                mCousins.AddRange(cousins.Where(c => c.FatherId == m.PersonId || c.MotherId == m.PersonId).ToList());
            }
            if (mCousins.Count > 0) lb_mCousins.DataSource = mCousins;
            else SetNotFound(lb_mCousins);
        }

        private void SetUpPaternalUnclesAndAunts()
        {
            var pUnclesAndAunts = unclesAndAunts.Where(p => p.FatherId == person.Father?.FatherId || p.MotherId == person.Father?.MotherId).ToList();
            if (pUnclesAndAunts.Count > 0 && cousins.Count > 0) SetUpPaternalCousins(pUnclesAndAunts);
            else SetNotFound(lb_pCousins);
            if (pUnclesAndAunts.Count > 0) lb_pUncleAunt.DataSource = pUnclesAndAunts;
            else SetNotFound(lb_pUncleAunt);
        }

        private void SetUpPaternalCousins(List<Person> pUnclesAndAunts)
        {
            var pCousins = new List<Person>();
            foreach (var p in pUnclesAndAunts)
            {
                pCousins.AddRange(cousins.Where(c => c.FatherId == p.PersonId || c.MotherId == p.PersonId).ToList());
            }
            if (pCousins.Count > 0) lb_pCousins.DataSource = pCousins;
            else SetNotFound(lb_pCousins);
        }
        private void SetUpSiblings()
        {
            if (siblings.Count > 0) lb_siblings.DataSource = siblings;
            else SetNotFound(lb_siblings);
        }

        private void SetUpChildren()
        {
            if (children.Count > 0) lb_children.DataSource = children;
            else SetNotFound(lb_children);
        }

        private void SetUpGrandParents()
        {
            tb_pGrandFather.Text = person.Father?.FatherId != null ? grandParents.First(p => p.PersonId == person.Father.FatherId).FullNameAndLifeTime : "No data found in database";
            tb_pGrandMother.Text = person.Father?.MotherId != null ? grandParents.First(p => p.PersonId == person.Father.MotherId).FullNameAndLifeTime : "No data found in database";
            tb_mGrandFather.Text = person.Mother?.FatherId != null ? grandParents.First(p => p.PersonId == person.Mother.FatherId).FullNameAndLifeTime : "No data found in database";
            tb_mGrandMother.Text = person.Mother?.MotherId != null ? grandParents.First(p => p.PersonId == person.Mother.MotherId).FullNameAndLifeTime : "No data found in database";
        }

        private void GetDataForFamilyTree()
        {
            children = GetChildren(person);
            siblings = GetSiblings(person);
            parents = GetParents(person);
            grandParents = GetGrandParents(parents);
            unclesAndAunts = GetUnclesAndAunts(grandParents, person.FatherId, person.MotherId);
            cousins = GetCousins(unclesAndAunts);
            PopulateFamilyTreeList();
        }

        private void FamilyTreeForm_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                using (Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 2))
                {
                    g.DrawLine(pen, 100, 60, 100, 70);//under pgrandfather
                    g.DrawLine(pen, 300, 60, 300, 70);//under pgrandmother
                    g.DrawLine(pen, 100, 70, 360, 70);//horizontal towards father
                    g.DrawLine(pen, 360, 69, 360, 105);//down to father
                    g.DrawLine(pen, 150, 69, 150, 90);//down to pUncleAunt
                    g.DrawLine(pen, 900, 60, 900, 70);//under mgrandmother
                    g.DrawLine(pen, 700, 60, 700, 70);//under mgrandfather
                    g.DrawLine(pen, 630, 70, 900, 70);//horizontal towards mother
                    g.DrawLine(pen, 630, 69, 630, 105);//down to mother
                    g.DrawLine(pen, 830, 69, 830, 90);//down to mUncleAunt
                    g.DrawLine(pen, 630, 135, 630, 145);//down from mother
                    g.DrawLine(pen, 360, 135, 360, 145);//down from father
                    g.DrawLine(pen, 320, 145, 631, 145);//horizontal mother-father
                    g.DrawLine(pen, 495, 145, 495, 180);//down to person
                    g.DrawLine(pen, 320, 145, 320, 260);//down to siblings
                    g.DrawLine(pen, 450, 200, 450, 245);//down from person
                    g.DrawLine(pen, 550, 230, 550, 245);//down from partner
                    g.DrawLine(pen, 449, 245, 551, 245);//horizontal mother-father
                    g.DrawLine(pen, 495, 245, 495, 370);//down to children
                    g.DrawLine(pen, 830, 210, 830, 260);//down to mCousins
                    g.DrawLine(pen, 150, 210, 150, 260);//down to pCousins
                }
            }
        }

        private void ListBox_DoubleClick(object sender, EventArgs e)
        {
            var lb = (ListBox)sender;
            cb_selectPerson.SelectedValue = lb.SelectedValue;
        }

        private void B_go_Click(object sender, EventArgs e)
        {
            if ((int)cb_selectPerson.SelectedValue != -1)
            {
                var personForNewFamilyTree = GetPersonById((int)cb_selectPerson.SelectedValue);
                FamilyTreeForm ftf = new(personForNewFamilyTree);
                ftf.Show();
                this.Close();
            }
        }

        private void Textbox_DoubleClick(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            if (tb.Name != "tb_personData")
            {
                var pers = familyTree.Find(p => p.FullName == tb.Text || p.FullNameAndLifeTime == tb.Text);
                if (pers != null && pers.PersonId != 0) cb_selectPerson.SelectedValue = pers.PersonId;
            }
        }

        private void B_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
