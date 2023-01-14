using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        bool getNumber = true;
        while (getNumber == true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                getNumber = false;
            }
            else
            {
                numbers.Add(number);
            }
        }

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");

        int smallestPositive = 100;
        foreach (int num in numbers)
        {
            if (num < 0)
            {
                continue;
            }
            else
            {
                if (num < smallestPositive)
                {
                    smallestPositive = num;
                }
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        
    }
}