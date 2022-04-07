using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Composite Pattern Demo***\n");

            CompositeEmployee principal = new CompositeEmployee("Dr.S.Som (Principal)", "Planning-Supervising-Managing");

            CompositeEmployee hodMaths = new CompositeEmployee("Mrs.S.Das(HOD-Maths)", "Maths");
            CompositeEmployee hodCompSc = new CompositeEmployee("Mr. V.Sarcar(HOD-CSE)", "Computer Sc.");

            Employee mathTeacher1 = new Employee("Math Teacher-1", "Maths");
            Employee mathTeacher2 = new Employee("Math Teacher-2", "Maths");

            Employee cseTeacher1 = new Employee("CSE Teacher-1", "Computer Sc.");
            Employee cseTeacher2 = new Employee("CSE Teacher-2", "Computer Sc.");
            Employee cseTeacher3 = new Employee("CSE Teacher-3", "Computer Sc.");

            hodMaths.Add(mathTeacher1);
            hodMaths.Add(mathTeacher2);

            hodCompSc.Add(cseTeacher1);
            hodCompSc.Add(cseTeacher2);
            hodCompSc.Add(cseTeacher3);

            principal.Add(hodMaths);
            principal.Add(hodCompSc);

            Console.WriteLine("\nTesting the structure of a Principal object.");
            principal.PrintStructures();

            Console.WriteLine("\nTesting the structure of a HOD object:");
            Console.WriteLine("Teachers working at Computer Science department:");
            hodCompSc.PrintStructures();

            Console.WriteLine("\nTesting the structure of a leaf node:");
            mathTeacher1.PrintStructures();

            hodCompSc.Remove(cseTeacher2);
            Console.WriteLine("\nAfter CSE Teacher-2 resigned, the organization has following members:");
            principal.PrintStructures();
        }
    }
}
