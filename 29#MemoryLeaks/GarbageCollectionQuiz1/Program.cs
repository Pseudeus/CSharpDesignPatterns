using System;

namespace GarbageCollectionQuiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Quiz on Garbage Collections***\n");
            MyClass myOb = new MyClass();
            myOb.DoSomething();
            myOb.Dispose();
        }
    }
}
