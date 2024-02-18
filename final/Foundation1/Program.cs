using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    
        List<Video> videos = CreateVideos();

        foreach (var video in videos) {
            DisplayVideoInfo(video);
        }
    }

    public static List<Video> CreateVideos() {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Title 1", "Author 1", 120);
        video1.AddComment("User1", "This is a comment.");
        video1.AddComment("User2", "Another comment.");

        Video video2 = new Video("Title 2", "Author 2", 180);
        video2.AddComment("User3", "Yet another comment.");
        video2.AddComment("User4", "One more comment.");

        Video video3 = new Video("Title 3", "Author 3", 150);
        video3.AddComment("User5", "A comment here.");
        video3.AddComment("User6", "And another comment.");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        return videos;
    }

    public static void DisplayVideoInfo(Video video) {
        Console.WriteLine("Title: " + video.Title);
        Console.WriteLine("Author: " + video.Author);
        Console.WriteLine("Length: " + video.Length + " seconds");
        Console.WriteLine("Number of Comments: " + video.GetNumComments());
        Console.WriteLine("Comments:");
        video.DisplayComments();
        Console.WriteLine();
    }
}
