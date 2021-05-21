using StrategyDesignPattern.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Business.Strategies.SalesTax
{
    class UsSalesTaxStrategy : ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order order)
        {
            switch (ShippingDetails.Destinationstate.ToLowerInvariant())
            {
                case "la": return TotalPrice * 0.095m;
                case "ny": return TotalPrice * 0.04m;
                case "nyc": return TotalPrice * 0.045m;
                default: return 0m;
            }
        }

    }
}
