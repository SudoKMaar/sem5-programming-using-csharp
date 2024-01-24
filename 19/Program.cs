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
class MainClass
{
    static void Main(string[] args)
    {
        Person person = new Person();
        GreetingDelegate greetingDelegate = person.SayHello;
        greetingDelegate("Abhishek Kumar");
        GreetingDelegate farewellDelegate = person.SayGoodbye;
        farewellDelegate("KMaar");
    }
}
