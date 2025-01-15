using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<string> menuOptions = ["1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"];
        List<string> questions = ["Who surprised me the most with their perspective or actions today?", "What moment today filled me with the most joy or pride?", "How did I notice God’s guidance or blessings in unexpected ways today?", "What emotion stood out as the most powerful or meaningful for me today, and why?", "If I could relive one part of today to do it differently or savor it more, what would it be?"];
        Random random = new();
        int randomNumber = random.Next(0, 4);

        Console.WriteLine("Please select one of the following choices: ");
        foreach (string option in menuOptions)
        {
            Console.WriteLine($"{option}");
        }
        Console.Write("What would you like to do? ");

        string userResponse = Console.ReadLine();
        int selectedOption = int.Parse(userResponse);


        if (selectedOption == 1)
        {
            Console.WriteLine($"{questions[randomNumber]}");
        }
    }
}