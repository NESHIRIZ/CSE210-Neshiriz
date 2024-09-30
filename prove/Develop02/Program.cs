using System;
using System.Collections.Generic;
class Program
{
    static Emotion DisplayEmotions()
    {
        Console.WriteLine("Choose your emotion:");
        int i = 1;
        foreach (Emotion emotion in Enum.GetValues(typeof(Emotion)))
        {
            Console.WriteLine($"{i}. {emotion}");
            i++;
        }
        Console.Write("Enter emotion number: ");
        int emotionNumber = Convert.ToInt32(Console.ReadLine());
        return (Emotion)(emotionNumber - 1);
    }

    static void DisplayEmotionsList()
    {
        Console.WriteLine("Emotions:");
        int i = 1;
        foreach (Emotion emotion in Enum.GetValues(typeof(Emotion)))
        {
            Console.WriteLine($"{i}. {emotion}");
            i++;
        }
    }

    static void Main(string[] args)
    {
        string emotionChoice = "Happy";//Declare and initialize
        Console.WriteLine("Emotion:"+ emotionChoice);
        // Initialize prompt generator
        string[] prompts = {
            "What is one thing you learned from the Book of Mormon today?",
            "How does it make you feel to know that God loves you?",
            "What are you grateful for that God has given you?",
            "What's something you're looking forward to tomorrow?",
            "Describe a challenging experience and what you learned from it."
        };
        PromptGenerator generator = new PromptGenerator(prompts);

        // Initialize journal
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Journal Program");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Display emotions");
            Console.WriteLine("6. Exit");

            Console.Write("Choose an option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    string prompt = generator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Response: ");
                    string response = Console.ReadLine();
                    Console.WriteLine("Choose an emotion");
                    Console.WriteLine("1. Happy");
                    Console.WriteLine("2. Sad");
                    Console.WriteLine("3. Angry");
                    Console.WriteLine("4. Fearful");
                    Console.WriteLine("5. Surprised");
                    Console.WriteLine("6. Excited");
                    Console.WriteLine("Enter tags(commas-separated):");
                    string tagsInput = Console.ReadLine();
                    string[] tags = tagsInput.Split(',').Select(t=>t.Trim()).ToArray();
                    Emotion emotion = DisplayEmotions();
                    string date = DateTime.Now.ToShortDateString();
                    string time = DateTime.Now.ToShortTimeString();
                    Entry entry = new Entry(prompt, response, date, time, emotion, tags);
                    journal.AddEntry(entry);
                    journal.SaveToFile("Neshiriz.txt");
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.Write("Enter filename: ");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                    break;
                case 4:
                    Console.Write("Enter filename: ");
                    filename = Console.ReadLine();
                    journal.LoadFromFile(filename);
                    break;
                case 5:
                    DisplayEmotionsList();
                    break;
                
                case 6:
                   journal.SaveToFile("Neshiriz.txt");
                   Console.WriteLine("Exiting the program. Goodbye!");
                   Environment.Exit(0);
                   break;

                default:
                  Console.WriteLine("Invalid option. Please try again.");
                  break;
            };
        }
    }
}