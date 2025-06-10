using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Assignment class
        Assignment myAssignment = new Assignment("Sunday Idowu", "Mathematics");

        Console.WriteLine(myAssignment.GetSummary());

        // Just a blankline for better readability
        Console.WriteLine();

        // Test the MathAssignment class
        MathAssignment MathAssignment = new MathAssignment("Sunday Idowu", "Mathematics", "Section 7.3", "Problems 1-10");

        Console.WriteLine(MathAssignment.GetSummary());
        Console.WriteLine(MathAssignment.GetHomeworkList());

        Console.WriteLine();

        // Test the WritingAssignment class
        WritingAssignment WritingAssignment = new WritingAssignment("Sunday Idowu", "English", "The Art of Programming");

        Console.WriteLine(WritingAssignment.GetSummary());

        Console.WriteLine(WritingAssignment.GetWritingInformation());
    }
    
}