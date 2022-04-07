using System;

namespace CommandPatternQAs
{
    public class AdditionCommand : ICommand
    {
        IReceiver receiver;

        public AdditionCommand(IReceiver receiver)
        {
            this.receiver = receiver;
        }     
        public void Do()
        {
            receiver.OptionalTasksPriorProcessing();
            receiver.Add2WithNumber();
            receiver.OptionalTasksPostProcessing();
        }   
        public void UnDo()
        {
            Console.WriteLine("Trying undoing addition...");
            receiver.Remove2FromNumber();
            Console.WriteLine("Undo request processed.");
        }
    }
}