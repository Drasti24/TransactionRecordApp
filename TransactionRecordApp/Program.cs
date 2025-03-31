//DRASTI PATEL
//QUIZ 05
//MARCH 31, 2025

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TransactionRecordApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connStr = builder.Configuration.GetConnectionString("TransactionsDb");

//REGISTER THE APPLICATION'S DbContext with dependency injection and configure it to use SQL Server.
builder.Services.AddDbContext<TransactionContext>(options =>
    options.UseSqlServer(connStr));

//Configure ASP.NET Core Identity with custom password rules and use our custom User Class
builder.Services.AddIdentity<User, IdentityRole>(options => {
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireDigit = true;
})
.AddEntityFrameworkStores<TransactionContext>()       //Use EF Core to store identity data
.AddDefaultTokenProviders();              //add token providers for password reset, email confirmation, etc.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//create the admin user and role at startup
var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope())
{
    await TransactionContext.CreateAdminUser(scope.ServiceProvider);
}

//app.Run();
await app.RunAsync();
