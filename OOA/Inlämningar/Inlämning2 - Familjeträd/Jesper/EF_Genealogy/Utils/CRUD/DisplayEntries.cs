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

namespace EF_Genealogy.Utils.CRUD
{
    public static class DisplayEntries
    {

        #region ChoseAPerson
        public static void ChooseAPersonByIndex()
        {
            SelectFromAList(GetListFromDB(), "Select ID to view more details");
        }

        // The following four methods could probably relatively easily be combined into one, with a little extra time.
        /// <summary>
        /// Allows the user to select a specific person from specified list.
        /// </summary>
        /// <param name="message"></param>
        public static void ChoosePersonFromNameList(string message)
        {
            WriteLineColour("Enter a name or last name to search for:\n");
            var searchTerm = Console.ReadLine().Trim(); // add handler
            var resultList = SearchEntries.GetPeopleByName(searchTerm);
            if (resultList.Count != 0)
            {
                WriteLineColour($"\nSearched for \"{searchTerm}\"\n");
                WriteLineColour($"Found the following results:", ConsoleColor.DarkGreen);
                SelectFromAList(resultList, message);
            }
            else
            {
                WriteLineColour("Found no results.", ConsoleColor.DarkRed);
                PressEnterToContinue();
            }
        }

        public static void ChoosePersonFromNameListFirstLetter(string message)
        {
            WriteLineColour("Enter a letter to search for a matching first name:\n");
            var searchTerm = Console.ReadLine().Trim(); // add handler
            var resultList = SearchEntries.GetPeopleBySameNameLetter(searchTerm);
            if (resultList.Count != 0)
            {
                WriteLineColour($"\nSearched for \"{searchTerm}\"\n");
                WriteLineColour($"Found the following results:", ConsoleColor.DarkGreen);
                SelectFromAList(resultList, message);
            }
            else
            {
                WriteLineColour("Found no results.", ConsoleColor.DarkRed);
                PressEnterToContinue();
            }
        }

        public static void ChooseFromPlanetList()
        {
            WriteLineColour("\nEnter a planet to search for:\n");
            var searchTerm = Console.ReadLine().Trim(); // add handler
            var resultList = SearchEntries.GetPeopleByPlanet(searchTerm);
            if (resultList.Count != 0)
            {
                SearchSuccessfullSelect(searchTerm, resultList);
            }
            else
            {
                WriteLineColour("Found no planets with that name.", ConsoleColor.DarkRed);
                PressEnterToContinue();
            }
        }

        public static void ChooseFromBirthDateList()
        {
            WriteLineColour("\nEnter a birth date to search for.\nYear in numbers, followed by \"BBY\" or \"ABY\"\n(Example: 19 BBY)\n\nEnter date:");
            var searchTerm = Console.ReadLine().ToUpper().Trim(); // add handler
            var resultList = SearchEntries.GetPeopleByBirthDate(searchTerm);
            if (resultList.Count != 0)
            {
                SearchSuccessfullSelect(searchTerm, resultList);
            }
            else
            {
                WriteLineColour("Found no results.", ConsoleColor.DarkRed);
                PressEnterToContinue();
            }
        }
        //------------------------------------------------------------------------
        private static void SearchSuccessfullSelect(string searchTerm, List<Person> resultList)
        {
            WriteLineColour($"\nSearched for \"{searchTerm}\"\n");
            WriteLineColour($"Found the following results:", ConsoleColor.DarkGreen);
            SelectFromAList(resultList, "Select ID to view more details");
        }
        #endregion

        public static List<Person> GetListFromDB()
        {
            using (var db = new GenealogyContext())
            {
                var dbPeople = db.People.ToList();
                return dbPeople;
            }
        }

        /// <summary>
        /// Allows the user to select a person from a list.
        /// Does different things depending on what text the parameter contains. Probably an unoptimzed way of reusing this method but seems to work alright.
        /// </summary>
        /// <param name="personList"></param>
        /// <param name="whatToDo">"Write "view" "edit" or "delete" for respective menu</param>
        public static void SelectFromAList(List<Person> personList, string whatToDo)
        {
            DisplayPeopleInList(personList, false);
            WriteLineColour(whatToDo);
            WriteLineColour("Leave blank to return to previous menu.\n");
            var selectedPerson = SelectFromListIndexToDBIndex(personList);
            if (selectedPerson != null && whatToDo.Contains("view"))
                DisplayWholePerson(selectedPerson);
            else if (selectedPerson != null && whatToDo.Contains("edit"))
                Menus.EditMenu.AskToAddStuff(selectedPerson);
            else if (selectedPerson != null && whatToDo.Contains("delete"))
                DeleteEntries.DeleteAPerson(selectedPerson);
            //else if (selectedPerson == null)
            //{
            //    WriteLineColour("Could not find corresponding ID", ConsoleColor.DarkRed);
            //    PressEnterToContinue();
            //}
        }

        /// <summary>
        /// Prints out all information about a person. Shows a mini-menu to allow for more navigation person-to-person
        /// </summary>
        /// <param name="person"></param>
        public static void DisplayWholePerson(Person person)
        {
            using (var db = new GenealogyContext())
            {
                Person mother, father, spouse;
                GetMotherFatherSpouseForDisplay(person, db, out mother, out father, out spouse);
                ClearAndSetBackground();
                WriteLineColour("┌──────────────────────────────┐");
                WriteLineColour($"│Viewing database entry #{person.ID}     │");
                WriteLineColour("┌─────────────────────────────────────────────────────────────────────────────────────────");
                WriteLineColour($"│Name:\t {person.FirstName} {person.LastName} ");
                WriteLineForMaidenNameOrnot(person);
                WriteLineColour("│");
                WriteLineColour($"│Born:\t {person.BirthDate}\t| {person.BirthLocation ?? ("Unknown location")}");
                WriteLineColour($"│Died:\t {person.DeathDate}\t| {person.DeathLocation ?? ("Unknown location")}");
                WriteLineColour("│");
                WriteLineColour($"│Mother: {mother?.FirstName} {mother?.LastName ?? ("Unknown")}");
                WriteLineColour($"│Father: {father?.FirstName} {father?.LastName ?? ("Unknown")}");
                WriteLineColour($"│Spouse: {spouse?.FirstName} {spouse?.LastName}");
                WriteLineColour("│");
                WriteLineColour("│Notable events: ");
                DisplayNotableEventsIfExists(person);
                WriteLineColour("│");
                WriteLineColour("└─────────────────────────────────────────────────────────────────────────────────────────");
            }
            Menus.PersonInfoMenu.AskToViewMoreInfo(person);
        }

        private static void DisplayNotableEventsIfExists(Person person)
        {
            if (person.PersonHistory != null)
                foreach (var item in person?.PersonHistory)
                {
                    WriteLineColour($"│\t {item.EventLocation?.LocationName} - {item?.EventDate} \t{item?.EventDescription}");
                }
        }

        private static void WriteLineForMaidenNameOrnot(Person person)
        {
            if (person.MaidenName != null)
                WriteLineColour($"│Maiden\n│Name:  {person.MaidenName}"); 
        }

        private static void GetMotherFatherSpouseForDisplay(Person person, GenealogyContext db, out Person mother, out Person father, out Person spouse)
        {
            mother = db.People.FirstOrDefault(p => p.ID == person.MotherID);
            father = db.People.FirstOrDefault(p => p.ID == person.FatherID);
            spouse = db.People.FirstOrDefault(p => p.ID == person.SpouseID);
        }


        /// <summary>
        /// Displays all the people in a list with the current list index increased by 1 (to allow for a more intuitive user choice if a list starts with 0).
        /// If the bool is true, sorts by the specified sorting, otherwise sorts by default (this makes it easier to reuse this method to sort the default DB-list by ID, instead of the DB-ID being scrambled around.)
        /// </summary>
        /// <param name="people"></param>
        /// <param name="sortBy">Specify if list is to be sorted or not</param>
        private static void DisplayPeopleInList(List<Person> people, bool sortBy)
        {
            if (!sortBy)
            {
                foreach (var person in people)
                {
                    WriteLineColour("┌───────────────────────────────────────────────────────────────");
                    WriteLineColour($"│[{people.IndexOf(person) + 1}] - {person.FirstName} {person.LastName} ");
                    WriteLineColour("└───────────────────────────────────────────────────────────────");
                }
            }
            else
            {
                foreach (var person in people.OrderBy(p => p.LastName))//.ThenBy(p => p.MotherID))
                {
                    WriteLineColour("┌────────────────────────────────────────────────────────────────");
                    WriteLineColour($"│[{people.IndexOf(person) + 1}] - {person.FirstName} {person.LastName} ");
                    WriteLineColour("└───────────────────────────────────────────────────────────────");
                }
            }

        }


        /// <summary>
        /// Allows the user to select a person ID from a list, gets the chosen list ID and converts it to the database index of the chosen person.
        /// Returns the person.
        /// </summary>
        /// <param name="people">List of people</param>
        /// <returns></returns>
        private static Person SelectFromListIndexToDBIndex(List<Person> people)
        {
            Person person = null;
            var selectedIndex = ReceiveInput.ReceiveInt();
            if (selectedIndex <= people.Count && selectedIndex > 0)
            {
                var tempPerson = people[selectedIndex - 1];
                person = SearchEntries.GetPersonByID(tempPerson.ID);
            }
            return person;
        }

    }
}
