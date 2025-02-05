using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Joh Carry", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment = new MathAssignment("Roberto Carlos", "Fractions", "8.4", "5-15");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();


        WritingAssigment writingAssigment = new WritingAssigment("Carlos Alberto", "Brazilian History", "The 80's in Brazil");
        Console.WriteLine(writingAssigment.GetSummary());
        Console.WriteLine(writingAssigment.GetWritingInformation());
    }
}