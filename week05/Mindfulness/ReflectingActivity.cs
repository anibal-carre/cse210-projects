public class ReflectingActivity : Activity
{

    private List<string> _prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
    private List<string> _questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your lifes when you have shown strength and resilence. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        SetDuration();

        Console.WriteLine("Get ready...");
        Console.WriteLine();
        ShowSpinner(5);

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();

        DisplayPrompt();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        Console.WriteLine();

        ShowCountDown(5);
        Console.WriteLine();

        DisplayQuestion();
        ShowSpinner(_duration / 3);

        DisplayQuestion();
        ShowSpinner(_duration / 3);

        DisplayQuestion();
        ShowSpinner(_duration / 3);

        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count);
        string findPrompt = _prompts[randomNumber];
        return findPrompt;
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _questions.Count);
        string findQuestion = _questions[randomNumber];
        return findQuestion;

    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
    }

    public void DisplayQuestion()
    {
        Console.Write($"> {GetRandomQuestion()}");
        Console.WriteLine();
    }
}