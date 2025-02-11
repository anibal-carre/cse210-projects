public class Circle(string color, double radius) : Shape(color)
{
    private double _radius = radius;

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}