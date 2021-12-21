using EF_Genealogy.Data;
using EF_Genealogy.Models;
using EF_Genealogy.Utils.UserInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EF_Genealogy.Utils.UserExperience;
using static EF_Genealogy.Display.DisplayHelper;
using static EF_Genealogy.Display.ArtAssets.ASCII;

namespace EF_Genealogy.Utils.CRUD
{
    public static class DeleteEntries
    {
        public static void DeleteAPerson(Person person)
        {
            ClearAndSetBackground();
            WriteLineColour(deleteAscii);
            WriteLineColour($"Are you sure you want to delete {person.FirstName} {person.LastName} with database ID:{person.ID} from the database?\n");
            WriteLineColour("Warning! This decision is irreversible (though only a Sith deals in absolutes)", ConsoleColor.DarkRed);
            WriteLineColour("\nPress [1] to confirm your choice or [Enter] to return to the previous menu.");
            var userChoice = ReceiveInput.ReceiveInt();
            if (userChoice == 1)
            {
                InputNameToConfirm(person, out string inputFirstName, out string inputLastName);
                if (inputFirstName == person.FirstName && inputLastName == person.LastName)
                {
                    DbEntityHandler.DeletePerson(person);
                    WriteLineColour("Person successfully deleted.", ConsoleColor.DarkGreen);
                    PressEnterToContinue();
                }
                else
                {
                    WriteLineColour("Wrong input. Person has not been deleted.", ConsoleColor.DarkRed);
                    PressEnterToContinue();
                }
            }
            else
            {
                WriteLineColour("Nothing has been deleted. Returning to the previous menu.");
                PressEnterToContinue();
            }
        }

        private static void InputNameToConfirm(Person person, out string inputFirstName, out string inputLastName)
        {
            WriteLineColour("Please type in the exact name of the person to confirm your choice\n");
            WriteLineColour($"{person.FirstName} {person.LastName}\n", ConsoleColor.DarkRed);
            WriteLineColour("First name: ", ConsoleColor.DarkRed);
            inputFirstName = ReceiveInput.ReceiveNameString();
            WriteLineColour("Last name: ",ConsoleColor.DarkRed);
            inputLastName = ReceiveInput.ReceiveNameString();
        }
    }
}
