class ChecklistGoal : Goal 
{
    // Represents a checklist goal in the Eternal Quest game
    private int _amountCompleted; private int _target; private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    // Records the completion of a checklist item and returns the points earned
    public override int RecordEvent()
    {
        int earned = _points;
        _amountCompleted++;
        if (_amountCompleted == _target) earned += _bonus;
        return earned;
    }
    // Checks if the checklist goal is complete
    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target}";
    }
    // Returns a string representation of the checklist goal
    public override string GetStringRepresentation() => $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";

}