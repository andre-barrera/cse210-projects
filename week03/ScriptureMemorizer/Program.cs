using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nefi", 3, 7, -1);
        string scriptureMemorize = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        Scripture scripture = new Scripture(reference, scriptureMemorize);

        while (scripture.IsCompletelyHidden() == false)
        {
            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string userAnswer = Console.ReadLine();
            if (userAnswer.ToLower() == "quit")
                break;

            scripture.HideRandomWords(7);
        }

        Console.WriteLine();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll the words are now hidden. Thank you for participating");
    }
}