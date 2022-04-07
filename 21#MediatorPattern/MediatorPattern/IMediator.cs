using System;

namespace MediatorPattern
{
    public interface IMediator
    {
        void Register(Friend friend);
        void Send(Friend friend, string msg);
    }
}