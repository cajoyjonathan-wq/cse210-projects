public class Assignment
{
    public string _studentName = "";
    public string _topic = "";

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }


    public string GetSummary()
    {
        string summary = $"{_studentName} - {_topic}";
        return summary;
    }
}