using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ArtWebApp.Models;
using ArtWebApp.Data;

namespace ArtWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ArtContext _context;

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
    public ViewResult Login(User user)
    {
        if (ModelState.IsValid)
        {
            //ToDo: Get Forum
            // return View("Marketplace", user);
            return View("Marketplace");
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
}
