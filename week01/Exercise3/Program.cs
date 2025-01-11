using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Console.Write("What is the magic number? ");
        // string startNumber = Console.ReadLine();
        // int magicNumber = int.Parse(startNumber);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        int guess = -1; 

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }

        }
    }
}