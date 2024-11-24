using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Create scripture example
        var reference = new Reference("Proverbs", 3, 5, 6);
        var scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to Him, and He will make your paths straight.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScriptureText());

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Well done!");
                break;
            }
                 Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
            var input = Console.ReadLine();
            if (input?.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // Hide 3 random words
        }
    }
}
