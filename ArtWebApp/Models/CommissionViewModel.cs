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
    public class CommissionViewModel
    {
        public int? userId {get; set;}
        public List<OrderedCommission> orderedCommissions {get; set;}
        public List<Commission> commissions {get; set;}
        
    }
}