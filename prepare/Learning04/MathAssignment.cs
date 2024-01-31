using System.Security.Cryptography.X509Certificates;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public void SetTextbookSection(string textbookSection)
    {
       _textbookSection = textbookSection;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public void GetHomeworkList()
    {
        Console.WriteLine($"Section {_textbookSection} Problems {_problems}");
    }
}