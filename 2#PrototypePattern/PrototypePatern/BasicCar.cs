using System;

namespace PrototypePattern
{
    public abstract class BasicCar
    {
        public string ModelName;
        public int Price;
        public static int SetPrice()
        {
            return new Random().Next(200_000, 500_000);
        }
        public abstract BasicCar Clone();
    }
}