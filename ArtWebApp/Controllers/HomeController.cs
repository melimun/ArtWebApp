using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ArtWebApp.Models;
using ArtWebApp.Data;
using Microsoft.VisualBasic;

namespace ArtWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ArtContext _context;

    public HomeController(ArtContext context)
    {
        _context = context;
    }


    //Main Home Page
    public IActionResult Index()
    {
        return View();
    }

    //Login
    [HttpGet]
    public ViewResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(User user)
    {
        var existingUser = _context.Users.FirstOrDefault(u => u.Username == user.Username && u.PasswordHash == user.PasswordHash);

        if (existingUser != null)
        {
            // Authentication successful
            return RedirectToAction("Profile", user);
        }
        else
        {
            // Authentication failed
            ModelState.AddModelError(string.Empty, "Invalid login attempt");
            return View();
        }
    }

    //Registration
    [HttpGet]
public IActionResult Register()
{
    return View();
}

[HttpPost]
public IActionResult Register(User user)
{
    if (ModelState.IsValid)
    {
        // Check if the username is already taken
        if (_context.Users.Any(u => u.Username == user.Username))
        {
            ModelState.AddModelError("Username", "Username is already taken");
            return View();
        }

        // Add the new user to the database
        _context.Users.Add(user);
        _context.SaveChanges();

        // Redirect to the login page after successful registration
        return RedirectToAction("Login");
    }
    else
    {
        return View();
    }
}

    //Marketplace
    [HttpGet]
    public ViewResult Marketplace()
    {
        return View();
    }

    //Marketplace
    [HttpPost]
    public ViewResult Marketplace(Profile profile)
    {
        if (ModelState.IsValid)
        {
            return View("Profile");
        }
        else
        {
            return View();
        }
    }

    //Profile
     public ViewResult Profile()
    {
        return View();
        // return View();
    }

     //Profile
     public ViewResult ChatHub()
    {
        return View();
    }

    public ViewResult AddItem()
    {
        return View();
    }

    public ViewResult ViewItems()
    {
        return View();
    }
}
