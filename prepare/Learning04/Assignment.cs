public class Assignment
{
    private string _studentName;
    private string _topic;

    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_studentName} - {_topic}");
    }
}