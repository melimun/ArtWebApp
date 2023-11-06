using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ArtWebApp.Models
{
    public class Item
    {
        private int itemId {get; set;}

        [Required(ErrorMessage = "Please enter item name")]
        public string name {get;set;}

        [Required(ErrorMessage = "Please enter item description")]
        public string description {get;set;}

        [Required(ErrorMessage = "Please enter condition")]
        public string condition {get;set;}

        public bool isAvailable {get;set;}

        [Required(ErrorMessage = "Please enter price")]
        public double price {get;set;}

        [Required(ErrorMessage = "Please enter shipping price")]
        public double shippingPrice {get;set;}

        public User seller {get;set;}

        public User buyer {get;set;}

        public Commission item {get; set;}

        
    }

}