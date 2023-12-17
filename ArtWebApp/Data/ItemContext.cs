using ArtWebApp.Models;
using System;
using System.Linq;

namespace ArtWebApp.Data
{
    public static class ItemInitializer
    {
        public static void Initialize(ItemContext context)
        {
            context.Database.EnsureCreated();

            if (context.Items.Any())
            {
                return;   
            }

            var item = new Item[]
            {
                new Item{
                    id = 1, 
                    name = "Supply1",
                    description = "Art Supply",
                    condition = "Good",
                    price = 10.0,
                    shippingPrice = 5.00
                },

                new Item{
                    id = 2, 
                    name = "Supply2",
                    description = "Art Supply",
                    condition = "Great",
                    price = 15.0,
                    shippingPrice = 5.00
                }
            };

            context.Items.AddRange(item);
            context.SaveChanges();

        }
    }
}