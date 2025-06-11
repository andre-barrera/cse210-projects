public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you did something for someone else.",
        "Think of a time when you did something very difficult.",
        "Think of a time when you protected a friend.",
        "Think of a time when you did an act of charity."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience important for you?",
        "Have you done anything similar before?",
        "How did you do it?",
        "What were your feelings after doing it?",
        "How was it different than other experiences?",
        "What is your favorite part of this experience?",
        "What could you learn from it?",
        "What did you learn from yourself?",
        "How can you remember this experience for the future?"
    };

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times when you have shown strength.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("\nRead the following message:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("When you are ready, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now think on each of the following questions:");
        ShowSpinner(3);
    }

    public void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"> {question}");
            ShowSpinner(4);
        }
    }
}
