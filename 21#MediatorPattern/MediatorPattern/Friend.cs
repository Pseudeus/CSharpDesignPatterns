using System;

namespace MediatorPattern
{
    public abstract class Friend
    {
        protected IMediator mediator;
        private string name;
        
        public string Name
        {
            get => name;
            set { name = value; }
        }

        public Friend(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}