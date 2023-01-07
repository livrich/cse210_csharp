using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();
        double doublePercent = Math.Round(Single.Parse(gradePercent));
        int percent = Convert.ToInt32(doublePercent);

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

        int remainder = percent % 10;
        string sign = "";

        if (remainder >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (remainder < 3 && letter != "F")
        {
            sign = "-";
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}");

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