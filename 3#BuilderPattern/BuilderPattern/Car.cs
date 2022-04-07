using System;

namespace BuilderPattern
{
    public class Car : IBuilder
    {
        private string brandName;
        private Product product;

        public Car(string brand)
        {
            product = new Product();
            brandName = brand;
        }
        public void StartUpOperations()
        {
            product.Add(string.Format("Car Model name: {0}", brandName));
        }
        public void BuildBody()
        {
            product.Add("this is a body of a Car");
        }
        public void InsertWheels()
        {
            product.Add("4 wheels are added");
        }
        public void AddHeadlights()
        {
            product.Add("2 Headlights are added");
        }
        public void EndOperations()
        {
            Console.WriteLine(this.ToString() + " has finished");
        }
        public Product GetVehicle()
        {
            return product;
        }
    }
}