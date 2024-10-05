using System;
using System.Collections.Generic;

namespace ScriptureMemoryHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new ScriptureLibrary();
            library.LoadScriptures("scriptures.txt");

            while (true)
            {
                DisplayMenu();
                var input = Console.ReadLine();
                HandleMenuInput(library, input);
            }
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Scripture Memory Helper");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Study Scripture");
            Console.WriteLine("2. View Library");
            Console.WriteLine("3. Add Scripture");
            Console.WriteLine("4. Exit");
        }

        static void HandleMenuInput(ScriptureLibrary library, string input)
        {
            switch (input)
            {
                case "1":
                    StudyScripture(library);
                    break;
                case "2":
                    ViewLibrary(library);
                    break;
                case "3":
                    AddScripture(library);
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    Console.ReadLine();
                    break;
            }
        }

        static void StudyScripture(ScriptureLibrary library)
        {
            Console.Clear();
            Console.WriteLine("Select a scripture to study:");
            var scriptures = library.GetScriptures();

            if (scriptures.Count == 0)
            {
                Console.WriteLine("No scriptures available.");
                Console.ReadLine();
                return;
            }

            for (int i = 0; i < scriptures.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {scriptures[i].GetReference()}");
            }

            if (!int.TryParse(Console.ReadLine(), out int selectedIndex) || selectedIndex < 1 || selectedIndex > scriptures.Count)
            {
                Console.WriteLine("Invalid input. Please try again.");
                Console.ReadLine();
                return;
            }

            var selectedScripture = scriptures[selectedIndex - 1];
            StudyScriptureLoop(selectedScripture);
        }

        static void StudyScriptureLoop(Scripture selectedScripture)
        {
            while (true)
            {
                Console.Clear();
                selectedScripture.Display();
                Console.WriteLine("Press Enter to hide more words or type 'quit' to exit or 'fill' to fill in hidden words.");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }
                else if (input.ToLower() == "fill")
                {
                    FillInHiddenWords(selectedScripture);
                }
                else
                {
                    selectedScripture.HideRandomWords(2);
                    if (selectedScripture.AllWordsHidden())
                    {
                        EncouragingFeedback.DisplayFeedback(selectedScripture);
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }

        static void FillInHiddenWords(Scripture selectedScripture)
        {
                var hiddenWords = selectedScripture.GetHiddenWords();
    Console.Write("Enter the hidden words (separated by spaces): ");
    var inputWords = Console.ReadLine().Split(' ');

    for (int index = 0; index < hiddenWords.Length; index++)
    {
        Console.WriteLine($"Comparing '{inputWords[index].Trim()}' with '{hiddenWords[index].Trim()}'");
        if (!string.Equals(inputWords[index].Trim(), hiddenWords[index].Trim(), StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Incorrect answer.");
            Console.ReadLine();
            return;
        }
        else
        {
            var word = selectedScripture.GetWords().Find(w => w.GetText().Trim().Equals(hiddenWords[index].Trim(), StringComparison.OrdinalIgnoreCase));
            if (word != null)
            {
                word.IsHidden = false;
            }
        }
    }

    Console.WriteLine("You completed the scripture! Congratulations!");
    Console.ReadLine();
    

        }

        static void ViewLibrary(ScriptureLibrary library)
        {
            Console.Clear();
            Console.WriteLine("Scripture Library:");
            var scriptures = library.GetScriptures();

            for (int i = 0; i < scriptures.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {scriptures[i].GetReference()} - {string.Join(", ", scriptures[i].GetTags())}");
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }

        static void AddScripture(ScriptureLibrary library)
        {
            Console.Clear();
            Console.WriteLine("Add Scripture:");

            Console.Write("Book: ");
            var book = Console.ReadLine();


             Console.Write("Chapter: ");
            if (!int.TryParse(Console.ReadLine(), out int chapter))
            {
                Console.WriteLine("Invalid chapter. Please try again.");
                Console.ReadLine();
                return;
            }

             Console.Write("Verse: ");
            if (!int.TryParse(Console.ReadLine(), out int verse))
            {
                Console.WriteLine("Invalid verse. Please try again.");
                Console.ReadLine();
                return;
            }

            Console.Write("Text: ");
            var text = Console.ReadLine();

            Console.Write("Tags (comma-separated): ");
            var tags = Console.ReadLine().Split(new[] { ',' });


            library.AddScripture(new Scripture(book, chapter, verse, text, tags));
            Console.WriteLine("Script");
        }
    }
}