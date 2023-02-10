using System;

class Reference {
    private string _book;
    private string _chapter;
    private string _verse;
    private string _secondVerse;

    // Constructor to set value of book, chapter, and verse.
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _secondVerse = "";
    }

    // Constructor to set value of book, chapter, verse, and second verse.
    public Reference(string book, string chapter, string verse, string secondVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _secondVerse = secondVerse;
    }
    
    // Method to format reference based on number of verses.
    public string FormatReference()
    {
        if (_secondVerse == "")
        {
            string singleVerse = $"{_book} {_chapter}:{_verse}";
            return singleVerse;
        }
        else 
        {
            string doubleVerse = $"{_book} {_chapter}:{_verse}-{_secondVerse}";
            return doubleVerse;
        }
    }
}