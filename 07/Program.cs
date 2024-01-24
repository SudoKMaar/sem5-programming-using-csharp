internal class Person
{
    private readonly string _name;
    private readonly int _age;
    protected Person(string name, int age)
    {
        _name = name;
        _age = age;
    }
    protected void Display()
    {
        Console.WriteLine($"Name : {_name}, Age : {_age}");
    }
}
internal class Student : Person
{
    private readonly int _rollNo;
    private readonly string _universityName;
    private string _branch;
    public Student(string name, int age, int rollNo, string universityName, string branch) : base(name, age)
    {
        _universityName = universityName;
        _rollNo = rollNo;
        _branch = branch;
    }
    public void ChangeBranch(string branch)
    {
        _branch = branch;
        Console.WriteLine($"Your branch is changed to {_branch}");
    }

    public new void Display()
    {
        base.Display();
        Console.WriteLine($"University Name : {_universityName}, Roll No. : {_rollNo} and Branch : {_branch}");
    }
}
internal abstract class Program
{
    public static void Main(string[] args)
    {
        var student = new Student("Abhishek Kumar", 19, 31, "Lingaya's Vidyapeeth", "BTech CSE");
        student.Display();
        student.ChangeBranch("BCA");
    }
}
