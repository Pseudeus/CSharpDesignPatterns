using System;

namespace StrategyPattern
{
    public class FirstChoise : IChoise
    {
        public void MyChoise()
        {
            Console.WriteLine("Traveling to Japan");
        }
    }
}