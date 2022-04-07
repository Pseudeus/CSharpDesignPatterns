using System;

namespace StrategyPattern
{
    public class SecondChoise : IChoise
    {
        public void MyChoise()
        {
            Console.WriteLine("Traveling to India");
        }
    }
}