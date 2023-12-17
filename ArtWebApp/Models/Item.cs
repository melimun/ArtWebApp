using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtWebApp.Models
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get; set;}

        [Required(ErrorMessage = "Please enter item name")]
        public string name {get;set;}

        [Required(ErrorMessage = "Please enter item description")]
        public string description {get;set;}

        [Required(ErrorMessage = "Please enter condition")]
        public string condition {get;set;}

        [Required(ErrorMessage = "Please enter price")]
        public double price {get;set;}

        [Required(ErrorMessage = "Please enter shipping price")]
        public double shippingPrice {get;set;}

        
    }

}