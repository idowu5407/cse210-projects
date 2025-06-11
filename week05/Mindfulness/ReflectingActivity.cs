using System;


public class ReflectionActivity : Activity
{
    // List contains prompts that will be shown to the user to help them reflect on their experiences.
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    // List of questions that will be asked to the user during the reflection activity.
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?", 
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random _random = new Random();
   
    public ReflectionActivity() : base("Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }
    // The Run method that guiding the user through a series of prompts and questions.
    public void Run()
    {
        StartActivity();

        List<string> usedQuestions = new List<string>(_questions);

        Console.WriteLine("\nCosider this following prompt:");
       
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"\n-- {prompt} --");
        Console.WriteLine("\nWhen you have something in mind press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");

        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        // Loop through the questions, randomly selecting
        while (DateTime.Now < endTime && usedQuestions.Count > 0)
        {
            int index = _random.Next(usedQuestions.Count);
            string question = usedQuestions[index];
            usedQuestions.RemoveAt(index);

            Console.WriteLine($"> {question}");
            ShowSpinner(5);
        }

        EndActivity();
    }
}