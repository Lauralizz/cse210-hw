using System;

class Running : Activity
{
    public double Distance { get; set; }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / Length * 60;
    }

    public override double GetPace()
    {
        return Length / Distance;
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Running ({Length} min) - Distance {Distance} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}