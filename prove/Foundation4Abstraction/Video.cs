using System;
using System.Collections.Generic;

public class Videos 
{
    public string _author { get; set; }
    public string _title { get; set; }
    public int _length { get; set; }
    private list<Comment> _comments;

    public Video(string _title, string _author, int _length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}