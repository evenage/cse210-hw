using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        //list to store videos
        List<Video> videos = new List<Video>();

        //populate the videos
        Video video1 = new Video("Introduction to Python", "Mosh", 3600);
        video1.AddComment(new Comment("Great tutorial!", "Alice"));
        video1.AddComment(new Comment("Very informative!", "Bob"));
        video1.AddComment(new Comment("Good explanation", "Clever"));

        Video video2 = new Video("Introduction to Programming", "Aaron Jack", 300);
        video2.AddComment(new Comment("As a developer of 3+ years i still didn't fully understand the difference lol", "@angelosmico422"));
        video2.AddComment(new Comment("next: developer vs software engineer", "Nikosmj1"));
        video2.AddComment(new Comment("i still don't get it", "LexiconLover"));

        Video video3 = new Video("Introduction to C#", "Professor Sluiter",250);
        video3.AddComment(new Comment("Woow i love everything about C#", "MacMartin"));
        video3.AddComment(new Comment("Man you have a talent of explaining things", "TheDeathknight23"));
        video3.AddComment(new Comment("Common Language Runtime (CLR)**", "Eplic"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        //display vedio information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Lenght: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }

    } 
}
