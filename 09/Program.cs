using System;

abstract class Shape
{
  public abstract double CalculateArea();
}

class Circle : Shape
{
  public double Radius { get; set; }
  public override double CalculateArea()
  {
    return Math.PI * Math.Pow(Radius, 2);
  }
}

class Rectangle : Shape
{
  public double Width { get; set; }
  public double Height { get; set; }
  public override double CalculateArea()
  {
    return Width * Height;
  }
}

class Program
{
  static void Main(string[] args)
  {
    Circle circle = new Circle();
    circle.Radius = 5;
    Rectangle rectangle = new Rectangle();
    rectangle.Width = 10;
    rectangle.Height = 5;
    Console.WriteLine("Area of circle: {0}", circle.CalculateArea());
    Console.WriteLine("Area of rectangle: {0}", rectangle.CalculateArea());
  }
}
