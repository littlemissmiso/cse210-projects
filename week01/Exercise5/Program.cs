using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userSquareNumber = SquareNumber(userNumber);

        DisplayResult(userName, userSquareNumber);    
    }   
        
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!"); 
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int squareNum = number * number;

        return squareNum;
    }

    static void DisplayResult(string userName, int squareNum)
    {
        Console.WriteLine($"Thanks {userName}, the square root of your number is {squareNum}.");
    }

        
}