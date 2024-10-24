using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet properties for each entity
        public DbSet<Control> Controls { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<CompletedTask> CompletedTasks { get; set; }
        public DbSet<LogCollection> LogCollections { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TaskDetail> TaskDetails { get; set; }
        public DbSet<Employee> Employee { get; set; }

        // Override OnModelCreating to configure relationships if necessary
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add any custom configuration for relationships or constraints here

            // For example:
            // modelBuilder.Entity<Task>()
            //     .HasOne(t => t.Project)
            //     .WithMany(p => p.Tasks)
            //     .HasForeignKey(t => t.ProjectId);
        }
    }
}
