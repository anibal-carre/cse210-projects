using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<string> menuOptions = ["1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"];
        List<string> prompts = ["Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"];
        Journal journal = new();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Please select one of the following choices: ");
            foreach (string option in menuOptions)
            {
                Console.WriteLine(option);
            }

            Console.Write("What would you like to do? ");
            string userResponse = Console.ReadLine();

            if (int.TryParse(userResponse, out int selectedOption))
            {
                switch (selectedOption)
                {
                    case 1:
                        PromptGenerator newPrompt = new PromptGenerator();
                        string randomPrompt = newPrompt.GetRandomPrompt(prompts);
                        Console.WriteLine(randomPrompt);
                        Entry userEntry = new();
                        string entry = Console.ReadLine();
                        string prompt = randomPrompt;
                        DateTime theCurrentTime = DateTime.Now;
                        string dateText = theCurrentTime.ToShortDateString();
                        userEntry._entryText = entry;
                        userEntry._date = dateText;
                        userEntry._promptText = prompt;
                        journal.AddEntry(userEntry);

                        break;
                    case 2:
                        journal.DisplayAll();
                        break;
                    case 3:
                        Console.WriteLine("What is the filename? ");
                        string filename = Console.ReadLine();
                        journal.LoadFromFile(filename);
                        break;
                    case 4:

                        Console.WriteLine("Option 2");
                        journal.SaveToFile("journal.txt");
                        break;
                    case 5:
                        Console.WriteLine("Option 5");
                        running = false;
                        break;
                }
            }
        }

    }
}