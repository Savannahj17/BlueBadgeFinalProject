using BadgeClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeConsole
{
    public class ProgramUI
    {
        private readonly Dictionary<int, List<string>> _badgeDictionary = new Dictionary<int, List<string>>();

        public void Run()
        {
            SeedContentList();
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Hello Security Administration! Here's a list of options for you to manage badges and their access. \n" +
                    "What would you like to do? \n" +
                    "1. Add a badge \n" +
                    "2. Edit doors to aspecific badge \n" +
                    "3. List all badges \n" +
                    "4. Get a badge by the ID Number \n" +
                    "5. Exit");


                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CreateNewBadge();
                        break;
                    case "2":
                        UpdateDoorsOnExistingBadge();
                        break;
                    case "3":
                        GetAllBadges();
                        break;
                    case "4":
                        GetBadgeById();
                    case "5":
                        continueToRun = false;
                        break;
                    //exit
                    default:
                        Console.WriteLine("Please enter in a valid number between 1 and 5. \n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void CreateNewBadge()
        {
            Badge badge = new Badge();
            Console.WriteLine("Time to add your badge to your collection. \n" +
                "Let's get started! \n" +
                "Please enter the badge Id of the badge you would like to add: ");
            badge.BadgeId = intConsole.ReadLine();
            //convert string to int

            //Description
            Console.WriteLine("Please enter the doors that this badge has access to: ");
            badge.DoorNames = Console.ReadLine();

            //StarRating
            Console.WriteLine("Please enter the name associated with this badge: ");
            string starRatingInput = Console.ReadLine();

        }
        private void ShowAllBadges()
        {
            //call method that returns dict

            foreach (KeyValuePair<int, List<string>> kvp in badges)
            {
                GetAllBadges(kvp);
                Console.WriteLine("----------------------------------------------");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void ShowBadgeById()
        {
            Console.Clear();
            Console.WriteLine("Enter a badge ID");
            int badgeId = Console.ReadLine();
           // Badge foundId = __badges.getBadgeById(badgeId);
            if (badgeId != null)
            {
                DisplayContent(foundId);
            }
            else
            {
                Console.WriteLine("Invalid. Cound not find any results.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        private void RemoveAllDoorsFromBadge()
        {
            Dictionary<int, List<string>> _badgeDictionary = //call method to import dict
            Console.WriteLine("Please enter badge ID you wish to remove all doors from.");
            foreach (KeyValuePair<int, List<string>> kvp in _badgeDictionary)
            {
                //display badge id and badge name

            }
            int badgeId = Console.ReadLine(); // convert to int
                                              //call remove method
                                              //if true door have been revove
                                              //false - badge wasnt found
                                              //account for user error - repo method
        }
        Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
        private void DisplayAllDoors(Badge badge)
        {
            Console.WriteLine($"ID: {content.Title}");
            Console.WriteLine($": {content.Description}");
        }
        private void SeedContentList()
        {
            badge movieOne = new StreamingContent("Jaws", "Fish eats man", 3.5, MaturityRating.R, GenreType.Horror);
            Badge movieTwo = new StreamingContent("Interstellar", "space and stuff", 4.0, MaturityRating.PG_13, GenreType.Thriller);
            _streamingRepo.AddContentToDirectory(movieOne);
            _streamingRepo.AddContentToDirectory(badgeTwo);
        }
    }
}
