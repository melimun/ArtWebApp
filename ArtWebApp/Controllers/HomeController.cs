using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ArtWebApp.Models;
using ArtWebApp.Data;

namespace ArtWebApp.Controllers;

public class HomeController : Controller
{
    //Main Home Page
    private readonly CommissionContext _context;
    public HomeController(CommissionContext context)
    {
        _context = context;
    }
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
    }

    [HttpGet]
    public IActionResult CreateCommission()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateCommission(Commission commission)
    {
        if (ModelState.IsValid)
        {
            _context.Commissions.Add(commission);
            _context.SaveChanges();

            return RedirectToAction("Login");
        }
        else
        {
            return View();
        }
    }

    [HttpGet]
    public async Task<IActionResult> OrderedCommission()
    {
        return View(_context.Commissions.ToList());
    }

}
