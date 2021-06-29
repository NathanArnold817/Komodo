using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceDeveloperTeam
{
    public class DeveloperUI
    {
        protected readonly DeveloperRepo _DeveloperRepo = new DeveloperRepo();
        protected readonly DevTeamRepo _DevTeamRepo = new DevTeamRepo();
        static void Main(string[] args)
        {
            DeveloperUI ui = new DeveloperUI();
            ui.Run();
        }


        public void Run()
        {
            SeedContentList();

            DisplayMenu();
        }
        private void DisplayMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine(
                    "Enter the number of the option you would like to select:\n" +
                    "1. View developers \n" +
                    "2. Add a new developer \n" +
                    "3. Add a new team \n" +
                    "4. Update teams \n" +
                    "5. View existing teams \n" +
                    "6. Remove a developer from a team \n" +
                    "7. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ViewDevelopers();
                        break;
                    case "2":
                        AddDeveloper();
                        break;
                    case "3":
                        AddATeam();
                        break;
                    case "4":
                        AddToTeams();
                        break;
                    case "5":
                        ViewDeveloperTeams();
                        break;
                    case "6":
                        RemoveDeveloper();
                        break;
                    case "7":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please select an option between 1 and 7");
                        ReduceRed();
                        break;
                }
            }
        }

        private void ViewDevelopers()
        {
            Console.Clear();
            List<Developer> listOfContent = _DeveloperRepo.GetContents();
            foreach (Developer content in listOfContent)
            {
                DisplayContent(content);
            }
            ReduceRed();
        }
        private void DisplayContent(Developer content)
        {
            Console.WriteLine((content.Name) + "" + (content.Id) + " " + (content.PluralSightAccess));
        }
        private void AddDeveloper()
        {
            Console.Clear();
            Console.Write("Please enter developers name");
            string name = Console.ReadLine();
            Console.Write("Please enter developers Id number");
            string id = Console.ReadLine();
            Console.Write("Does developer have pluralsight access yes or no?");
            string userInput = Console.ReadLine();
            bool pluralSightAccess = false;
            switch (userInput)
            {
                case "Yes":
                    pluralSightAccess = true;
                    break;
                case "No":
                    pluralSightAccess = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection yes or no: ");
                    userInput = Console.ReadLine();
                    break;
            }
            Developer content = new Developer(name, id, pluralSightAccess);
            _DeveloperRepo.AddContentToDirectory(content);
        }
        private void AddATeam()
        {
            Console.Clear();
            Console.Write("What would you like the team name to be? ");
            string teamName = Console.ReadLine();
            Console.Write("What will the teams Id be? ");
            string teamId = Console.ReadLine();
            Console.WriteLine("Whom would you like your first member to be? Enter name ");
            string name = Console.ReadLine();
            Console.WriteLine("What is their Id number? ");
            string id = Console.ReadLine();
            Console.WriteLine("Do they have access to Plural Sight yes or no? ");
            string userInput = Console.ReadLine();
            bool pluralSightAccess = false;
            switch(userInput)
            {
                case "Yes":
                    pluralSightAccess = true;
                    break;
                case "No":
                    pluralSightAccess = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection yes or no: ");
                    userInput = Console.ReadLine();
                    break;


            }
            DevTeam content = new DevTeam(name, id, pluralSightAccess, teamName, teamId);
            _DevTeamRepo.AddContentToDirectory(content);
        }
        private void AddToTeams()
        {
            Console.Clear();
            Console.WriteLine("What team id would you like to add to? ");
            string teamId = Console.ReadLine();
            Console.WriteLine("What is the name of the member you would like to add? ");
            string name = Console.ReadLine();
            Console.WriteLine("What is there unique id number? ");
            string id = Console.ReadLine();
            Console.WriteLine("Do they have access to Plural Sight? Yes or no. ");
            string userInput = Console.ReadLine();
            bool pluralSightAccess = false;
            switch (userInput)
            {
                case "Yes":
                    pluralSightAccess = true;
                    break;
                case "No":
                    pluralSightAccess = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection yes or no: ");
                    userInput = Console.ReadLine();
                    break;


            }
            Console.WriteLine("What is the name of team you would like to add them to? ");
            string teamName = Console.ReadLine();

            DevTeam content = new DevTeam(name, id, pluralSightAccess, teamName, teamId);
            _DevTeamRepo.AddContentToDirectory(content);
        }
        private void ViewDeveloperTeams()
        {
            Console.Clear();
            List<DevTeam> listOfContent = _DevTeamRepo.GetContents();
            foreach (DevTeam content in listOfContent)
            {
                DisplayContent(content);
            }
            ReduceRed();
        }
        private void DisplayContent(DevTeam content)
        {

            Console.WriteLine((content.TeamName) + " " + (content.TeamId));
            Console.WriteLine((content.DeveloperName) + " " + (content.DeveloperId));
        }
        private void ReduceRed()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void SeedContentList()
        {
            Developer mikeJones = new Developer("Mike Jones", "9021", true);
            Developer hartleyRathaway = new Developer("Hartley Rathaway", "9023", true);
            Developer bruceSpringstein = new Developer("Bruce Springstein", "9024", true);

            _DeveloperRepo.AddContentToDirectory(mikeJones);
            _DeveloperRepo.AddContentToDirectory(hartleyRathaway);
            _DeveloperRepo.AddContentToDirectory(bruceSpringstein);
        }
        private void RemoveDeveloper()
        {
            Console.Clear();
            Console.WriteLine("Who would you like to remove? enter id: ");
            string userInput = Console.ReadLine();
            _DevTeamRepo.RemoveDeveloper(userInput);
        }
    }
}



