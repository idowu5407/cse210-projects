// Class representing a scripture reference
class Reference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int VerseStart { get; private set; }
    public int? VerseEnd { get; private set; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verse;
        VerseEnd = null;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verseStart;
        VerseEnd = verseEnd;
    }

    public static Reference Parse(string referenceStr)
    {
        var parts = referenceStr.Split(' ');
        string book = parts[0];
        string[] verseParts = parts[1].Split(':');
        int chapter = int.Parse(verseParts[0]);

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

    public override string ToString()
    {
        return VerseEnd.HasValue
            ? $"{Book} {Chapter}:{VerseStart}-{VerseEnd}"
            : $"{Book} {Chapter}:{VerseStart}";
    }
}

