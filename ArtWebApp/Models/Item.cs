using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebApp.Models
{
    public class Item
    {
        private int itemId {get; set;}

        private string name {get;set;}

        private string description {get;set;}

        private string condition {get;set;}

        private bool isAvailable {get;set;}

        private double price {get;set;}

        private double shippingPrice {get;set;}

        private User seller {get;set;}

        private User buyer {get;set;}

        private Commission item {get; set;}

        
    }

}