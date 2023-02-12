using System;

class Word {
    private string _word;

    // Constructor to set word.
    public Word(string word)
    {
        _word = word;
    }
    
    // Method to replace characters of word with underscores.
    public string ConvertToUnderscore()
    {
        // Don't hide line break '\n'
        // Ya this if statement didn't do anything to
        // fix the line break problem.
        if (_word == "\n")
        {
            return "\n";
        }
        else
        {
            foreach (char character in _word)
            {
                string c = character.ToString();
                _word = _word.Replace(c, "_");
            }
            return _word;
        }
    }
}