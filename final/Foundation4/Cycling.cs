using System;
public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed; // Speed in mph
    }

    public override double GetDistance()
    {
        return _speed * (GetLengthInMinutes() / 60.0); // Distance in miles
    }

    public override double GetPace()
    {
        return 60.0 / _speed; // Minutes per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}Cycling ({GetLengthInMinutes()} min): Speed: {_speed} mph, Distance: {GetDistance()} miles, Pace: {GetPace()} min per mile";
    }
}