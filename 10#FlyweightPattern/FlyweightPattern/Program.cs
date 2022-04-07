using System;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Flyweight Pattern Demo***\n");
            RobotFactory myFactory = new RobotFactory();
            IRobot shape = myFactory.GetRobotFromFactory("Small");

            for (int i = 0; i < 2; i++)
            {
                shape = myFactory.GetRobotFromFactory("Small");
                shape.Print();
            }
            int numOfDistinctRobots = myFactory.TotalObjectsCreated;
            Console.WriteLine($"\n  Now, total numbers of distinct robot objects is = { numOfDistinctRobots }\n");

            for (int i = 0; i < 5; i++)
            {
                shape = myFactory.GetRobotFromFactory("Large");
                shape.Print();
            }
            numOfDistinctRobots = myFactory.TotalObjectsCreated;
            Console.WriteLine("\n   Distinct Robot objects created till now = {0}", numOfDistinctRobots);
        }
    }
}
