using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthSeconds;
    public List<Comment> comments = new List<Comment>();

    public Video(string t, string a, int len)
    {
        _title = t;
        _author = a;
        _lengthSeconds = len;
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
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthSeconds} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");
        foreach (var c in comments)
        {
            Console.WriteLine($"- {c._commenterName}: {c._text}");
        }
        Console.WriteLine();
    }
}
