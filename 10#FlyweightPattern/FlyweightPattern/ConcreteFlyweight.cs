using System;

namespace FlyweightPattern
{
    /// <summary>
    /// A "ConcreteFlyweight" class
    /// </summary>
    public class SmallRobot : IRobot
    {
        public void Print()
        {
            Console.WriteLine("This is a small Robot");
        }
    }
    public class LargeRobot : IRobot
    {
        public void Print()
        {
            Console.WriteLine("I am a large Robot");
        }
    }
}
