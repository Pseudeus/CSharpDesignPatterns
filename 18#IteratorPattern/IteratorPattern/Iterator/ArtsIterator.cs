using System;

namespace IteratorPattern.Iterator
{
    public class ArtsIterator : IIterator
    {
        private string[] subjects;
        private int position;

        public ArtsIterator(params string[] subjects)
        {
            this.subjects = subjects;
        }
        public string CurrentItem()
        {
            return subjects[position];
        }
        public void First()
        {
            position = 0;
        }
        public bool IsDone()
        {
            if (position < subjects.Length)
            {
                return false;
            }
            return true;
        }
        public string Next()
        {
            return subjects[position++];
        }
    }
}
