using System;

namespace AdapterPattern_Modified
{
    interface IRectangle
    {
        void AboutRectangle();
        double CalculateAreaOfRectangle();
    }
    interface ITriangle
    {
        void AboutTriangle();
        double CalculateAreaOfTriangle();
    }
    class Rectangle : IRectangle 
    {
        double length;
        double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public double CalculateAreaOfRectangle()
        {
            return length * width;
        }
        public void AboutRectangle()
        {
            Console.WriteLine("Actualy, I'm a rectangle");
        }
    }
    class Triangle : ITriangle
    {
        double baseT;
        double height;

        public Triangle(int b, int h)
        {
            baseT = b;
            height = h;
        }
        public double CalculateAreaOfTriangle()
        {
            return (baseT * height) / 2;
        }
        public void AboutTriangle()
        {
            Console.WriteLine("Actualy, I'm a triangle");
        }
    }
    class TriangleAdapter : IRectangle
    {
        Triangle triangle;
        public TriangleAdapter(Triangle t)
        {
            triangle = t;
        }
        public double CalculateAreaOfRectangle()
        {
            return triangle.CalculateAreaOfTriangle();
        }
        public void AboutRectangle()
        {
            triangle.AboutTriangle();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Adapter Pattern Modified Demo***\n");

            Rectangle rect = new Rectangle(10, 15);
            Console.WriteLine($"Area of Rectangle is: { rect.CalculateAreaOfRectangle() } square unit");

            Triangle t = new Triangle(12, 15);
            Console.WriteLine($"Area of Triangle is: { t.CalculateAreaOfTriangle() } square unit");

            IRectangle adapter = new TriangleAdapter(t);
            Console.WriteLine($"Area of Triangle using the triangle adapter is: { GetArea(adapter) } square unit");
        }
        static double GetArea(IRectangle r)
        {
            r.AboutRectangle();
            return r.CalculateAreaOfRectangle();
        }
    }
}
