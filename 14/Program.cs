internal abstract class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the First Number: ");
            var input1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            var input2 = Convert.ToDouble(Console.ReadLine());
            var result = input1 * input2;
            Console.WriteLine($"The result of {input1} * {input2} is : {result}.");
        }
        catch (FormatException e)
        {
            Console.WriteLine("FormatException Caught! Please enter the valid numeric values.");
        }
    }
}