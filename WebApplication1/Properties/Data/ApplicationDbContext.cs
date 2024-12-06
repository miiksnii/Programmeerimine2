using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Properties.Data;

namespace WebApplication1.Properties.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)  // Pass options to the base constructor
        { }


        public DbSet<Project> Projects { get; set; }

        // DbSet for Employees table
        public DbSet<Employee> Employees { get; set; }

        // DbSet for ProjectLists (if you want to persist ProjectList objects in DB)
        public DbSet<ProjectList> ProjectLists { get; set; }

        // DbSet for EmployeeLists (if you want to persist EmployeeList objects in DB)
        public DbSet<EmployeeList> EmployeeLists { get; set; }
    }
}
