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

                BreathingActivity breathingActivity = new();
                breathingActivity.Run();

            }
            else if (option == 2)
            {
                ReflectingActivity reflectingActivity = new();
                reflectingActivity.Run();
            }
            else if (option == 3)
            {
                ListingActivity listingActivity = new();
                listingActivity.Run();
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