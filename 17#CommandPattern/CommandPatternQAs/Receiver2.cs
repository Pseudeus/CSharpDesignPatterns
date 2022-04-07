using System;

namespace CommandPatternQAs
{
    public class Reciever2 : IReceiver
    {
        private byte myNumber;

        public byte MyNumber 
        {
            get => myNumber;
        }

        public Reciever2()
        {
            myNumber = 75;
            Console.WriteLine("Receiver1 initialized with {0}", myNumber);
            Console.WriteLine("The objects of receiver1 cannot set beyond {0}", myNumber);
        }
        public void Add2WithNumber()
        {
            byte current = myNumber;
            myNumber += 2;
            Console.WriteLine($"{ current } + 2 = { myNumber }");
        }
        public void Remove2FromNumber()
        {
            byte current = myNumber;
            if(current > 75)
            {
                myNumber -= 2;
                Console.WriteLine($"{ current } - 2 = { myNumber }");
            }
            else
            {
                Console.WriteLine("Nothing more to undo...");
            }
        }
        public void OptionalTasksPostProcessing()
        {
            Console.WriteLine(this);
        }
        public void OptionalTasksPriorProcessing()
        {
            Console.WriteLine(this);
        }

    }
}