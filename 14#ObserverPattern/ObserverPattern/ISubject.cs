using System;

namespace ObserverPattern
{
    public interface ISubject
    {
        void NotifyRegisteredUsers();
        void Register(IObserver io);
        void Unregister(IObserver io);
    }
}