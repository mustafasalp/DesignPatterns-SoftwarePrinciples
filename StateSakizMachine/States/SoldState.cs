using System;
using System.Collections.Generic;
using System.Text;

namespace StateSakizMachine.States
{
    public class SoldState : IState
    {
        public void InsertCoin(SakizMakinesi machine)
        {
            Console.WriteLine("Coin already inserted");
        }

        public void EjectCoin(SakizMakinesi machine)
        {
            Console.WriteLine("Coin ejected");
        }

        public void TurnCrank(SakizMakinesi machine)
        {
            Console.WriteLine("Crank turned");
        }

        public void Dispense(SakizMakinesi machine)
        {
            Console.WriteLine("Gum dispensed");
        }
    }
}
