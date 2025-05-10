using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string fist_name = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string last_name = Console.ReadLine();
        
        Console.WriteLine($"Your name is {last_name}, {fist_name} {last_name}");
    }
}


