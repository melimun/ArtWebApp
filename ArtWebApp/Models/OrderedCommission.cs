using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebApp.Models
{
    public class OrderedCommission
    {
        private int orderId {get; set;}

        private String status {get;set;}

        private String notes {get;set;}

        private User buyer {get;set;}

        private Commission item {get; set;}

        
    }

}