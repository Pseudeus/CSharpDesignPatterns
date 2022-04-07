using System;
using System.Collections.Generic;

namespace MemoryLeakWithSimpleEventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PizOShi");

            Dictionary<int, SimpleEventClass> col = new Dictionary<int, SimpleEventClass>();
            for(int currentObjectNo = 0; currentObjectNo < 500_000; currentObjectNo++)
            {
                using(col[currentObjectNo] = new SimpleEventClass{ Id = currentObjectNo })
                {
                    string resutl = col[currentObjectNo].RaiseEvent("Raising an event");
                    Console.WriteLine(currentObjectNo);
                    col[currentObjectNo].Dispose();
                }
                //We are indicating that the object is now ready for GC
                col[currentObjectNo] = null;
            }
        }   
    }
}
