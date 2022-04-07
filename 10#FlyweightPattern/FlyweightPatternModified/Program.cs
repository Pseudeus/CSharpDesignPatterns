using System;
using System.Threading;

namespace FlyweightPatternModified
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Flyweight Pattern Modified Demo***\n");
            RobotFactory myFactory = new RobotFactory();
            Robot shape;

            for (int i = 0; i < 3; i++)
            {
                shape = (Robot)myFactory.GetRobotFromFactory("Small");
                Thread.Sleep(1000);
                shape.SetColor(GetRandomColor());
                shape.Print();
            }
            for (int i = 0; i < 3; i++)
            {
                shape = (Robot)myFactory.GetRobotFromFactory("Large");
                Thread.Sleep(1000);
                shape.SetColor(GetRandomColor());
                shape.Print();
            }
            int numOfDistinctRobots = myFactory.TotalObjectCreated;
            Console.WriteLine("\nFinally No. of Distinct Robot objects created: " + numOfDistinctRobots);
        }
        private static string GetRandomColor()
        {
            Random r = new Random();
            int random = r.Next(100);

            if(random % 2 == 0)
            {
                return "red";
            }
            else
            {
                return "green";
            }
        }
    }
}
