public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    public int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        Console.WriteLine($"You did it! You have earned {_points} points");

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"You have completed the checklist. You earned {_bonus} points");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status;
    if (IsComplete())
    {
        status = "X";
    }
    else
    {
        status = " ";
    }

    return $"[{status}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";

    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}
