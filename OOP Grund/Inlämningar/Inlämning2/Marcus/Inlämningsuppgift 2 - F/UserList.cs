using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.Text;

namespace Inlämningsuppgift_2___F
{
    static class UserList
    {
        static public BindingList<User> Users = new BindingList<User>();
        static private int _selectedMonth = DateTime.Now.Month;

        static public int selectedMonth
        {
            get { return _selectedMonth; }
            set {
                _selectedMonth = value;

                if (value < 1)
                    _selectedMonth = 12;
                if(value > 12)
                    _selectedMonth = 1;

                }
        }

        static public bool LoadUserList(string file)
        {
            if (File.Exists(file + ".json"))
            {
                StreamReader stream=null;

                try
                {
                    stream = new StreamReader(file + ".json");

                    string json = stream.ReadToEnd();
                    Users = JsonConvert.DeserializeObject<BindingList<User>>(json);
                }
                catch (JsonException jEx)
                {
                    MessageBox.Show(jEx.Message);

                    return false;
                }
                catch (IOException IOEx)
                {
                    MessageBox.Show(IOEx.Message);

                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    return false;
                }
                finally
                {
                    stream.Close();
                }

                return true;
            }
            else
            {
                MessageBox.Show("Couldn't find " + file + ".json");

                return false;
            }
        }

        static public void SaveUserList(ref Stream stream)
        {
            try
            {
                string json = JsonConvert.SerializeObject(Users.ToArray());

                stream.Write(Encoding.UTF8.GetBytes(json));
            }
            catch (JsonException jEx)
            {
                MessageBox.Show(jEx.Message);
            }
            catch (IOException IOEx)
            {
                MessageBox.Show(IOEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                stream.Close();
            }

        }

        static public IEnumerable<User> filterUsers(Func<User, bool> q)
        {
            IEnumerable<User> results = Users.Where(q).ToList();

            return results;
        }

        static public string GetBirthdaysString(int month)
        {
            IEnumerable<User> users = filterUsers(q => q.Birthday.Month == selectedMonth);
            string str = "";

            foreach (var user in users)
            {
                str += user.FirstName + " " + user.LastName + "\t\t\t" + user.Birthday.ToShortDateString() + "\r\n";
            }

            return str;
        }


    }
}
