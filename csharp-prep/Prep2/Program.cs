using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();
        float percent = Single.Parse(gradePercent);

        string letter = "F";
        
        do
        {
            if (percent >= 60)
            {
                if (percent >= 70)
                {
                    if (percent >= 80)
                    {
                        if (percent >= 90)
                        {
                            letter = "A";
                            break;
                        }
                        letter = "B";
                        break;
                    }
                    letter = "C";
                    break;
                }
                letter = "D";
            }
        } while (false);

        Console.WriteLine($"Your letter grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed... :(");
        }
        

    }
}