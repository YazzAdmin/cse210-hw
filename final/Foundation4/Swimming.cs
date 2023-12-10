using System;
public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62; // Distance (miles)
    }

    public override double GetSpeed(){   
        return _laps * 50 / 1000 / (GetLengthInMinutes() / 60.0); // Speed in mph
    }

    public override double GetPace()
    {
        return (GetLengthInMinutes() / (_laps * 50 / 1000)); // minutes per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}Swimming ({GetLengthInMinutes()} min): Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}