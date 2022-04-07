using System;
using System.Collections.Generic;

namespace MediatorPattern
{
    public class ConcreteMediator : IMediator
    {
        List<Friend> participants = new List<Friend>();
    
        public void DisplayDetails()
        {
            Console.WriteLine("At present, registered Participants are: ");

            foreach(var friend in participants)
            {
                Console.WriteLine("{0}", friend.Name);
            }
        }
        public void Register(Friend f)
        {
            participants.Add(f);
        }
        public void Send(Friend friend, string msg)
        {
            if(participants.Contains(friend))
            {
                Console.WriteLine(String.Format("[{0}] posts: {1} Last message posted {2}",friend.Name, msg, DateTime.Now));
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("An outsider named {0} trying to send some messages", friend.Name);
            }
        }
    }
}