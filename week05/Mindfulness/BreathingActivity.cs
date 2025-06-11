using System;

// This code defines a BreathingActivity class that inherits from the Activity base class.
public class BreathingActivity : Activity
{
    public BreathingActivity() 
    : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    
    }
    // The Run method executes the breathing activity, guiding the user through a series of breathing exercises.
    public void Run()
    {
        StartActivity();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            Countdown(4);

            Console.WriteLine("Now breathe out...");
            Countdown(6);
        }

        EndActivity();
    }
}