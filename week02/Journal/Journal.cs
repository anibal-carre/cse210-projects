using System;
using System.Collections.Generic;
using System.IO;
class Journal
{
    public List<Entry> _entries = [];


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine();
            Console.WriteLine($"{entry._date} - Prompt: {entry._promptText}");
            Console.WriteLine($"{entry._entryText}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {

        try
        {
            using StreamWriter outputFile = new(file);
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._entryText} - {entry._date} - {entry._promptText}");
            }
            Console.WriteLine("Journal saved successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }

    }

    public void LoadFromFile(string file)
    {
        try
        {
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] entryParts = line.Split('-');
                Entry newEntry = new()
                {
                    _entryText = entryParts[0],
                    _date = entryParts[1],
                    _promptText = entryParts[2]
                };
                _entries.Add(newEntry);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: The file '{file}' was not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }
}