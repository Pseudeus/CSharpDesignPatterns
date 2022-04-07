using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Bridge Pattern Demo***\n");
            Console.WriteLine("\nDealing with a Television: ");

            ElectronicsGood eItem = new Television();
            IState presentState = new OnState();
            eItem.State = presentState;
            eItem.MoveToCurrentState();

            presentState = new OffState();
            eItem.State = presentState;
            eItem.MoveToCurrentState();

            Console.WriteLine("\nDealing with a VCD: ");
            presentState = new OnState();
            eItem = new VCD();
            eItem.State = presentState;
            eItem.MoveToCurrentState();

            presentState = new OffState();
            eItem.State = presentState;
            eItem.MoveToCurrentState();
        }
    }
}
