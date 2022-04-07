using System;

namespace VisittorPatternWithCompositePatternEx
{
    public class Visitor : IVisitor
    {
        public void VisitCompositeElement(CompositeEmployee employee)
        {
            string eleigibleForPromotion = employee.Experience > 15 
                                         ? String.Format($"\t\t{ employee.Name } from { employee.Dept } is eleigible for promotion.")
                                         : String.Format($"\t\t{ employee.Name } from { employee.Dept } is not eleigible for promotion.");
            Console.WriteLine(eleigibleForPromotion);
        }
        public void VisitLeafNode(Employee employee)
        {
            string eleigibleForPromotion = employee.Experience > 12 
                                         ? String.Format($"\t\t{ employee.Name } from { employee.Dept } is eleigible for promotion.")
                                         : String.Format($"\t\t{ employee.Name } from { employee.Dept } is not eleigible for promotion.");
            Console.WriteLine(eleigibleForPromotion);
        }
    }
}