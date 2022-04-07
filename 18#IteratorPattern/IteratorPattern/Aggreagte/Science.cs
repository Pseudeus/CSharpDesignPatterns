using System;
using IteratorPattern.Iterator;
using System.Collections.Generic;

namespace IteratorPattern.Aggreagte
{
    public class Science : ISubjects
    {
        private LinkedList<string> subjects;

        public Science()
        {
            subjects = new LinkedList<string>();
            subjects.AddFirst("Maths");
            subjects.AddFirst("Comp. Sc.");
            subjects.AddFirst("Physics");
        }
        public IIterator CreateIterator()
        {
            return new ScienceIterator(subjects);
        }
    }
}
