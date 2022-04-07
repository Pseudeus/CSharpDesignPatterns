using System;
using IteratorPattern.Iterator;

namespace IteratorPattern.Aggreagte
{
    public interface ISubjects
    {
        IIterator CreateIterator();
    }
}
