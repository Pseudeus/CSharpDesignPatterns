using System;

namespace VisitorPattern
{
    public interface IOriginalInterface
    {
        void Accept(IVisitor visitor);
    }
}