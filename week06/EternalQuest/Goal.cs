public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    public int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
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

    return $"[{status}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
    }