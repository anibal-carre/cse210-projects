public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        //I decided that the ternary operator would be a good option, I have used this operator in other programming languages ​​such as javascript, I find it very useful.
        return _isHidden ? new string('_', _text.Length) : _text;
    }

}