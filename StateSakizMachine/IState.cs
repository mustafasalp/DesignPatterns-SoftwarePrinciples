using System;
using System.Collections.Generic;
using System.Text;

namespace StateSakizMachine
{
    public interface IState
    {
        void InsertCoin(SakizMakinesi machine);
        void EjectCoin(SakizMakinesi machine);
        void TurnCrank(SakizMakinesi machine);
        void Dispense(SakizMakinesi machine);

    }
}
