using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WorkoutWebApp.Data;
using System;
using System.Linq;

namespace WorkoutWebApp.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new WorkoutWebAppContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<WorkoutWebAppContext>>()))
        {
            // Look for any movies.
            if (context.Workout.Any())
            {
                return;   // DB has been seeded
            }
            context.Workout.AddRange(
                new Workout
                {
                    Exercise = "Flat Chest Press",
                    Sets = 3,
                    Reps = 8,
                    Notes = "Make sure to do a 90 degree angle.",
                    CreatedDatetime = DateTime.Now
                },
                new Workout
                {
                    Exercise = "Incline Chest Press",
                    Sets = 3,
                    Reps = 8,
                    Notes = "Make sure to do a 90 degree angle.",
                    CreatedDatetime = DateTime.Now
                },
              new Workout
              {
                  Exercise = "Leg Squat",
                  Sets = 3,
                  Reps = 10,
                  Notes = "70% of PR (Personal Record).",
                  CreatedDatetime = DateTime.Now
              },
                new Workout
                {
                    Exercise = "Leg Extension",
                    Sets = 4,
                    Reps = 12,
                    Notes = "Fully extend leg at the top.",
                    CreatedDatetime = DateTime.Now
                }
            );
            context.SaveChanges();
        }
    }
}