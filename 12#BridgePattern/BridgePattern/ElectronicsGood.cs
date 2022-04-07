using System;

namespace BridgePattern
{
    //Abstraction
    public abstract class ElectronicsGood
    {
        protected IState state;

        public IState State
        {
            get => state;
            set 
            {
                state = value;
            }
        }
        public abstract void MoveToCurrentState();
    }
}