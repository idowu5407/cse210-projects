using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create some videos
        var video1 = new Video("Come follow me", "Alice Johnson", 600);
        video1.AddComment(new Comment("Idowu", "Great explanation!"));
        video1.AddComment(new Comment("Sunday", "Thanks for the video."));
        video1.AddComment(new Comment("Mike", "Really helpful!"));

        var video2 = new Video("Crown", "Hillsong", 450);
        video2.AddComment(new Comment("Linda", "Looks delicious!"));
        video2.AddComment(new Comment("Tom", "I’ll try this today."));
        video2.AddComment(new Comment("Anna", "Thanks for sharing!"));

        var video3 = new Video("Top 10 Travel Destinations", "TravelWithMe", 720);
        video3.AddComment(new Comment("Chris", "I’ve been to #3, it’s amazing."));
        video3.AddComment(new Comment("Ade", "Adding these to my bucket list."));
        video3.AddComment(new Comment("Samson", "Awesome picks!"));

        var video4 = new Video("Lion King", "Sam Strings", 300);
        video4.AddComment(new Comment("Nina", "Clear and easy to follow."));
        video4.AddComment(new Comment("Mark", "Nice chords breakdown."));
        video4.AddComment(new Comment("Alex", "This helped a lot."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display each video and its comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
