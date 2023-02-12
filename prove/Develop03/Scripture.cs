using System;

class Scripture {
    // Attributes
    private string _text;
    private List<string> _textList;
    private string _underscore;
    private Boolean _allHidden;


    // Constructor to set text attribute
    // and turn text string into list.
    public Scripture(string text)
    {
        _text = text;
        _textList = ConvertToList();
    }

    // Method to get text so it can be displayed.
    public string GetText()
    {
        return _text;
    }

    // Method to convert a string into a list.
    // Breaks sting at each space character.
    private List<string> ConvertToList()
    {
        _textList = _text.Split(" ").ToList();
        return _textList;
    } 

    // Method to pick and hide a word from the text.
    public void HideWord()
    {
        // Get random index of a word in _textList
        Random rnd = new Random();
        // Min value is included, max value is not.
        int number = rnd.Next(0, _textList.Count);
        
        // Instance of Word where _word will be value at the
        // index of the random number.
        Word word = new Word(_textList[number]);
        
        // Call method to convert word to underscores.
        _underscore = word.ConvertToUnderscore();

        // Update list to have underscore words.
        _textList[number] = _underscore;
    }

    // Method to display list version of text.
    public void DisplayList()
    {
        foreach (string word in _textList)
        {   
            // Space after word is important for formatting.
            Console.Write($"{word} ");
        }
    }

    // Method to check if all words have been hidden.
    public bool CheckIfAllHidden()
    {
        // List to hold true/false if each word is hidden.
        List<bool> isHidden = new List<bool>();

        foreach (string word in _textList)
        {
            // Only checking first character of each word.
            // If first character is '_' then whole word is.
            string first = word.Substring(0, 1);
            if (first != "_")
            {
                isHidden.Add(false);
            }
            else 
            {
                isHidden.Add(true);
            }
        }

        // If there is a false in the list, there's still
        // a word not hidden.
        if (isHidden.Contains(false))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}