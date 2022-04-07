using System;
using System.Collections.Generic;

namespace VisittorPatternWithCompositePatternEx
{
    public class CompositeEmployee : IEmployee
    {
        private string name;
        private string dept;
        private byte yearsOfExperience;
        private List<IEmployee> childrens;

        public CompositeEmployee(string name, string dept, byte experience)
        {
            this.name = name;
            this.dept = dept;
            yearsOfExperience = experience;
            childrens = new List<IEmployee>();
        }
        public void Add(IEmployee child)
        {
            childrens.Add(child);
        }
        public void Remove(IEmployee prodigal)
        {
            childrens.Remove(prodigal);
        }
        public string Name { get => name; }
        public string Dept { get => dept; }
        public byte Experience { get => yearsOfExperience; }
        public List<IEmployee> Controls { get => childrens; }
        public void PrintStructures()
        {
            Console.WriteLine($"\t{ this.name } works in { this.dept } Experience: { this.yearsOfExperience } years");
            foreach (IEmployee child in childrens)
            {
                child.PrintStructures();
            }
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitCompositeElement(this);
        }
    }
}