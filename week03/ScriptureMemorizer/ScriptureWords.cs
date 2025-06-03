// Class representing an individual word in scripture
class Word
{
    // Represents a word in the scripture, which can be hidden or displayed
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Property to get the text of the word
    public bool IsHidden => _isHidden;

    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    public override string ToString()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}

