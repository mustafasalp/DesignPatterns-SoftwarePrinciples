using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.BaseConverter;
using TemplateMethod.Models;

namespace TemplateMethod.ConcreteClasses
{
    public class CreditCardPayment : PaymentProcessor
    {

        private readonly CreditCard _creditCard;

        public CreditCardPayment(CreditCard creditCard)
        {
            _creditCard = creditCard;
        }
        protected override bool ProcessPayment(Order order)
        {
            if(_creditCard != null && _creditCard.IsActive)
            {
                if(_creditCard.Balance >= order.OrderTotal)
                {
                    _creditCard.Balance -= order.OrderTotal;
                    Console.WriteLine($"Payment of {order.OrderTotal} processed successfully using Credit Card {_creditCard.Id}. Remaining balance: {_creditCard.Balance}");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Insufficient balance on Credit Card {_creditCard.Id}. Payment failed.");
                    return false;
                }
            }
            Console.WriteLine("Credit Card is not active or Null.");
            return false;
        }
    }
}
