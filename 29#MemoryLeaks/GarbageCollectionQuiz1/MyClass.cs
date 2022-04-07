using System;

namespace GarbageCollectionQuiz1
{
    public class MyClass : IDisposable
    {
        public void DoSomething()
        {
            Console.WriteLine("MyClass.DoSomething()");
        }
        public void Dispose()
        {
            //GC.SuppressFinalize(this);
            Console.WriteLine("MyClass.Dispose() is called");
        }
        ~MyClass()
        {
            Console.WriteLine("MyClass.Destructor() is Called..");
            System.Threading.Thread.Sleep(5000);
        }
    }
}