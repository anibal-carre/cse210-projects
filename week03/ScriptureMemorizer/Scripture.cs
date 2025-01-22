public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = [.. text.Split(' ').Select(word => new Word(word))];
    }

    public void HideRandomWords(int numberToHide)
    {
        var notHiddenWords = _words.Where(word => !word.IsHidden()).ToList();
        var random = new Random();

        for (int i = 0; i < numberToHide && notHiddenWords.Count > 0; i++)
        {
            int index = random.Next(notHiddenWords.Count);
            notHiddenWords[index].Hide();
            notHiddenWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}