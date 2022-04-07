using System;

namespace CommandPattern
{
    public class Invoker
    {
        ICommand commandToBePerformed;

        public void SetCommand(ICommand command)
        {
            commandToBePerformed = command;
        }
        public void ExecuteCommand()
        {
            commandToBePerformed.Do();
        }
    }
}