using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        string positive = "+";
        string negative = "-";
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (percent % 10 >= 7 && percent < 97 && percent > 60 )
        
        {
            Console.WriteLine($"Your grade is: {letter}{positive}");
        }
        else if  (percent % 10 <= 3 && percent < 97 && percent > 60 )
        
        {
            Console.WriteLine($"Your grade is: {letter}{negative}");
        }
        else {
            Console.WriteLine($"Your grade is: {letter}");
        }



    if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}