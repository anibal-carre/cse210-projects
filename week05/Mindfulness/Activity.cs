public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        Console.WriteLine();
    }

    public void SetDuration()
    {
        Console.WriteLine();
        Console.Write("How long, in  seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        _duration = seconds;
    }

    public void ShowSpinner(int seconds)
    {

        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(seconds);

        List<string> spinnerString = ["|", "/", "-", "\\", "|", "/", "-", "\\"];


        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= spinnerString.Count)
            {
                i = 0;
            }
        }

    }

    public void ShowCountDown(int seconds)
    {


        for (int i = seconds; i > 0; i--)
        {
            // I decided to use the following 'Escape Sequences' \r and \n because this allows me to better display the counter numbers if they have more than one or two digits. I learn about this in the Microsoft Page: https://learn.microsoft.com/en-us/cpp/c-language/escape-sequences?view=msvc-170
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }

        Console.WriteLine("\r ");
    }

}