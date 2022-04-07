using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Observer Pattern Demo***\n");

            Subject subject = new Subject();

            IObserver ob1 = new ObserverType1("Pancho");
            IObserver ob2 = new ObserverType2("Juan");

            subject.Register(ob1);
            subject.Flag = 50;

            subject.Register(ob2);
            subject.Flag = 100;

            subject.Unregister(ob1);
            subject.Flag = 25;
        }
    }
}
