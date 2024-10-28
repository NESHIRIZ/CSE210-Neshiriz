using System;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>()
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 3), 30, 6.0),
            new Swimming(new DateTime(2022, 11, 3), 30, 100) // 100 laps * 50 meters/lap = 5000 meters = 3.106855 miles
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}