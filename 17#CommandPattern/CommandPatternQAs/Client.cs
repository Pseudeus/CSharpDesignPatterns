using System;

namespace CommandPatternQAs
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Command Pattern QAs***\n");
            Console.WriteLine("*** A simple demo with undo supported operations***\n");

            Invoker invoke = new Invoker();
            IReceiver receiver = new Reciever1();

            ICommand command = new AdditionCommand(receiver);
            invoke.SetCommand(command);

            invoke.ExecuteCommand();
            invoke.ExecuteCommand();

            invoke.UndoCommand();
            invoke.UndoCommand();
            invoke.UndoCommand();

            Console.WriteLine("\nTesting receiver-Receiver2");
            receiver = new Reciever2();
            command = new AdditionCommand(receiver);
            invoke.SetCommand(command);

            invoke.ExecuteCommand();

            invoke.UndoCommand();
            invoke.UndoCommand();
        }
    }
}
