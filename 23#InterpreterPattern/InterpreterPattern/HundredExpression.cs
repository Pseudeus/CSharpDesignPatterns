using System;

namespace InterpreterPattern
{
    public class HundredExpression : InputExpression
    {
        public override void Interpret(Context context)
        {
            if(context.CanProceed)
            {
                int hundreds = context.GetInput / 100;

                switch(hundreds)
                {
                    case 1:
                        context.SetOutput += "One Hundred";
                        break;
                    case 2:
                        context.SetOutput += "Two Hundred";
                        break;
                    case 3:
                        context.SetOutput += "Three Hundred";
                        break;
                    case 4:
                        context.SetOutput += "Four Hundred";
                        break;
                    case 5:
                        context.SetOutput += "Five Hundred";
                        break;
                    case 6:
                        context.SetOutput += "Six Hundred";
                        break;
                    case 7:
                        context.SetOutput += "Seven Hundred";
                        break;
                    case 8:
                        context.SetOutput += "Eight Hundred";
                        break;
                    case 9:
                        context.SetOutput += "Nine Hundred";
                        break;
                    default:
                        context.SetOutput += "*";
                        break;
                }
            }
        }
    }
}