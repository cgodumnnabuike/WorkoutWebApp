using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkoutWebApp.Models;

namespace WorkoutWebApp.Data
{
    public class WorkoutWebAppContext : DbContext
    {
        public WorkoutWebAppContext (DbContextOptions<WorkoutWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<WorkoutWebApp.Models.Workout> Workout { get; set; } = default!;
    }
}
