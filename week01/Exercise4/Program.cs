using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numberList = new List<int>();

        int number = -1;

        while (number != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.Write("Enter number: ");
            string numberString = Console.ReadLine();
            number = int.Parse(numberString);

            if (number != 0)
            {
                numberList.Add(number);
            }   
        }
        
        int sum = 0;
        foreach (int num in numberList)
        {
            sum += num;
           
        }

        Console.WriteLine($"The sum is: {sum}"); 

        float average = ((float)sum) / numberList.Count;
        Console.WriteLine($"The average is: {average}");

        int maxNumber = numberList[0];

        foreach (int num in numberList)
        {
            if (num > maxNumber)
            {
                maxNumber = num;
            }
        }
        Console.WriteLine($"The max is: {maxNumber}");
    
    }
}