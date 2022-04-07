using System;
using System.Collections.Generic;

namespace MementoPatternQAs
{
    /// <summary>
    /// Caretaker class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Memento Pattern QAs***\n");
            Console.WriteLine("***Demonstration-Caretaker is using multiple restore points***\n");

            Originator originatorObj = new Originator();
            //Memento mementoObj;
            Stack<Memento> savedStates = new Stack<Memento>();
            Console.WriteLine("A new set of verification");

            originatorObj.State = "State-1";
            savedStates.Push(originatorObj.GetTheMemento());

            originatorObj.State = "State-2";
            savedStates.Push(originatorObj.GetTheMemento());

            originatorObj.State = "State-3";
            savedStates.Push(originatorObj.GetTheMemento());

            originatorObj.State = "State-4";

            Console.WriteLine("Started restoring process...");
            for(byte i = (byte)savedStates.Count; i > 0; i--)
            {
                //mementoObj = originatorObj.GetTheMemento();
                //mementoObj.State = savedStates[i -1].State; 
                if(savedStates.TryPop(out Memento result))
                {
                    originatorObj.RevertToState(result);
                }               
            }
        }
    }
}
