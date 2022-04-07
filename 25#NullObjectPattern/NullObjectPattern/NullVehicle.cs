using System;

namespace NullObjectPattern
{
    public class NullVehicle : IVehicle
    {
        private static readonly NullVehicle self = new NullVehicle();
        public static int NullVehicleCount;

        public static NullVehicle Instance
        {
            get
            {
                Console.WriteLine("We already have an instance now. Use it.");
                return self;
            }
        }
        public void Travel()
        {
        
        }
    }
}