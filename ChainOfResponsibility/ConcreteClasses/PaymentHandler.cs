using ChainOfResponsibility.AbstractClass;
using ChainOfResponsibility.Interfaces;
using ChainOfResponsibility.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ConcreteClasses
{
    public class PaymentHandler : BaseOrderHandler
    {
        public override bool Handle(Order order)
        {
            if (!order.PaymentSuccessful)
            {
                Console.WriteLine("Payment check failed");
                return false;
            }

            Console.WriteLine("Payment check passed");
            return base.Handle(order);
        }
    }
}
