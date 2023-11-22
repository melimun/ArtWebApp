using ArtWebApp.Models;
using System;
using System.Linq;

namespace ArtWebApp.Data
{
    public static class CommissionInitializer
    {
        public static void Initialize(CommissionContext context)
        {
            context.Database.EnsureCreated();

            if (context.Commissions.Any())
            {
                return;   
            }

            var commissions = new Commission[]
            {
                new Commission{
                    id = 1, 
                    name = "test", 
                    userId = 1, 
                    price = 1,
                    description = "test"
                },

                new Commission{
                    id = 2, 
                    name = "test", 
                    userId = 2, 
                    price = 2,
                    description = "test"
                }
            };

            context.Commissions.AddRange(commissions);
            context.SaveChanges();

            var orderedCommissions = new OrderedCommission[]
            {
                new OrderedCommission{
                    orderId = 1, 
                    status = "test", 
                    buyerId = 1, 
                    itemId = 1,
                    price = 1,
                    notes = "test"
                },

                new OrderedCommission{
                    orderId = 1, 
                    status = "test", 
                    buyerId = 1, 
                    itemId = 1,
                    price = 1,
                    notes = "test"
                }
            };

            context.OrderedCommissions.AddRange(orderedCommissions);
            context.SaveChanges();

        }
    }
}