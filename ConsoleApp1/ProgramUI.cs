using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProgramUI
    {

        private readonly MenuRepo _menuRepo = new MenuRepo();


        public void Run()
        {
            //SeedContentList();
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Hello! Welcome to your application! \n" +
               "Here is where you can create and interact with a  list of your favorite menu items and ingredients \n" +
               "Enter the number of the option you would like to select: \n" +
               "1. Show all menu items \n" +
               "2. Find streaming content by title \n" +
               "3. Add new item to the menu\n" +
               "4. Remove streaming content \n" +
               "5. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //show all
                        //GetAllItems();
                        break;
                    case "2":
                        //find by title
                        ShowContentByTitle();
                        break;
                    case "3":
                        //add new
                        CreateNewContent();
                        break;
                    case "4":
                        //remove
                        //RemoveContentFromList();
                        break;
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
        private void CreateNewContent()
        {
            //StreamingContent content = new StreamingContent();
            //the user is going to have to create this streaming content object 
            //Title
            Console.WriteLine("Time to add your streaming content to your collection. \n" +
                "Let's get started! \n" +
                "Please enter the title of the content: ");
            //content.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Please enter the description: ");
            //content.Description = Console.ReadLine();

            //StarRating
            Console.WriteLine("Please enter the star rating (1-5): ");
            string starRatingInput = Console.ReadLine();
            //try catch
            //allow your application to capture an error and instead of breaking move on
            try
            {
                //content.StarRating = double.Parse(starRatingInput);
            }
            catch
            {
                Console.WriteLine("Sorry. You need to enter in a valid decimal.");
            }
            //MaturityRating
            Console.WriteLine("Please select a maturity rating (1-7): \n" +
                "1. G \n" +
                "2. PG \n" +
                "3. PG_13 \n" +
                "4. R \n" +
                "5. NC_17 \n" +
                "6. TV_MA \n" +
                "7. NR");
            string maturityString = Console.ReadLine();
            switch (maturityString.ToUpper())
            {
                //case "1":
                //case "G":
                //    content.MaturityRating = MaturityRating.G;
                //    break;
                //case "2":
                //case "PG":
                //    content.MaturityRating = MaturityRating.PG;
                //    break;
                //case "3":
                //case "PG_13":
                //    content.MaturityRating = MaturityRating.PG_13;
                //    break;
                //case "4":
                //case "R":
                //    content.MaturityRating = MaturityRating.R;
                //    break;
                //case "5":
                //case "NC_17":
                //    content.MaturityRating = MaturityRating.NC_17;
                //    break;
                //case "6":
                //case "TV_MA":
                //    content.MaturityRating = MaturityRating.TV_MA;
                //    break;
                //case "7":
                //case "NR":
                //    content.MaturityRating = MaturityRating.NR;
                //    break;
                default:
                    Console.WriteLine("Please enter in a valid number between 1-7.");
                    break;
            }
            //TypeOfGenre
            Console.WriteLine("Please select a Genre (1-8): \n" +
                "1. Horror \n" +
                "2. Thriller \n" +
                "3. Mockumentary \n" +
                "4. RomCom \n" +
                "5. Romance \n" +
                "6. Drama \n" +
                "7. Action \n" +
                "8. Comedy");
            string genreInput = Console.ReadLine();
            try
            {
                int genreID = int.Parse(genreInput);
                //content.TypeOfGenre = (GenreType)genreID;
            }
            catch
            {
                Console.WriteLine("Please enter in a valid number bewteen 1-8.");
            }
            //AddContentToDirectory take in streaming content object and add it to my collection
            //_streamingRepo.AddContentToDirectory(content);
        }
        private void ShowAllContent()
        {
            //List<StreamingContent> listOfContent = _streamingRepo.GetAllContents();

            //foreach (StreamingContent contentVariable in listOfContent)
            //{
            //    DisplayContent(contentVariable);
            //    Console.WriteLine("----------------------------------------------");
            //}
            //Console.WriteLine("Press any key to continue...");
            //Console.ReadKey();
        }
        private void ShowContentByTitle()
        {
            Console.Clear();
            Console.WriteLine("Enter a title");
            string title = Console.ReadLine();
            //    StreamingContent foundTitle = _streamingRepo.GetContentByTitle(title);
            //    if (foundTitle != null)
            //    {
            //        DisplayContent(foundTitle);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid title. Cound not find any results.");
            //    }
            //    Console.WriteLine("Press any key to continue");
            //    Console.ReadKey();
            //}
            //private void RemoveContentFromList()
            {
                //Console.WriteLine("Which item would you like to remove?");
                //List<StreamingContent> contentList = _streamingRepo.GetAllContents();
                //int count = 0;
                //foreach (StreamingContent content in contentList)
                //{
                //    count++;
                //    Console.WriteLine($"{count}. {content.Title}");
                //}

                int targetContentId = int.Parse(Console.ReadLine());
                int targetIndex = targetContentId - 1;
                //if (targetIndex >= 0 && targetIndex < contentList.Count)
                {
                    //StreamingContent desiredContent = contentList[targetIndex];
                    //if (_streamingRepo.DeleteExistingContent(desiredContent))
                    //{
                    //    Console.WriteLine($"{desiredContent.Title} successfully removed.");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");
                    //}
                }
                //else
                {
                    Console.WriteLine("No content has that ID");
                }
                Console.WriteLine("Press any key to continue....");
                Console.ReadKey();
            }
            //private void DisplayContent(StreamingContent content)
            //{
            //    Console.WriteLine($"Title: {content.Title}");
            //    Console.WriteLine($"Description: {content.Description}");
            //}
            // private void SeedContentList()
            {
                //StreamingContent movieOne = new StreamingContent("Jaws", "Fish eats man", 3.5, MaturityRating.R, GenreType.Horror);
                //StreamingContent movieTwo = new StreamingContent("Interstellar", "space and stuff", 4.0, MaturityRating.PG_13, GenreType.Thriller);
                //_streamingRepo.AddContentToDirectory(movieOne);
                //_streamingRepo.AddContentToDirectory(movieTwo);
            }
        }
    }
}
