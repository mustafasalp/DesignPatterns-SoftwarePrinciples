using System;
using System.Collections.Generic;
using System.Text;

namespace StateSakizMachine.States
{
    public class HasCoinState : IState
    {
        public void InsertCoin(SakizMakinesi machine)
        {
            Console.WriteLine("Coin already inserted");
        }

        public void EjectCoin(SakizMakinesi machine)
        {
            Console.WriteLine("Coin ejected");
            machine.SetState(new NoCoinState());
        }

        public void TurnCrank(SakizMakinesi machine)
        {
            Console.WriteLine("Crank turned");
            machine.SetState(new SoldState());
        }

        public void Dispense(SakizMakinesi machine)
        {
            Console.WriteLine("Gum dispensed");
        }
    }
}
