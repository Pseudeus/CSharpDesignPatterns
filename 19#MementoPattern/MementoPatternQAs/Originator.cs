using System;

namespace MementoPatternQAs
{
    /// <summary>
    /// Originator class
    /// </summary>
    public class Originator
    {
        private Memento myMemento;

        private string state;

        public string State
        {
            get => state;
            set
            {
                state = value;
                Console.WriteLine("Current State: {0}", state);
            }
        }

        public Memento GetTheMemento()
        {
            myMemento = new Memento();
            myMemento.State = state;
            return myMemento;
        }
        public void RevertToState(Memento previousState)
        {
            Console.WriteLine("Restoring to previous state...");
            this.state = previousState.State;
            Console.WriteLine($"Current State: { this.state }");
        }
    }
}