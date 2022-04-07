using System;
using static System.Console;

namespace GarbageCollectionEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***Exploring Garbage Collections.***\n");
            try
            {
                WriteLine("Maxium Generations of GC: {0}", GC.MaxGeneration);
                WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));
                MyClass myOb = new MyClass();
                WriteLine("myOb is in Generation : {0}", GC.GetGeneration(myOb));
                WriteLine("Now Total Memory is: {0}", GC.GetTotalMemory(false));
                WriteLine("Collection occurred in 0th Generation: {0}", GC.CollectionCount(0));
                WriteLine("Collection occurred in 1st Generation: {0}", GC.CollectionCount(1));
                WriteLine("Collection occurred in 2nd Generation: {0}", GC.CollectionCount(2));

                GC.Collect(0);//will call generation 0
                WriteLine("\nAfter GC.Collect(0)");

                WriteLine("Collection occurred in 0th Generation: {0}", GC.CollectionCount(0));
                WriteLine("Collection occurred in 1st Generation: {0}", GC.CollectionCount(1));
                WriteLine("Collection occurred in 2nd Generation: {0}", GC.CollectionCount(2));
                WriteLine("myOb is in Generation: {0}", GC.GetGeneration(myOb));
                WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

                GC.Collect(1);//will call generation 1 with 0
                WriteLine("\nAfter GC.Collect(1)");

                WriteLine("Collection occurred in 0th Generation: {0}", GC.CollectionCount(0));
                WriteLine("Collection occurred in 1st Generation: {0}", GC.CollectionCount(1));
                WriteLine("Collection occurred in 2nd Generation: {0}", GC.CollectionCount(2));
                WriteLine("myOb is in Generation: {0}", GC.GetGeneration(myOb));
                WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

                GC.Collect(2);//will call generation 2 with 1 and 0
                WriteLine("\nAfter GC.Collect(2)");

                myOb.Dispose();

                WriteLine("Collection occurred in 0th Generation: {0}", GC.CollectionCount(0));
                WriteLine("Collection occurred in 1st Generation: {0}", GC.CollectionCount(1));
                WriteLine("Collection occurred in 2nd Generation: {0}", GC.CollectionCount(2));
                WriteLine("myOb is in Generation: {0}", GC.GetGeneration(myOb));
                WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));
            }
            catch(Exception e)
            {
                WriteLine("Error: {0}", e);
            }
        }
    }
}
