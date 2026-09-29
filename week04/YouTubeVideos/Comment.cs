public class Comment
{
    public string _nameOfComment = "";
    public string _textOfComment = "";

    public Comment(string nameOfComment, string textOfComment)
    {
        _nameOfComment = nameOfComment;
        _textOfComment = textOfComment;
    }

    public string GetName()
    {
        return _nameOfComment;
    }
    
    public string GetText()
    {
        return _textOfComment;
    }
}