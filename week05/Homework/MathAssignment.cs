public class MathAssignments : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignments(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    
    public string GetHomeWorkList()
    {
        string summary = $"{_studentName} - {_topic}\n{_textbookSection} - {_problems}";
        return summary;
    }
}