using System;

namespace VisittorPatternWithCompositePatternEx
{
    public interface IEmployee
    {
        void Accept(IVisitor visitor);
        void PrintStructures();
    }
}