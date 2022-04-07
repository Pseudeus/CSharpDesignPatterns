using System;

namespace ChainOfResponsabilityPattern
{
    public class IssueRaiser
    {
        public IReceiver setFirstReceiver;

        public IssueRaiser(IReceiver firstReceiver)
        {
            setFirstReceiver = firstReceiver;
        }
        public void RaiseMessage(Message message)
        {
            if(setFirstReceiver != null)
            {
                setFirstReceiver.HandleMessage(message);
            }
        }
    }
}