using System;

namespace StatePattern
{
    public interface IPossibleStates
    {
        void PressMuteButton(LGTV tv);
        void PressOffButton(LGTV tv);
        void PressOnButton(LGTV tv);
    }
}