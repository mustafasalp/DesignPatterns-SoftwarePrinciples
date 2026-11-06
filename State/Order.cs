using System;
using System.Collections.Generic;
using System.Text;
using State.States;

namespace State
{
    public class Order
    {
        private IOrderState _state { get; set; }

        public Order()
        {
            _state = new NewOrderState();
        }

        internal void SetState(IOrderState state)   // public değil
        {
            _state = state;
        }

        public void NextState()
        {
            _state.Next(this); // Bu nesneyi al. Türü neyse.
        }

        public void PreviousState()
        {
            _state.Previous(this);
        }

    }

}
