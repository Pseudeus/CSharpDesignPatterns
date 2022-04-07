using System;

namespace SingletonPatternEx
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private byte numberOfInstances = 0;

        private Singleton()
        {
            Console.WriteLine("Instantiating inside the private constructor.");
            numberOfInstances++;
            Console.WriteLine("Number of instances = {0}", numberOfInstances);
        }
        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("We already have an instance now. Use it.");
                return instance;
            }
        }
        public static int MyInt = 25;
        public int MyNSInt = 12;
    }

    public sealed class SingletonLO
    {
        private static volatile SingletonLO instance;
        private static object lockObject = new Object();

        private SingletonLO(){}

        public static SingletonLO Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(lockObject)
                    {
                        if(instance == null)
                            instance = new SingletonLO();
                    }
                }
                return instance;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Singleton patternd demo***\n");
            Console.WriteLine("Trying to create instance s1");
            Singleton s1 = Singleton.Instance;

            Console.WriteLine("Trying to create instance s2");
            Singleton s2 = Singleton.Instance;

            Console.WriteLine(Singleton.MyInt);
            Console.WriteLine(s1.MyNSInt);

            if(s1 == s2)
            {
                Console.WriteLine("Only one instance exist.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }
            Console.Read();
        }
    }
}
