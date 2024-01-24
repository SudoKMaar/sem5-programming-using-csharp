internal abstract class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter a integer between 0 and 1000: ");
            var input = Convert.ToInt32(Console.ReadLine());
            if (input is < 0 or > 1000)
            {
                throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine($"You entered: {input}");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine($"Error: Input must be between 0 and 100.");
        }
    }
}
