using System;
using System.Collections.Generic;
using System.Linq;
using SQL_Server_DataBase._nenu;
using SQL_Server_DataBase._DBHelper;
using System.Data;
using System.Data.SqlClient;

namespace SQL_Server_DataBase._action
{
    class action
    {
        public void start()
        {
            int numStartMenu = 0;
            bool flag = true;
            menu.startMenu();
            while (flag)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out numStartMenu))
                {
                    if (numStartMenu > 0 && numStartMenu < 3) break;
                    else Console.WriteLine("Invalid value, try again");
                }
                else Console.WriteLine("Invalid value, try again");
            }

            switch (numStartMenu)
            {
                case 1:
                    Console.Write("Enter your name: ");
                    string input1 = Console.ReadLine();

                    menu.mainMenuSelection();
                    sitting();
                    break;

                default:    //2) ---> exit
                    Environment.Exit(0);
                    break;

            }
        }

        public void sitting()
        {
            int numMainMenu = 0;
            bool flag = true;

            while (flag)
            {
                Console.Write("Your choises is << 1  -  5 >>: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out numMainMenu))
                {
                    if (numMainMenu > 0 && numMainMenu < 6) break;
                }
                else Console.WriteLine("Invalid value, try again");
            }

            switch (numMainMenu)
            {
                case 1:
                    Console.WriteLine("Enter To Continu");
                    showDetails();
                    break;

                case 2:
                    Console.WriteLine("Enter To Continu");
                    EditPerson();
                    break;

                case 3:
                    Console.WriteLine("Enter To Continu");
                    AddPerson();
                    break;

                case 4:
                    Console.WriteLine("Enter To Continu");
                    DeletePerson();
                    break;

                default:    //5) ---> exit
                    Environment.Exit(0);
                    break;
            }
        }

        public void showDetails()
        {
            int numShowDetails = 0;
            bool flag = true;
            menu.showDetailsMenu();
            while (flag)
            {
                Console.Write("Your choises is << 1  -  11 >>: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out numShowDetails))
                {
                    if (numShowDetails > 0 && numShowDetails < 12) break;
                }
                else Console.WriteLine("Invalid value, try again");
            }

            switch (numShowDetails)
            {
                case 1:
                    var query1 = "Select id, first_name,  country from PERSON_DATA ";
                    var dt1 = DBHelper.ExecSelect(query1);
                    DBHelper.rowDetail(dt1);
                    Console.WriteLine("\n");
                    Console.Write($"There are ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write($"{dt1.Rows.Count}");
                    Console.ResetColor();
                    Console.WriteLine(" Person on The List.");
                    Console.WriteLine();
                    Console.WriteLine("Perss Enter to Exit");
                    Console.Read();
                    menu.mainMenuSelection();
                    sitting();
                    break;

                case 2:
                    char ch = ' ';
                    while (flag)
                    {
                        Console.Write("Select a letter: ");
                        string input = Console.ReadLine();
                        if (char.TryParse(input, out ch))
                        {
                            if (ch == 'a' || ch == 'A' || ch == 'b' || ch == 'B' || ch == 'c' || ch == 'C' || ch == 'd' || ch == 'D'
                                || ch == 'e' || ch == 'E' || ch == 'f' || ch == 'F' || ch == 'g' || ch == 'G' || ch == 'h' || ch == 'H'
                                || ch == 'i' || ch == 'I' || ch == 'j' || ch == 'J' || ch == 'k' || ch == 'K' || ch == 'l' || ch == 'L'
                                || ch == 'm' || ch == 'M' || ch == 'n' || ch == 'N' || ch == 'o' || ch == 'O' || ch == 'p' || ch == 'P'
                                || ch == 'q' || ch == 'Q' || ch == 'r' || ch == 'R' || ch == 's' || ch == 'S' || ch == 't' || ch == 'T'
                                || ch == 'u' || ch == 'U' || ch == 'w' || ch == 'W' || ch == 'x' || ch == 'X' || ch == 'y' || ch == 'Y'
                                || ch == 'z' || ch == 'Z') break;
                        }
                        else Console.WriteLine("Invalid value, try again");
                    }
                    var query2 = "Select  first_name from PERSON_DATA WHERE first_name LIKE '" + ch + "%' ";
                    var dt2 = DBHelper.ExecSelect(query2);
                    DBHelper.rowDetail(dt2);
                    Console.WriteLine("\n");
                    Console.Write($"There are ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write($"{dt2.Rows.Count}");
                    Console.ResetColor();
                    Console.Write(" Persons Whose First Name Begins With a Specific Letter ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write($"{ch}");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Perss Enter to Exit");
                    Console.Read();
                    menu.mainMenuSelection();
                    sitting();
                    break;

                case 3:
                    char ch2 = ' ';
                    while (flag)
                    {
                        Console.Write("Select a letter: ");
                        string input = Console.ReadLine();
                        if (char.TryParse(input, out ch2))
                        {
                            if (ch2 == 'a' || ch2 == 'A' || ch2 == 'b' || ch2 == 'B' || ch2 == 'c' || ch2 == 'C' || ch2 == 'd' || ch2 == 'D'
                                || ch2 == 'e' || ch2 == 'E' || ch2 == 'f' || ch2 == 'F' || ch2 == 'g' || ch2 == 'G' || ch2 == 'h' || ch2 == 'H'
                                || ch2 == 'i' || ch2 == 'I' || ch2 == 'j' || ch2 == 'J' || ch2 == 'k' || ch2 == 'K' || ch2 == 'l' || ch2 == 'L'
                                || ch2 == 'm' || ch2 == 'M' || ch2 == 'n' || ch2 == 'N' || ch2 == 'o' || ch2 == 'O' || ch2 == 'p' || ch2 == 'P'
                                || ch2 == 'q' || ch2 == 'Q' || ch2 == 'r' || ch2 == 'R' || ch2 == 's' || ch2 == 'S' || ch2 == 't' || ch2 == 'T'
                                || ch2 == 'u' || ch2 == 'U' || ch2 == 'w' || ch2 == 'W' || ch2 == 'x' || ch2 == 'X' || ch2 == 'y' || ch2 == 'Y'
                                || ch2 == 'z' || ch2 == 'Z') break;
                        }
                        else Console.WriteLine("Invalid value, try again");
                    }
                    var query3 = "Select  first_name, last_name from PERSON_DATA WHERE last_name LIKE '" + ch2 + "%'";
                    var dt3 = DBHelper.ExecSelect(query3);
                    DBHelper.rowDetail(dt3);
                    Console.WriteLine("\n");
                    Console.Write($"There are ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write($"{dt3.Rows.Count}");
                    Console.ResetColor();
                    Console.Write(" Persons Whose Last Name Begins With a Specific Letter ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write($"{ch2}");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Perss Enter to Exit");
                    Console.Read();
                    menu.mainMenuSelection();
                    sitting();
                    break;

                case 4:
                    while (flag)
                    {
                        Console.Write("Write a gender: ");
                        string input = Console.ReadLine();
                        if (input == "male" || input == "Male" || input == "female" || input == "Female")
                        {
                            var query4 = "Select  first_name, gender from PERSON_DATA WHERE gender = '" + input + "'";
                            var dt4 = DBHelper.ExecSelect(query4);
                            DBHelper.rowDetail(dt4);
                            Console.WriteLine("\n");
                            Console.Write($"There are ");
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.Write($"{dt4.Rows.Count}");
                            Console.ResetColor();
                            Console.Write(" Persons Whose have the Gender ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write($"{input}");
                            Console.ResetColor();
                            Console.WriteLine();
                            break;
                        }
                        else Console.WriteLine("Invalid value, try again");

                    }

                    Console.WriteLine("Perss Enter to Exit");
                    Console.Read();
                    menu.mainMenuSelection();
                    sitting();
                    break;

                case 5:
                    var query5 = "Select Distinct country from PERSON_DATA";
                    var dt5 = DBHelper.ExecSelect(query5);
                    DBHelper.rowDetail(dt5);
                    Console.WriteLine("\n");
                    Console.Write($"There are ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write($"{dt5.Rows.Count}");
                    Console.ResetColor();
                    Console.WriteLine(" Countries on The List.");
                    Console.WriteLine();
                    Console.WriteLine("Perss Enter to Exit");
                    Console.Read();
                    menu.mainMenuSelection();
                    sitting();
                    break;

                case 6:
                    var query6 = "Select Distinct  username, password from PERSON_DATA ";
                    var dt6 = DBHelper.ExecSelect(query6);
                    //var dt6 = helpMethod.GetDataTable(sql6, "@param", "@param");
                    DBHelper.rowDetail(dt6);
                    Console.WriteLine("\n");
                    Console.Write($"There are ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write($"{dt6.Rows.Count}");
                    Console.ResetColor();
                    Console.WriteLine(" Persons' UserName and Password.");
                    Console.WriteLine();
                    Console.WriteLine("That is mean All Usernames and Passwords Are unique");
                    Console.WriteLine();
                    Console.WriteLine("Perss Enter to Exit");
                    Console.Read();
                    menu.mainMenuSelection();
                    sitting();
                    break;

                case 7:
                    var query7 = "Select first_name, country from PERSON_DATA Where country in ('Sweden', 'Norway', 'Denmark')";
                    var dt7 = DBHelper.ExecSelect(query7);
                    DBHelper.rowDetail(dt7);
                    Console.WriteLine("\n");
                    Console.Write($"There are ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write($"{dt7.Rows.Count}");
                    Console.ResetColor();
                    Console.WriteLine(" User from Scandinavia countries.");
                    Console.WriteLine();
                    Console.WriteLine("Perss Enter to Exit");
                    Console.Read();
                    menu.mainMenuSelection();
                    sitting();
                    break;

                case 8:
                    var query8 = "Select Top 1 country from PERSON_DATA group by country order by count(*) DESC";
                    var dt8 = DBHelper.ExecSelect(query8);
                    DBHelper.rowDetail(dt8);
                    Console.WriteLine("\n");
                    Console.Write($"There are ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write($"{dt8.Rows.Count}");
                    Console.ResetColor();
                    Console.WriteLine(" the most common country");
                    Console.WriteLine();
                    Console.WriteLine("Perss Enter to Exit");
                    Console.Read();
                    menu.mainMenuSelection();
                    sitting();
                    break;

                case 9:
                    var query9 = "Select Top 10 first_name, last_name from PERSON_DATA Where last_name LIKE '" + "l" + "%' ";
                    var dt9 = DBHelper.ExecSelect(query9);
                    DBHelper.rowDetail(dt9);
                    Console.WriteLine("\n");
                    Console.Write($"There are ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write($"{dt9.Rows.Count}");
                    Console.ResetColor();
                    Console.WriteLine(" User whose last name starts with the letter L");
                    Console.WriteLine();
                    Console.WriteLine("Perss Enter to Exit");
                    Console.Read();
                    menu.mainMenuSelection();
                    sitting();
                    break;

                case 10:
                    var query10 = "Select first_name, last_name from PERSON_DATA where left(first_name, 1) = left(last_name, 1)";
                    var dt10 = DBHelper.ExecSelect(query10);
                    DBHelper.rowDetail(dt10);
                    Console.WriteLine("\n");
                    Console.Write($"There are ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write($"{dt10.Rows.Count}");
                    Console.ResetColor();
                    Console.WriteLine(" User whose first and last names have the same initials");
                    Console.WriteLine();
                    Console.WriteLine("Perss Enter to Exit");
                    Console.Read();
                    menu.mainMenuSelection();
                    sitting();
                    break;

                default:    //11) ---> exit
                    Environment.Exit(0);
                    break;
            }
        }

        public void EditPerson()
        {
            int n = 0;
            int age = 0;
            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine(" ....    EDITTING AN EXISTED PERSON   .... ");
                Console.WriteLine(" ...        Please Write The ID :      ... ");
                Console.WriteLine("___________________________________________");
                string input = Console.ReadLine();
                if (int.TryParse(input, out n))
                {
                    if (n > 0) break;
                }
            }

            //updat The firs name
            string query1 = $"Select first_name From PERSON_DATA Where id = {n}";
            DataTable dt1 = DBHelper.ExecSelect(query1);
                      
            foreach (DataRow row in dt1.Rows)
            {
                for (var i = 0; i < dt1.Columns.Count; i++)
                {
                    Console.Write($"First Name is: {row[i]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press y if you want to change it, or press Enter to countinu");
            string str1 = Console.ReadLine();
            if (str1 == "y" || str1 == "Y" || str1 == "yes" || str1 == "Yes")
            {
                Console.Write("New First Name = ");
                string input = Console.ReadLine();
                string query = $"update PERSON_DATA set first_name = '{input}' where id = {n}";
                DBHelper.ExecuteNonQuery(query);
            }

            //updat The Last Name
            string query2 = $"Select last_name From PERSON_DATA Where id = {n}";
            DataTable dt2 = DBHelper.ExecSelect(query2);

            foreach (DataRow row in dt2.Rows)
            {
                for (var i = 0; i < dt2.Columns.Count; i++)
                {
                    Console.Write($"Last Name is: {row[i]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press y if you want to change it, or press Enter to countinu");
            string str2 = Console.ReadLine();
            if (str2 == "y" || str2 == "Y" || str2 == "yes" || str2 == "Yes")
            {
                Console.Write("New Last Name = ");
                string input = Console.ReadLine();
                string query = $"update PERSON_DATA set last_name = '{input}' where id = {n}";
                DBHelper.ExecuteNonQuery(query);
            }

            //updat The E-Mail
            string query3 = $"Select email From PERSON_DATA Where id = {n}";
            DataTable dt3 = DBHelper.ExecSelect(query3);

            foreach (DataRow row in dt3.Rows)
            {
                for (var i = 0; i < dt3.Columns.Count; i++)
                {
                    Console.Write($"E-Mail is: {row[i]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press y if you want to change it, or press Enter to countinu");
            string str3 = Console.ReadLine();
            if (str3 == "y" || str3 == "Y" || str3 == "yes" || str3 == "Yes")
            {
                Console.Write("New E-Mail = ");
                string input = Console.ReadLine();
                string query = $"update PERSON_DATA set email = '{input}' where id = {n}";
                DBHelper.ExecuteNonQuery(query);
            }

            //updat The User Name
            string query4 = $"Select userName From PERSON_DATA Where id = {n}";
            DataTable dt4 = DBHelper.ExecSelect(query4);

            foreach (DataRow row in dt4.Rows)
            {
                for (var i = 0; i < dt4.Columns.Count; i++)
                {
                    Console.Write($"User Name is: {row[i]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press y if you want to change it, or press Enter to countinu");
            string str4 = Console.ReadLine();
            if (str4 == "y" || str4 == "Y" || str4 == "yes" || str4 == "Yes")
            {
                Console.Write("New User Name = ");
                string input = Console.ReadLine();
                string query = $"update PERSON_DATA set userName = '{input}' where id = {n}";
                DBHelper.ExecuteNonQuery(query);
            }

            //updat The PassWord
            string query5 = $"Select password From PERSON_DATA Where id = {n}";
            DataTable dt5 = DBHelper.ExecSelect(query5);

            foreach (DataRow row in dt5.Rows)
            {
                for (var i = 0; i < dt5.Columns.Count; i++)
                {
                    Console.Write($"PassWord is: {row[i]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press y if you want to change it, or press Enter to countinu");
            string str5 = Console.ReadLine();
            if (str5 == "y" || str5 == "Y" || str5 == "yes" || str5 == "Yes")
            {
                Console.Write("New PassWord = ");
                string input = Console.ReadLine();
                string query = $"update PERSON_DATA set password = '{input}' where id = {n}";
                DBHelper.ExecuteNonQuery(query);
            }

            //updat The Age
            string query6 = $"Select Age From PERSON_DATA Where id = {n}";
            DataTable dt6 = DBHelper.ExecSelect(query6);

            foreach (DataRow row in dt6.Rows)
            {
                for (var i = 0; i < dt6.Columns.Count; i++)
                {
                    Console.Write($"Age is: {row[i]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press y if you want to change it, or press Enter to countinu");
            string str6 = Console.ReadLine();
            if (str6 == "y" || str6 == "Y" || str6 == "yes" || str6 == "Yes")
            {
                while (true)
                {
                    Console.Write("New Age is = ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out age))
                    {
                        if (age > 0 && age < 100) break;
                    }
                }                             
                string query = $"update PERSON_DATA set Age = {age} where id = {n}";
                DBHelper.ExecuteNonQuery(query);
            }

            //updat The Gender
            string query7 = $"Select gender From PERSON_DATA Where id = {n}";
            DataTable dt7 = DBHelper.ExecSelect(query7);

            foreach (DataRow row in dt7.Rows)
            {
                for (var i = 0; i < dt7.Columns.Count; i++)
                {
                    Console.Write($"Gender is: {row[i]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press y if you want to change it, or press Enter to countinu");
            string str7 = Console.ReadLine();
            if (str7 == "y" || str7 == "Y" || str7 == "yes" || str7 == "Yes")
            {
                Console.Write("New Gender = ");
                string input = Console.ReadLine();
                string query = $"update PERSON_DATA set gender = '{input}' where id = {n}";
                DBHelper.ExecuteNonQuery(query);
            }

            //updat The Country
            string query8 = $"Select country From PERSON_DATA Where id = {n}";
            DataTable dt8 = DBHelper.ExecSelect(query8);

            foreach (DataRow row in dt8.Rows)
            {
                for (var i = 0; i < dt8.Columns.Count; i++)
                {
                    Console.Write($"Country is: {row[i]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press y if you want to change it, or press Enter to countinu");
            string str8 = Console.ReadLine();
            if (str8 == "y" || str8 == "Y" || str8 == "yes" || str8 == "Yes")
            {
                Console.Write("New Country = ");
                string input = Console.ReadLine();
                string query = $"update PERSON_DATA set country = '{input}' where id = {n}";
                DBHelper.ExecuteNonQuery(query);
            }




            string finalQuery = $"Select * From PERSON_DATA Where id = {n}";
            DataTable dt = DBHelper.ExecSelect(finalQuery);
            DBHelper.rowDetail(dt);
            Console.WriteLine(".. You SUCCEEDED Editing a person ..");
            Console.WriteLine("Perss go back to Main Menu");
            Console.Read();
            menu.mainMenuSelection();
            sitting();

        }

        public void AddPerson()
        {
            int n1 = 0;
            int n2 = 0;
            Console.WriteLine("\n");
            Console.WriteLine(" ....        ADDING A NEW PERSON      .... ");
            Console.WriteLine(" ...    Please fill tHE informations:  ... ");
            Console.WriteLine("___________________________________________");

            while (true)
            {
                Console.Write("ID = : ");
                string input1 = Console.ReadLine();
                if (int.TryParse(input1, out n1))
                {
                    if (n1 > 0) break;
                }
            }
            Console.WriteLine("___________________________________________");
            Console.Write("First Name is: ");
            string input2 = Console.ReadLine();
            Console.WriteLine("___________________________________________");
            Console.Write("Last Name is: ");
            string input3 = Console.ReadLine();
            Console.WriteLine("___________________________________________");
            Console.Write("E-Mail is: ");
            string input4 = Console.ReadLine();
            Console.WriteLine("___________________________________________");
            Console.Write("User Name is: ");
            string input5 = Console.ReadLine();
            Console.WriteLine("___________________________________________");
            Console.Write("Password is: ");
            string input6 = Console.ReadLine();
            Console.WriteLine("___________________________________________");
            while (true)
            {
                Console.Write("Age is : ");
                string input7 = Console.ReadLine();
                if (int.TryParse(input7, out n2))
                {
                    if (n2 > 0 && n2 < 100) break;
                }
            }
            Console.Write("Gender is: ");
            string input8 = Console.ReadLine();
            Console.WriteLine("___________________________________________");
            Console.Write("He is from: ");
            string input9 = Console.ReadLine();
            Console.WriteLine("___________________________________________");
            string query1 = $"Insert into PERSON_DATA Values ({n1}, '{input2}', '{input3}', '{input4}', '{input5}', '{input6}', {n2},'{input8}', '{input9}')";

            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine(".. You SUCCEEDED To Create a New Account ..");
            Console.WriteLine("___________________________________________");
            int n = DBHelper.ExecuteNonQuery(query1);
            string query2 = $"Select id, first_name, last_name, email, userName, password, Age, gender, country From PERSON_DATA Where first_name = '{input2}'";
            DataTable dt = DBHelper.ExecSelect(query2);
            DBHelper.rowDetail(dt);
            Console.WriteLine("\n");
            Console.WriteLine("Perss go back to Main Menu");
            Console.Read();
            menu.mainMenuSelection();
            sitting();
        }

        public void DeletePerson()
        {
            int n = 0;
            Console.WriteLine("\n");
            Console.WriteLine(" ....    DELETING AN EXISTED PERSON   .... ");
            Console.WriteLine(" ...        Please Write The ID :      ... ");
            Console.WriteLine("___________________________________________");

            while (true)
            {
                Console.Write("ID = : ");
                string input1 = Console.ReadLine();
                if (int.TryParse(input1, out n))
                {
                    if (n > 0) break;
                }
            }
            string query = $"Delete From PERSON_DATA where id = {n}";
            DBHelper.ExecuteNonQuery(query);
            Console.WriteLine(".. You SUCCEEDED Deleting a person ..");
            Console.WriteLine("Perss go back to Main Menu");
            Console.Read();
            menu.mainMenuSelection();
            sitting();
        }
    }
}
