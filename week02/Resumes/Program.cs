using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new Job object
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Tech Corp";
        job1._startDate = 2020;
        job1._endDate = 2025;


        // Create second Job instance
        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._companyName = "Web Solutions";
        job2._startDate = 2018;
        job2._endDate = 2019;

        // Create a new Resume object
        Resume myResume = new Resume();
        myResume._name = "Idowu Sunday";

        // Add jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Access the Display method
        Console.WriteLine("First Job Title: " + myResume._jobs[0]._jobTitle);

        // Display the resume
        myResume.Display();
    }
}