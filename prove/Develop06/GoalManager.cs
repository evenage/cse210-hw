using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n1. Display Player Info");
            Console.WriteLine("2. List  Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create New Goal");
            Console.WriteLine("5. Record an Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");

            Console.WriteLine("Enter your choice");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    SaveGoals();
                    break;
                case "7":
                    LoadGoals();
                    break;
                case "8":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine("\nPlayer Information:");
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine($"Number of Goals: {_goals.Count}");
    }


    public void ListGoalNames()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        Console.WriteLine("Goals List:");
        for (int i = 0; i < _goals.Count; i++)
        {
            string completionStatus = _goals[i].IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {completionStatus} {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        Console.WriteLine("Goal Details:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Which type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string goalTypeChoice = Console.ReadLine();
        Goal newGoal = null;

        switch (goalTypeChoice)
        {
            case "1":
                newGoal = CreateSimpleGoal();
                break;
            case "2":
                newGoal = CreateEternalGoal();
                break;
            case "3":
                newGoal = CreateChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine($"Goal '{newGoal.Name}' created successfully!");
        }
        else
        {
            Console.WriteLine("Failed to create goal. Invalid input.");
        }
    }

    private SimpleGoal CreateSimpleGoal()
    {
        Console.Clear();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        return new SimpleGoal(name, description, points);
    }

    private EternalGoal CreateEternalGoal()
    {
        Console.Clear();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        return new EternalGoal(name, description, points);
    }

    private ChecklistGoal CreateChecklistGoal()
    {
        Console.Clear();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("Enter target number of completions: ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus points for completion: ");
        int bonus = int.Parse(Console.ReadLine());

        return new ChecklistGoal(name, description, points, target, bonus);
    }

    public void RecordEvent()
    {
        Console.WriteLine("Enter goal index to record an event:");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            _score += _goals[goalIndex].GetPoints();
            Console.WriteLine($"Event recorded for goal: {_goals[goalIndex].Name}");
            Console.WriteLine($"New score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                sw.WriteLine(goal.GetStringRepresentation());
            }
            Console.WriteLine("Goals have been saved.");
        }
    }

    public void LoadGoals()
    {
        _goals.Clear();
        if (File.Exists("goals.txt"))
        {
            foreach (var line in File.ReadLines("goals.txt"))
            {
                string[] parts = line.Split('|');
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                Goal goal = null;
                if (type == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4]);
                    goal = new SimpleGoal(name, description, points);
                }
                else if (type == "EternalGoal")
                {
                    goal = new EternalGoal(name, description, points);
                }
                else if (type == "ChecklistGoal")
                {
                    int amountCompleted = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    goal = new ChecklistGoal(name, description, points, target, bonus);
                }

                if (goal != null)
                {
                    _goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}

