using System;

namespace CommandPatternQAs
{
    public class Invoker
    {
        private ICommand commandToBePerformed;

        public void SetCommand(ICommand command)
        {
            commandToBePerformed = command;
        }
        public void ExecuteCommand()
        {
            commandToBePerformed.Do();
        }
        public void UndoCommand()
        {
            commandToBePerformed.UnDo();
        }
    }
}