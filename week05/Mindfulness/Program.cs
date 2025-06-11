using System;
using System.Collections.Generic;

/*
EXCEEDING REQUIREMENTS:
- I added GratitudeActivity (extra activity)
- I added Keeps log of how many times each activity was performed
- Ensures no duplicate prompts/questions until all used
*/

class Program
{
    // Main Method
    static void Main(string[] args)
    {
        Dictionary<string, int> activityLog = new Dictionary<string, int>()
        {
            { "Breathing Activity", 0 },
            { "Reflection Activity", 0 },
            { "Listing Activity", 0 },
            { "Gratitude Activity", 0 }
        };
        // Main loop for the menu
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Start Gratitude Activity");
            Console.WriteLine("5. View Activity Log");
            Console.WriteLine("6. Quit");

            Console.Write("\nSelect a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                activityLog["Breathing Activity"]++;
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
                activityLog["Reflection Activity"]++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                activityLog["Listing Activity"]++;
            }
            else if (choice == "4")
            {
                GratitudeActivity activity = new GratitudeActivity();
                activity.Run();
                activityLog["Gratitude Activity"]++;
            }
            else if (choice == "5")
            {
                Console.WriteLine("\nActivity Log:");
                foreach (var entry in activityLog)
                {
                    Console.WriteLine($"{entry.Key}: {entry.Value} time(s)");
                }
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to try again.");
                Console.ReadLine();
            }
        }
    }
}