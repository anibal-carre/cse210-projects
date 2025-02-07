

using System.Data;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} activity");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_name} activity");
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

        Console.WriteLine("Done!");

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            // I decided to use the following 'Escape Sequences' \r and \n because this allows me to better display the counter numbers if they have more than one or two digits. I learn about this in the Microsoft Page: https://learn.microsoft.com/en-us/cpp/c-language/escape-sequences?view=msvc-170
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }

        Console.WriteLine("\rGO! \n");
    }

}