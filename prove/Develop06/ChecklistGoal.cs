public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        int pointsEarned = _points;

        if (_amountCompleted == _target)
        {
            pointsEarned += _bonus;
            Console.WriteLine($"Goal '{_shortName}' completed! You earned {pointsEarned} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{_shortName}' recorded! You earned {pointsEarned} points.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return IsComplete() ? $"[X] {_shortName} - {_description} ({_amountCompleted}/{_target})" : $"[ ] {_shortName} - {_description} ({_amountCompleted}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}


