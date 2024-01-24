internal abstract class Program
{
    public static void Main()
    {
        try
        {
            int[] numbers = { };
            var average = CalculateAverage(numbers);
            Console.WriteLine($"The average of numbers is: {average}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: Cannot be able to compute Average because array is empty");
        }
    }
    private static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new IndexOutOfRangeException();
        }
        var sum = numbers.Sum();
        sum = sum / numbers.Length;
        return sum;
    }
}