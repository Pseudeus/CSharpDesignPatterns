using System;

namespace FlyweightPatternModified
{
    public class Robot : IRobot
    {
        public string colorOfRobot;
        
        string robotType;

        public Robot(string robotType)
        {
            this.robotType = robotType;
        }
        public void SetColor(string colorOfRobot)
        {
            this.colorOfRobot = colorOfRobot;
        }
        public void Print()
        {
            Console.WriteLine($"This is a { robotType } type robot with { colorOfRobot } color");
        }
    }
}
