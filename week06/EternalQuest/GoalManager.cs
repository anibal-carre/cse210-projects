public class GoalManager
{
    private List<Goal> _goals = [];
    private int _score;


    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            Console.WriteLine();


            switch (choice)
            {
                case "1":
                    CreateGoal();

                    break;

                case "2":
                    ListGoals();
                    break;

                case "3":
                    SaveGoals();
                    break;

                case "4":
                    Console.WriteLine("Load Goals");
                    break;

                case "5":
                    Console.WriteLine("Record Event");
                    break;

                case "6":
                    return;

                default:
                    Console.Write("Invalid Choice");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string typeChoice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        switch (typeChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }

    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to save.");
            return;
        }
        Console.Write("What is the filename for the goal file ");
        string fileName = Console.ReadLine();

        using StreamWriter outputFile = new(fileName);
        outputFile.WriteLine(_score);
        foreach (var goal in _goals)
        {
            outputFile.WriteLine(goal.GetStringRepresentation());
        }

    }

    public void LoadGoals()
    {

    }
}