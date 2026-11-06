using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    internal class OnTheWayState : IOrderState
    {
        public void Next(Order order)
        {
            order.state = new DeliveredState();
        }
        public void Previous(Order order)
        {
            order.state = new ProcessingState();
        }
        public void PrintStatus()
        {
            Console.WriteLine("Order is on the way");
        }
    {
    }
}
