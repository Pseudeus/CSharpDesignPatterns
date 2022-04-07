using System;
using FacadePattern.RobotParts;

namespace FacadePattern
{
    public class RobotFacade
    {
        RobotColor robotColor;
        RobotHands robotHands;
        RobotBody robotBody;

        public RobotFacade()
        {
            robotColor = new RobotColor();
            robotHands = new RobotHands();
            robotBody = new RobotBody();
        }
        public void CostructMilanoRobot()
        {
            Console.WriteLine("Creation of a Milano Robot Start");
            robotColor.SetDefaultColor();
            robotHands.SetMilanoHands();
            robotBody.CreateHands();
            robotBody.CreateRemainingParts();
            Console.WriteLine("Milano Robot Creation End");
            Console.WriteLine();
        }
        public void ConstructRobonautRobot()
        {
            Console.WriteLine("Initiating the creational process of a Robonaut Robot");
            robotColor.SetGreenColor();
            robotHands.SetRobonautHands();
            robotBody.CreateHands();
            robotBody.CreateRemainingParts();
            Console.WriteLine("A Robonaut Robot is created");
        }
        public void DestroyMilanoRobot()
        {
            Console.WriteLine("Milano Robot's destruction process is started");
            robotHands.ResetMilanoHands();
            robotBody.DestroyHands();
            robotBody.DestroyRemaininngParts();
            Console.WriteLine("Milano Robot's destructin process is over");
            Console.WriteLine();
        }
        public void DestroyRobonautRobot()
        {
            Console.WriteLine("Initiating a Robonaut Robot's destruction process");
            robotHands.ResetRobonautHands();
            robotBody.DestroyHands();
            robotBody.DestroyRemaininngParts();
            Console.WriteLine("A Robonaut Robot was destroyed");
            Console.WriteLine();
        }
    }
}
