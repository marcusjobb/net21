using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Genealogy.Data;
using EF_Genealogy.Utils;
using EF_Genealogy.Utils.CRUD;
using EF_Genealogy.Utils.UserInput;
using EF_Genealogy.Display;
using static EF_Genealogy.Utils.UserExperience;
using static EF_Genealogy.Display.DisplayHelper;
using static EF_Genealogy.Display.ArtAssets.ASCII;


namespace EF_Genealogy.Menus
{
    /// <summary>
    /// Displays the primary menus and initializes the database initializer
    /// </summary>
    public static class DBMenu
    {
        public static void Run()
        {
            // Init the DB and seed it
            InitializeDB.RunInitializer();
            MainMenu();
        }

        internal static void MainMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                DisplayHelper.ClearAndSetBackground();
                WriteLineColour(headerStarWarsAscii);
                WriteLineColour("[1] - View the family tree ");
                WriteLineColour("[2] - Create a new person");
                WriteLineColour("[3] - Edit and Delete");
                WriteLineColour("[4] - Exit the program");
                switch (ReceiveInput.ReceiveInt())
                {
                    case 1:
                        DisplayHelper.ClearAndSetBackground();
                        MenuViewPerson();
                        break;
                    case 2:
                        DisplayHelper.ClearAndSetBackground();
                        CreateEntries.CreateAPerson();
                        break;
                    case 3:
                        DisplayHelper.ClearAndSetBackground();
                        WriteLineColour("Edit and Delete");
                        MenuEditDelete();
                        break;
                    case 4:
                        DisplayHelper.ClearAndSetBackground();
                        WriteLineColour("Exiting..");
                        PressKeyToContinue();
                        showMenu = false;
                        break;
                    default:
                        break;
                }
            }
        }



        internal static void MenuViewPerson()
        {
            bool showMenu = true;
            while (showMenu)
            {
                DisplayHelper.ClearAndSetBackground();
                WriteLineColour(displayAscii);
                WriteLineColour("[1] - View all people in the family tree");
                WriteLineColour("[2] - View person by name or last name");
                WriteLineColour("[3] - View people whose first names start with the same letter");
                WriteLineColour("[4] - View people by birthplace");
                WriteLineColour("[5] - View people by birth year");
                WriteLineColour("\nPress [Enter] to return to the previous menu");
                switch (ReceiveInput.ReceiveInt())
                {
                    case 1:
                        DisplayHelper.ClearAndSetBackground();
                        DisplayEntries.ChooseAPersonByIndex();
                        break;
                    case 2:
                        DisplayHelper.ClearAndSetBackground();
                        WriteLineColour(displayAscii);
                        DisplayEntries.ChoosePersonFromNameList("Enter ID to view more details");
                        break;
                    case 3:
                        DisplayHelper.ClearAndSetBackground();
                        WriteLineColour(displayAscii);
                        DisplayEntries.ChoosePersonFromNameListFirstLetter("Enter ID to view more details");
                        break;
                    case 4:
                        DisplayHelper.ClearAndSetBackground();
                        WriteLineColour(displayAscii);
                        DisplayEntries.ChooseFromPlanetList();
                        break;
                    case 5:
                        DisplayHelper.ClearAndSetBackground();
                        WriteLineColour(displayAscii);
                        DisplayEntries.ChooseFromBirthDateList();
                        break;
                    default:
                        showMenu = false;
                        break;
                }
            }
        }

        internal static void MenuEditDelete()
        {
            bool showMenu = true;
            while (showMenu)
            {
                DisplayHelper.ClearAndSetBackground();
                WriteLineColour(updateAscii);
                WriteLineColour("[1] Edit details of a person");
                WriteLineColour("[2] Remove a person");
                WriteLineColour("[3] Return to the previous menu");
                switch (ReceiveInput.ReceiveInt())
                {
                    case 1:
                        DisplayHelper.ClearAndSetBackground();
                        WriteLineColour(updateAscii);
                        DisplayEntries.ChoosePersonFromNameList("Enter ID to edit person");
                        break;
                    case 2:
                        DisplayHelper.ClearAndSetBackground();
                        WriteLineColour(deleteAscii);
                        DisplayEntries.ChoosePersonFromNameList("Enter ID of who you'd like to delete");
                        break;
                    case 3:
                        showMenu = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
