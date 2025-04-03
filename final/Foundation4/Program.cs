using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2028, 11, 3), 32, 3.333),
            new Cycling(new DateTime(1924, 11, 3), 44, 15.1),
            new Swimming(new DateTime(0, 11, 3), 40, 31)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}