using System;

class Program
{
    static void Main(string[] args)
    {
        // Play again variable
        string playAgain = "yes";
        while (playAgain.ToLower() == "yes")
        {
            // Generate a random number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            // Ask for the magic number and user's guess
            Console.Write("What is the magic number? ");
            magicNumber = int.Parse(Console.ReadLine());
            
            // Loop until the user guesses the number
            int guess = -1;

            // Track the number of guesses
            int guesCount = 0;
            while (guess != magicNumber)
            {
                // Ask for the user's guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guesCount++;

                // Compare the guess to the magic number
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");    
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guesCount} guesses.");
                }
            }
                    // Ask if the user wants to play again
                     Console.Write("Do you want to play again? (yes/no) ");
                    playAgain = Console.ReadLine();
        }
                  Console.WriteLine("Thank you for playing!");
                       
    }
}