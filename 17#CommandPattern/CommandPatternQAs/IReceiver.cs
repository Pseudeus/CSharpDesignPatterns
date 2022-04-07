using System;

namespace CommandPatternQAs
{
    public interface IReceiver
    {
        void Add2WithNumber();
        void Remove2FromNumber();
        void OptionalTasksPriorProcessing();
        void OptionalTasksPostProcessing();
    }
}