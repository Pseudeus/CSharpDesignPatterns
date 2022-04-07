using System;

namespace MementoPatternQAs
{
    /// <summary>
    /// Memento class
    /// </summary>
    public class Memento
    {
        private string state;

        public string State
        {
            get => state;
            set
            {
                state = value;
            }
        }
    }
}