using System;

namespace ScriptureMemoryHelper
{
    public class EncouragingFeedback
    {
        public static void DisplayFeedback(Scripture scripture)
        {
            Console.WriteLine("Congratulations! You've memorized the entire scripture!");
            Console.WriteLine($"Scripture: {scripture.GetReference()}");
            Console.WriteLine("Keep up the good work!");
        }
    }
}