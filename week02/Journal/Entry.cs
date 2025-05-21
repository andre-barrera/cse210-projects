using System;

public class Entry
{
    public string _date;
    public string _entryText;
    public string _promptText;

    public Entry(string prompt, string entryText)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = prompt;
        _entryText = entryText;
    }
    
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}
