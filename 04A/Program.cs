using System;
public class BubbleSort
{
    public static void Main(string[] args)
    {
        int[] numbers;
        Console.WriteLine("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        numbers = new int[size];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter element " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Sorted array:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}