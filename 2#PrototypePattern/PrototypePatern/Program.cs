using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Prototype Pattern Demo*** \n");
            //Base or original copy
            BasicCar nanoBase = new Nano("Green Nano") {Price = 100_000};
            BasicCar fordBase = new Ford("Ford Yellow") {Price = 500_000};
            BasicCar bc1;
            //Nano
            bc1 = nanoBase.Clone();
            bc1.Price += BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1:C}", bc1.ModelName, bc1.Price);
            //Ford
            bc1 = fordBase.Clone();
            bc1.Price += BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1:c}", bc1.ModelName, bc1.Price);
        }
    }
}
