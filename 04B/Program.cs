using System;
public class MatrixMultiplication
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the dimensions of the first matrix (rows x columns): ");
        string[] dimensions1 = Console.ReadLine().Split(' ');
        int rows1 = int.Parse(dimensions1[0]);
        int columns1 = int.Parse(dimensions1[1]);
        Console.WriteLine("Enter the dimensions of the second matrix (rows x columns): ");
        string[] dimensions2 = Console.ReadLine().Split(' ');
        int rows2 = int.Parse(dimensions2[0]);
        int columns2 = int.Parse(dimensions2[1]);
        if (columns1 != rows2)
        {
            Console.WriteLine("The two matrices are not compatible for multiplication.");
            return;
        }
        int[,] matrix1 = new int[rows1, columns1];
        int[,] matrix2 = new int[rows2, columns2];
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns1; j++)
            {
                Console.WriteLine("Enter element " + (i + 1) + "," + (j + 1) + " of the first matrix: ");
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < rows2; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                Console.WriteLine("Enter element " + (i + 1) + "," + (j + 1) + " of the second matrix: ");
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int[,] resultMatrix = new int[rows1, columns2];
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < columns1; k++)
                {
                    resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        Console.WriteLine("Result matrix:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
