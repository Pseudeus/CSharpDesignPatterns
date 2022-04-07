using System;

namespace VisitorPattern
{
    public class MyClass : IOriginalInterface
    {
        private int myInt = 5;
        public int MyInt
        {
            get => myInt;
            set { myInt = value; }
        }

        public void Accept(IVisitor visitor)
        {
            Console.WriteLine("Initial value of the integer: {0}", myInt);
            visitor.Visit(this);
            Console.WriteLine("\nValue of integer now: {0}", myInt);
        }
    }
}