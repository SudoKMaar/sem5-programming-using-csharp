using System;
public class SumOfDigits
{
    public static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter an integer: ");
        number = int.Parse(Console.ReadLine());
        int sumOfDigits = 0;
        while (number > 0)
        {
            int remainder = number % 10;
            sumOfDigits += remainder;
            number /= 10;
        }
        Console.WriteLine("Sum of digits: " + sumOfDigits);
    }
}
