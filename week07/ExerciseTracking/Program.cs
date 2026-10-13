using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        RunningActivity running = new RunningActivity("August 23, 2026", 30, 4.0);
       
        CyclingActivity cycling = new CyclingActivity("August 27, 2026", 40, 13);
        
        SwimmingActivity swimming = new SwimmingActivity("August 29, 2026", 20, 3);
        

        List<Activity> activities = new List<Activity>();

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}