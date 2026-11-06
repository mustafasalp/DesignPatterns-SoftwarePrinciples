using System;
using System.Collections.Generic;
using System.Text;
using State;

namespace State.States
{
    public class NewOrderState : IOrderState
    {
        public void Next(Order order)
        {
            order.state = new ProcessingState();
        }

        public void Previous(Order order)
        {
            Console.WriteLine("This is the initial state.");
        }

        public void PrintStatus()
        {
            Console.WriteLine("Order is placed");
        }
    }
}
