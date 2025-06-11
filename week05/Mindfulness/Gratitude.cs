using System;


public class GratitudeActivity : Activity
{
    // The Gratitude activity prompts user to list things they are grateful for.
    public GratitudeActivity() 
    : base("Gratitude Activity",
        "This activity will help you cultivate gratitude by listing things you are thankful for.")
    {
    }
    // The Run method executes the gratitude activity
    public void Run()
    {
        StartActivity();

        Console.WriteLine("\nBegin listing things you are grateful for! Press Enter after each one:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                itemCount++;
            }
        }

        Console.WriteLine($"\nYou listed {itemCount} things you are grateful for.");
        EndActivity();
    }
}