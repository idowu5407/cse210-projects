// Class representing an individual word in scripture
class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool IsHidden => _isHidden;

    public void Hide()
    {
        _isHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? new string(' ', _text.Length) : _text;
    }
}

