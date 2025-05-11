using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        string sign = "";
        Console.WriteLine("Please enter your grade percentage:");
        string gradePercentage = Console.ReadLine();
        int gradePercentageNum = int.Parse(gradePercentage);

        if (gradePercentageNum >= 90)
        {
            letter = "A";
        }
        else if (gradePercentageNum >= 80)
        {
            letter = "B";
        }
        else if (gradePercentageNum >= 70)
        {
            letter = "C";
        }
        else if (gradePercentageNum >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        int calculateSign = gradePercentageNum % 10;
        if (letter == "A" && gradePercentageNum < 93)
        {
            sign = "-";
        }
        else if (letter != "A" && letter != "F")
        {
            if (calculateSign >= 7)
            {
                sign = "+";
            }
            else if (calculateSign < 3)
            {
                sign ="-";
            }
        }

        Console.WriteLine ($"Your grade is {letter}{sign}");
        if (gradePercentageNum > 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You're almost there!");
        }
    }
}