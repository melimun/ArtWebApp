using ArtWebApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Specialized;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string connString = builder.Configuration.GetConnectionString("ArtContext");

builder.Services.AddDbContext<ArtContext>(options =>
{
    options.UseSqlite(connString);

});

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
