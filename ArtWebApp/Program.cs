using ArtWebApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Specialized;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//services to database
// builder.Services.AddEntityFrameworkSqlite().AddDbContext<ArtContext>();
//database
string connString = builder.Configuration.GetConnectionString("ArtContext");

builder.Services.AddDbContext<ArtContext>(options =>
{
    options.UseSqlite(connString);

});

//seed data
// Build the service provider
using var serviceProvider = builder.Services.BuildServiceProvider();

// Get an instance of ArtContext from the service provider
using var scope = serviceProvider.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<ArtContext>();

// Initialize the database with seed data
UserInitializer.Initialize(context);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
