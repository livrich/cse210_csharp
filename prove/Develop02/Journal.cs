using System;
using System.IO;

public class Journal
{
    // Attribute for name of file.
    public string _filename;

    // Method to save allEntries list to text file.
    public void SaveJournal(List<string> entries, string file)
    {
        File.WriteAllLines(file, entries);
    }

    // Could not figure out how to get this to work.
    // Instead included as part of Program.cs.
    // public void LoadJournal(string file)
    // {
    //     File.ReadAllLines(file);
    // }
}