using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumberNum = randomGenerator.Next(1,100);
        
        int userGuessNum = -1;
        int numberOfGuesses = 0;

        while (magicNumberNum != userGuessNum)
        {
        Console.Write($"What is your guess? ");
        string userGuess = Console.ReadLine();
        userGuessNum = int.Parse(userGuess);
        numberOfGuesses += 1;

        if (userGuessNum == magicNumberNum)
        {
            Console.WriteLine("Your guessed it!");
            Console.WriteLine($"You had {numberOfGuesses} attempts");
        }
        else if (userGuessNum > magicNumberNum)
        {
            Console.WriteLine("Lower");
        }
        else if (userGuessNum < magicNumberNum)
        {
            Console.WriteLine("Higher");
        }
        }
        
    }
}