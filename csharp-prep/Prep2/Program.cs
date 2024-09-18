using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your order number? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your order number is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You order passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time, come and order again!");
        }
    }
}

    
