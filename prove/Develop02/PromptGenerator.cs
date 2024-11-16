public class PromptGenerator
{
    public  List<string> _prompts = new()
    {
        "What's one thing you're grateful for today?",
        "What was a highlight of your day?",
        "What's something you learned today?",
        "What's a goal you're working towards?",
        "How did you practice self-care today?"
    };
    public Random _random = new Random();
 
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    
    }
}