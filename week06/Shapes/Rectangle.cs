public class Rectangle(string color, double length, double width) : Shape(color)
{
    private double _length = length;
    private double _width = width;

    public override double GetArea()
    {
        return _length * _width;
    }
}