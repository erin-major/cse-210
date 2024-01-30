using System;

class Program
{
    static void Main(string[] args)
    {        
        Assignment assignment1 = new Assignment("Erin Major", "Coding");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Benjamin Hugh", "Algebra", "12.5", "10-30");
        Console.WriteLine();
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Burr", "Religion", "Tips and Tricks for Daily Study");
        Console.WriteLine();
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}