using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2, where the user specified the number...
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        // For Part 3, where we use a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int numTries = 0;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            numTries++;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"it took you {numTries} tries");
                Console.Write("would you want to play a game? press Y to continue and N to end the game: ");
                string input = Console.ReadLine().ToLower();
                if (input == "y"){
                    magicNumber = randomGenerator.Next(1, 101);
                    continue;
                }
                else {
                    Console.WriteLine("Thank you, see you next time.");
                }
            }
        }                    
    }
}