using System;
using System.Threading;

// This code defines a base class for activities 
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor 
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    // Method to start the activity
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"\nWelcome to {_name}\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

    // Display a countdown 
        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }
    // Method to end the activity.
    public void EndActivity()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }
    // Method to display a spinner animation 
    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(600);
            Console.Write("\b \b");
            i = (i + 1) % spinner.Length;
        }
    }
    // Countdown method
    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}