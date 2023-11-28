using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ArtWebApp.Models;
using ArtWebApp.Data;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.EntityFrameworkCore;


namespace ArtWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ArtContext _context;

        public HomeController(ArtContext context)
        {
            _context = context;
        }

        // Main Home Page
        public IActionResult Index()
        {
            return View();
        }

        // Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
public IActionResult Login(User user)
{
    try
    {
        var existingUser = _context.Users.FirstOrDefault(u => u.Username == user.Username && u.PasswordHash == user.PasswordHash);

        if (existingUser != null)
        {
            // Authentication successful
            HttpContext.Session.SetInt32("UserId", existingUser.UserId); // Set the session ID
            return RedirectToAction("Profile");
        }
        else
        {
            // Authentication failed
            ModelState.AddModelError(string.Empty, "Invalid login attempt");
            return View();
        }
    }
    catch (Exception ex)
    {
        // Log the exception for debugging purposes
        Console.WriteLine($"Exception during login: {ex.Message}");
        ModelState.AddModelError(string.Empty, "Error during login. Please try again.");
        return View();
    }
}


        // Registration
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
                // Check if the username already exists
                if (_context.Users.Any(u => u.Username == user.Username))
                {
                    ModelState.AddModelError("Username", "Username is already taken");
                    return View();
                }

                // Create a new User and associated Profile with default values
                var newUser = new User
                {
                    Username = user.Username,
                    PasswordHash = user.PasswordHash,
                    Email = user.Email,
                    ProfileID = user.UserId,
                    Profile = new Profile
                    {
                        // Initialize profile fields with default values
                        Bio = "Tell us about yourself!",
                        School = "Your school name",
                        PhoneNumber = "000-000-0000",
                        Birthday = DateTime.Now.ToString("yyyy-MM-dd"),
                        ProfileImage = "default_image.jpg", // Default image name or path
                        ProfileImageData = null, // Set to null for default image data
                        UserID = 0 // Placeholder value; it will be updated below
                    }
                };

                _context.Users.Add(newUser);
                _context.SaveChanges();

                // Update the Profile's UserID to match the User's UserId
                newUser.Profile.UserID = newUser.UserId;
                newUser.ProfileID = newUser.UserId;
                _context.SaveChanges();

                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }



        // Profile
        // Profile
// Remove the [Authorize] attribute to allow access without authentication
public IActionResult Profile()
{
    // Retrieve the user ID from session or cookie
    int? userId = HttpContext.Session.GetInt32("UserId");

    if (userId != null)
    {
        var userProfile = _context.Profiles
            .Include(p => p.User)
            .FirstOrDefault(p => p.UserID == userId);

        if (userProfile != null)
        {
            Console.WriteLine($"User Profile: {userProfile.UserID}, {userProfile.Bio}, {userProfile.School}, {userProfile.PhoneNumber}");

            return View(userProfile); // Pass the userProfile object to the view
        }
    }

    // If the user ID is not found or the profile doesn't exist, handle it accordingly
    return RedirectToAction("Login");
}











        [HttpGet]
        public IActionResult EditProfile(int userId)
        {
            var userProfile = _context.Profiles.FirstOrDefault(p => p.UserID == userId);

            if (userProfile == null)
            {
                return View(new Profile { UserID = userId });
            }

            return View(userProfile);
        }

        [HttpPost]
        public async Task<IActionResult> EditProfile(int userId, Profile profile, IFormFile ProfileImage)
        {
            if (ModelState.IsValid)
            {
                var existingProfile = _context.Profiles.FirstOrDefault(p => p.UserID == userId);

                if (existingProfile != null)
                {
                    // Update profile fields
                    existingProfile.Bio = profile.Bio;
                    existingProfile.School = profile.School;
                    existingProfile.PhoneNumber = profile.PhoneNumber;
                    existingProfile.Birthday = profile.Birthday;

                    // Check if a new profile image is uploaded
                    if (ProfileImage != null && ProfileImage.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await ProfileImage.CopyToAsync(memoryStream);
                            existingProfile.ProfileImageData = memoryStream.ToArray();
                        }
                    }

                    _context.Profiles.Update(existingProfile);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Profile", new { userId = userId });
                }
                else
                {
                    // Handle if the profile doesn't exist for the provided userId
                    // This could be an error or a redirect depending on your requirement
                    return RedirectToAction("Login");
                }
            }

            // If ModelState is not valid, return to the EditProfile view with the provided profile
            return View("EditProfile", profile);
        }



    //Marketplace
    [HttpGet]
    public ViewResult Marketplace()
    {
        return View();
    }

    //Marketplace
    [HttpPost]
    public ViewResult Marketplace(int userId)
    {
        if (ModelState.IsValid)
        {
            return View("Marketplace");
        }
        else
        {
            return View();
        }
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
}