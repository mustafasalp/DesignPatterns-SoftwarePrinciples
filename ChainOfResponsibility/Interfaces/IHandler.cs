using System;
using System.Collections.Generic;
using System.Text;
using ChainOfResponsibility.Model;

namespace ChainOfResponsibility.Interfaces
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        bool Handle(Order order);
    }
}
