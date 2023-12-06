using System;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // To create activities of different types
        activities.Add(new Running(new DateTime(2023, 11, 03), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2023, 11, 03), 30, 15.0));
        activities.Add(new Swimming(new DateTime(2023, 11, 03), 30, 20));

        // To display summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine("\n");
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("\n");
        }
    }
}