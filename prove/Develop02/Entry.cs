using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

// Entry class to store journal entries
public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }
    public string Time {get; set;}
    public Emotion Emotion { get; set; }
    public  string[] Tags {get; set; }

    public Entry(string prompt, string response, string date, string time, Emotion emotion, string[]tags)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
        Time = time;
        Emotion = emotion;
        Tags = tags;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Time: {Time}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine($"Emotion: {Emotion}");
        Console.WriteLine($"Tags: {string.Join(",", Tags)}");
        Console.WriteLine();
    }
}
