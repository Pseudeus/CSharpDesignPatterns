using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Mediator Pattern Demo***\n");

            ConcreteMediator mediator = new ConcreteMediator();

            Friend1 Amith = new Friend1(mediator, "Amith");
            Friend2 Sohel = new Friend2(mediator, "Sohel");
            Boss Raghu = new Boss(mediator, "Raghu");

            mediator.Register(Amith);
            mediator.Register(Sohel);
            mediator.Register(Raghu);

            mediator.DisplayDetails();

            Console.WriteLine("Communication starts among participants...");
            Amith.Send("Hy Sohel, can we discuss the mediator pattern?");
            Sohel.Send("Hi Amith, Yup, we can discuss now.");
            Raghu.Send("Please get back to work quickly.");

            Unknown unknown = new Unknown(mediator, "Jack");
            unknown.Send("Hello Guys...");
        }
    }
}
