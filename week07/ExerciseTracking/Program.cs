using System;

class Program
{
    static void Main(string[] args)
    {

        Running activity1 = new(new DateTime(2025, 2, 18), 30, 3.0);
        Cycling activity2 = new(new DateTime(2025, 2, 15), 50, 6.0);
        Swimming activity3 = new(new DateTime(2025, 2, 10), 60, 40);

        List<Activity> activities = [
            activity1,
            activity2,
            activity3
        ];

        foreach (var a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }

    }
}