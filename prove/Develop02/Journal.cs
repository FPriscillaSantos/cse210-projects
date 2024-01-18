using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry record in _entries)
        {
            Console.WriteLine($"Date: {record._date} - Prompt: {record._promptText}\r\n{record._entryText}\r\n");
        }
    }

    public void SaveToFile()
    {
        string filename = "record.txt";

        using (StreamWriter writer = new StreamWriter(filename, true))
        {
            foreach (Entry record in _entries)
            {
                writer.WriteLine($"Date: {record._date} - Prompt: {record._promptText}\r\n{record._entryText}\r\n");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        // Implementar a lógica de leitura de um arquivo, se necessário
    }
}