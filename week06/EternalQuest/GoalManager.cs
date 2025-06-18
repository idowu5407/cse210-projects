using System; 
using System.Collections.Generic; 
using System.IO;

class GoalManager
{
    // Manages the goals in the Eternal Quest game, allowing creation, listing, recording events, saving/loading, and deleting goals.
    private List<Goal> _goals; private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    // Starts the goal management system, displaying the menu and handling user input
    public void Start()
    {
        string choice;
        do
        {
            Console.Clear();
            Console.WriteLine($"Score: {_score} | Level: {GetLevel()}\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Delete Goal");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": DeleteGoal(); break;
            }
        } while (choice != "7");
    }

    private int GetLevel() => _score / 500;

    private void CreateGoal()
    {
        // Prompts the user to create a new goal, allowing them to choose the type and enter details
        Console.WriteLine("The types of Goals are: \n1. Simple \n2. Eternal \n3. Checklist");
        Console.Write("What type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of the goal? "); string name = Console.ReadLine();
        Console.Write("Give short description of your goal: "); string desc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? "); int pts = int.Parse(Console.ReadLine());

        Goal goal = null;
        if (type == "1") goal = new SimpleGoal(name, desc, pts);
        else if (type == "2") goal = new EternalGoal(name, desc, pts);
        else if (type == "3")
        {
            Console.Write("Target Count: "); int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus: "); int bonus = int.Parse(Console.ReadLine());
            goal = new ChecklistGoal(name, desc, pts, target, bonus);
        }

        if (goal != null) _goals.Add(goal);
    }

    // Lists all goals with their details, showing whether they are complete or not
    private void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        
      
    }

    // Records an event for a specific goal, updating the score based on the points earned
    private void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("\nEnter goal number to record: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            int earned = _goals[index].RecordEvent();
            _score += earned;
            Console.WriteLine($"You earned {earned} points!");
        }
        else Console.WriteLine("Invalid goal number.");
        
        
    }

    // Saves the current goals and score to a file, allowing for persistence between sessions
    private void SaveGoals()
    {
        Console.Write("Enter filename to save to: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
                writer.WriteLine(goal.GetStringRepresentation());
        }
    }

    // Loads goals and score from a file, allowing the user to continue from a previous session
    private void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _goals.Clear();
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];

                if (type == "SimpleGoal")
                {
                    var g = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (bool.Parse(parts[4]))
                    {
                        g.RecordEvent();
                    }
                    _goals.Add(g);
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if (type == "ChecklistGoal")
                {
                    var g = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                    for (int x = 0; x < int.Parse(parts[6]); x++)
                    {
                        g.RecordEvent();
                    }
                    _goals.Add(g);
                }
            }

            Console.WriteLine("Goals loaded successfully.");
            ListGoalDetails();
        }
        else
        {
            Console.WriteLine("File not found.");
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    // Deletes a goal by its index, allowing the user to remove goals they no longer want to track
    private void DeleteGoal()
    {
        ListGoalDetails();
        Console.Write("Enter goal number to delete: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            Console.WriteLine($"Deleting: {_goals[index].GetName()}");
            _goals.RemoveAt(index);
        }
        else Console.WriteLine("Invalid number.");
        
    }

}