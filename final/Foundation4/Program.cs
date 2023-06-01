using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running runningActivity = new Running()
        {
            Date = new DateTime(2022, 11, 3),
            Length = 30,
            Distance = 3.0
        };
        activities.Add(runningActivity);

        Cycling cyclingActivity = new Cycling()
        {
            Date = new DateTime(2022, 11, 3),
            Length = 30,
            Speed = 9.7
        };
        activities.Add(cyclingActivity);

        Swimming swimmingActivity = new Swimming()
        {
            Date = new DateTime(2022, 11, 3),
            Length = 30,
            Laps = 60
        };
        activities.Add(swimmingActivity);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }    
}