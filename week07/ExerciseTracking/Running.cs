using System;

public class Running : Activity
{
    private double _distanceKm;

    public Running(DateTime date, int lengthMinutes, double distanceKm)
        : base(date, lengthMinutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance() => _distanceKm;
    public override double GetSpeed() => (_distanceKm / GetLengthMinutes()) * 60;
    public override double GetPace() => GetLengthMinutes() / _distanceKm;
}