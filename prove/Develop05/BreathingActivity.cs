using System;

public class BreathingActivity : Activity
{
    // Constructor to initialize the BreathingActivity with a duration
    public BreathingActivity(int duration)
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
    {
    }

    // Override the Run method to handle the breathing activity
    public void Run()
    {
        DisplayStartingMessage();

        int elapsedTime = 0;
        DateTime startTime = DateTime.Now;

        // Breathing exercise logic
        while (elapsedTime < GetDuration())
        {
            // Breathe in
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);  // Show countdown for breathing in
            elapsedTime = (int)(DateTime.Now - startTime).TotalSeconds;

            if (elapsedTime >= GetDuration()) break;

            // Breathe out
            Console.WriteLine("Breathe out...");
            ShowCountDown(4);  // Show countdown for breathing out
            elapsedTime = (int)(DateTime.Now - startTime).TotalSeconds;
        }

        DisplayEndingMessage();
    }
}
