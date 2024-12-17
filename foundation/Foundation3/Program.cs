using System;

class Program
{
    static void Main(string[] args)
    
{
    
    {
        List<Activity> activities = new List<Activity>();

        // Adding different activities
        activities.Add(new Running("03 Nov 2022", 30, 5.0));

        activities.Add(new Cycling("04 Nov 2022", 45, 15.0));
        
        activities.Add(new Swimming("05 Nov 2022", 20, 30));

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
}                                                                                                                                                                                                                              