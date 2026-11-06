using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public interface IOrderState
    {
        void Next(Order order);

        void Previous(Order order);

        void PrintStatus();
    }
}
