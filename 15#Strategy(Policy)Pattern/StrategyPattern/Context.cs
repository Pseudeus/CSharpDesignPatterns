using System;

namespace StrategyPattern
{
    public class Context
    {
        IChoise choise;

        public void SetChoise(IChoise option)
        {
            choise = option;
        }
        public void ShowChoise()
        {
            choise.MyChoise();
        }
    }
}