using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public bool IsInStock { get; set; }
        public bool PaymentSuccessful { get; set; }
        public bool IsFraudulent { get; set; }
        public bool HasValidAddress { get; set; }
    }
}
