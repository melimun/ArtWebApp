using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtWebApp.Models;
using System.ComponentModel.DataAnnotations;


namespace ArtWebApp.Models
{
    public class User
    {
        public int userId { get; }
        public string username { get; set; }
        public string passwordHash {get; private set;}
        public string email { get; set; } 
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