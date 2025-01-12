using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [];

        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.WriteLine("Enter a number: ");

            string userRes = Console.ReadLine();
            userNumber = int.Parse(userRes);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
        }

        Console.WriteLine($"The sum is: {sum}");

        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        int max = numbers[0];

        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}