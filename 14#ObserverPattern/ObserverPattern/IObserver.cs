using System;

namespace ObserverPattern
{
    public interface IObserver
    {
        void Update(int newValue);
    }
}