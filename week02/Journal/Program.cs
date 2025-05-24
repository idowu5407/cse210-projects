using System;


class Program
{
    static void Main(string[] args)
    {
        // Create a new journal instance
        Journal journal = new Journal(); 
        string choice = "";

        while (choice != "5")
        {
            // Display the user menu
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Select an option (1-5): ");
            choice = Console.ReadLine();

            // Perform the action based on user choice
            switch (choice)
            {
                    // Add a new journal entry
                case "1":
                    journal.AddEntry(); 
                    break;

                    // Show all entries
                case "2":
                    journal.DisplayEntries(); 
                    break;

                    // Save to file
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile); 
                    break;
                
                    // Load from file
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile); 
                    break;

                    // Exit the program
                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a number 1-5.");
                    break;
            }
        }
    }
}