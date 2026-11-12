using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using TemplateMethod.Models;

namespace TemplateMethod.BaseConverter
{
    public abstract class PaymentProcessor
    {
        public bool HandlePayment(Order order) // Template method same for all subclasses.
        {
            if (!ValidateOrder(order))
            {
                Console.WriteLine("Validation Failed");
                return false;
            }
            order.OrderTotal = CalculateTotal(order);

            if (order.OrderTotal <= 0)
            {
                Console.WriteLine("Invalid Total");
                return false;
            }
            if (!ProcessPayment(order))
            {
                Console.WriteLine("Payment Processing Failed");
                return false;
            }
            GenerateReceipt(order);
            return true;
        }

        protected virtual bool ValidateOrder(Order order)
        {
            if(order.IsValid)
                return true;
            return false;
        }

        protected virtual decimal CalculateTotal(Order order)
        {
            return order.ProductCount * order.ProductValue;
        }

        protected abstract bool ProcessPayment(Order order); // Depends on the payment method.
        protected virtual void GenerateReceipt(Order order)
        {
            Console.WriteLine($"Receipt Generated for Order {order.Id} with Order Name {order.Name} and Order Total {order.OrderTotal}");
        }
    }
}
