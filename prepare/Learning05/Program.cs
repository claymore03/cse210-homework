using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square square = new Square();
        square.SetColor("Blue");
        square.SetSide(4);

        Rectangle rectangle = new Rectangle();
        rectangle.SetColor("Red");
        rectangle.SetLength(8);
        rectangle.SetWidth(4);

        Circle circle = new Circle();
        circle.SetColor("Green");
        circle.SetRadius(5);

        List<Shape> shape = new List<Shape>();
        shape.Add(square);
        shape.Add(rectangle);
        shape.Add(circle);

        foreach (Shape s in shape)
        {
            double area = s.GetArea();
            s.GetColor();
        }
    }
}