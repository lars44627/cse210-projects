using System;

public class Cycling : Activity
{
    private double _speedInMph;

    public Cycling(DateTime date, int lengthInMinutes, double speedInMph)
        : base(date, lengthInMinutes)
    {
        _speedInMph = speedInMph;
    }

    public override double GetDistance() => (_speedInMph * GetLength()) / 60;
    public override double GetSpeed() => _speedInMph;
    public override double GetPace() => 60 / _speedInMph;
}