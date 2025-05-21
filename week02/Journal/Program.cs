using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool repeat = true;

        while (repeat)
        {
            Console.WriteLine("Enter the number of your choice");
            Console.WriteLine("1. Create a new entry\n2. Display Journal\n3. Save\n4. Load Existing Journal\n5. Exit");
            Console.Write("Please enter your choice: ");
            string userResponse = Console.ReadLine();

            int userResponseInt = int.Parse(userResponse);
            if (userResponseInt != 1 && userResponseInt != 2 && userResponseInt != 3 && userResponseInt != 4 && userResponseInt != 5)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.\n");
                continue;
            }

            if (userResponseInt == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your answer: ");
                string promptResponse = Console.ReadLine();
                Entry newEntry = new Entry(prompt, promptResponse);
                journal.AddEntry(newEntry);
            }

            if (userResponseInt == 2)
            {
                journal.DisplayAll();
            }

            if (userResponseInt == 3)
            {
                Console.Write("Enter a filename to save in your journal: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
                Console.WriteLine("Journal was saved successfully.");
            }

            if (userResponseInt == 4)
            {
                Console.Write("Enter a filename for your journal: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
                Console.WriteLine("Journal was loaded successfully.");
            }

            if (userResponseInt == 5)
            {
                repeat = false;
                Console.WriteLine("Thank you!");
            }
            
            Console.WriteLine();
        }
    }
}
