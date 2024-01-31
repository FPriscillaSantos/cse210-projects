public class WritingAssignment : Assignment
{
    private string _title;

    public void SetTitle(string title)
    {
        _title = title;
    }

    public void GetWritingInformation()
    {
        Console.WriteLine($"{_title}");
    }
}