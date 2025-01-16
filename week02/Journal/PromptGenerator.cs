public class PromptGenerator
{
    public List<string> _prompts;

    public static string GetRandomPrompt(List<string> prompts, int num = 1)
    {
        string findPrompt = prompts[num];

        return findPrompt;
    }
}