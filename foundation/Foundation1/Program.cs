using System;

class Program
{
    static void Main(string[] args)
    {
       // Create videos
        Video video1 = new Video("Video 1", "Author 1", 300);
        video1.AddComment(new Comment("John Doe", "Great video!"));
        video1.AddComment(new Comment("Jane Doe", "Very informative!"));
        video1.AddComment(new Comment("Bob Smith", "Well done!"));

        Video video2 = new Video("Video 2", "Author 2", 240);
        video2.AddComment(new Comment("Alice Johnson", "Excellent!"));
        video2.AddComment(new Comment("Mike Brown", "Good job!"));
        video2.AddComment(new Comment("Emily Davis", "Very good!"));

        Video video3 = new Video("Video 3", "Author 3", 180);
        video3.AddComment(new Comment("Sarah Taylor", "Awesome!"));
        video3.AddComment(new Comment("David Lee", "Great work!"));
        video3.AddComment(new Comment("Emily Chen", "Well done!"));

        // Add videos to list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (Video video in videos)
        {
            Console.WriteLine(video.ToString());
            Console.WriteLine("\n");
        }
    }
}

 
    
