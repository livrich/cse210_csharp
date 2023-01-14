using System;

class Program
{
    static void Main(string[] args)
    {
        // Create new list called numbers.
        List<int> numbers = new List<int>();
        
        // Display instruction message.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        // Loop to keep getting numbers for list until 0 is entered.
        bool getNumber = true;
        while (getNumber == true)
        {
            // Get number from user.
            Console.Write("Enter number: ");
            // Convert input into int.
            int number = int.Parse(Console.ReadLine());

            // Exit loop, don't add 0 to list.
            if (number == 0)
            {
                getNumber = false;
            }
            // Add number to list.
            else
            {
                numbers.Add(number);
            }
        }

        // Calculate the sum of list.
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // Calculate average of list.
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        // Determine largest number in list.
        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");

        // Determine smallest positive number in list.
        // Initialize smallest positive number.
        int smallestPositive = 100;
        foreach (int num in numbers)
        {
            // Skip number if negative.
            if (num < 0)
            {
                continue;
            }
            // Compare number to current smallest
            // positive number and set as smallest
            // positive number if appropriate.
            else
            {
                if (num < smallestPositive)
                {
                    smallestPositive = num;
                }
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Sort list of numbers.
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        
    }
}