using System;

namespace TemplateMethodPatternQAs
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
            if(IsAdditionalPapersNeeded()) AdditionalPapers();
        }
        private void SoftSkills()
        {
            Console.WriteLine("Soft skills");
        }
        private void AdditionalPapers()
        {
            Console.WriteLine("Additional Papers are needed in this stream.");
        }
        public abstract void SpecialPaper();
        public virtual bool IsAdditionalPapersNeeded()
        {
            return true;
        }
    }
}