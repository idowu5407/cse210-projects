using System;

abstract class Goal
{
    // Base class for all goals in the Eternal Quest game
    protected string _shortName; protected string _description; protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    // Abstract methods to be implemented by derived classes
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
    public string GetName() => _shortName;

}

