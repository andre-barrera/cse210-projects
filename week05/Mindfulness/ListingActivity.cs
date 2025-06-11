public class ListingActivity : Activity
{
    protected int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are the people you love/apreciate the most?",
        "What are your strengths?",
        "Have you helped anyone this week?",
        "When have you felt the company of Holy Ghost during this month?",
        "Who are your heroes / role models?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect in the good things in your life by listing as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetPrompt();
        Console.WriteLine($"List as many responses as you can:\n--- {prompt} ---");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        List<string> items = GetListFromUser();
        _count = items.Count;

        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();
    }

    public string GetPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input);
        }
        return items;
    }
}
