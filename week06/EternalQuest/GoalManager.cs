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
                    Console.WriteLine("Create New Goal");

                    break;

                case "2":
                    Console.WriteLine("List Goals");
                    break;

                case "3":
                    Console.WriteLine("Save Goals");
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

    public void ListGoalNames()
    {
        Console.WriteLine("\nGoal Names:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {

    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}