using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // List to store journal entries
    private List<JournalEntry> _entries = new List<JournalEntry>();

    // List of prompts to randomly ask the user
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did I learn today?",
        "What was a challenge I faced today and how did I overcome it?",
        "What is something I am grateful for today?",
        "What is a goal I want to achieve this week?",
        "What is something I wish I had done differently today?",
        "What is a new skill I want to learn?",
        "What is a book I want to read and why?",
    };

    // For selecting random prompt
    private Random _random = new Random(); 

    
    // Prompts the user with a random question and stores the response as a new journal entry.
    public void AddEntry()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        // Create and store new entry
        _entries.Add(new JournalEntry(prompt, response)); 
    }

   
    // Displays all journal entries in memory.
    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    // Saves all journal entries to a specified file.
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                // Write each entry in line format
                writer.WriteLine(entry.ToFileFormat()); 
            }
        }
        Console.WriteLine("Journal saved.");
    }

    /// Loads journal entries from a file and replaces current entries.
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

         // Clear current entries before loading
        _entries.Clear();
        foreach (var line in File.ReadAllLines(filename))
        {
            // Add each loaded entry
            _entries.Add(JournalEntry.FromFileFormat(line)); 
        }
        Console.WriteLine("Journal loaded.");
    }
}