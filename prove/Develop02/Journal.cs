using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

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

    public void SaveToFile(string filename)
    {
        try
        {
            // Use Path.Combine para criar o caminho do arquivo
            string filePath = Path.Combine(@"C:\Users\fabia\OneDrive\Área de Trabalho\BYU\CSE 210 Programming With Classes\cse210-projects\prove\Develop02\", $"{filename}.txt");

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (Entry record in _entries)
                {
                    writer.WriteLine($"Date: {record._date} - Prompt: {record._promptText}\r\n - {record._entryText}\r\n");
                }
            }
            Console.WriteLine($"File saved successfully as {filename}");

            //_entries.Clear();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        string filePath = Path.Combine(@"C:\Users\fabia\OneDrive\Área de Trabalho\BYU\CSE 210 Programming With Classes\cse210-projects\prove\Develop02\", $"{filename}.txt");
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    // Divide a linha usando o separador "-"
                    string[] parts = line.Split(new[] { "-" }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length >= 3)
                    {
                        string dateText = parts[0].Trim();
                        string promptText = parts[1].Trim();
                        string entryText = parts[2].Trim();

                        Entry newEntry = new Entry
                        {
                            _date = dateText,
                            _promptText = promptText,
                            _entryText = entryText
                        };

                        _entries.Add(newEntry);
                    }
                }

                Console.WriteLine("File loaded successfully.");

                foreach (Entry record in _entries)
                {
                    Console.WriteLine($"Loaded Entry: Date: {record._date}, Prompt: {record._promptText}, Entry: {record._entryText}");
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
