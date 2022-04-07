using System;

namespace DecoratorPattern
{
    abstract class Component
    {
        public abstract void MakeHouse();
    }
    class ConcreteComponent : Component
    {
        public override void MakeHouse()
        {
            Console.WriteLine("Original House is complete. It is closed for modification.");
        }
    }
    abstract class AbstractDecorator : Component
    {
        protected Component component;
        public void SetTheComponent(Component c)
        {
            component = c;
        }
        public override void MakeHouse()
        {
            component?.MakeHouse();
        }
    }
    class ConcreteDecoratorEx1 : AbstractDecorator
    {
        public override void MakeHouse()
        {
            base.MakeHouse();
            Console.WriteLine("***Using a decorator***");
            //Decorating now
            AddFloor();
        }
        private void AddFloor()
        {
            Console.WriteLine("I am making an additional floor on top of it.");
        }
    }
    class ConcreteDecoratorEx2 : AbstractDecorator
    {
        public override void MakeHouse()
        {
            Console.WriteLine("");
            base.MakeHouse();
            Console.WriteLine("***Using another decorator***");
            //Decorating now.
            PaintTheHouse();
        }
        private void PaintTheHouse()
        {
            Console.WriteLine("Now I am painting the house.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Decorator Pattern Demo***\n");
            ConcreteComponent cc = new ConcreteComponent();

            AbstractDecorator decorator1 = new ConcreteDecoratorEx1();
            decorator1.SetTheComponent(cc);
            decorator1.MakeHouse();

            AbstractDecorator decorator2 = new ConcreteDecoratorEx2();
            decorator2.SetTheComponent(decorator1);
            decorator2.MakeHouse();
        }
    }
}
