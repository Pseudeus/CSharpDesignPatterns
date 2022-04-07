using System;

namespace StatePattern
{
    public class LGTV
    {
        private IPossibleStates currentState;

        public IPossibleStates CurrentState
        {
            get => currentState;
            set
            {
                currentState = value;
            }
        }
        public LGTV()
        {
            currentState = new Off(this);
        }
        public void PressMuteButton()
        {
            currentState.PressMuteButton(this);
        }
        public void PressOffButton()
        {
            currentState.PressOffButton(this);
        }
        public void PressOnButton()
        {
            currentState.PressOnButton(this);
        }
    }
}