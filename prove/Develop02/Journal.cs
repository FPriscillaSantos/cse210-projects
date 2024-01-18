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
    try
        {
            string filePath = @"C:\Users\fabia\OneDrive\Área de Trabalho\BYU\CSE 210 Programming With Classes\cse210-projects\prove\Develop02\record.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (Entry record in _entries)
                {
                    writer.WriteLine($"Date: {record._date} - Prompt: {record._promptText}\r\n{record._entryText}\r\n");
                }
            }
            Console.WriteLine("File saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
}

    public void LoadFromFile(string file)
    {
        // Implementar a lógica de leitura de um arquivo, se necessário
    }
}