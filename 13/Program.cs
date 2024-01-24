internal interface IShape
{
    public void GetArea();
}
internal class Rectangle : IShape
{
    private double _length, _breadth;

    public Rectangle(double length, double breadth)
    {
        _length = length;
        _breadth = breadth;
    }
    public void GetArea()
    {
        Console.WriteLine($"Rectangle: Area is : {_length * _breadth}");
    }
}
internal class Circle : IShape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }
    public void GetArea()
    {
        Console.WriteLine($"Circle: Area is : {2 * 3.14 * _radius * _radius}");
    }
}
internal class Triangle : IShape
{
    private double _height, _base;
    public Triangle(double height, double @base)
    {
        _height = height;
        _base = @base;
    }
    public void GetArea()
    {
        Console.WriteLine($"Triangle: Area is : {0.5 * _height * _base}");
    }
}
internal abstract class Program
{
    public static void Main(string[] args)
    {
        var rectangle = new Rectangle(31, 44);
        var circle = new Circle(28);
        var triangle = new Triangle(28, 08);
        rectangle.GetArea();
        circle.GetArea();
        triangle.GetArea();
    }
}
