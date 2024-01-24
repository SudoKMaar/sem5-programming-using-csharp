using System;
public class PrimeNumberChecker
{
    public static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter an integer: ");
        number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        { Console.WriteLine("The number is prime."); }
        else
        { Console.WriteLine("The number is not prime."); }
    }
}
