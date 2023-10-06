using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebApp.Models
{
    public class OrderedCommission : Commission
    {
        private int orderId {get; set;}

        private String status {get;set;}

        private String notes {get;set;}

        private User buyer {get;set;}

        
    }
}