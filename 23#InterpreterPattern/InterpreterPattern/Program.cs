using System;
using System.Collections.Generic;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Interpreter Pattern Demo***\n");

            Console.WriteLine("Enter a 3 digit number only (i.e. 100 to 999)");
            string inputString = Console.ReadLine();
            Context context = new Context(inputString);

            if(context.ValidateUserInputBeforeProceding(inputString) != -9999)
            {
                List<InputExpression> expTree = new List<InputExpression>();

                expTree.Add(new HundredExpression());
                expTree.Add(new TenExpression());
                expTree.Add(new UnitExpression());

                foreach(InputExpression iExp in expTree)
                {
                    iExp.Interpret(context);
                }
                Console.WriteLine("Original Input {0} is interpreted as {1}", context.GetInput, context.SetOutput);
            }
        }
    }
}
