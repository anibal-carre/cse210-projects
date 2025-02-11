using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [];

        Square shape1 = new("Red", 6);
        shapes.Add(shape1);

        Rectangle shape2 = new("Blue", 8, 9);
        shapes.Add(shape2);

        Circle shape3 = new("Green", 8);
        shapes.Add(shape3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}