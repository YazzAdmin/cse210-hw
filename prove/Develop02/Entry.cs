using System;

public class Entry
{
    public string _insertDate;
    public string _promptGenertn;
    public string _entry;

    public void ViewEntry()
    {
        Console.WriteLine($"Date: {_insertDate} - prompt: {_promptGenertn} ");
        Console.WriteLine($"Entry: {_entry}");
    }
}

