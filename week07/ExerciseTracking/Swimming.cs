using System;

public class Swimming : Activity
{
    private int _lapCount;

    public Swimming(DateTime date, int lengthMinutes, int lapCount)
        : base(date, lengthMinutes)
    {
        _lapCount = lapCount;
    }

    public override double GetDistance() => (_lapCount * 50) / 1000.0;
    public override double GetSpeed() => (GetDistance() / GetLengthMinutes()) * 60;
    public override double GetPace() => GetLengthMinutes() / GetDistance();
}