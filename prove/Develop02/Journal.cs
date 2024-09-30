using System;
using System.Collections.Generic;

// Journal class to manage entries
public class Journal
{
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        Entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in Entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename,true))
        {
            Entry lastEntry = Entries[Entries.Count-1];
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{lastEntry.Date}|{lastEntry.Time}|{lastEntry.Prompt}|{lastEntry.Response}|{lastEntry.Emotion}|{string.Join(",", lastEntry.Tags)}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string date = parts[0];//Define date here
            string time = parts[1];
            string prompt = parts[2];
            string response = parts[3];
            string emotionString = parts[4];
            Emotion emotion = (Emotion)Enum.Parse(typeof(Emotion),emotionString);
            string[]tags = parts[4].Split(',').Select(t =>t.Trim()).ToArray();
            Entry entry = new Entry(parts[1], parts[2], date, time, emotion, tags);
            Entries.Add(entry);
        }
    }
}
