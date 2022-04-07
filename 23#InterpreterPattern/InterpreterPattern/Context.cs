using System;

namespace InterpreterPattern
{
    public class Context
    {
        private int getInput;
        private string getStringInput;
        private string setOutput;
        private bool canProceed;

        public bool CanProceed{ get => canProceed; }
        public int GetInput{ get => getInput; }
        public string SetOutput { get => setOutput;  set { setOutput = value; }}

        public Context(string input)
        {
            this.getStringInput = input;
        }
        public int ValidateUserInputBeforeProceding(string inputString)
        {
            if(int.TryParse(inputString, out getInput))
            {
                Console.WriteLine($"You have entered { getInput }");

                if(getInput < 100 || getInput > 999)
                {
                    Console.WriteLine("Please enter a number between 100 and 999 and try again.");
                    return -9999;
                }
            }
            canProceed = true;
            return getInput;
        }
    }
}