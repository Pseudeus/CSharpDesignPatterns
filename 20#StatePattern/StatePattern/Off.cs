using System;

namespace StatePattern
{
    public class Off : IPossibleStates
    {
        private LGTV tvContext;

        public Off(LGTV tv)
        {
            tvContext = tv;
            Console.WriteLine(" TV is Off now.");
        }
        public void PressMuteButton(LGTV tv)
        {
            Console.WriteLine("You pressed Mute button. TV is already in Off state, so Mute operation will not work.");
        }
        public void PressOnButton(LGTV tv)
        {
            Console.WriteLine("You pressed On button. Going from Off to On state.");
            tvContext.CurrentState = new On(tv);
        }
        public void PressOffButton(LGTV tv)
        {
            Console.WriteLine("You pressed Off button. TV is already in Off state");
        }
    }
}