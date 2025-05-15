using System;
using System.Collections.Generic;
// This program prompts the user to enter a list of numbers, calculates the sum, average, and largest number,
// and also finds the smallest positive number and sorts the list of numbers.
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store numbers entered by the user
        List<int> numbers = new List<int>();
        int input;

        // Prompt user to enter numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // loop to read numbers until 0 is entered
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            // Add the number to the list if it's not 0
            if (input != 0)
            {
                numbers.Add(input);
            }
            // If 0 is entered, exit the loop
        } while (input != 0);

        // Calculate the sum, average, and largest number
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        // Display the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Get the positive numbers and find the smallest positive number
        var positiveNumbers = numbers.Where(n => n > 0).ToList();

        // Check if there are any positive numbers
        if (positiveNumbers.Count > 0)
        {
            int smallestPositive = positiveNumbers.Min();
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // Sort the list of numbers
        numbers.Sort();

        // Display the sorted list
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}