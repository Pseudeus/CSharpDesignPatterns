using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Strategy Pattern Demo***\n");

            Context ctx = new Context();
            IChoise ic;

            for(int i = 0; i < 2; i++)
            {
                rerun:
                Console.WriteLine("\nEnter ur choise(1 or 2)");
                string c = Console.ReadLine();

                if(c == "1" || c == "2")
                {
                    ic = c == "1" ? new FirstChoise()
                                  : new SecondChoise();

                    ctx.SetChoise(ic);
                    ctx.ShowChoise();
                }
                else
                {
                    Console.WriteLine("No valid option. Already we have not that option.");
                    goto rerun;
                }
            }
        }
    }
}
