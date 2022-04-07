using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorPattern.Iterator
{
    public class ScienceIterator : IIterator
    {
        private LinkedList<string> subjects;
        private int position;

        public ScienceIterator(LinkedList<string> subjects)
        {
            this.subjects = subjects;
            position = 0;
        }
        public string CurrentItem()
        {
            return subjects.ElementAt(position);
        }
        public void First()
        {
            position = 0;
        }
        public bool IsDone()
        {
            if (position < subjects.Count)
            {
                return false;
            }
            return true;
        }
        public string Next()
        {
            return subjects.ElementAt(position++);
        }
    }
}
