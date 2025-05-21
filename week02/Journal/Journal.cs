using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

    if (!File.Exists(filename))
    {
        Console.WriteLine($"File was not found: {filename}");
        return;
    }

    foreach (string prompt in File.ReadLines(filename))
    {
        string[] parts = prompt.Split(',');

        Entry entry = new Entry(parts[1], parts[2])
        {
            _date = parts[0]
        };
            _entries.Add(entry);
        }
    }
}


