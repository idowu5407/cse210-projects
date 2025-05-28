using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = LoadScriptures("scriptures.txt");
        Random rand = new Random();
        Scripture selectedScripture = scriptures[rand.Next(scriptures.Count)];

        while (!selectedScripture.AllWordsHidden())
        {
            Console.Clear();
            selectedScripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                return;

            selectedScripture.HideRandomWords(3); // Hide 3 random words
        }

        // Final display when all words are hidden
        Console.Clear();
        selectedScripture.Display();
        Console.WriteLine("\nAll words hidden. Press Enter to exit.");
        Console.ReadLine();
    }

    // Load scriptures from a file
    static List<Scripture> LoadScriptures(string filename)
    {
        List<Scripture> scriptures = new List<Scripture>();
        foreach (var line in File.ReadAllLines(filename))
        {
            var parts = line.Split('|');
            if (parts.Length == 2)
            {
                Reference reference = Reference.Parse(parts[0].Trim());
                scriptures.Add(new Scripture(reference, parts[1].Trim()));
            }
        }
        return scriptures;
    }
}
