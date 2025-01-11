using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGen = new();
        // Studying and with the warnings of visual studio code, I discovered that you can use this abbreviation, instead of using new Random()


        int magicNumber = randomGen.Next(1, 101);

        int guess = 0;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}