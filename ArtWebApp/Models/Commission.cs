using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebApp.Models
{
public class Commission
{
    public int id {get; set;}
    public User artist {get; set;}

    [Required(ErrorMessage = "Please enter the name")]
    public string name {get; set;}

    [Required(ErrorMessage = "Please enter a price")]
    public int price {get; set;}

    [Required(ErrorMessage = "Please make a description")]
    public String description {get; set;}

}

}