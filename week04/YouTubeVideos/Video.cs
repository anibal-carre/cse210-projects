public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = [];

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} minutes");
        Console.WriteLine("Comments:");
        Console.WriteLine();
        foreach (var comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}