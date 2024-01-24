delegate void GreetingDelegate(string name);
class Person
{
    public void SayHello(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }
    public void SayGoodbye(string name)
    {
        Console.WriteLine("Goodbye, " + name + "!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        GreetingDelegate greetingDelegate = person.SayHello;
        greetingDelegate += person.SayGoodbye;
        greetingDelegate("Abhishek Kumar");
        greetingDelegate("KMaar");
    }
}
