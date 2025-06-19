using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        DateTime today = DateTime.Now.Date;

        List<Activity> activities = new List<Activity>
        {
            new Running(today, 30, 4.8),
            new Cycling(today, 30, 9.7),
            new Swimming(today, 30, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}