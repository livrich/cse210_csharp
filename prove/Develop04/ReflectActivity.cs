using System;

public class ReflectActivity : Activity 
{
    // Attributes
    private string _introMessage;
    private string _prompt;
    private string _question;

    // Constructor
    public ReflectActivity(string type) : base(type)
    {
        _introMessage = "\nThis activity will help you reflect on times in \n" +
            "your life when you have shown strength and resilience. \n" +
            "This will help you recognize the power you have and how \n" +
            "you can use it in other aspects of your life.";
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
        Prompt prompt = new Prompt("Rprompts.txt");
        _prompt = prompt.GeneratePrompt();
        Console.WriteLine($"\nConsider the following prompt:");
        Console.WriteLine($"-- {_prompt} --");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    private void DisplayInstruction()
    {
        Console.WriteLine("\nNow ponder on each of the following questions " +
            "as they relate to this experience.");
        Console.Write("You may begin in: ");
    }

    // Calls Prompt class to get a random question,
    // clear the console, and display the question.
    private void DisplayQuestion()
    {
        Prompt question = new Prompt("Rquestions.txt");
        _question = question.GeneratePrompt();
        Console.Clear();
        Console.Write($"> {_question} ");
    }

    // Keep providing questions until time passed
    // exceeds or equals the activity duration.
    private void Reflect()
    {
        int reflectTime = 8;
        int timePassed = 0;

        while (timePassed < _duration)
        {
            DisplayQuestion();
            DisplaySpinner(reflectTime);
            timePassed += reflectTime;
        }
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
        DisplayInstruction();
        CountDown(5);
        Reflect();

        DisplayWellDone();
        DisplaySpinner(3);
        DisplayFinish();
        DisplaySpinner(4);
    }
}