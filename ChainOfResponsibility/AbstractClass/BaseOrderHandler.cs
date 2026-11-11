using ChainOfResponsibility.Interfaces;
using ChainOfResponsibility.Model;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ChainOfResponsibility.AbstractClass
{
    public abstract class BaseOrderHandler : IHandler
    {
        private IHandler? _nextHandler = null;

        public virtual bool Handle(Order order)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(order);   
            }

            return true;
        }

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }
    }
}
