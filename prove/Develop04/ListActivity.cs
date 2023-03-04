using System;

public class ListActivity : Activity
{
    // Attributes
    private string _introMessage;
    private string _prompt;
    private int _itemsListed;

    // Constructor
    public ListActivity(string type) : base(type)
    {
        _introMessage = "\nThis activity will help you reflect on the good\n" +
            "things in your life by having you list as many\n" +
            "things as you can in a certain area.";
    }

    // Methods
    private void DisplayIntro()
    {
        Console.WriteLine(_introMessage);
    }

    // Calls Prompt class to get a random
    // prompt and display the prompt on screen.
    private void DisplayPrompt()
    {
        Prompt prompt = new Prompt("Lprompts.txt");
        _prompt = prompt.GeneratePrompt();
        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"-- {_prompt} --");
        Console.Write("You may begin in: ");
    }

    // Prompt for response until duration of activity
    // is reached. Display how many things were listed.
    private void List()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            _itemsListed += 1;
        }

        Console.WriteLine($"You listed {_itemsListed} items.");
    }
    
    // Call on methods from Activity class and
    // above to display messages and pause program.
    public void RunActivity()
    {
        DisplayWelcome();
        DisplayIntro();
        PromptDurationTime();
        DisplayReady();
        DisplayDots(3);

        DisplayPrompt();
        CountDown(5);
        List();

        DisplayWellDone();
        DisplaySpinner(3);
        DisplayFinish();
        DisplaySpinner(4);
    }
}