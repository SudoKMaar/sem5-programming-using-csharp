internal class Employee
{
    private readonly int _empId;
    private readonly double _salary;
    private readonly string _name;
    private static int _noOfEmployee = 1;

    public Employee(double salary, string? name)
    {
        _empId = _noOfEmployee++;
        _salary = salary;
        _name = name;
    }

    public void Display()
    {
        Console.WriteLine($"{_empId}. Employee ID : {_empId}, Name : {_name} and Salary : {_salary}");
    }
}

internal abstract class Program
{
    public static void Main(string[] args)
    {
        var employee = new Employee[4];
        Console.WriteLine("Enter the Name and Salary of employee: ");
        for (var i = 0; i < 4; i++)
        {
            Console.WriteLine($" {i + 1}. ");
            Console.Write("Name : ");
            var name = Console.ReadLine();
            Console.Write("Salary : ");
            var salary = Convert.ToDouble(Console.ReadLine());
            employee[i] = new Employee(salary, name);
        }

        Console.WriteLine("Four Employees :- ");
        for (var i = 0; i < 4; i++)
            employee[i].Display();
    }
}
