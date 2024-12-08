using System;

class Program
{
    static void Main(string[] args)
    
    {
        // Breathing Activity
        Console.WriteLine("Starting Breathing Activity:");
        BreathingActivity breathingActivity = new BreathingActivity(10); // 10 seconds duration
        breathingActivity.Run();

        // Reflection Activity
        Console.WriteLine("\nStarting Reflection Activity:");
        List<string> reflectionPrompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult."
        };
        List<string> reflectionQuestions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?"
        };
        ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", 
            "This activity will help you reflect on past experiences by asking deep questions.", 
            30, // 30 seconds duration
            reflectionPrompts,
            reflectionQuestions);
        reflectionActivity.Run();

        // Listing Activity
        Console.WriteLine("\nStarting Listing Activity:");
        List<string> listingPrompts = new List<string>
        {
            "Who are people you appreciate?",
            "What are your personal strengths?"
        };
        ListingActivity listingActivity = new ListingActivity("Listing Activity", 
            "This activity will help you list things you're grateful for.", 
            20, // 20 seconds duration
            5, // Number of items to list
            listingPrompts);
        listingActivity.Run();
    }
}