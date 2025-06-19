class EternalGoal : Goal 
{
    // Represents an eternal goal in the Eternal Quest game
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent() => _points;

    public override bool IsComplete() => false;

    public override string GetStringRepresentation() => $"EternalGoal|{_shortName}|{_description}|{_points}";

}