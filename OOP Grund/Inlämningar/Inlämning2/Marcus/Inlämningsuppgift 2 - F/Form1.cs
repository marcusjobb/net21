using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift_2___F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserList.LoadUserList("Users");

            dgUsers.DataSource = UserList.Users;
            tbUsersByMonth.Text = UserList.GetBirthdaysString(UserList.selectedMonth);
            lblMonth.Text = Extensions.ToString(UserList.selectedMonth);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Stream stream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "json files (*.json)|*.json";
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    UserList.SaveUserList(ref stream);
                }
            }

            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string filePath;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory(); ;
                openFileDialog.Filter = "json files (*.json)|*.json";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    filePath=filePath.Substring(0, filePath.LastIndexOf("."));

                    if(UserList.LoadUserList(filePath))
                    {
                        dgUsers.DataSource = UserList.Users;
                    }
                    else
                    {
                        UserList.Users = new BindingList<User>();
                    }
                    
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgUsers.Update();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserList.Users.Add(new User());
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            UserList.Users.RemoveAt(dgUsers.SelectedRows[0].Index);
        }

        private void dgUsers_SelectionChanged(object sender, EventArgs e)
        {
            int currentUser = dgUsers.CurrentRow.Index;
            int age = UserList.Users[currentUser].CalculateAge();

            lblName.Text = UserList.Users[currentUser].FirstName + " " + UserList.Users[currentUser].LastName + " is: ";

            if(age!=1)
            {
                lblYearsOld.Text = age.ToString() + " years old";
            }
            else
            {
                lblYearsOld.Text = age.ToString() + " year old";
            }

        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            UserList.selectedMonth++;
            tbUsersByMonth.Text = UserList.GetBirthdaysString(UserList.selectedMonth);
            lblMonth.Text = Extensions.ToString(UserList.selectedMonth);
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            UserList.selectedMonth--;
            tbUsersByMonth.Text = UserList.GetBirthdaysString(UserList.selectedMonth);
            lblMonth.Text = Extensions.ToString(UserList.selectedMonth);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbBlockedUsers.Text = "";
            tbGhostedUsers.Text = "";
            tbUsersByMonth.Text = UserList.GetBirthdaysString(UserList.selectedMonth);

            foreach (var user in UserList.Users)
            {
                if(user.IsBlocked)
                    tbBlockedUsers.Text += user.FirstName + " " + user.LastName + "\r\n";

                if(user.IsGhosted)
                    tbGhostedUsers.Text += user.FirstName + " " + user.LastName + "\r\n";
            }       
        }
    }
}
