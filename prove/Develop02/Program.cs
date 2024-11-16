using System;

class Program
{
    static void Main(string[] args)
    {
         Journal journal = new Journal();
         PromptGenerator promptGenerator = new PromptGenerator();

         
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        bool run = true;
        while (run)
        {
            journal.ShowMenu();
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(promptText);
                    string response = Console.ReadLine();
                    Entry newEntry = new Entry();
                    newEntry._dateText = dateText;
                    newEntry._promptText = promptText;
                    newEntry._entryText = response;
                    journal.AddEntry(newEntry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.Write("Enter the filename: ");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                    break;
                case 4:
                    Console.Write("Enter the filename: ");
                    string filenameload = Console.ReadLine();
                    journal.LoadFromFile(filenameload);
                    break;
                case 5:
                    Console.WriteLine("Enter the entry number to edit");
                    if (int.TryParse(Console.ReadLine(), out int entryIndex))
                    { 
                        journal.EditEntry(entryIndex - 1);        
                    } else { 
                        Console.WriteLine("Invalid number.");
                    }
 
                    break;
                case 6:
                    run = false;
                    Console.WriteLine("See you soon");
                    break;
                default:
                    Console.WriteLine("invalid choice choose another number");
                    break;
    }
}
    }
}