using System;
using IteratorPattern.Aggreagte;
using IteratorPattern.Iterator;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Iterator Pattern Demo***\n");
            ISubjects scienceSubjects = new Science();
            ISubjects artsSubjects = new Arts();

            IIterator iteratorForScience = scienceSubjects.CreateIterator();
            IIterator iteratorForArts = artsSubjects.CreateIterator();

            Console.WriteLine("\nScience subjects: ");
            Print(iteratorForScience);

            Console.WriteLine("\nArts subjects");
            Print(iteratorForArts);
        }
        public static void Print(IIterator iterator)
        {
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
