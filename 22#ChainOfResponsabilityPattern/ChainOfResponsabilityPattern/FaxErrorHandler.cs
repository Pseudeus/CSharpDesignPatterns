using System;

namespace ChainOfResponsabilityPattern
{
    public class FaxErrorHandler : IReceiver
    {
        private IReceiver nextReceiver;

        public FaxErrorHandler(IReceiver nextReceiver)
        {
            this.nextReceiver = nextReceiver;
        }
        public bool HandleMessage(Message message)
        {
            if(message.text.Contains("Fax"))
            {
                Console.WriteLine($"FaxErrorHandler processed { message.priority } priority issue: { message.text }");
                return true;
            }
            else
            {
                if(nextReceiver != null)
                {
                    nextReceiver.HandleMessage(message);
                }
            }
            return false;
        }
    }
}