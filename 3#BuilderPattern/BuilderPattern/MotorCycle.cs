using System;

namespace BuilderPattern
{
    public class MotorCycle : IBuilder
    {
        private string brandName;
        private Product product;

        public MotorCycle(string brand)
        {
            brandName = brand;
            product = new Product();
        }

        public void StartUpOperations()
        {
            product.Add("Nothing to do");
        }
        public void BuildBody()
        {
            product.Add("This is a body of a Motorcycle");
        }
        public void InsertWheels()
        {
            product.Add("2 wheels are added");
        }
        public void AddHeadlights()
        {
            product.Add("1 Headlights are added");
        }
        public void EndOperations()
        {
            product.Add(string.Format("Motorcycle Model name: {0}", brandName));
        }
        public Product GetVehicle()
        {
            return product;
        }
    }
}