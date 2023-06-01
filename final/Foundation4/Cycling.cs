using System;

class Cycling : Activity
{
    public double Speed { get; set; }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Cycling ({Length} min) - Speed: {Speed} kph, Pace: {GetPace()} min per km";
    }
}