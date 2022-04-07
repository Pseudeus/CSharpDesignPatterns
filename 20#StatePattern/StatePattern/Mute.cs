using System;

namespace StatePattern
{
    public class Mute : IPossibleStates
    {
        private LGTV tvContext;

        public Mute(LGTV tv)
        {
            tvContext = tv;
            Console.WriteLine("TV is in Mute mode now.");
        }
        public void PressMuteButton(LGTV tv)
        {
            Console.WriteLine("You pressed Mute button. TV is already in Mute mode.");
        }
        public void PressOnButton(LGTV tv)
        {
            Console.WriteLine("You pressed On button. Going from Mute mode to On state.");
            tvContext.CurrentState = new On(tv);
        }
        public void PressOffButton(LGTV tv)
        {
            Console.WriteLine("You pressed Off button. Going from Mute mode to Off state.");
            tvContext.CurrentState = new Off(tv);
        }
    }
}