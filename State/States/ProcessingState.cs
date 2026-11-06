using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    internal class ProcessingState : IOrderState
    {
        public void Next(Order order)
        {
            order.state = new ShippedState();
        }
        public void Previous(Order order)
        {
            order.state = new NewOrderState();
        }
        public void PrintStatus()
        {
            Console.WriteLine("Order is being processed");
        }
    {
    }
}
