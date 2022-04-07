using System;

namespace VisittorPatternWithCompositePatternEx
{
    public class Employee : IEmployee
    {
        private string name;
        private string dept;
        private byte yearsOfExperience;
        public Employee(string name, string dept, byte experience)
        {
            this.name = name;
            this.dept = dept;
            yearsOfExperience = experience;
        }
        public string Name { get => name; }
        public string Dept { get => dept; }
        public byte Experience { get => yearsOfExperience; }
        public void PrintStructures()
        {
            Console.WriteLine($"\t\t{ this.name } works in { this.dept } Experience: { this.yearsOfExperience } years");
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitLeafNode(this);
        }
    }
}