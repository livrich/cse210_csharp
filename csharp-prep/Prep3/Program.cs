using System;

class Program
{
    static void Main(string[] args)
    {
        // Loop that let's user pick to play game again.
        bool playGame = true;
        while (playGame == true)
        {
            // Code that let programmer pick winning number.
            // Console.Write("What is the magic number? ");
            // string answerString = Console.ReadLine();
            // int answer = Int32.Parse(answerString);

            // Also convert to int this way:
            // int magicNum = int.Parse(Console.ReadLine());

            // Generate random number between 1 and 100.
            // This is the number user tries to guess.
            Random randomGenerator = new Random();
            int answer = randomGenerator.Next(1, 101);

            // Track how many guesses it takes to guess number.
            int numGuesses = 0;
            
            // Loop lets user keep guessing until right number is picked.
            bool win = false;
            while (win == false)
            {
                // Get user guess, convert to integer, increase guess counter.
                Console.Write("Enter guess: ");
                int guess = int.Parse(Console.ReadLine());
                numGuesses += 1;

                // Determine if user guessed the number, or needs to guess
                // lower or higher. Display appropriate message.
                if (guess == answer)
                {
                    Console.WriteLine("You guessed the magic number!");
                    win = true;
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

            // Display how many guesses it took to win.
            Console.WriteLine($"It took you {numGuesses} guesses");

            // Loop to handle input errors while asking user if
            // they want to play again.
            bool valid = false;
            while (valid == false)
            {
                // Ask user if they want to play again.
                Console.Write("Would you like to play again? Y/N: ");
                string again = Console.ReadLine();
                // Convert answer to uppercase.
                // Must declare new variable or will not work.
                string playAgain = again.ToUpper();

                // Display goodbye message, exit game loop, exit
                // play again loop.
                if (playAgain == "N")
                {
                    Console.WriteLine("Thanks for playing, bye!");
                    playGame = false;
                    valid = true;
                }
                // Exit play again loop.
                else if (playAgain == "Y")
                {
                    valid = true;
                }
                // Display error message.
                else
                {
                    Console.WriteLine("That was not an option. Please pick again.");
                }
            }
        }
    }    
}