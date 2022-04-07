using System;

namespace ChainOfResponsabilityPattern
{
    public class EmailErrorHandler : IReceiver
    {
        private IReceiver nextReceiver;

        public EmailErrorHandler(IReceiver nextReceiver)
        {
            this.nextReceiver = nextReceiver;
        }
        public bool HandleMessage(Message message)
        {
            if(message.text.Contains("Email"))
            {
                Console.WriteLine($"EmailErrorHandler processed { message.priority } priority issue: { message.text }");
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