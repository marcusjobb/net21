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

namespace EF_Genealogy.Menus
{
    /// <summary>
    /// Contains the menus that allow the user to view more information about a person result.
    /// </summary>
    public static class PersonInfoMenu
    {
        public static void AskToViewMoreInfo(Person person)
        {
            WriteLineColour("Press [1] for more options or press [Enter] to return to the previous menu.");
            //var viewMoreInfo = ReceiveInput.ReceiveInt();
            if (ReceiveInput.ReceiveInt() == 1)
            {

                WriteLineColour($"View more details.");
                WriteLineColour("[1] - View parents");
                WriteLineColour("[2] - View siblings");
                WriteLineColour("[3] - View children");
                switch (ReceiveInput.ReceiveInt())
                {
                    case 1:
                        ViewParentsInfo(person);
                        break;
                    case 2:
                        ViewSiblingsInfo(person);
                        break;
                    case 3:
                        ViewChildrenInfo(person);
                        break;
                }
            }
            else
                Console.Clear();
        }

        private static void ViewSiblingsInfo(Person person)
        {
            var listOfSiblings = SearchEntries.GetSiblings(person);
            if (listOfSiblings.Count == 0)
            {
                WriteLineColour($"{person.FirstName} does not appear to have any siblings");
                UserExperience.PressEnterToContinue();
            }
            else
            {
               WriteLineColour("Found the following siblings:");
               DisplayEntries.SelectFromAList(listOfSiblings, "Enter ID to view more information about the sibling");
            }
        }

        private static void ViewChildrenInfo(Person person)
        {
            var listOfChildren = SearchEntries.GetChildren(person);
            if (listOfChildren.Count == 0)
            {
                WriteLineColour($"{person.FirstName} does not appear to have any children");
                UserExperience.PressEnterToContinue();
            }
            else
            {
                WriteLineColour("Found the following children:");
                DisplayEntries.SelectFromAList(listOfChildren, "Enter ID to view more information about the child");
            }
        }

        private static void ViewParentsInfo(Person person)
        {
            Person mother;
            Person father;
            int fatherID = 0;
            int motherID = 0;
            if (person.FatherID != null)
                fatherID = (int)person.FatherID;
            if (person.MotherID != null)
                motherID = (int)person.MotherID;
            WriteLineColour($"[1] - View details about {person.FirstName}'s mother");
            WriteLineColour($"[2] - View details about {person.FirstName}'s father");
            var fatherOrMother = ReceiveInput.ReceiveInt();
            switch (fatherOrMother)
            {
                case 1:
                    if (motherID >= 0)
                    {
                        mother = SearchEntries.GetPersonByID(motherID);
                        if (mother != null)
                            DisplayEntries.DisplayWholePerson(mother);
                        else
                        {
                            WriteLineColour($"Could not find mother of {person.FirstName}");
                            UserExperience.PressEnterToContinue();
                        }
                    }
                    break;
                case 2:
                    if (fatherID >= 0)
                    {
                        father = SearchEntries.GetPersonByID(fatherID);
                        if (father != null)
                            DisplayEntries.DisplayWholePerson(father);
                        else
                        {
                            WriteLineColour($"Could not find father of {person.FirstName}");
                            UserExperience.PressEnterToContinue();
                        }
                    }
                    break;
            }
        }

    }
}
