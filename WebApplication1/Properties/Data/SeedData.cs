using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Properties.Data
{
    public static class SeedData
    {
        public static void Generate(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            if (context.Employees.Any())
            {
                return;
            }

            if (context.Projects.Any())
            {
                return;
            }

            var adminUser = new IdentityUser
            {
                UserName = "admin",
                Email = "admin",
                EmailConfirmed = true,
            };

            userManager.CreateAsync(adminUser, "Password123!");

            var list = new Employees();
            list.Title = "List 1";
            context.TodoLists.Add(list);

            // Veel andmeid

            context.SaveChanges();
        }
    }
}
