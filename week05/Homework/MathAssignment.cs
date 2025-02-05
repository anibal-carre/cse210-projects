public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string topic, string studentName, string textbookSection, string problems) : base(topic, studentName)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_textbookSection} Problems {_problems} ";
    }
}