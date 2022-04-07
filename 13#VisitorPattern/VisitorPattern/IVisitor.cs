using System;

namespace VisitorPattern
{
    public interface IVisitor
    {
        void Visit(MyClass mc);
    }
}