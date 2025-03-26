using System;
using System.Collections.Generic;

public class Video
{
    public string title;
    public string author;
    public int lengthSeconds;
    public List<Comment> comments = new List<Comment>();

    public Video(string t, string a, int len)
    {
        title = t;
        author = a;
        lengthSeconds = len;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {lengthSeconds} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");
        foreach (var c in comments)
        {
            Console.WriteLine($"- {c.commenterName}: {c.text}");
        }
        Console.WriteLine();
    }
}
