using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> comments = new List<Comment>();
    private int _numComments = 0;

    // Constructor to set initial values
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Series of getters
    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }

    public int GetNumberComments()
    {
        return _numComments;
    }

    // Add comment to list of comments
    public void AddComment()
    {
        // User entered name
        Console.Write("Comment author's name: ");
        string name = Console.ReadLine();
        // User entered text
        Console.Write("Comment text: ");
        string text = Console.ReadLine();
        
        // Instance of Comment class
        Comment c = new Comment(name, text);
        // Add comment to list
        comments.Add(c);
    }

    // Determine how many comments there are
    public void CountNumComments()
    {
        _numComments = comments.Count();
    }
}