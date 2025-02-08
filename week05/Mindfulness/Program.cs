using System;

class Program
{
    static void Main(string[] args)
    {

        Menu menu = new();

        int option;

        do
        {
            option = menu.ShowMenu();

            if (option == 1)
            {

                BreathingActivity bActivity = new();
                bActivity.Run();

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
        } while (option != 4);
    }
}