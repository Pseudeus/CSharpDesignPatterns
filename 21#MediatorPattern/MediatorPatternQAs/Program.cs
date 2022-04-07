using System;

namespace MediatorPatternQAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Modified Mediator Pattern Demo***\n");

            ConcreteMediator cMediator = new ConcreteMediator();

            Friend1 Amith = new Friend1(cMediator, "Amith");
            Friend2 Sohel = new Friend2(cMediator, "Sohel");
            Boss Raghu = new Boss(cMediator,"Raghu");

            cMediator.Register(Amith);
            cMediator.Register(Sohel);
            cMediator.Register(Raghu);

            Amith.Send(Sohel, "Hy Sohel, can we discuss the mediator pattern?");
            Sohel.Send(Amith, "Hi Amith, Yup, se can discuss now.");
            Raghu.Send("Please get back to work quickly.", Amith, Sohel);

            Sohel.Status = Status.offline;
            Amith.Send(Sohel, "I am testin to sen a message when Sohel is in offline state.");

            Sohel.Status = Status.online;
            Amith.Send(Sohel, "I am testing to send a message when Sohel in online state again.");

            Amith.Status = Status.away;
            Raghu.Send("Can you please come here?", Sohel, Amith);
        }
    }
}
