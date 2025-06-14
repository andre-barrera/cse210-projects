using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Circle(5));
        shapes.Add(new Square(4));
        shapes.Add(new Rectangle(4, 5));

        foreach (Shape i in shapes)
        {
            Console.WriteLine($"The Area is: {i.GetArea()}");
        }
    }
}