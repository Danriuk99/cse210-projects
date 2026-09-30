using System;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Fundamentals in 10 Minutes", "CodeMaster", 600);
        video1.AddComment(new Comment("Carlos", "Great video, very clear!"));
        video1.AddComment(new Comment("Ana", "Saved my life for the assignment."));
        video1.AddComment(new Comment("Luis", "Thanks for the explanation."));
        videos.Add(video1);

        Video video2 = new Video("Object-Oriented Programming Basics", "TechGuy", 1200);
        video2.AddComment(new Comment("Sofia", "Finally understood what abstraction is."));
        video2.AddComment(new Comment("Pedro", "Excellent pacing throughout."));
        video2.AddComment(new Comment("Maria", "Waiting for part two!"));
        videos.Add(video2);

        Video video3 = new Video("Visual Studio Code Shortcuts", "DevTips", 450);
        video3.AddComment(new Comment("Jorge", "Did not know that shortcut, thanks."));
        video3.AddComment(new Comment("Lucia", "Very useful!"));
        video3.AddComment(new Comment("Mario", "Good content."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}