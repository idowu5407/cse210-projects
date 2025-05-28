// Class representing a scripture reference
class Reference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int VerseStart { get; private set; }
    public int? VerseEnd { get; private set; }

    
    // Initializes a scripture reference with a book, chapter, and verse.
    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verse;
        VerseEnd = null;
    }

    // Constructor for a range of verses
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verseStart;
        VerseEnd = verseEnd;
    }

    
    // Parses a scripture reference string into a Reference object.
    public static Reference Parse(string referenceStr)
    {
        var parts = referenceStr.Split(' ');
        string book = parts[0];
        string[] verseParts = parts[1].Split(':');
        int chapter = int.Parse(verseParts[0]);

        // Check if the verse part contains a range or a single verse
        if (verseParts[1].Contains('-'))
        {
            var range = verseParts[1].Split('-');
            return new Reference(book, chapter, int.Parse(range[0]), int.Parse(range[1]));
        }
        else
        {
            return new Reference(book, chapter, int.Parse(verseParts[1]));
        }
    }

    // Returns a string representation of the scripture reference.
    public override string ToString()
    {
        return VerseEnd.HasValue
            ? $"{Book} {Chapter}:{VerseStart}-{VerseEnd}"
            : $"{Book} {Chapter}:{VerseStart}";
    }
}

