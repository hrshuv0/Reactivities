using Domain;

namespace Persistence;

public class Seed
{
    public static async Task SeedData(DataContext context)
    {
        if (context.Activities.Any()) return;

        var activities = new List<Activity>()
        {
            new Activity()
            {
                Title = "Past Activity 1",
                Date = DateTime.Now.AddMonths(-2),
                Description = "Activity 2 month ago",
                Category = "drinks",
                City = "London",
                Venue = "Pub"
            },
            new Activity()
            {
                Title = "Past Activity 2",
                Date = DateTime.Now.AddMonths(-1),
                Description = "Activity 1 month ago",
                Category = "culture",
                City = "Paris",
                Venue = "Louvre"
            },
            new Activity()
            {
                Title = "Future Activity 1",
                Date = DateTime.Now.AddMonths(2),
                Description = "Activity 2 month in future",
                Category = "music",
                City = "London",
                Venue = "02 Arena"
            },
            new Activity()
            {
                Title = "Future Activity 2",
                Date = DateTime.Now.AddMonths(-2),
                Description = "Activity 2 month in future",
                Category = "drinks",
                City = "London",
                Venue = "Another Pub"
            }
        };

        await context.Activities.AddRangeAsync(activities);
        await context.SaveChangesAsync();
    }
    
}