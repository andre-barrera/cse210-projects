public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity was created to help you feel relax by completing a breathing exercise";
    }

    public void Run()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string secondsInput = Console.ReadLine();
        int numOfSeconds = int.Parse(secondsInput);
        Console.Clear();

        Console.WriteLine("Get Ready");
        ShowSpinner(4);

        DateTime startingTime = DateTime.Now;
        DateTime endingTime = startingTime.AddSeconds(numOfSeconds);

        int breathInTime = 3;
        int breathOutTime = 3;
        int cycleTime = breathInTime + breathOutTime;

        while (DateTime.Now.AddSeconds(cycleTime) <= endingTime)
        {
            Console.Write("Breathe in ... ");
            ShowCountDown(breathInTime);
            Console.WriteLine();
            Console.Write("Breathe out ... ");
            ShowCountDown(breathOutTime);
            Console.WriteLine();
        }


        int remainingSeconds = (int)(endingTime - DateTime.Now).TotalSeconds;
        if (remainingSeconds > 0)
        {
            int finalIn = (remainingSeconds + 1) / 2;  
            int finalOut = remainingSeconds - finalIn;

            if (finalIn > 0)
            {
                Console.Write("Final breathe in ... ");
                Console.Write("");
                ShowCountDown(finalIn);
            }
            if (finalOut > 0)
            {
                Console.Write("Final breathe out ... ");
                Console.Write("");
                ShowCountDown(finalOut);
            }
        }

        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
    }
}
