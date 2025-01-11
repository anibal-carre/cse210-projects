using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();
        int parsedGradePercent = int.Parse(gradePercent);

        string letter;

        if (parsedGradePercent >= 90)
        {
            letter = "A";
            Console.WriteLine($"Your grade is: {letter}");
        }
        else if (parsedGradePercent >= 80)
        {
            letter = "B";
            Console.WriteLine($"Your grade is: {letter}");
        }
        else if (parsedGradePercent >= 70)
        {
            letter = "C";
            Console.WriteLine($"Your grade is: {letter}");
        }
        else if (parsedGradePercent >= 60)
        {
            letter = "D";
            Console.WriteLine($"Your grade is: {letter}");
        }
        else
        {
            letter = "F";
            Console.WriteLine($"Your grade is: {letter}");
        }

        if (parsedGradePercent >= 70)
        {
            Console.WriteLine("Fantastic, you passed!");
        }
        else
        {
            Console.WriteLine("Next time will be your time to shine!");
        }
    }
}