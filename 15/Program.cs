internal abstract class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the Numerator: ");
            var numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Denominator: ");
            var denominator = Convert.ToInt32(Console.ReadLine());
            var result = numerator / denominator;
            Console.WriteLine($"The result of {numerator} / {denominator} is : {result}.");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Divide by Zro Exception. You cant divide by zero");
        }
    }
}