using System;
using System.Collections.Generic;
using ChainOfResponsibility.ConcreteClasses;
using ChainOfResponsibility.Model;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order()
            {
                OrderId = 1,
                IsInStock = true,
                PaymentSuccessful = true,
                IsFraudulent = false,
                HasValidAddress = false
            }; // The order will not preceed because the address is invalid.


            // Chain setted up
            var stock = new StockHandler();
            var payment = new PaymentHandler();
            var fraud = new FraudHandler();
            var shipping = new ShippingHandler();

            stock.SetNext(payment)
                 .SetNext(fraud)
                 .SetNext(shipping);

            bool result = stock.Handle(order);

            if (result)
            {
                Console.WriteLine("Order processing completed successfully.");
            }
            else
            {
                Console.WriteLine("Order processing failed.");
            }

            Console.ReadLine();
        }
    }
}
