using System;

class Program
{
    static void Main(string[] args)
    {
    
        // Display mindfulness program options
        Console.WriteLine("Mindfulness Program");
        Console.WriteLine("-------------------");
        Console.WriteLine("1. Breathing Exercise");
        Console.WriteLine("2. Reflection Exercise");
        Console.WriteLine("3. Listing Exercise");

        // Validate user input
        Console.Write("Choose an activity (1-3): ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.Write("Invalid input. Please enter a number between 1 and 3: ");
        }

        // Run selected activity
        switch (choice)
        {
            case 1:
                // Breathing Exercise
                Console.Write("Enter duration in seconds: ");
                int breathingDuration;
                while (!int.TryParse(Console.ReadLine(), out breathingDuration) || breathingDuration <= 0)
                {
                    Console.Write("Invalid input. Please enter a positive integer: ");
                }
                MindfulnessActivity breathingExercise = new BreathingExercise(breathingDuration);
                breathingExercise.RunActivity();
                break;

            case 2:
                // Reflection Exercise
                Console.Write("Enter duration in seconds: ");
                int reflectionDuration;
                while (!int.TryParse(Console.ReadLine(), out reflectionDuration) || reflectionDuration <= 0)
                {
                    Console.Write("Invalid input. Please enter a positive integer: ");
                }
                MindfulnessActivity reflectionExercise = new ReflectionExercise(reflectionDuration);
                reflectionExercise.RunActivity();
                break;

            case 3:
                // Listing Exercise
                Console.Write("Enter duration in seconds: ");
                int listingDuration;
                while (!int.TryParse(Console.ReadLine(), out listingDuration) || listingDuration <= 0)
                {
                    Console.Write("Invalid input. Please enter a positive integer: ");
                }
                MindfulnessActivity listingExercise = new ListingExercise(listingDuration);
                listingExercise.RunActivity();
                break;
        }

        // Display farewell message
        Console.WriteLine("Thank you for participating in the mindfulness program!");
    }
}



    
