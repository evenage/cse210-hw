class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Getter for the reference
    public Reference GetReference() => _reference;

    // Method to hide random words
    public void HideRandomWords(int count)
    { var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        var random = new Random();

        for (int i = 0; i < count && visibleWords.Any(); i++)
        {
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }
    }

    // Check if all words are hidden
    public bool AllWordsHidden() => _words.All(w => w.IsHidden());

    // Get the scripture text for display
    public string GetScriptureText()
    {
        var scriptureText = string.Join(" ", _words);
        return $"{_reference}\n{scriptureText}";
    }
}

    






