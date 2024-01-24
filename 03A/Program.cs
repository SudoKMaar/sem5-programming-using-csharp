using System;
public class PalindromeChecker
{
    public static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter an integer: ");
        number = int.Parse(Console.ReadLine());

        bool isPalindrome = false;
        int reversedNumber = 0;
        int remainder;
        int originalNumber = number;

        while (number > 0)
        {
            remainder = number % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            number /= 10;
        }

        if (originalNumber == reversedNumber)
        {
            isPalindrome = true;
        }

        if (isPalindrome)
        {
            Console.WriteLine("The number is a palindrome.");
        }
        else
        {
            Console.WriteLine("The number is not a palindrome.");
        }
    }
}
