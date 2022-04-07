using System;

namespace InterpreterPattern
{
    public abstract class InputExpression
    {
        public abstract void Interpret(Context context);
    }
}