using System;

namespace TemplateMethodPattern
{
    public abstract class BasicEngineering
    {
        private void Math ()
        {
            Console.WriteLine("Mathematics");
        }
        public void Papers()
        {
            //Common papers
            Math();
            SoftSkills();
            //Special papers
            SpecialPaper();
        }
        private void SoftSkills()
        {
            Console.WriteLine("Soft skills");
        }
        public abstract void SpecialPaper();
    }
}