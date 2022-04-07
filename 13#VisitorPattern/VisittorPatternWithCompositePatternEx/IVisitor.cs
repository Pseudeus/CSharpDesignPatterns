using System;

namespace VisittorPatternWithCompositePatternEx
{
    public interface IVisitor
    {
        void VisitCompositeElement(CompositeEmployee ce);
        void VisitLeafNode(Employee e);
    }
}