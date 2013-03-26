using System;


namespace JCI.BrainMess
{

    public class InterPretter
    {

        public const int TapeSize = 800;
        public int[] tape = new int[TapeSize];
        public int pointerIndex = 0; //Current Index of Tape
        public int pointerValue = 0; //Value at Current Index of Tape

        public int indexOfOpeningBracket = 0;
        public int pointerIndexAtOpeningBracket = 0;
        public int charIndex = 0;
        public string outputString = string.Empty;

        public void Interpret(string inputString)
        {
            for (charIndex = 0; charIndex < inputString.Length; charIndex++)
                switch (inputString[charIndex].ToString())
                {
                    case ">":
                        MoveToNextIndex();
                        break;
                    case "<":
                        MoveToPreviousIndex();
                        break;
                    case "+":
                        IncreaseIndexValue();
                        break;
                    case "-":
                        DecreaseIndexValue();
                        break;
                    case ".":
                        WriteIndexValue();
                        break;
                    case ",":
                        ReadIndexValue();
                        break;
                    case "[":
                        StartLoop();
                        break;
                    case "]":
                        EndLoop();
                        break;
                }
        }



        public void IncreaseIndexValue()
        {
            ++tape[pointerIndex];
        }

        public void DecreaseIndexValue()
        {
            --tape[pointerIndex];
        }
        public void MoveToPreviousIndex()
        {
            --pointerIndex;
        }

        public void MoveToNextIndex()
        {
            ++pointerIndex;
        }

        public void StartLoop()
        {
            pointerIndexAtOpeningBracket = pointerIndex;
            indexOfOpeningBracket = charIndex;
        }
        public void EndLoop()
        {
            if (tape[pointerIndexAtOpeningBracket] > 0)
                charIndex = indexOfOpeningBracket;
        }

        public void WriteIndexValue()
        {
            Console.Write(Convert.ToChar((tape[pointerIndex])));
            outputString += Convert.ToChar((tape[pointerIndex]));
        }
        public void ReadIndexValue()
        {
            tape[pointerIndex] = (int)Console.ReadKey().KeyChar;
        }
        
    }
}
