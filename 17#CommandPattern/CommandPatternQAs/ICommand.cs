using System;

namespace CommandPatternQAs
{
    public interface ICommand
    {
        void Do();
        void UnDo();
    }
}