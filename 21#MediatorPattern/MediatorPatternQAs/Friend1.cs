using System;

namespace MediatorPatternQAs
{
    public class Friend1 : Friend
    {
        public Friend1(IMediator mediator, string name) : base(mediator)
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