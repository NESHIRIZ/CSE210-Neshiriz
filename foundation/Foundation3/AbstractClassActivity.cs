using System;
using System.Collections.Generic;

// Base Activity class
public abstract class Activity
{
    private DateTime date;
    private int lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        this.date = date;
        this.lengthInMinutes = lengthInMinutes;
    }

    public DateTime Date { get { return date; } }
    public int LengthInMinutes { get { return lengthInMinutes; } }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} {GetType().Name} ({lengthInMinutes} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F2} min per mile";
    }
}

// Derived Running class
public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int lengthInMinutes, double distance) 
        : base(date, lengthInMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance() { return distance; }
    public override double GetSpeed() { return (distance / LengthInMinutes) * 60; }
    public override double GetPace() { return 60 / GetSpeed(); }
}

// Derived Cycling class
public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int lengthInMinutes, double speed) 
        : base(date, lengthInMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance() { return (speed / 60) * LengthInMinutes; }
    public override double GetSpeed() { return speed; }
    public override double GetPace() { return 60 / speed; }
}

// Derived Swimming class
public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps) 
        : base(date, lengthInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance() { return laps * 50 / 1609.34; } // Convert meters to miles
    public override double GetSpeed() { return (GetDistance() / LengthInMinutes) * 60; }
    public override double GetPace() { return 60 / GetSpeed(); }
}
