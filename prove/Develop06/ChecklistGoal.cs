public class ChecklistGoal : Goal 
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points) 
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent() 
    {
        if (_amountCompleted < _target) {
            _amountCompleted++;
            Console.WriteLine($"Goal '{_shortName}' recorded event {_amountCompleted}/{_target}!");
            if (_amountCompleted == _target) {
                Console.WriteLine($"Congratulations! Goal '{_shortName}' completed with bonus {_bonus} points!");
            }
        } else {
            Console.WriteLine($"Goal '{_shortName}' has already been completed.");
        }
    }

    public override bool IsComplete() 
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString() 
    {
        return $"{base.GetDetailsString()} ({_amountCompleted}/{_target} completed)";
    }

    public override string GetStringRepresentation() 
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}