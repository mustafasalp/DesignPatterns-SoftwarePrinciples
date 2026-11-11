using ChainOfResponsibility.AbstractClass;
using ChainOfResponsibility.Interfaces;
using ChainOfResponsibility.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ConcreteClasses
{
    public class FraudHandler : BaseOrderHandler
    {
        public override bool Handle(Order order)
        {
            if(order.IsFraudulent)
            {
                Console.WriteLine("Fraud check failed");
                return false;
            }

            Console.WriteLine("Fraud check passed");
            return base.Handle(order);
        }
    }
}
