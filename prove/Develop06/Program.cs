using System;

class Program
{
    static void Main(string[] args)
    {
        //GoalManager goalManager1 = new GoalManager();
        //goalManager1.DisplayPlayerInfo();


         GoalManager goalManager = new GoalManager();
        goalManager.Start();

        GoalManager goalManager1 = new GoalManager();
        goalManager1.LoadGoals();

        
        while (true)  // Menu loop
        {
            // Display menu options
            Console.Clear();  // Clear the console screen for a clean display
            Console.WriteLine("Welcome to Eternal Quest!");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List  Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create New Goal");
            Console.WriteLine("5. Record an Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");
            Console.Write("\nPlease select an option: ");

            // Read user input and execute the corresponding action
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    goalManager.DisplayPlayerInfo();
                    break;

                case "2":
                    goalManager.ListGoalNames();
                    break;

                case "3":
                    goalManager.ListGoalDetails();
                    break;

                case "4":
                    goalManager.CreateGoal();
                    break;

                case "5":
                    goalManager.RecordEvent();
                    break;

                case "6":
                    goalManager.SaveGoals();
                    break;
                case "7":
                    goalManager.LoadGoals();
                    break;

                case "8":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;  // Exit the loop and end the program

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

        }
    }
}