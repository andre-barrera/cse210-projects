using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Choose an Option:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option above: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you! Goodbye");
            }
            else
            {
                Console.WriteLine("Invalid answer. Press Enter to try again.");
                Console.ReadLine();
            }
        }
    }
}
