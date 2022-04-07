using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class Subject : ISubject
    {
        private int flag;
        private List<IObserver> observers = new List<IObserver>();

        public int Flag 
        {
             get => flag; 
             set
             {
                 Console.WriteLine($"Setting flag = { value }");
                 flag = value;
                 NotifyRegisteredUsers();
             }
        }

        public void NotifyRegisteredUsers()
        {
            foreach(IObserver o in observers)
            {
                o.Update(flag);
            }
        }
        public void Register(IObserver io)
        {
            if(!observers.Contains(io))
                observers.Add(io);
            
        }
        public void Unregister(IObserver io)
        {
            if(observers.Contains(io))
                observers.Remove(io);
        }
    }
}