using System;

namespace GarbageCollectionEx1
{
    public class MyClass
    {
        private int myInt;
        private double myDouble;

        public MyClass()
        {
            myInt = 25;
            myDouble = 100.5;
        }
        public void ShowMe()
        {
            Console.WriteLine("MyClass.ShowMe()");
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Console.WriteLine("Dispose() is called");
            Console.WriteLine("Toyal Memory: " + GC.GetTotalMemory(false));
        }
        ~MyClass()
        {
            Console.WriteLine("Destructor is called..");
            Console.WriteLine("After this destruction total Memory: " + GC.GetTotalMemory(false));
            System.Threading.Thread.Sleep(60000);
        }
    }
}