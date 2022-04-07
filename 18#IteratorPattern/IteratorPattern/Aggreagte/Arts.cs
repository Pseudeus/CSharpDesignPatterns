using System;
using IteratorPattern.Iterator;

namespace IteratorPattern.Aggreagte
{
    public class Arts : ISubjects
    {
        private string[] subjects;

     public Arts()
     {
         subjects = new[]{"Bengali", "English"};
     }   
     public IIterator CreateIterator()
     {
         return new ArtsIterator(subjects);
     }
    }
}
