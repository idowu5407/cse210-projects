using System;

// Represents a single journal entry with a date, prompt, and response.
public class JournalEntry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    // Constructor sets the prompt and response, and automatically sets the current date
    public JournalEntry(string prompt, string response)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        Prompt = prompt;
        Response = response;
    }

    // Display format for journal entry
    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }

    // Converts the entry into a single line string format for saving to file
    public string ToFileFormat()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    // Recreates an entry from a line of text from file
    public static JournalEntry FromFileFormat(string line)
    {
        var parts = line.Split('|');
        return new JournalEntry(parts[1], parts[2]) { Date = parts[0] };
    }
}