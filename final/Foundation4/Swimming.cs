using System;

class Swimming : Activity
{
    public int Laps { get; set; }

    public override double GetDistance()
    {
        return Laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / Length * 60;
    }

    public override double GetPace()
    {
        return Length / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Swimming ({Length} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}