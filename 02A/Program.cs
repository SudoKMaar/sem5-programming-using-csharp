using System;
public class GradeCalculation
{
    public static void Main(string[] args)
    {
        int subject1, subject2, subject3, subject4, subject5;
        Console.WriteLine("Enter the marks of subject 1: ");
        subject1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the marks of subject 2: ");
        subject2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the marks of subject 3: ");
        subject3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the marks of subject 4: ");
        subject4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the marks of subject 5: ");
        subject5 = int.Parse(Console.ReadLine());

        int totalMarks = subject1 + subject2 + subject3 + subject4 + subject5;
        double percentageMarks = (totalMarks / 500.0) * 100.0;
        Console.WriteLine("Percentage marks: " + percentageMarks);

        string grade = "";
        if (percentageMarks >= 90.0)
        {
            grade = "O";
        }
        else if (percentageMarks >= 80.0)
        {
            grade = "A";
        }
        else if (percentageMarks >= 70.0)
        {
            grade = "B";
        }
        else if (percentageMarks >= 60.0)
        {
            grade = "C";
        }
        else if (percentageMarks >= 50.0)
        {
            grade = "D";
        }
        else if (percentageMarks >= 45.0)
        {
            grade = "P";
        }
        else
        {
            grade = "F";
        }
        Console.WriteLine("Grade: " + grade);
    }
}
