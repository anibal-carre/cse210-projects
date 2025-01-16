public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 4);
        string findPrompt = prompts[randomNumber];

        return findPrompt;
    }
}