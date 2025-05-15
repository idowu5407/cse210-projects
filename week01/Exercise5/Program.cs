using System;

class Program
{
    static void Main(string[] args)
        {
            // Call the WelcomeMessage method
            WelcomeMessage();
            
            // Prompt the user for their name
            string userName = PromptUserName();
            
            // Prompt the user for their favorite number
            int favoriteNumber = PromptUserNumber();
            
            // Calculate the square of the favorite number
            int squaredNumber = Square(favoriteNumber);
            
            // Display the result
            DisplayResult(userName, squaredNumber);
        }
        // Display a welcome message
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }
    
        // Prompt the user for name 
        static string PromptUserName()
        {
            Console.Write("Please enter your name:");
            return Console.ReadLine();
        }
        
        // Prompt the user for favorite number
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number:");
            return int.Parse(Console.ReadLine());
        }
        
        // Accepts an interger as a parameter and returns the square of that number
        static int Square(int number)
        {
            return number * number;
        }
        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"Hello {userName}, the square of your favorite number is: {squaredNumber}");
        }
       
    
}