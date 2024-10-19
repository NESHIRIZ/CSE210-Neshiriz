public class ListingExercise : MindfulnessActivity
{
    private string[] _listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingExercise(int duration) 
        : base("Listing Exercise", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration) { }

    protected override void ExecuteActivity()
    {
        Random rand = new Random();
        DisplayAnimation(_listingPrompts[rand.Next(_listingPrompts.Length)], 3000);
        Console.WriteLine("List items:");
        int itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration / 10);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter item " + (itemCount + 1) + ": ");
            string item = Console.ReadLine();
            Console.WriteLine("Item " + (itemCount + 1) + ": " + item);
            itemCount++;
            DisplayDots(3, 1000);
        }

        Console.WriteLine("You listed " + itemCount + " items.");
    }
}