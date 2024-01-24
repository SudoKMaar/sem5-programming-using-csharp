internal class Shape
{
    protected Shape(string name)
    {
        Name = name;
    }
    protected string shape_name()
    {
        return Name;
    }
    public string Name { get; set; }
}
internal class RectShape : Shape
{
    protected RectShape(string name, double length, double breadth) : base(name)
    {
        Length = length;
        Breadth = breadth;
    }
    public double Length { get; set; }
    public double Breadth { get; set; }
    protected string GetArea()
    {
        return $"{shape_name()}: Area is : {Length * Breadth}";
    }
}
internal class Area : RectShape
{
    public Area(string name, double sameLength) : base(name, sameLength, sameLength)
    {
    }
    public Area(string name, double length, double breadth) : base(name, length, breadth)
    {
    }
    public void DisplayArea()
    {
        Console.WriteLine(GetArea());
    }
}
internal abstract class Program
{
    public static void Main(string[] args)
    {
        var square = new Area("Square", 31.0); square.DisplayArea();
        var rectangle = new Area("Rectangle", 31.0, 44.0);
        rectangle.DisplayArea();
    }
}
