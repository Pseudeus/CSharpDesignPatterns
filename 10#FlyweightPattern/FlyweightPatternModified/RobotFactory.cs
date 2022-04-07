using System;
using System.Collections.Generic;

namespace FlyweightPatternModified
{
    //The "FlyweightFactory" class
    public class RobotFactory
    {
        Dictionary<string, IRobot> shapes = new Dictionary<string, IRobot>();

        public int TotalObjectCreated
        {
            get => shapes.Count;
        }
        public IRobot GetRobotFromFactory(string robotType)
        {
            IRobot robotCategory;

            if (shapes.ContainsKey(robotType))
            {
                robotCategory = shapes[robotType];
            }
            else
            {
                switch(robotType)
                {
                    case "Small":
                        Console.WriteLine("We dont have Small Robot at present. So we are creating a Small Robot now.");
                        robotCategory = new Robot("Small");
                        shapes.Add(robotType, robotCategory);
                        break;
                    case "Large":
                        Console.WriteLine("We dont have a Large Robot at present, So we are creating a Large Robot now.");
                        robotCategory = new Robot("Large");
                        shapes.Add(robotType, robotCategory);
                        break;
                    default:
                        throw new Exception("Robot Factory can create only king and queen type robots");
                }
            }
            return robotCategory;
        }
    }
}
