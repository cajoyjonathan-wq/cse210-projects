public class Video
{
    public string _title = "";
    public string _author = "";
    public int _lengthSeconds = 0;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

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
        return _lengthSeconds;
    }

    public List<Comment> GetComment()
    {
        return _comments;
    }
    
    public int NumberOfComments()
    {
        return _comments.Count;
    }
}