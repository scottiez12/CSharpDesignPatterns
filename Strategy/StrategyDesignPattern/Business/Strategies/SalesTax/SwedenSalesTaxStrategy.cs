using StrategyDesignPattern.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Business.Strategies.SalesTax
{
    public class SwedenSalesTaxStrategy : ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order order)
        {
            var destination = order.ShippingDetails.DestinationCountry.ToLowerInvariant();
            var origin = ShippingDetails.OriginCountry.ToLowerInvariant();
            if (destination == origin)
            {
                return TotalPrice * 0.25m;
            }

            //tax per item....

            return 0;

        }
    }
}
