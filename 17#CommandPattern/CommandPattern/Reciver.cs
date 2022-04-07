using System;

namespace CommandPattern
{
    public class Receiver
    {
        public void OptionalTaskPriorToUndo()
        {
            Console.WriteLine("Executing-Optional Task prior to execute undo command");
        }
        public void PreformUndo()
        {
            Console.WriteLine("Executing-MyUndoCommand");
        }
        public void OptionalTaskPriorToRedo()
        {
            Console.WriteLine("Executing-Optional Task prior to execute redo command");
        }
        public void PreformRedo()
        {
            Console.WriteLine("Executing-MyRedoCommand");
        }
    }
}