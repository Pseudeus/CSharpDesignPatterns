using System;

namespace MediatorPattern
{
    public class Friend2 : Friend
    {
        public Friend2(IMediator mediator, string name) : base(mediator)
        {
            this.Name = name;
        }
        public void Send(string msg)
        {
            mediator.Send(this, msg);
        }
    }
}