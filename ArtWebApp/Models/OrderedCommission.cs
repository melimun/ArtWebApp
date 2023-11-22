using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtWebApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//Matthew Goehner

namespace ArtWebApp.Models
{
    public class OrderedCommission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderId {get; set;}

        public String status {get;set;}

        public int buyerId {get;set;}

        public int itemId {get;set;}

        public int price {get;set;}

        public String notes {get; set;}

        
    }
}