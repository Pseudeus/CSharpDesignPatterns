using System;

namespace ObserverPattern
{
    public class ObserverType2 : IObserver
    {
        private string nameOfObserver;

        public ObserverType2(string name)
        {
            nameOfObserver = name;            
        }
        public void Update(int upd)
        {
            Console.WriteLine($"\tI'm { this.nameOfObserver } and I love that the new value have changed to { upd }");            
        }
    }
}