using System;

namespace AdapterPattern
{
    public class Rect
    {
        public double length;
        public double width;
    }
    public class Calculator
    {
        public double GetArea(Rect rect)
        {
            return rect.length * rect.width;
        }
    }
    public class Triangle
    {
        public double baseT;
        public double height;
        public Triangle(int b, int h)
        {
            baseT = b;
            height = h;
        }
    }
    class CalculatorAdapter
    {
        public double GetArea(Triangle triangle)
        {
            Calculator c = new Calculator();
            Rect rect = new Rect();

            //Area of Triangle = 0.5 * base * height
            rect.length = triangle.baseT;
            rect.width = triangle.height / 2;
            return c.GetArea(rect);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Adapter Pattern Demo***\n");
            CalculatorAdapter ca = new CalculatorAdapter();
            Triangle t = new Triangle(12, 9);
            Console.WriteLine($"Area of Triangle is { ca.GetArea(t) } square unit");
        }
    }
}
