using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();
        int newNumberInt = -1;
        int numSum = 0;
        int largestNumber = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (newNumberInt != 0)
        {
        Console.Write("Enter number: ");
        string newNumber = Console.ReadLine();
        newNumberInt = int.Parse(newNumber);

        if (newNumberInt != 0)
        {
        numbers.Add(newNumberInt);
        numSum += newNumberInt;

        if(newNumberInt > largestNumber)
        {
            largestNumber = newNumberInt;
        }

        }
        }

        int numOfEntries = numbers.Count;
        int aveNum = numSum / numOfEntries;



        Console.WriteLine($"The sum is {numSum}");
        Console.WriteLine($"The average is {aveNum}");
        Console.WriteLine($"The largest number is {largestNumber}");






    }
}