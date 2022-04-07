using System;

namespace ChainOfResponsabilityPattern
{
    public class Message
    {
        public string text;
        public MessagePriority priority;

        public Message(string msg, MessagePriority p)
        {
            text = msg;
            priority = p;
        }
    }
}