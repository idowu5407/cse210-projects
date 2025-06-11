using System;


public class ListingActivity : Activity
{
    // The Listing activity that prompts the user to list items on a random prompt.
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
    // The method that executes the listing activity.
    public void Run()
    {
        StartActivity();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.WriteLine("You will have a moment to think before listing items...");
        Countdown(5);

        Console.WriteLine("Begin listing items! Press Enter after each item:");

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

        Console.WriteLine($"\nYou listed {itemCount} items.");
        EndActivity();
    }
}