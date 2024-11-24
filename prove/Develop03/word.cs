class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Getters and Setters
    public string GetText() => _text;
    public bool IsHidden() => _isHidden;
    public void Hide() => _isHidden = true;

    public override string ToString()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}