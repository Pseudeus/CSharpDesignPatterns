using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Builder Pattern Demo***\n");
            Director director = new Director();

            IBuilder b1 = new Car("Subaru brz");
            IBuilder b2 = new MotorCycle("Honda");

            director.Construct(b1);
            Product p1 = b1.GetVehicle();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetVehicle();
            p2.Show();
        }
    }
}
