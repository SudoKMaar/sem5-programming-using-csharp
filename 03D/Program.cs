using System;
public class BinaryToDecimal
{
    public static void Main(string[] args)
    {
        string binaryNumber;
        Console.WriteLine("Enter a binary number: ");
        binaryNumber = Console.ReadLine();
        int decimalNumber = 0;
        int power = 0;
        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            int digit = int.Parse(binaryNumber[i].ToString());
            decimalNumber += digit * (int)Math.Pow(2, power);
            power++;
        }
        Console.WriteLine("Decimal number: " + decimalNumber);
    }
}
