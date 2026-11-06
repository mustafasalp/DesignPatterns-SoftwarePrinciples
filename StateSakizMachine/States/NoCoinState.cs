using System;
using System.Collections.Generic;
using System.Text;
namespace StateSakizMachine.States
{
    public class NoCoinState : IState
    {
        public void InsertCoin(SakizMakinesi machine)
        {
            Console.WriteLine("Coin inserted");
            machine.SetState(new HasCoinState());
        }

        public void EjectCoin(SakizMakinesi machine)
        {
            Console.WriteLine("First insert a coin");
        }

        public void TurnCrank(SakizMakinesi machine)
        {
            Console.WriteLine("First insert a coin");
        }

        public void Dispense(SakizMakinesi machine)
        {
            Console.WriteLine("First insert a coin");
        }
    }
}
