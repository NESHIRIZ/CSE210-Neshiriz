using System;

class Program
{
    static void Main(string[] args)
    {
        // Test Assignment class
        Assignment assignment = new Assignment("Kelvin Vundla", "Division");
        Console.WriteLine(assignment.GetSummary());

        // Test MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("Eric Nkomo", "Addition", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Test WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Sbonginkosi Moyo", "African History", "The Causes of the Partion of Africa ");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
};
    
