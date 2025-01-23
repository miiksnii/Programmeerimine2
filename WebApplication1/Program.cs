using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Properties.Data;  // Adjust the namespace to where your ApplicationDbContext is located

var builder = WebApplication.CreateBuilder(args);


// Configure the DbContext with a database provider (e.g., SQL Server)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // Or UseSqlite, UseNpgsql, etc.
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

#if DEBUG
using (var scope = app.Services.CreateScope())
using (var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>())
using (var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>())
{
    context.Database.EnsureCreated();
    SeedData.Generate(context, userManager);
}
#endif


app.Run();
