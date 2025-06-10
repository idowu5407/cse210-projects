using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Assignment class
        Assignment myAssignment = new Assignment("Sunday Idowu", "Mathematics");

        // Call the GetStudentName method
        string summary = myAssignment.GetStudentName();

        // Display the summary to the screen
        Console.WriteLine(summary);
    }
}