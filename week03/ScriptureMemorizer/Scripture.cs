// Class representing the scripture

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    // Initializes a scripture with a reference and text, splitting the text into words
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Displays the scripture reference and the words, hiding those that are marked as hidden
    public void Display()
    {
        Console.WriteLine(_reference.ToString());
        foreach (var word in _words)
        {
            Console.Write(word.ToString() + " ");
        }
    }

    // Hides a specified number of random words in the scripture
    public void HideRandomWords(int count)
    {
        var visibleWords = _words.Where(w => !w.IsHidden).ToList();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            var wordToHide = visibleWords[_random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }
    }

    // Checks if all words in the scripture are hidden
    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden);
    }
}
