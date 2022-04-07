using System;

namespace ChainOfResponsabilityPattern
{
    public interface IReceiver
    {
        bool HandleMessage(Message message);
    }
}