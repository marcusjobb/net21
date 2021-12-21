using EF_Genealogy.Data;
using EF_Genealogy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Genealogy.Utils.UserInput;
using static EF_Genealogy.Utils.UserExperience;
using static EF_Genealogy.Display.DisplayHelper;
using static EF_Genealogy.Display.ArtAssets.ASCII;

namespace EF_Genealogy.Utils.CRUD
{
    public static class CreateEntries
    {

        #region CreateAPerson
        /// <summary>
        /// Contains options to create and add a person to the database
        /// </summary>
        public static void CreateAPerson()
        {
            Person createdPerson = new();
            WriteLineColour("Create a new person.");
            EnterFirstNameLastName(createdPerson);
            WriteLineColour("\nIs this correct?");
            WriteLineColour("Press [1] for Yes or [Enter] to abort");
            switch (ReceiveInput.ReceiveInt())
            {
                case 1:
                    ClearAndSetBackground();
                    WriteLineColour(createAscii);
                    WriteLineColour("Checking if person already exists..\n");
                    ShortPause(300);
                    if (SearchEntries.DoesPersonExist(createdPerson.FirstName, createdPerson.LastName))
                    {
                        WriteLineColour($"The database already contains a \"{createdPerson.FirstName} {createdPerson.LastName}\".", ConsoleColor.DarkRed);
                        PressEnterToContinue();
                    }
                    else
                    {
                        DbEntityHandler.AddPerson(createdPerson);
                        WriteLineColour($"Sucessfully added {createdPerson.FirstName} {createdPerson.LastName} to the database!\n", ConsoleColor.DarkGreen);
                        WriteLineColour($"Would you like to add more details to {createdPerson.FirstName} {createdPerson.LastName}?");
                        WriteLineColour("Press [1] for yes or press [Enter] to return to the previous menu.");
                        if (ReceiveInput.ReceiveInt() == 1)
                            Menus.EditMenu.AskToAddStuff(createdPerson);
                    }
                    break;
                default:
                    WriteLineColour("Person was not saved.", ConsoleColor.DarkRed);
                    PressEnterToContinue();
                    break;
            }
        }

        internal static void SetOrCreateRelationOfPerson(Person createdPerson, string personToAdd)
        {
            WriteLineColour(personToAdd);
            WriteColour("Name: ");
            var createdPersonRelationName = ReceiveInput.ReceiveNameString();
            WriteColour("Last name: ");
            var createdPersonParentLastName = ReceiveInput.ReceiveNameString();
            bool doesParentExist = SearchEntries.DoesPersonExist(createdPersonRelationName, createdPersonParentLastName);
            if (doesParentExist)
                RelationExistsUseRelation(createdPerson, personToAdd, createdPersonRelationName, createdPersonParentLastName);
            else
                CreateNewPersonRelation(createdPerson, personToAdd, createdPersonRelationName, createdPersonParentLastName);
        }
        /// <summary>
        /// Sets a family member to a person, for example a parent.
        /// </summary>
        /// <param name="createdPerson"></param>
        /// <param name="personToAdd"></param>
        /// <param name="createdPersonRelationsName"></param>
        /// <param name="createdPersonRelationsLastName"></param>
        private static void CreateNewPersonRelation(Person createdPerson, string personToAdd, string createdPersonRelationsName, string createdPersonRelationsLastName)
        {
            if (personToAdd == "Father")
                createdPerson.FatherID = DbEntityHandler.FindOrCreatePerson(createdPersonRelationsName, createdPersonRelationsLastName);
            else if (personToAdd == "Mother")
                createdPerson.MotherID = DbEntityHandler.FindOrCreatePerson(createdPersonRelationsName, createdPersonRelationsLastName);
            else if (personToAdd =="Spouse")
                createdPerson.SpouseID = DbEntityHandler.FindOrCreatePerson(createdPersonRelationsName, createdPersonRelationsLastName);
            DbEntityHandler.UpdatePerson(createdPerson);
            WriteLineColour($"\nSuccessfully added {createdPersonRelationsName} as {personToAdd} of {createdPerson.FirstName}", ConsoleColor.DarkGreen);
            PressEnterToContinue();
        }

        /// <summary>
        /// Uses an already existing person as a relation to the person.
        /// </summary>
        /// <param name="createdPerson"></param>
        /// <param name="personRelation"></param>   
        /// <param name="createdPersonParentName"></param>
        /// <param name="createdPersonParentLastName"></param>
        private static void RelationExistsUseRelation(Person createdPerson, string personRelation, string createdPersonParentName, string createdPersonParentLastName)
        {
            WriteLineColour($"{personRelation} already exists. Would you like to use that person as {personRelation}?", ConsoleColor.DarkRed);
            WriteLineColour("\nPress [1] to confirm.");
            if (ReceiveInput.ReceiveInt() == 1)
            {
                if (personRelation == "Father")
                    createdPerson.FatherID = DbEntityHandler.GetPersonID(createdPersonParentName, createdPersonParentLastName);
                else if (personRelation == "Mother")
                    createdPerson.MotherID = DbEntityHandler.GetPersonID(createdPersonParentName, createdPersonParentLastName);
                else if (personRelation == "Spouse")
                    createdPerson.SpouseID = DbEntityHandler.GetPersonID(createdPersonParentName, createdPersonParentLastName);
                DbEntityHandler.UpdatePerson(createdPerson);
                WriteLineColour($"\nSuccessfully added {createdPersonParentName} as {personRelation} of {createdPerson.FirstName}", ConsoleColor.DarkGreen);
                PressEnterToContinue();
            }
        }


        internal static void EnterFirstNameLastName(Person createdPerson)
        {
            ClearAndSetBackground();
            WriteLineColour(updateAscii);
            WriteLineColour("\nEnter first name and last name\n");
            WriteColour("\nFirst name: ");
            createdPerson.FirstName = ReceiveInput.ReceiveNameString();
            WriteColour("\nLast name: ");
            createdPerson.LastName = ReceiveInput.ReceiveNameString();
            WriteLineColour("Entered the following name:\n");
            WriteLineColour($"{createdPerson.FirstName} {createdPerson.LastName}", ConsoleColor.DarkCyan);
        }
        #endregion
 
         // TODO: Add proper location?
        internal static void EnterEventDescription(Person person)
        {
            WriteLineColour($"\nEnter a short description of an event you'd like to add to {person.FirstName}\n");
            WriteColour("Event: ", ConsoleColor.DarkCyan);
            var userInput = ReceiveInput.ReceiveNameString();
            WriteLineColour($"\nDo you want to save the following event?\n");
            WriteLineColour($"{ userInput}",ConsoleColor.DarkCyan);
            WriteLineColour("\nPress [1] for yes or [Enter] to abort");
            if (ReceiveInput.ReceiveInt() == 1)
            {
                DbEntityHandler.AddEvent(person, userInput);
                DbEntityHandler.UpdatePerson(person);
                WriteLineColour($"Event was successfully added to {person.FirstName}", ConsoleColor.DarkGreen);
                PressEnterToContinue();
            }
            else
            {
                WriteLineColour("Event was not added.", ConsoleColor.DarkRed);
                PressEnterToContinue();
            }
        }
        /// <summary>
        /// Lets the user change either name, last name, or maiden name of selected person, depending on the paramter text.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="name">"first name"/"last name"/"maiden name" as params to reuse</param>
        internal static void UpdateFirstNameLastName(Person person, string name)
        {
            var oldName = "";
            WriteLineColour($"Renaming {person.FirstName} {person.LastName}");
            WriteLineColour($"Enter new {name} :");
            var newName = ReceiveInput.ReceiveNameString();
            if (name == "first name")
                oldName = person.FirstName;
            else if (name == "last name")
                oldName = person.LastName;
            else if (name == "maiden name")
                oldName = person.MaidenName;
            WriteLineColour($"Change {oldName} to {newName}?");
            WriteLineColour($"\nPress [1] to confirm or [Enter] to abort.");
            if (ReceiveInput.ReceiveInt() == 1)
            {
                if (name == "first name")
                    person.FirstName = newName;
                else if (name == "last name")
                    person.LastName = newName;
                else if (name == "maiden name")
                    person.MaidenName = newName;
                DbEntityHandler.UpdatePerson(person);
                WriteLineColour($"Successfully changed {oldName} to {newName}", ConsoleColor.DarkGreen);
            }
            else
                WriteLineColour("Nothing was updated.");
        }

        #region PlanetOfPerson
        internal static void SetOrCreatePlanetOfPerson(Person person, string planetInfo)
        {
            ClearAndSetBackground();
            WriteLineColour(updateAscii);
            WriteLineColour($"Add {planetInfo} to {person.FirstName}");
            if (planetInfo == "homeplanet")
                AddBirthplace(person, planetInfo);
            else if (planetInfo == "death location")
                AddDeathLocation(person, planetInfo);
            else
                WriteLineColour($"{planetInfo} has not been changed.", ConsoleColor.DarkRed);
        }

        private static void AddDeathLocation(Person person, string planetInfo)
        {
            ClearAndSetBackground();
            WriteLineColour(updateAscii);
            WriteLineColour($"Add location where {person.FirstName} died.");
            WriteLineColour("Death location: ");
            var deathLoc = ReceiveInput.ReceiveNameString();
            person.DeathLocation = deathLoc;
            DbEntityHandler.UpdatePerson(person);
            WriteLineColour($"Successfully updated {planetInfo}", ConsoleColor.DarkGreen);
        }

        private static void AddBirthplace(Person person, string planetInfo)
        {
            ClearAndSetBackground();
            WriteLineColour(updateAscii);
            WriteLineColour("Add birthplace.");
            WriteLineColour("Homeplanet: ");
            var homeplanet = ReceiveInput.ReceiveNameString();
            person.BirthLocation = homeplanet;
            DbEntityHandler.UpdatePerson(person);
            WriteLineColour($"Successfully updated {planetInfo}", ConsoleColor.DarkGreen);
        }

        #endregion


        #region AddYear

        /// <summary>
        /// Adds either a birth date or dath date, depending on the string parameter
        /// </summary>
        /// <param name="person"></param>
        /// <param name="birthOrDeathDate">"Birth"/"Death" to add the respective date</param>
        public static void AddYearToPerson(Person person, string birthOrDeathDate)
        {
            ClearAndSetBackground();
            WriteLineColour(updateAscii);
            WriteLineColour($"Add {birthOrDeathDate} to {person.FirstName}");
            WriteLineColour("All dates are either BBY (before battle of Yavin) or ABY (after battle of yavin)\n");
            WriteLineColour("Enter year in numbers: ");
            var personDate = ReceiveInput.ReceiveInt();
            if (personDate > 0)
            {
                WriteLineColour("[1] - BBY (Before battle of Yavin)");
                WriteLineColour("[2] - ABY (After battle of Yavin)");
                switch (ReceiveInput.ReceiveInt())
                {
                    case 1:
                        SetPersonDate(person, birthOrDeathDate, personDate, "BBY");
                        break;
                    case 2:
                        SetPersonDate(person, birthOrDeathDate, personDate, "ABY");
                        break;
                    default:
                        WriteLineColour("Date was not updated", ConsoleColor.DarkRed);
                        break;
                }
            }
            else
                WriteLineColour("Date was not changed", ConsoleColor.DarkRed);
        }

        private static void SetPersonDate(Person person, string birthOrDeathDate, int personDate, string userInput)
        {
            if (birthOrDeathDate == "date of birth")
                person.BirthDate = personDate + " " + userInput;
            else if (birthOrDeathDate == "date of death")
                person.DeathDate = personDate + " " + userInput;
            DbEntityHandler.UpdatePerson(person);
            WriteLineColour("Successfully updated date", ConsoleColor.DarkGreen);
        }
        #endregion
 


    }
}
