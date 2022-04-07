using System;

namespace BridgePattern
{
    //Concrete Implementor 1
    public class OnState : IState
    {
        public void MoveState()
        {
            Console.WriteLine("On State");
        }
    }
    //Concrete Implementor 2
    public class OffState : IState
    {
        public void MoveState()
        {
            Console.WriteLine("Off State");
        }
    }
}