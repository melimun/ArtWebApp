using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;


namespace ArtWebApp.Models
{
    public class Profile
    {
        public int ProfileID { get; set; }
        public int UserID {get; set;}
        public string Bio {get; set;}
        public string ProfileImage {get; set;}
        public string School {get; set;}
        public string PhoneNumber {get; set;}
        public string Birthday {get; set;}
    }
}