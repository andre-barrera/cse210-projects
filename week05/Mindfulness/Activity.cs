public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity() { }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine($"{_description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nPerfect!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed the {_name} for {_duration} seconds.");
        ShowSpinner(4);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> _spinnerAnimation = new List<string> { "/", "-", "\\", "|" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int s = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(_spinnerAnimation[s]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            s = (s + 1) % _spinnerAnimation.Count;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
