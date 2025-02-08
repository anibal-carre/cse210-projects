using System;

class Program
{
    static void Main(string[] args)
    {
        //Activity activity = new("Program", "Working", 10);
        //activity.DisplayStartingMessage();
        //activity.ShowCountDown(10);
        //activity.ShowSpinner(10);
        //activity.DisplayEndingMessage();

        Menu menu = new();
        int option = menu.ShowMenu();
        Console.WriteLine(option);

        if (option == 1)
        {
            Console.WriteLine("Breathing Activity");
        }
        else if (option == 2)
        {
            Console.WriteLine("Refelcting Activity");
        }
        else if (option == 3)
        {
            Console.WriteLine("Listing Activity");
        }
        else if (option == 4)
        {
            Console.WriteLine("Program finish");
        }
        else
        {
            Console.WriteLine("Option not valid");
        }
    }
}