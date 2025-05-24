using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions fra = new Fractions();
        Console.WriteLine(fra.GetFractionString());
        Console.WriteLine(fra.GetDecimalValue());

        Fractions fra2 = new Fractions(5);
        Console.WriteLine(fra2.GetFractionString());
        Console.WriteLine(fra2.GetDecimalValue());

        Fractions fra3 = new Fractions(3, 4);
        Console.WriteLine(fra3.GetFractionString());
        Console.WriteLine(fra3.GetDecimalValue());

        Fractions fra4 = new Fractions(1, 3);
        Console.WriteLine(fra4.GetFractionString());
        Console.WriteLine(fra4.GetDecimalValue());

    }
}