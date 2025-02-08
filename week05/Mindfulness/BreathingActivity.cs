public class BreathingActivity : Activity

{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        SetDuration();

        Console.WriteLine("Get ready...");
        Console.WriteLine();
        ShowSpinner(5);


        int durationDivided = _duration / 4;
        int durationBreatheIn = durationDivided / 2 + 1;
        int durationBreatheOut = durationDivided / 2 - 1;


        Console.WriteLine($"Breathe in...");
        ShowCountDown(durationBreatheIn);

        Console.WriteLine("Now breathe out...");
        ShowCountDown(durationBreatheOut);

        Console.WriteLine($"Breathe in...");
        ShowCountDown(durationBreatheIn);

        Console.WriteLine("Now breathe out...");
        ShowCountDown(durationBreatheOut);

        Console.WriteLine($"Breathe in...");
        ShowCountDown(durationBreatheIn);

        Console.WriteLine("Now breathe out...");
        ShowCountDown(durationBreatheOut);

        Console.WriteLine($"Breathe in...");
        ShowCountDown(durationBreatheIn);

        Console.WriteLine("Now breathe out...");
        ShowCountDown(durationBreatheOut);

        DisplayEndingMessage();
    }


}