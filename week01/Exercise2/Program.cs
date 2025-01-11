using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Please enter your grade percentage: ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        
        string letterGrade = "";

        if (gradeNumber >= 90)
        {
            letterGrade = "A";
        }
        else if (gradeNumber >= 80 && gradeNumber < 90)
        {
            letterGrade = "B";
        }
        else if (gradeNumber >= 70 && gradeNumber < 80)
        {
            letterGrade = "C";
        }
        else if (gradeNumber >= 60 && gradeNumber < 70)
        {
            letterGrade = "D";
        }
        else 
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is {letterGrade}.");
        
        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else 
        {
            Console.WriteLine("Better luck next time.");
        }
    }

}