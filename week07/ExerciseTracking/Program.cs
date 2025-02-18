using System;

class Program
{
    static void Main(string[] args)
    {
        Running activity1 = new(new DateTime(2025, 2, 18), 30, 3.0);
        Console.WriteLine(activity1.GetSummary());
    }
}