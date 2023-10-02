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
        public Profile profile {get; set; }  
    }
}