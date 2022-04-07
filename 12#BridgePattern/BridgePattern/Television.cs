using System;

namespace BridgePattern
{
    //Refinded abstraction
    public class Television : ElectronicsGood
    {
        public override void MoveToCurrentState()
        {
            Console.WriteLine("\nTelevision is functioning at: ");
            state.MoveState();
        }
    }
}