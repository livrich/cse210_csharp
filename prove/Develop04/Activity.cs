using System;

public class Activity 
{
    // Attributes
    private string _activityType;
    private string _welcomeMessage;
    private string _readyMessage;
    private string _durationMessage;
    protected int _duration;
    private string _wellDoneMessage;
    private string _finishMessage;

    // Constructors
    public Activity(string type) 
    {
        _activityType = type;
        _welcomeMessage = $"Welcome to the {_activityType} Activity.";
        _readyMessage = "\nGet ready";
        _durationMessage = "\nHow long, in seconds, would you like for your session? ";
        _wellDoneMessage = "\nWell done!!";
        // If I initialize here, _duration will always be initial value of zero.
        // _finishMessage = $"\nYou have completed another {_duration} seconds of the {_activityType} Activity."; 
    }

    // Methods
    protected void DisplayWelcome()
    {
        Console.WriteLine(_welcomeMessage);
    }

    protected void DisplayReady()
    {
        Console.Write(_readyMessage);
    }

    protected void DisplayWellDone()
    {
        Console.WriteLine(_wellDoneMessage);
    }

    protected void DisplayFinish()
    {
        // If I initialize finish message sooner, _duration doesn't update or causes errors.
        _finishMessage = $"\nYou have completed another {_duration} seconds of the {_activityType} Activity.";
        Console.WriteLine(_finishMessage);
    }

    // This method still works if I return void.
    // Get's duration for activity from user and
    // converts string input to int.
    protected int PromptDurationTime()
    {
        Console.Write(_durationMessage);
        string answer = Console.ReadLine();
        _duration = Int32.Parse(answer);
        return _duration;
    }

    // Print dot and pause program for one second, 
    // for as long as declared time.
    protected void DisplayDots(int time)
    {
        // _duration needs to be part of duration
        for (int i = time; i > 0; i --)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        // To move to next line after dots are displayed.
        Console.WriteLine();
    }

    // Count down timer. Backspaces, writes space character,
    // backspaces, then writes next number. Program pauses for
    // one second between writing next number.
    protected void CountDown(int time)
    {
        for (int i = time; i > 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        // To move to next line after count down.
        Console.WriteLine();
    }

    // Prints character from list, then does same backspace
    // concept as count down to display next character.
    protected void DisplaySpinner(int time)
    {
        // Way to have "spinning" animation
        List<string> animations = new List<string>();
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        int i = 0;
        
        while (DateTime.Now < endTime)
        {
            string a = animations[i];
            Console.Write(a);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            // When i would be out of list range,
            // reset i to 0 and go through list again.
            if (i >= animations.Count())
            {
                i = 0;
            }
        }
    }
}