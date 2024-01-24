using System;
public class ArithmeticOperations
{
    public static void Main(string[] args)
    {
        int num1, num2;
        Console.WriteLine("Enter the first number: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum: " + (num1 + num2));
        Console.WriteLine("Difference: " + (num1 - num2));
        Console.WriteLine("Product: " + (num1 * num2));
        Console.WriteLine("Quotient: " + (num1 / num2));
        Console.WriteLine("Remainder: " + (num1 % num2));
        Console.WriteLine("Incremented num1: " + (++num1));
        Console.WriteLine("Decremented num2: " + (--num2));
    }
}
