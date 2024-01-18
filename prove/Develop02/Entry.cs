using System.IO;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }

     public void SaveToCsv(string filePath)
    {
       

            using (StreamWriter _newEntry = new StreamWriter(filePath,true))
            {
                
            _newEntry.WriteLine("Date,Prompt,Entry");
                
            _newEntry.WriteLine($"{_date},{_promptText},{_entryText}");
            }
    }
}
