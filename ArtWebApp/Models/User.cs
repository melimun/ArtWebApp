using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtWebApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace ArtWebApp.Models
{
    public class User
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get;set;}

        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Password is required")]
        public string PasswordHash {get; set;}

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } 
        // public Profile profile {get; set; } 
        // public bool isAuthenticated {get; private set;}

        // public User(){
        //     userId = 0;
        //     username = "username";
        //     passwordHash = "password";
        //     email = "username@email.com";
        //     isAuthenticated = true;
        // }
    }
}