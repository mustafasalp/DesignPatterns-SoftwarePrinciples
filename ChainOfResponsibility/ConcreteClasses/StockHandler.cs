using ChainOfResponsibility.AbstractClass;
using ChainOfResponsibility.Interfaces;
using ChainOfResponsibility.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ConcreteClasses
{
    public class StockHandler : BaseOrderHandler
    {
        public override bool Handle(Order order)
        {
            if(!order.IsInStock)
            {
                Console.WriteLine("Stock check failed");
                return false;
            }

            Console.WriteLine("Stock check passed");
            return base.Handle(order);
        }
    }
}
