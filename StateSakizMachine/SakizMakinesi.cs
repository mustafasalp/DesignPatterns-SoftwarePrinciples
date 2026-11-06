using System;
using System.Collections.Generic;
using System.Text;
using StateSakizMachine.States;

namespace StateSakizMachine
{
    public class SakizMakinesi
    {
        private IState _state;

        private int _gumCount;

        public SakizMakinesi()
        {
            _state = new NoCoinState();
        }

        internal void SetState(IState state)
        {
            _state = state;
        }
    }
}
