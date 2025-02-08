public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = [];
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();
        SetDuration();

        Console.WriteLine("Get ready...");
        Console.WriteLine();
        ShowSpinner(5);

        Console.WriteLine("List as many responses you can to the following prompt: ");

        GetRamdomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);

        List<string> userResponsesList = GetListFromUser();
        _count = userResponsesList.Count;

        Console.WriteLine($"You listed {_count} items");
        Thread.Sleep(1000);

        DisplayEndingMessage();
        ShowSpinner(5);
    }

    public void GetRamdomPrompt()
    {
        Random random = new();
        int randomNumber = random.Next(0, _prompts.Count);
        string prompt = _prompts[randomNumber];
        Console.WriteLine($"--- {prompt} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = [];

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string userResponse = Console.ReadLine();
            userList.Add(userResponse);

        }
        return userList;
    }
}