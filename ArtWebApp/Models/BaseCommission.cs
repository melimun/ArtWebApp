using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//Matthew Goehner

namespace ArtWebApp.Models
{
    public class BaseCommission
    {
        public int id {get; set;}
        public int artistId {get; set;}        

        [Required(ErrorMessage = "Please enter the name")]
        public string name {get; set;}

        [Required(ErrorMessage = "Please enter a price")]
        public int price {get; set;}

        [Required(ErrorMessage = "Please make a description")]
        public String description {get; set;}

    }
}