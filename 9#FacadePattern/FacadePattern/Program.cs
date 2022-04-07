using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Facade Pattern Demo***\n");
            RobotFacade rf1 = new RobotFacade();
            rf1.CostructMilanoRobot();

            RobotFacade rf2 = new RobotFacade();
            rf2.ConstructRobonautRobot();

            rf1.DestroyMilanoRobot();
            rf2.DestroyRobonautRobot();
        }
    }
}
