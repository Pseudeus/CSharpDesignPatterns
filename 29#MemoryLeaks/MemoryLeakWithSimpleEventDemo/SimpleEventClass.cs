using System;

namespace MemoryLeakWithSimpleEventDemo
{
    public delegate string MyDelegate(string str);
    public class SimpleEventClass : IDisposable
    {
        public int Id { get; set; }
        public event MyDelegate SimpleEvent;

        public SimpleEventClass()
        {
            SimpleEvent += new MyDelegate(PrintText);
        }
        private string PrintText(string text)
        {
            return text;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                //Use this section to cleanup managed objects
                //In our case, we are just cleaning the event subscription
                if(this.SimpleEvent != null)
                {
                    this.SimpleEvent -= new MyDelegate(PrintText);
                    Console.WriteLine("Unsuscribed");
                }
            }
        }
        ~SimpleEventClass()
        {
            Dispose(false);
        }
        public string RaiseEvent(string msg)
        {
            return SimpleEvent(msg);
        }
    }
}