using System;

namespace IteratorPattern.Iterator
{
    public interface IIterator
    {
        string CurrentItem();
        void First();
        bool IsDone();
        string Next();
    }
}
