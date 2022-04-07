using System;
using System.Collections.Generic;

namespace MediatorPatternQAs
{
    public class ConcreteMediator : IMediator
    {
        private List<Friend> registry = new List<Friend>();
        
        public void Register(Friend friend)
        {
            if(!registry.Contains(friend))
                registry.Add(friend);
        }
        public void Send(Friend from, Friend to, string msg)
        {
            if(registry.Contains(from))
            {
                if(to.Status == Status.online)
                {
                    Console.WriteLine(String.Format($"[{ from.Name } => { to.Name }] : { msg } | Last message posted { DateTime.Now }"));
                    System.Threading.Thread.Sleep(SimulateRandomly());
                }
                else
                {
                    Console.WriteLine(String.Format($"[{ from.Name } => { to.Name }] : { from.Name }, you cannot post messages now. { to.Name } is not online. Try again later"));
                } 
            }
            else
            {
                Console.WriteLine($"Someone not registred called { from.Name } tryed to send a message to { to.Name }.");
            }
        }
        private int SimulateRandomly()
        {
            return new Random().Next(1000, 5000);
        }
    }
}