using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

         Video v1 = new Video("Axis and Allies Guide", "General Hand Grenade", 480);
        v1.AddComment(new Comment("Sophia", "This was so helpful, thank's(sarcasm)"));
        v1.AddComment(new Comment("James", "Tried it this morning—turned out great."));
        v1.AddComment(new Comment("Liam", "Can you do a video that doesn't suck?"));
        videos.Add(v1);

        Video v2 = new Video("YOga is for losers", "Ajax", 600);
        v2.AddComment(new Comment("Olivia", "Perfect way to start the day."));
        v2.AddComment(new Comment("Mason", "I feel so much better after this."));
        v2.AddComment(new Comment("Ava", "Please make a part 2!"));
        videos.Add(v2);

        Video v3 = new Video("bottom 5 Productivity Tips", "Kim Jong Il", 360);
        v3.AddComment(new Comment("Emma", "Tip #3 changed the game for me."));
        v3.AddComment(new Comment("Noah", "Simple but super effective."));
        v3.AddComment(new Comment("Isabella", "Love the energy in this video."));
        videos.Add(v3);
        
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
