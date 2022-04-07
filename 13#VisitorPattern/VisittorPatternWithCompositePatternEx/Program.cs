using System;

namespace VisittorPatternWithCompositePatternEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Visitor Pattern combined with Composite Pattern Demo***\n");
            #region Similar code structure taken from Composite Pattern demo

            CompositeEmployee principal = new CompositeEmployee("Dr.S.Som(Principal)", "Planning-Supervising-Managing", 20);

            CompositeEmployee hodMaths = new CompositeEmployee("Mrs.S.Das(HOD-Maths)", "Maths", 14);
            CompositeEmployee hodCompSc = new CompositeEmployee("Mr.V.Sarcar(HOD-CSE)", "Computer Sc.", 16);

            IEmployee mathTeacher1 = new Employee("Math Teacher-1", "Maths", 14);
            IEmployee mathTeacher2 = new Employee("Math Teacher-2", "Maths", 6);

            IEmployee cseTeacher1 = new Employee("CSE Teacher-1", "Computer Sc.", 10);
            IEmployee cseTeacher2 = new Employee("CSE Teacher-2", "Computer Sc.", 13);
            IEmployee cseTeacher3 = new Employee("CSE Teacher-3", "Computer Sc.", 7);

            principal.Add(hodMaths);
            principal.Add(hodCompSc);

            hodMaths.Add(mathTeacher1);
            hodMaths.Add(mathTeacher2);

            hodCompSc.Add(cseTeacher1);
            hodCompSc.Add(cseTeacher2);
            hodCompSc.Add(cseTeacher3);

            principal.PrintStructures();
            #endregion
            
            Console.WriteLine("\n***Visitor starts visiting our composite structure***\n");
            IVisitor visitor = new Visitor();

            foreach (IEmployee e in principal.Controls)
            {
                e.Accept(visitor);
            }
            foreach (IEmployee e in hodMaths.Controls)
            {
                e.Accept(visitor);
            }
            foreach (IEmployee e in hodCompSc.Controls)
            {
                e.Accept(visitor);
            }
        }
    }
}
