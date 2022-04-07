using System;

namespace MediatorPatternQAs
{
    public class Boss : Friend
    {
        public Boss(IMediator mediator, string name) : base(mediator)
        {
            this.Name = name;
            this.Status = Status.online;
        }        
        public void Send(string msg, params Friend[] targets)
        {
            foreach(Friend target in targets)
            {
                mediator.Send(this, target, msg);
            }
        }
    }
}