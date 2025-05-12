using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome();
       
       string userName = PromptUserName();

       int userNumber = PromptUserNumber();

       int squaredNumber = SquareNumber(userNumber);

       DisplayResult(userName, squaredNumber);

    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

    static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
    static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userNumber = Console.ReadLine();
            int userNumberint = int.Parse(userNumber);
            return userNumberint;
        }
    static int SquareNumber(int usernumber)
        {
            int usernumberSquared = usernumber * usernumber;
            return usernumberSquared;
        }
    static void DisplayResult(string username, int squarednumber)
        {
            Console.WriteLine($"{username}, the square of your number is {squarednumber}");
        }
}