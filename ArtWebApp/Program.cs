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

var app = builder.Build();

//seed data
using(var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ArtContext>();
    // use dbInitializer
    UserInitializer.Initialize(context);
}

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
