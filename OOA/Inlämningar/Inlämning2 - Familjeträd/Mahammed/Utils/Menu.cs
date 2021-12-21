using EF_inlämning_2.Data;

namespace EF_inlämning_2.Utils
{
    internal class Menu
    {
        public static void Start()
        {
            using var context = new DataContext();
            Data.DBInitializer.Initialize(context);
            context.SaveChanges();
            DBInitializer dbInitializer = new();
            Menu.MainMenu();
        }

        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("______________________________________________________________________________");
            Console.WriteLine("|                                                                            |");
            Console.WriteLine("|                                  MENU                                      |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("|[1]-  Create a person                                                       |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("|[2]- Find all                                                               |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("|[3]- Delete                                                                 |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("|[4]- Update                                                                 |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("|[5]- Siblings                                                               |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("|[6]- Grand/parents                                                          |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("|[7]- Children                                                               |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("|[8]- Search                                                                 |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("|[9]-                              Exit                                      |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.Write("\r\nEnter Choice: ");
            _ = int.TryParse(Console.ReadLine(), out int MenuChoice);
            Crud crud = new Crud();
            if (MenuChoice <= 9)
            {
                switch (MenuChoice)
                {
                    case 1:
                        Crud.Create();
                        Again();
                        Console.Clear();
                        break;

                    case 2:
                        Crud.ReadAll();
                        Again();
                        Console.Clear();
                        MainMenu();
                        break;

                    case 3:
                        Crud.Delete();
                        Again();
                        Console.Clear();
                        MainMenu();
                        break;

                    case 4:
                        Crud.Update();
                        Again();
                        Console.Clear();
                        MainMenu();
                        break;

                    case 5:
                        Crud.Siblings();
                        Again();
                        Console.Clear();
                        MainMenu();
                        break;

                    case 6:
                        Crud.Children();
                        Crud.ReadListFirstL();
                        Again();
                        Console.Clear();
                        MainMenu();
                        break;

                    case 7:
                        crud.GrandParents();
                        Again();
                        Console.Clear();
                        MainMenu();
                        break;

                    case 8:
                        Crud.ReadListFirstL();
                        Again();
                        Console.Clear();
                        MainMenu();
                        break;

                    case 9:
                        Console.Clear();
                        Console.WriteLine("\nBye");
                        Environment.Exit(0);
                        return;

                    default:
                        Console.WriteLine("\nInput 1-8.");
                        Console.ReadKey();
                        break;
                }
            }
            else

                MainMenu();
        }

        public static void Again()
        {
            Console.WriteLine("\n[Press enter to continue]");
            Console.ReadKey();
            Console.Clear();
        }
    }
}