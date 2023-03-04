using System;

class BreathingActivity : Activity 
{
    // Attributes
    private string _introMessage;
    private string _inMessage;
    private string _outMessage;

    // Constructor
    public BreathingActivity(string type) : base(type)
    {
        _introMessage = "\nThis activity will help you relax by walking you through breathing in and \n" +
            "out slowly. Clear your mind and focus on your breathing.";
        _inMessage = "Breathe in...";
        _outMessage = "Breathe out...";
    }

    // Methods
    private void DisplayIntro()
    {
        Console.WriteLine(_introMessage);
    }

    private void DisplayIn()
    {
        Console.Write($"\n{_inMessage}");
    }

    private void DisplayOut()
    {
        Console.Write(_outMessage);
    }

    // How long to breath in and out. Calculate how,
    // many full breaths can happen without exceeding
    // activity duration. Display breathing messages.
    private void Breathe()
    {
        // Would like to use while loop and count progressively
        // longer breaths until activity duration is met.
        // int timePassed = 0;
        int inTime = 6;
        int outTime = 6;
        int numBreaths = _duration / (inTime + outTime);
        
        for (int i = 0; i < numBreaths; i++)
        {
            DisplayIn();
            CountDown(inTime);
            DisplayOut();
            CountDown(outTime);
            // timePassed += 14;
        }
    }

    // Calls methods from Activity class and above to display
    // messages and pause program.
    public void RunActivity()
    {
        DisplayWelcome();
        DisplayIntro();
        PromptDurationTime();
        DisplayReady();
        DisplayDots(3);
        Breathe();
        DisplayWellDone();
        DisplaySpinner(3);
        DisplayFinish();
        DisplaySpinner(4);
    }
}