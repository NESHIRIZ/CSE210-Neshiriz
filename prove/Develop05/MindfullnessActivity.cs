using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public MindfulnessActivity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    protected void StartActivity()
    {
        Console.WriteLine($"Prepare to begin {_activityName}...");
        Thread.Sleep(3000);
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds.");
        Thread.Sleep(2000);
    }

    protected void EndActivity()
    {
        Console.WriteLine("You have done a great job!");
        Thread.Sleep(2000);
        Console.WriteLine($"Activity completed. Duration: {_duration} seconds.");
        Thread.Sleep(2000);
    }

    protected void DisplayAnimation(string animationText, int pauseDuration)
    {
        Console.WriteLine(animationText);
        Thread.Sleep(pauseDuration);
    }

    protected void DisplayDots(int count, int pauseDuration)
    {
        for (int i = 0; i < count; i++)
        {
            Thread.Sleep(pauseDuration);
            Console.Write(".");
        }
        Console.WriteLine();
    }

    public void RunActivity()
    {
        StartActivity();
        ExecuteActivity();
        EndActivity();
    }

    protected abstract void ExecuteActivity();
}
