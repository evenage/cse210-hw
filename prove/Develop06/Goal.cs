public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    
    public string Name()
    {
        return _shortName;
    }
     public int GetPoints()
    {
        return _points;
    }

    // Abstract methods for behavior specific to each goal type
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    
    
    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName} - {_description}";
    }

    // Abstract method for saving goal data
    public abstract string GetStringRepresentation();
}


