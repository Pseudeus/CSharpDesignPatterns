using System;

namespace StatePattern
{
    public class On : IPossibleStates
    {
        private LGTV tvContext;

        public On(LGTV tv)
        {
            tvContext = tv;
            Console.WriteLine("TV is On now.");
        }
        public void PressMuteButton(LGTV tv)
        {
            Console.WriteLine("You pressed Mute button. Going from On to Mute mode.");
            tvContext.CurrentState = new Mute(tv);
        }
        public void PressOnButton(LGTV tv)
        {
            Console.WriteLine("You pressed On button. TV is already in On state.");
        }
        public void PressOffButton(LGTV tv)
        {
            Console.WriteLine("You pressed Off button. Going from On to Off state.");
            tvContext.CurrentState = new Off(tv);
        }
    }
}