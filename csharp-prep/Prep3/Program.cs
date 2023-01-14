using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string answerString = Console.ReadLine();
        // int answer = Int32.Parse(answerString);

        Random randomGenerator = new Random();
        int answer = randomGenerator.Next(1, 101);

        bool state = false;
        while (state == false)
        {
            Console.Write("Enter guess: ");
            string guessString = Console.ReadLine();
            int guess = Int32.Parse(guessString);

            if (guess == answer)
            {
                Console.WriteLine("You guessed the magic number!");
                state = true;
            }
            else if (guess > answer)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
        
    }
}