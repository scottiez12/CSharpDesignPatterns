﻿using StrategyDesignPattern.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Business.Strategies.Invoice
{
    public interface IInvoiceStrategy
    {
        public void Generate(Order order);
    }
}
