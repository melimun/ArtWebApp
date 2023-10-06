using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebApp.Models
{
    public class Commission
    {
        public string name {get; set;}

        public int id {get; set;}

        public String description {get; set;}

        public User artist {get; set;}        
    }
}