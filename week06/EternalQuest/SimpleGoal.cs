class SimpleGoal : Goal 
{
    // Represents a simple goal in the Eternal Quest game
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    // Records the completion of the goal and returns the points earned
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }
    // Checks if the goal is complete
    public override bool IsComplete() => _isComplete;

    public override string GetStringRepresentation() => $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";

}