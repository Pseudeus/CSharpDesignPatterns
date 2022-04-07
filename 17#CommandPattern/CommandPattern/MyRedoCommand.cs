using System;

namespace CommandPattern
{
    public class MyRedoCommand : ICommand
    {
        private Receiver reciver;

        public MyRedoCommand(Receiver recv)
        {
            reciver = recv;
        }
        public void Do()
        {
            reciver.OptionalTaskPriorToRedo();
            reciver.PreformRedo();
        }
    }
}