using EF_Genealogy.Models;
using EF_Genealogy.Utils.UserInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Genealogy.Utils.CRUD;
using EF_Genealogy.Utils;
using static EF_Genealogy.Display.DisplayHelper;
using static EF_Genealogy.Display.ArtAssets.ASCII;

namespace EF_Genealogy.Menus
{
    /// <summary>
    /// Contains the menus related to editing a person
    /// </summary>
    public static class EditMenu
    {
        internal static void AskToAddStuff(Person person)
        {
            bool showMenu = true;
            while (showMenu)
            {
                ClearAndSetBackground();
                WriteLineColour(updateAscii);
                WriteLineColour("\n─────────────────────");
                WriteLineColour($" {person.FirstName} {person.LastName}", ConsoleColor.DarkCyan);
                WriteLineColour("─────────────────────");
                WriteLineColour($"Add or update details\n");
                WriteLineColour("[1] - Add Parents");
                WriteLineColour("[2] - Add Locations and Dates");
                WriteLineColour("[3] - Add Spouse");
                WriteLineColour("[4] - Rename person");
                WriteLineColour("[5] - View details");
                WriteLineColour("[6] - Add an event");
                WriteLineColour("\nPress [Enter] to return to previous menu.");
                switch (ReceiveInput.ReceiveInt())
                {
                    case 1:
                        AskMotherOrFather(person);
                        break;
                    case 2:
                        AskToAddDateAndLoc(person);
                        break;
                    case 3:
                        ClearAndSetBackground();
                        WriteLineColour(createAscii);
                        WriteLineColour("Add a spouse: ");
                        CreateEntries.SetOrCreateRelationOfPerson(person, "Spouse");
                        break;
                    case 4:
                        AskToRename(person);
                        break;
                    case 5:
                        DisplayEntries.DisplayWholePerson(person);
                        break;
                    case 6:
                        ClearAndSetBackground();
                        WriteLineColour(createAscii);
                        CreateEntries.EnterEventDescription(person);
                        break;
                    default:
                        showMenu = false;
                        break;
                }
            }
        }

        internal static void AskToAddDateAndLoc(Person person)
        {
            bool showMenu = true;
            while (showMenu)
            {
                ClearAndSetBackground();
                WriteLineColour(updateAscii);
                WriteLineColour($"\nAdd or update Locations and Dates");
                WriteLineColour("─────────────────────");
                WriteLineColour($" {person.FirstName} {person.LastName}", ConsoleColor.DarkCyan);
                WriteLineColour("─────────────────────");
                WriteLineColour("[1] - Add Homeplanet");
                WriteLineColour("[2] - Add Date of Birth");
                WriteLineColour("[3] - Add Place of Death");
                WriteLineColour("[4] - Add Date of Death");
                WriteLineColour("\nPress [Enter] to return to previous menu.");
                switch (ReceiveInput.ReceiveInt())
                {
                    case 1:
                        CreateEntries.SetOrCreatePlanetOfPerson(person, "homeplanet");
                        UserExperience.PressEnterToContinue();
                        break;
                    case 2:
                        CreateEntries.AddYearToPerson(person, "date of birth");
                        UserExperience.PressEnterToContinue();
                        break;
                    case 3:
                        CreateEntries.SetOrCreatePlanetOfPerson(person, "death location");
                        UserExperience.PressEnterToContinue();
                        break;
                    case 4:
                        CreateEntries.AddYearToPerson(person, "date of death");
                        UserExperience.PressEnterToContinue();
                        break;
                    default:
                        showMenu = false;
                        break;
                }
            }


        }

        internal static void AskToRename(Person person)
        {
            bool showMenu = true;
            while (showMenu)
            {
                ClearAndSetBackground();
                WriteLineColour(updateAscii);
                WriteLineColour($"\nRename");
                WriteLineColour("─────────────────────");
                WriteLineColour($" {person.FirstName} {person.LastName}", ConsoleColor.DarkCyan);
                WriteLineColour("─────────────────────");
                WriteLineColour("[1] - Change First Name");
                WriteLineColour("[2] - Change Last Name");
                WriteLineColour("[3] - Change Maiden Name");
                WriteLineColour("\nPress [Enter] to return to previous menu.");
                switch (ReceiveInput.ReceiveInt())
                {
                    case 1:
                        CreateEntries.UpdateFirstNameLastName(person, "first name");
                        UserExperience.PressEnterToContinue();
                        break;
                    case 2:
                        CreateEntries.UpdateFirstNameLastName(person, "last name");
                        UserExperience.PressEnterToContinue();
                        break;
                    case 3:
                        CreateEntries.UpdateFirstNameLastName(person, "maiden name");
                        UserExperience.PressEnterToContinue();
                        break;
                    default:
                        showMenu = false;
                        break;
                }
            }


        }

        internal static void AskMotherOrFather(Person person)
        {
            bool showMenu = true;
            while (showMenu)
            {
                ClearAndSetBackground();
                WriteLineColour(updateAscii);
                WriteLineColour($"\nAdd or update Parents");
                WriteLineColour("─────────────────────");
                WriteLineColour($" {person.FirstName} {person.LastName}", ConsoleColor.DarkCyan);
                WriteLineColour("─────────────────────");
                WriteLineColour("[1] - Add Mother");
                WriteLineColour("[2] - Add Father");
                WriteLineColour("\nPress [Enter] to return to previous menu.");
                switch (ReceiveInput.ReceiveInt())
                {
                    case 1:
                        CreateEntries.SetOrCreateRelationOfPerson(person, "Mother");

                        break;
                    case 2:
                        CreateEntries.SetOrCreateRelationOfPerson(person, "Father");

                        break;
                    default:
                        showMenu = false;
                        break;
                }
            }


        }
    }
}
