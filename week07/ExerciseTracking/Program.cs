using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 11, 3), 34, 4.8),
            new Cycling(new DateTime(2025, 11, 3), 30, 9.7),
            new Swimming(new DateTime(2025, 11, 3), 20, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

abstract class Activity
{
    public DateTime Date { get; }
    public int Duration { get; } // in minutes

    public Activity(DateTime date, int duration)
    {
        Date = date;
        Duration = duration;
    }

    public abstract string GetSummary();
}

class Running : Activity
{
    public double Distance { get; } // in kilometers

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        Distance = distance;
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Running ({Duration} min): Distance {Distance} km";
    }
}

class Cycling : Activity
{
    public double Speed { get; } // in kph

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        Speed = speed;
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Cycling ({Duration} min): Speed {Speed} kph";
    }
}

class Swimming : Activity
{
    public int Laps { get; }

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        Laps = laps;
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Swimming ({Duration} min): Laps {Laps}";
    }
}