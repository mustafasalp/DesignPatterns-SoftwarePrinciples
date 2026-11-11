using System;
using System.Collections.Generic;
using System.Text;
using ChainOfResponsibility.Model;
using ChainOfResponsibility.Interfaces;
using ChainOfResponsibility.AbstractClass;

namespace ChainOfResponsibility.ConcreteClasses
{
    public class ShippingHandler : BaseOrderHandler
    {
        public override bool Handle(Order order)
        {
            if(!order.HasValidAddress)
            {
                Console.WriteLine("Shipping check failed");
                return false;
            }

            Console.WriteLine("Shipping check passed, all requirements met");
            return base.Handle(order);
        }
    }
}
