using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your mark? ");
        string answer = Console.ReadLine();
        int mark = int.Parse(answer);

        string letter = "";

        if (mark >= 90)
        {
            letter = "A";
        }
        else if (mark >= 80)
        {
            letter = "B";
        }
        else if (mark >=70)
        {
            letter ="C";
        }
        else if (mark >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your mark is: {letter}");
        
        if (mark >= 70)
        {
            Console.WriteLine("You passed, well done. You did well! ");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}