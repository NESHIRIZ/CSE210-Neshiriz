using System;

public class Resume
{
    public string _name;

    // Make sure to initialize the list to a new List before you utilizing  it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Take note of the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This brings the Display method on each job
            job.Display();
        }
    }
}