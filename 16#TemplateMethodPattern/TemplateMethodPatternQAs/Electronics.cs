using System;

namespace TemplateMethodPatternQAs
{
    public class Electronics : BasicEngineering
    {
        public override void SpecialPaper()
        {
            Console.WriteLine("Digital Logic and Circuit Theory");
        }
        public override bool IsAdditionalPapersNeeded()
        {
            return false;
        }
    }
}