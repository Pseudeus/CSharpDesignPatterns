using System;

namespace ObserverPattern
{
    public class ObserverType1 : IObserver
    {
        private string nameOfObserver;

        public ObserverType1(string name)
        {
            nameOfObserver = name;
        }
        public void Update(int upd)
        {
            Console.WriteLine($"\tI'm { this.nameOfObserver } and the updated value is { upd }");
        }
    }
}