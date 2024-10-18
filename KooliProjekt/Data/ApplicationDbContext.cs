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

        // DbSets for your application models
        public DbSet<Employee> Employees { get; set; }
        public DbSet<CompletedTask> CompletedTasks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<LogCollection> LogCollections { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectDetails> ProjectDetails { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskDetails> TaskDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cleaner> Cleaners { get; set; }

    }
}
