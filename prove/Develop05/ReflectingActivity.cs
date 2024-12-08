using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;

    public ReflectionActivity(string name, string description, int duration, List<string> prompts, List<string> questions)
        : base(name, description, duration)
    {

        _prompts = prompts;
        _questions = questions;
        
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        _random = new Random();
    }

    public void ReflectingActivity()
    {
        DisplayPrompt();
        DisplayQuestions();
    }

    public void Run()
    {
        // Display starting message
        DisplayStartingMessage();
        Console.WriteLine();

        // Run the reflecting activity
        ReflectingActivity();

        // Display ending message
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        // Select and display a random prompt
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        // Countdown before starting reflection
        Console.WriteLine("Get ready to reflect...");
        ShowCountDown(3);
    }

    public void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"\nReflect on this: {question}");
            ShowSpinner(5); // Pause for 5 seconds to reflect
        }
    }
}
