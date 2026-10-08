using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 2));
        shapes.Add(new Rectangle("green", 3, 5));
        shapes.Add(new Circle("yellow", 3));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea() :F2}.");
        }
        

    }
}