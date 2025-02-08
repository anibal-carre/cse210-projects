public class Menu
{
    private List<string> _options = ["1. Start breathing activity", "2. Start reflecting activity", "3. Start listing activity", "4. Quit"];
    public int ShowMenu()
    {
        Console.WriteLine("Menu Options: ");
        foreach (string option in _options)
        {
            Console.WriteLine($"  {option}");
        }

        Console.Write("Select a choice from the menu: ");
        int optionSelected = int.Parse(Console.ReadLine());

        return optionSelected;
    }
}