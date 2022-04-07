using System;

namespace VisitorPattern
{
    public class Visitor : IVisitor
    {
        public void Visit(MyClass mc)
        {
            Console.WriteLine("Visitor is trying to change the integer value.");
            mc.MyInt = 100;
            Console.WriteLine("Exiting from Visitor.");
        }
    }
}