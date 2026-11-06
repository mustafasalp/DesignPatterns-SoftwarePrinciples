using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    public class DeliveredState : IOrderState
    {
        public void Next(Order order)
        {
            Console.WriteLine("This is the final state.");
        }

        public void Previous(Order order)
        {
            order.state = new OnTheWayState();
        }

        public void PrintStatus()
        {
            Console.WriteLine("Order is delivered");
        }
    }
}
