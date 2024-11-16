using System.Formats.Tar;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

 

    public void AddEntry(Entry newEntry)
    {
        

        _entries.Add(newEntry);
       
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }

        foreach (var entry in _entries)
          {
            entry.Display();
        }

    }

    public void SaveToFile(string filename)
    {
      

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine(entry.ToFile());
                    
                }
            }
            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving journal: " + ex.Message);
        }
    }

    public void LoadFromFile(string filename)
    {
       if (File.Exists(filename))
       {
           try
        {
            _entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                  string[] parts = line.Split("****");
                  if (parts.Length == 3)
                  {
                    Entry entry = new Entry();
                    entry._dateText = parts[0];
                    entry._promptText = parts[1];
                    entry._entryText = parts[2];
                    _entries.Add(entry);

                  }
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading journal: " + ex.Message);
        } 
       }
       else{
        Console.WriteLine("file doesnot exist");
       }

        
    }


 public void ShowMenu()
    {
        Console.WriteLine("Journal Menu:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display journal entries");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Load journal from file");
        Console.WriteLine("5. Edit entry");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
    }


    public void EditEntry(int index)
    {
        if (index < 0 || index >= _entries.Count)
        {
            Console.WriteLine("Invalid entry number.");
            return;
        }
    
        Console.WriteLine("Current Entry:");
        _entries[index].Display();
    
        Console.WriteLine("What would you like to edit?");
        Console.WriteLine("1. Prompt");
        Console.WriteLine("2. Entry Text");
        Console.Write("Choose an option: ");
        string choice = Console.ReadLine();
    
        switch (choice)
        {
            case "1":
                Console.Write("Enter the new prompt: ");
                string newPrompt = Console.ReadLine();
                _entries[index].UpdatePrompt(newPrompt);
                Console.WriteLine("Prompt updated.");
                break;
    
            case "2":
                Console.Write("Enter the new entry text: ");
                string newEntryText = Console.ReadLine();
                _entries[index].UpdateEntryText(newEntryText);
                Console.WriteLine("Entry text updated.");
                break;
    
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

}

