internal class Shape
{
    protected Shape(string name)
    {
        Name = name;
    }
    protected void shape_name()
    {
        Console.WriteLine($"Shape Name : {Name}");
    }
    protected string Name { get; set; }
}
internal class Rectangle : Shape
{
    public Rectangle(double length, double breadth) : base("Rectangle")
    {
        Length = length;
        Breadth = breadth;
    }
    public double Length { get; set; }
    public double Breadth { get; set; }
    public void DisplayArea()
    {
        Console.WriteLine($"{Name} : Area is {Length * Breadth}");
    }
}
internal class Square : Shape
{
    public Square(double length) : base("Square")
    {
        Length = length;
    }
    public double Length { get; set; }
    public void DisplayArea()
    {
        Console.WriteLine($"{Name} : Area is {Length * Length}");
    }
}
internal abstract class Program
{
    public static void Main(string[] args)
    {
        var rectangle = new Rectangle(31.0, 44.0);
        var square = new Square(31.0);
        rectangle.DisplayArea();
        square.DisplayArea();
    }
}
