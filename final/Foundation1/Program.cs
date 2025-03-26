using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Product X Review", "TechGuru", 300);
        v1.AddComment(new Comment("Alice", "Very informative!"));
        v1.AddComment(new Comment("Bob", "I just bought this product."));
        v1.AddComment(new Comment("Charlie", "Can you compare it to Product Y?"));
        videos.Add(v1);

        Video v2 = new Video("Unboxing Product Y", "GadgetGuy", 420);
        v2.AddComment(new Comment("Dave", "I love unboxings!"));
        v2.AddComment(new Comment("Eve", "That packaging looks sleek."));
        v2.AddComment(new Comment("Frank", "Can't wait to try this out."));
        videos.Add(v2);

        Video v3 = new Video("Product Z vs Product X", "ReviewQueen", 510);
        v3.AddComment(new Comment("Grace", "Z is way better."));
        v3.AddComment(new Comment("Heidi", "Thanks for the comparison."));
        v3.AddComment(new Comment("Ivan", "I think X has better value."));
        videos.Add(v3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
