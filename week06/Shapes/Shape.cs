public abstract class Shape(string color)
{
    private string _color = color;

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();

}