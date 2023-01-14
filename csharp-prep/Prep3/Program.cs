using System;

class Program
{
    static void Main(string[] args)
    {
        string playGame = "Y";
        while (playGame == "Y")
        {
            // Console.Write("What is the magic number? ");
            // string answerString = Console.ReadLine();
            // int answer = Int32.Parse(answerString);

            Random randomGenerator = new Random();
            int answer = randomGenerator.Next(1, 101);

            int numGuesses = 0;
            
            bool state = false;
            while (state == false)
            {
                Console.Write("Enter guess: ");
                string guessString = Console.ReadLine();
                int guess = Int32.Parse(guessString);
                numGuesses += 1;

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

            Console.WriteLine($"It took you {numGuesses} guesses");

            bool valid = false;
            while (valid == false)
            {
                Console.Write("Would you like to play again? Y/N: ");
                string again = Console.ReadLine();
                string playAgain = again.ToUpper();

                if (playAgain == "N")
                {
                    Console.WriteLine("Thanks for playing, bye!");
                    playGame = "N";
                    valid = true;
                }
                else if (playAgain == "Y")
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("That was not an option. Please pick again.");
                }
            }
        }
    }    
}