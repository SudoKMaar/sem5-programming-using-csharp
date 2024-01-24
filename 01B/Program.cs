using System;

public class LogicalRelationalBitwiseOperations
{
    public static void Main(string[] args)
    {
        int num1, num2;
        Console.WriteLine("Enter the first number: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Logical and: " + (num1 > 0 && num2 > 0));
        Console.WriteLine("Logical or: " + (num1 > 0 || num2 > 0));
        Console.WriteLine("Logical xor: " + (num1 > 0 ^ num2 > 0));
        Console.WriteLine("Equal: " + (num1 == num2));
        Console.WriteLine("Not equal: " + (num1 != num2));
        Console.WriteLine("Greater than: " + (num1 > num2));
        Console.WriteLine("Less than: " + (num1 < num2));
        Console.WriteLine("Greater than or equal: " + (num1 >= num2));
        Console.WriteLine("Less than or equal: " + (num1 <= num2));
        Console.WriteLine("Bitwise and: " + (num1 & num2));
        Console.WriteLine("Bitwise or: " + (num1 | num2));
        Console.WriteLine("Bitwise xor: " + (num1 ^ num2));
        Console.WriteLine("Bitwise not: " + (~num1));
        Console.WriteLine("Bitwise left shift: " + (num1 << 1));
        Console.WriteLine("Bitwise right shift: " + (num2 >> 1));
    }
}
