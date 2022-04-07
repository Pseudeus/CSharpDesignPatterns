using System;

namespace MediatorPatternQAs
{
    public abstract class Friend
    {
        private string name;
        private Status status;
        protected IMediator mediator;

        public string Name
        {
            get => name;
            set { name = value; }
        }
        public Status Status
        {
            get => status;
            set { status = value; }
        }
        public Friend(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}