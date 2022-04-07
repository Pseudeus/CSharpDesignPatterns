using System;

namespace BridgePattern
{
    public class VCD : ElectronicsGood
    {
        public override void MoveToCurrentState()
        {
            Console.WriteLine("\nVCD is functioning at: ");
            state.MoveState();
        }
    }
}