using System;

namespace CommandPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Command Pattern Demo***\n");

            Invoker invoker = new Invoker();
            Receiver intendedReciver = new Receiver();

            MyUndoCommand undoCommand = new MyUndoCommand(intendedReciver);
            invoker.SetCommand(undoCommand);
            invoker.ExecuteCommand();

            MyRedoCommand redoCommand = new MyRedoCommand(intendedReciver);
            invoker.SetCommand(redoCommand);
            invoker.ExecuteCommand();
        }
    }
}
