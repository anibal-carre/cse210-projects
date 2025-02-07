using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new("Program", "Working", 10);
        activity.DisplayStartingMessage();
        activity.ShowCountDown(100);
        //activity.ShowSpinner(10);
        activity.DisplayEndingMessage();
    }
}