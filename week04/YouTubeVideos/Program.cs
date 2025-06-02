using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some videos
        var video1 = new Video("Come follow me", "Alice Johnson", 600);
        video1.AddComment(new Comment("Idowu", "Word of the Savour!"));
        video1.AddComment(new Comment("Sunday", "Thanks for the video."));
        video1.AddComment(new Comment("Mike", "Really helpful!"));

        var video2 = new Video("Looking up to God", "Chef Emma", 450);
        video2.AddComment(new Comment("segun", "It fill with spirit of God!"));
        video2.AddComment(new Comment("Taye", "I’ll try listen."));
        video2.AddComment(new Comment("Hanna", "Thanks for sharing!"));

        var video3 = new Video("Nigeria the Great Nation", "TravelWithMe", 720);
        video3.AddComment(new Comment("Chris", "I’ve been to #3, it’s amazing."));
        video3.AddComment(new Comment("Jade", "Adding these to my bucket list."));
        video3.AddComment(new Comment("Odun", "Awesome Country!"));

        var video4 = new Video("Black the Beauty", "Oluwatobi Strings", 300);
        video4.AddComment(new Comment("Nina", "Clear and easy to identify."));
        video4.AddComment(new Comment("Mark", "Our beauty is natural and pure."));
        video4.AddComment(new Comment("Alex", "There is always beauty in black."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display each video and its comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
