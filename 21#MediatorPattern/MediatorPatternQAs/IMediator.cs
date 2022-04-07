using System;

namespace MediatorPatternQAs
{
    public interface IMediator
    {
        void Register(Friend friend);
        void Send(Friend from, Friend to, string msg);
    }
}