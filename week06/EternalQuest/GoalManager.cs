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
                    LoadGoals();
                    break;

                case "5":
                    RecordEvent();
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
            string checkbox = _goals[i].IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {checkbox} {_goals[i].GetDetailsString()}");
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
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record an event.\n");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < _goals.Count)
        {
            Goal selectedGoal = _goals[goalNumber];
            selectedGoal.RecordEvent();

            if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.GetBonus() + checklistGoal.GetBonus();
            }
            else
            {
                _score += int.Parse(selectedGoal.GetPoints());
            }

            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal.");
        }
    }

    public void SaveGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to save.");
            return;
        }
        Console.Write("What is the filename for the goal file? ");
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
        Console.Write("What is the filename for goal file? ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            _score = int.Parse(lines[0]);

            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                if (parts.Length < 2)
                {
                    continue;
                }

                string type = parts[0];
                string[] details = parts[1].Split(',');

                try
                {
                    switch (type)
                    {
                        case "SimpleGoal":
                            if (details.Length >= 4)
                            {
                                bool isComplete = bool.Parse(details[3]);
                                _goals.Add(new SimpleGoal(details[0], details[1], details[2], isComplete));
                            }
                            else
                            {
                                Console.WriteLine($"Error in Simple Goal");
                            }
                            break;

                        case "EternalGoal":
                            if (details.Length >= 3)
                            {
                                _goals.Add(new EternalGoal(details[0], details[1], details[2]));
                            }
                            else
                            {
                                Console.WriteLine($"Error in Eternal Goal");
                            }
                            break;

                        case "ChecklistGoal":
                            if (details.Length >= 6)
                            {
                                int bonus = int.Parse(details[3]);
                                int target = int.Parse(details[4]);
                                int timesCompleted = int.Parse(details[5]);
                                _goals.Add(new ChecklistGoal(details[0], details[1], details[2], bonus, target, timesCompleted));
                            }
                            else
                            {
                                Console.WriteLine($"Error in Checklist Goal");
                            }
                            break;

                        default:
                            Console.WriteLine($"Error in line {i}: ({type}).");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in line {i}: {ex.Message}");
                }
            }
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}