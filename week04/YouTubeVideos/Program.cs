using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How To Cook An Egg", "Jorge Campbell", 120);
        video1.AddComment(new Comment("Silvia", "Now I know how to cook an egg"));
        video1.AddComment(new Comment("Renato", "Truly inspiring."));
        video1.AddComment(new Comment("Carol", "The best video!"));

        Video video2 = new Video("My First Car", "Elena Rivers", 560);
        video2.AddComment(new Comment("Daniel", "Great content!"));
        video2.AddComment(new Comment("Evangeline", "I had one like that too!"));
        video2.AddComment(new Comment("Frankie", "When is the next video?"));

        Video video3 = new Video("My last trip to the Bahamas", "Lilian Gonzales", 320);
        video3.AddComment(new Comment("Grace", "I want to visit this place!"));
        video3.AddComment(new Comment("Henry", "Beautiful photos"));
        video3.AddComment(new Comment("Isabela", "Favorite place"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}