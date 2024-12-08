using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;
    private Random _random;

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) 
        : base(name, description, duration)
    {

        _prompts = prompts;
        _count = count;


        _prompts = new List<string>
        {
            "Who are people you appreciate?",
            "What are your personal strengths?",
            "Who have you helped recently?",
            "Who inspires you?"
        };
        _random = new Random();
    }

    public void Run()
    {
        // Display starting message
        DisplayStartingMessage();
        Console.WriteLine();

        // Select a random prompt
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        // Countdown before starting
        Console.WriteLine("Get ready to list items...");
        ShowCountDown(3);

        // Collect user input
        List<string> responses = GetListFromUser();

        // Display results
        Console.WriteLine($"\nYou listed {responses.Count} items:");
        foreach (var response in responses)
        {
            Console.WriteLine($"- {response}");
        }

        // Display ending message
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        Console.WriteLine("Start listing items (press Enter after each item, and type 'done' to finish early):");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (input?.ToLower() == "done")
                break;

            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }

        return responses;
    }
}



    