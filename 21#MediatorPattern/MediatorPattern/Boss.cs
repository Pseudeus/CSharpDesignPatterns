using System;

namespace MediatorPattern
{
    public class Boss : Friend
    {
        public Boss(IMediator mediator, string name) : base(mediator)
        {
            this.Name = name;
        }
        public void Send(string msg)
        {
            mediator.Send(this, msg);
        }
    }
}