using System;

namespace MediatorPatternQAs
{
    public class Friend2 : Friend
    {
        public Friend2(IMediator mediator, string name) : base(mediator)
        {
            this.Name = name;
            this.Status = Status.online;
        }        
        public void Send(Friend target, string msg)
        {
            mediator.Send(this, target, msg);
        }
    }
}