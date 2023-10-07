using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebApp.Models
{
    public class Item
    {
        private int itemId {get; set;}

        private String name {get;set;}

        private String description {get;set;}

        private String condition {get;set;}

        private Bool isAvailable {get;set;}

        private double price {get;set;}

        private double shippingPrice {get;set;}

        private User seller {get;set;}

        private User buyer {get;set;}

        private Commission item {get; set;}

        
    }

}