public class WritingAssignment : Assignment
{
    public string _title = "";

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string summary = $"{_studentName} - {_topic}\n{_title} by {_studentName}";
        return summary;
    }
}