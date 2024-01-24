using System;
public class Calculator
{
    public static void Main(string[] args)
    {
        double operand1, operand2, result;
        Console.WriteLine("Enter the first operand: ");
        operand1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second operand: ");
        operand2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Select an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                result = operand1 + operand2;
                break;
            case 2:
                result = operand1 - operand2;
                break;
            case 3:
                result = operand1 * operand2;
                break;
            case 4:
                result = operand1 / operand2;
                break;
            default:
                Console.WriteLine("Invalid choice");
                return;
        }
        Console.WriteLine("The result is: " + result);
    }
}