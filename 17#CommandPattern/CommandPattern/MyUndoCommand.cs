using System;

namespace CommandPattern
{
    public class MyUndoCommand : ICommand
    {
        private Receiver reciver;

        public MyUndoCommand(Receiver recv)
        {
            reciver = recv;
        }
        public void Do()
        {
            reciver.OptionalTaskPriorToUndo();
            reciver.PreformUndo();
        }
    }
}