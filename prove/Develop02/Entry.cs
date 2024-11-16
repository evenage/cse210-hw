public class Entry
{
    public string _dateText;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        _dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine($"Date: {_dateText} - Prompt: {_promptText} {_entryText}");
    }


public void UpdatePrompt(string newPrompt) 
   {        
    _promptText = newPrompt;
    }     
    public void UpdateEntryText(string newEntryText) 
     {  
         _entryText = newEntryText;
     }


    public string ToFile(){
        return $"{_dateText}****{_promptText}****{_entryText}";
    }
}