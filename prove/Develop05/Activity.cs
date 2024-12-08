using System.Runtime.CompilerServices;

public class Activity
{
    private string _name;
    private int _duration;
    private string _description;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _duration = duration;
        _description = description;

    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine("Welcome to the {_name}.");
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
          Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }
    


    public void ShowSpinner(int seconds)
    {
        for(int i = 0; i< seconds; i ++)
        {
            Console.WriteLine("\rLoading...");
            Console.Write(".");
            Thread.Sleep(3000);
        }
         Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for(int i = seconds; i >= 0; i--)
        {
            Console .WriteLine("\rTime remaining:" + i +"seconds");
            Thread.Sleep(3000);
        }
        Console.WriteLine("\n");

    }

     public int GetDuration()
    {
        return _duration;
    }

}