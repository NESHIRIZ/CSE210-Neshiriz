using System;
using System.Collections.Generic;

public class ReflectionExercise : MindfulnessActivity
{
    private string[] _reflectionPrompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionExercise(int duration) 
        : base("Reflection Exercise", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration) { }

    protected override void ExecuteActivity()
    {
        Random rand = new Random();
        DisplayAnimation(_reflectionPrompts[rand.Next(_reflectionPrompts.Length)], 0);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int questionIndex = 0;
        List<string> reflections = new List<string>();

        while (DateTime.Now < endTime)
        {
            DisplayAnimation(_reflectionQuestions[questionIndex % _reflectionQuestions.Length], 15000);
            Console.Write("Enter your reflection: ");
            string reflection = Console.ReadLine();
            reflections.Add(reflection);
            questionIndex++;
            DisplayDots(10, 1000);
        }

        Console.WriteLine("Your Reflections:");
        for (int i = 0; i < reflections.Count; i++)
        {
            Console.WriteLine($"Reflection {i+1}: {reflections[i]}");
        }

        // Save reflections to file
        Console.Write("Would you like to save your reflections to a file? (y/n): ");
        string saveResponse = Console.ReadLine();
        if (saveResponse.ToLower() == "y")
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("reflections.txt");
            foreach (string reflection in reflections)
            {
                file.WriteLine(reflection);
            }
            file.Close();
            Console.WriteLine("Reflections saved to reflections.txt");
        }
    }
}