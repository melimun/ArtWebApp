using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//Matthew Goehner

namespace ArtWebApp.Models
{
    public class Commission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get; set;}
        public int userId {get; set;}        

        public string name {get; set;}

        public int price {get; set;}

        public String description {get; set;}

    }
}