using ArtWebApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Specialized;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//services to database
builder.Services.AddEntityFrameworkSqlite().AddDbContext<ArtContext>();
builder.Services.AddEntityFrameworkSqlite().AddDbContext<CommissionContext>();

// database
string connString = builder.Configuration.GetConnectionString("ArtContext");
string connString2 = builder.Configuration.GetConnectionString("CommissionContext");

builder.Services.AddSession(); // Add session support
builder.Services.AddControllersWithViews(); // Add MVC services

builder.Services.AddDbContext<ArtContext>(options =>
{
    options.UseSqlite(connString);

});

builder.Services.AddDbContext<CommissionContext>(options =>
{
    options.UseSqlite(connString2);

});

var app = builder.Build();

//seed data
using(var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ArtContext>();
    // use dbInitializer
    UserInitializer.Initialize(context);
}

using(var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<CommissionContext>();
    CommissionInitializer.Initialize(context);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // app.UseSwagger();
    // app.UseSwaggerUI();
    app.UseExceptionHandler("/Home/Error");
}

app.UseSession(); // Use session

    app.UseRouting();
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
    });
app.UseStaticFiles();

app.UseRouting();

app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
