using StrategyDesignPattern.Business.Models;
using System;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                ShippingDetails = new ShippingDetails
                {
                    OriginCountry = "Sweden",
                    DestinationCountry = "Sweden"
                }
            };

            order.LineItems.Add(
                new Item("CSHARO_SMORGASBORD",
                "C# Smorgasbord",
                100m,
                ItemType.Literature),
                1);

            order.LineItems.Add(
                new Item("CONSULTING",
                "Building a website",
                100m,
                ItemType.Service),
                1);

            Console.WriteLine(order.GetTax());

        }
    }
}
