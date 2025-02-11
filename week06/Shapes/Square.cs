public class Square(string color, double side) : Shape(color)
{
    private double _side = side;

    public override double GetArea()
    {
        return _side * _side;
    }
}