using System.Data.Entity;
using WorkoutApp.Domain;

namespace WorkoutApp.DataAccessLayer
{
    public class WorkoutAppDbContext : DbContext
    {
        public WorkoutAppDbContext() : base("name=WorkoutDb") { }

        public DbSet<Workout> Workouts { get; set; }
    }
}