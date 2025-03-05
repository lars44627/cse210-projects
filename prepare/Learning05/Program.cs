using System;

class Program
{
    static void Main()
    {
       List<Shape> shapes = new List<Shape>
        {
            new Square("Red", 5),
            new Rectangle("Blue", 4, 6),
            new Circle("Green", 3)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetType().Name} Color: {shape.GetColor()}");
            Console.WriteLine($"{shape.GetType().Name} Area: {shape.GetArea()}");
        }
    }
}