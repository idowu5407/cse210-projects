using System;

class Program
{
    static void Main(string[] args)
    { 
        // Prompt the user for their grade percentage
        Console.Write("Please enter your grade percentage:");
        // Read the input from the user
        string input = Console.ReadLine();
        // Convert the input to an integer 
        int grade = int.Parse(input);

        
        // Determine the letter grade
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
           letter = "C";
        }
        else if (grade >= 60)
        {
           letter = "D";
        }
        else if (grade <= 60)
        {
            letter = "F";

            // Print letter grade to the user
            Console.WriteLine($"Your letter grade is: {letter}");
        }
        //Determine if the user passed or failed
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you passed the course!");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep working hard and try again next time.");
        }
    }
}